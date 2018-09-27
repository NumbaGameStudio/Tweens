using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;
using UnityTime = UnityEngine.Time;

namespace Numba.Tweening
{
    public class Sequence : IPlayable
    {
        #region Structures and classes
        private struct PlayableData
        {
            public int Order { get; set; }

            public float StartTime { get; private set; }

            public IPlayable Playable { get; private set; }

            public PlayableData(int order, IPlayable playable, float startTime)
            {
                Order = order;
                Playable = playable;
                StartTime = startTime;
            }
        }

        private struct CallbackData
        {
            public int Order { get; set; }

            public Action Callback { get; private set; }

            public float StartTime { get; private set; }

            public CallbackData(int order, Action callback, float startTime)
            {
                Order = order;
                Callback = callback;
                StartTime = startTime;
            }
        }

        private struct PhasedData
        {
            public Phase Phase { get; set; }

            public PlayableData? PlayableData { get; set; }

            public CallbackData? CallbackData { get; set; }

            public PhasedData(Phase phase, PlayableData playableData)
            {
                Phase = phase;
                PlayableData = playableData;

                CallbackData = null;
            }

            public PhasedData(Phase phase, CallbackData callbackData)
            {
                Phase = phase;
                CallbackData = callbackData;

                PlayableData = null;
            }
        }

        private enum Phase
        {
            Start,
            Update,
            Complete
        }
        #endregion

        #region Fields
        private List<PlayableData> _playbleDatas = new List<PlayableData>();

        private List<CallbackData> _callbacksDatas = new List<CallbackData>();

        private Coroutine _playTimeRoutine;

        private PlayRoutine _playRoutine;

        private Action _playRoutineOnStopCallback;

        private int _loopsCount = 1;

        private LoopType _loopType;

        private float _duration;

        private float _durationWithLoops;

        private float _previousTime = -1f;

        #region Events
        public event Action Started;

        public event Action Updated;

        public event Action Completed;
        #endregion

        #region Callback
        private Action _onStartCallback;

        private Action _onUpdateCallback;

        private Action _onCompleteCallback;
        #endregion
        #endregion

        #region Constructors
        public Sequence() : this(string.Empty) { }

        public Sequence(int loopsCount) : this(new Settings(loopsCount, LoopType.Forward)) { }

        public Sequence(LoopType loopType) : this(new Settings(1, loopType)) { }

        public Sequence(int loopsCount, LoopType loopType) : this(new Settings(loopsCount, loopType)) { }

        public Sequence(string name, int loopsCount, LoopType loopType) : this(name, new Settings(loopsCount, loopType)) { }

        public Sequence(EasedSettings settings) : this(string.Empty, settings) { }

        public Sequence(string name) : this(name, new Settings(1, LoopType.Forward)) { }

        public Sequence(string name, Settings settings)
        {
            Name = string.IsNullOrEmpty(name) ? "[noname]" : name;
            Settings = settings;
        }

        public Sequence(params IPlayable[] playables) : this(null, playables) { }

        public Sequence(int loopsCount, params IPlayable[] playables) : this(new Settings(loopsCount, LoopType.Forward), playables) { }

        public Sequence(LoopType loopType, params IPlayable[] playables) : this(new Settings(1, loopType), playables) { }

        public Sequence(int loopsCount, LoopType loopType, params IPlayable[] playables) : this(new Settings(loopsCount, loopType), playables) { }

        public Sequence(EasedSettings settings, params IPlayable[] playables) : this(null, settings, playables) { }

        public Sequence(string name, params IPlayable[] playables) : this(name, new Settings(1, LoopType.Forward), playables) { }

        public Sequence(string name, int loopsCount, params IPlayable[] playables) : this(name, new Settings(loopsCount, LoopType.Forward), playables) { }

        public Sequence(string name, LoopType loopType, params IPlayable[] playables) : this(name, new Settings(1, loopType), playables) { }

        public Sequence(string name, int loopsCount, LoopType loopType, params IPlayable[] playables) : this(name, new Settings(loopsCount, loopType), playables) { }

        public Sequence(string name, Settings settings, params IPlayable[] playables)
        {
            for (int i = 0; i < playables.Length; i++)
            {
                Append(playables[i]);
            }

            Settings = settings;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public float CurrentTime
        {
            get { return _previousTime; }
            set { _previousTime = value; }
        }

        public float Duration
        {
            get { return _duration; }
            private set
            {
                _duration = value;
                _durationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
                ResetCurrentTime();
            }
        }

        public float DurationWithLoops { get { return _durationWithLoops; } }

        public int LoopsCount
        {
            get { return _loopsCount; }
            set
            {
                _loopsCount = Mathf.Max(value, -1);
                _durationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
                ResetCurrentTime();
            }
        }

        public bool IsPlaying { get { return _playTimeRoutine != null; } }

        public LoopType LoopType
        {
            get { return _loopType; }
            set
            {
                if (value == LoopType.Reversed)
                    _loopType = LoopType.Backward;
                else
                    _loopType = value;

                _durationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
                ResetCurrentTime();
            }
        }

        public Settings Settings
        {
            get { return new Settings(_loopsCount, _loopType); }
            set
            {
                LoopsCount = value.LoopsCount;
                LoopType = value.LoopType;
            }
        }

        public int NextOrder { get; private set; }
        #endregion

        #region Methods
        public Sequence Append(IPlayable playable)
        {
            _playbleDatas.Add(new PlayableData(NextOrder++, playable, Duration));
            Duration += playable.DurationWithLoops;

            return this;
        }

        public Sequence Append(IPlayable playable, int order)
        {
            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _playbleDatas.Add(new PlayableData(order, playable, Duration));
            Duration += playable.DurationWithLoops;

            return this;
        }

        public Sequence Append(Action callback)
        {
            _callbacksDatas.Add(new CallbackData(NextOrder++, callback, Duration));
            return this;
        }

        public Sequence Append(Action callback, int order)
        {
            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _callbacksDatas.Add(new CallbackData(order, callback, Duration));
            return this;
        }

        public Sequence Insert(float time, IPlayable playable)
        {
            time = Mathf.Max(0f, time);

            _playbleDatas.Add(new PlayableData(NextOrder++, playable, time));
            Duration = Mathf.Max(Duration, time + playable.DurationWithLoops);

            return this;
        }

        public Sequence Insert(float time, IPlayable playable, int order)
        {
            time = Mathf.Max(0f, time);

            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _playbleDatas.Add(new PlayableData(order, playable, time));
            Duration = Mathf.Max(Duration, time + playable.DurationWithLoops);

            return this;
        }

        public Sequence Insert(float time, Action callback)
        {
            time = Mathf.Max(0f, time);

            _callbacksDatas.Add(new CallbackData(NextOrder++, callback, time));
            Duration = Mathf.Max(Duration, time);

            return this;
        }

        public Sequence Insert(float time, Action callback, int order)
        {
            time = Mathf.Max(0f, time);
            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _callbacksDatas.Add(new CallbackData(order, callback, time));
            Duration = Mathf.Max(Duration, time);

            return this;
        }

        public void ResetCurrentTime()
        {
            _previousTime = GetPreviousTimeInitialPosition(LoopType);
        }

        private float GetPreviousTimeInitialPosition(LoopType loopType)
        {
            return (loopType == LoopType.Forward || loopType == LoopType.Yoyo) ? -1f : DurationWithLoops + 1f;
        }

        private void ShiftAllOrdersByOne(int startFromOrder)
        {
            for (int i = 0; i < _playbleDatas.Count; i++)
            {
                if (_playbleDatas[i].Order >= startFromOrder)
                {
                    var playableData = _playbleDatas[i];
                    playableData.Order += 1;
                    _playbleDatas[i] = playableData;
                }
            }

            for (int i = 0; i < _callbacksDatas.Count; i++)
            {
                if (_callbacksDatas[i].Order >= startFromOrder)
                {
                    var callbackData = _callbacksDatas[i];
                    callbackData.Order += 1;
                    _callbacksDatas[i] = callbackData;
                }
            }

            ++NextOrder;
        }

        IPlayable IPlayable.SetLoops(int loopsCount)
        {
            return SetLoops(loopsCount, LoopType);
        }

        public Sequence SetLoops(int loopsCount)
        {
            return SetLoops(loopsCount, LoopType);
        }

        IPlayable IPlayable.SetLoops(LoopType loopType)
        {
            return SetLoops(loopType);
        }

        public Sequence SetLoops(LoopType loopType)
        {
            return SetLoops(LoopsCount, loopType);
        }

        IPlayable IPlayable.SetLoops(int loopsCount, LoopType loopType)
        {
            return SetLoops(loopsCount, loopType);
        }

        public Sequence SetLoops(int loopsCount, LoopType loopType)
        {
            LoopsCount = loopsCount;
            LoopType = loopType;

            return this;
        }

        public void SetTime(float currentTime)
        {
            SetTime(_previousTime, currentTime, Duration, DurationWithLoops, LoopType);
        }

        private void SetTime(float previousTime, float currentTime, float duration, float durationWithLoops, LoopType loopType)
        {
            currentTime = Mathf.Clamp(currentTime, 0f, durationWithLoops);

            if (previousTime == currentTime) return;

            if (previousTime > 0f && previousTime < durationWithLoops)
            {
                float targetDuration = ((int)(previousTime / duration) + 1) * duration;

                if (previousTime < targetDuration && currentTime > targetDuration)
                {
                    UpdatePlayables(loopType, Engine.Math.WrapCeil(previousTime, duration), duration, duration);
                    UpdatePlayables(loopType, Engine.Math.WrapCeil(previousTime, duration) - duration, currentTime, duration);

                    return;
                }
            }

            if (previousTime >= 0f && previousTime <= durationWithLoops) previousTime = Engine.Math.WrapCeil(previousTime, duration);

            UpdatePlayables(loopType, previousTime, currentTime, duration);
        }

        private void UpdatePlayables(LoopType loopType, float previousTime, float currentTime, float duration)
        {
            if (loopType == LoopType.Forward)
                UpdatePlayables(previousTime, () => Engine.Math.WrapCeil(currentTime, duration));
            else if (loopType == LoopType.Backward)
                UpdatePlayables(previousTime, () => duration - Engine.Math.WrapCeil(currentTime, duration));
            else if (loopType == LoopType.Yoyo)
            {
                float repeatedYoyo = Engine.Math.WrapCeil(currentTime, duration * 2);

                if (repeatedYoyo <= duration)
                    UpdatePlayables(previousTime, () => Engine.Math.WrapCeil(repeatedYoyo, duration));
                else
                    UpdatePlayables(previousTime, () => duration - Engine.Math.WrapCeil(repeatedYoyo, duration));
            }
            else
            {
                float repeatedRevYoyo = Engine.Math.WrapCeil(currentTime, duration * 2);

                if (repeatedRevYoyo <= duration)
                    UpdatePlayables(previousTime, () => duration - Engine.Math.WrapCeil(repeatedRevYoyo, duration));
                else
                    UpdatePlayables(previousTime, () => Engine.Math.WrapCeil(repeatedRevYoyo, duration));
            }
        }

        private void UpdatePlayables(float previousTime, Func<float> timeGetter)
        {
            float time = timeGetter();
            UpdatePlayables(GetSortedByPhaseData(previousTime, time), time, time < previousTime);
        }

        private void UpdatePlayables(List<PhasedData> phasedDatas, float time, bool useBackward)
        {
            for (int i = 0; i < phasedDatas.Count; i++)
            {
                if (phasedDatas[i].PlayableData != null)
                {
                    PhasedData phasedData = phasedDatas[i];

                    if (phasedData.Phase == Phase.Start)
                    {
                        phasedData.PlayableData.Value.Playable.InvokeStart();
                        phasedData.PlayableData.Value.Playable.SetTime(time - phasedData.PlayableData.Value.StartTime);
                    }
                    else if (phasedData.Phase == Phase.Update)
                    {
                        phasedData.PlayableData.Value.Playable.SetTime(time - phasedData.PlayableData.Value.StartTime);
                        phasedData.PlayableData.Value.Playable.InvokeUpdate();
                    }
                    else
                    {
                        if (useBackward) phasedData.PlayableData.Value.Playable.SetTime(0f);
                        else phasedData.PlayableData.Value.Playable.SetTime(phasedData.PlayableData.Value.Playable.DurationWithLoops);

                        phasedData.PlayableData.Value.Playable.InvokeComplete();
                    }
                }
                else phasedDatas[i].CallbackData.Value.Callback();
            }
        }

        private float CalculateDurationWithLoops(float duration, int loopsCount, LoopType loopType)
        {
            return duration * GetLoopTypeDurationMultiplier(loopType) * Mathf.Abs(loopsCount);
        }

        private float GetLoopTypeDurationMultiplier(LoopType loopType)
        {
            return IsYoyoTypedLoopType(loopType) ? 2f : 1f;
        }

        private bool IsYoyoTypedLoopType(LoopType loopType)
        {
            return loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo;
        }

        private bool IsYoyoBackward(float time)
        {
            float repeated = time / Duration;
            if (repeated <= 1f) return false;

            int intPart = (int)repeated;
            float fraction = repeated - intPart;

            bool isEven = intPart % 2 == 0;

            return (!isEven && fraction == 0f) || (isEven && fraction != 0f) ? false : true;
        }

        public Sequence SetSettings(Settings settings)
        {
            Settings = settings;
            return this;
        }

        public PlayRoutine Play(bool useRealtime = false)
        {
            if (IsPlaying)
            {
                Debug.LogWarning(string.Format("Sequence with name \"{0}\" is already playing.", Name));
                return _playRoutine;
            }

            if (LoopsCount == 0) return PlayRoutine.CreateCompleted();

            _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(useRealtime, GetPreviousTimeInitialPosition(LoopType), Duration, DurationWithLoops, LoopsCount, LoopType));

            return PlayRoutine.Create(out _playRoutineOnStopCallback);
        }

        private IEnumerator PlayTime(bool useRealtime, float previousTime, float duration, float durationWithLoops, int loopsCount, LoopType loopType)
        {
            InvokeStart();

            float startTime = GetTime(useRealtime);
            float endTime = startTime + durationWithLoops;

            while (loopsCount == -1)
            {
                yield return null;
                    
                if (duration == 0f)
                {
                    SetTime(previousTime, 0f, duration, durationWithLoops, loopType);
                    InvokeUpdate();
                    continue;
                }

                float time = GetTime(useRealtime);

                while (endTime < time)
                {
                    startTime = endTime;
                    endTime = startTime + durationWithLoops;
                }

                time -= startTime;
                SetTime(previousTime, time, duration, durationWithLoops, LoopType);
                previousTime = time;

                InvokeUpdate();
            }

            if (duration == 0f)
            {
                yield return null;
                SetTime(previousTime, 0f, duration, durationWithLoops, loopType);
            }
            else
            {
                while (GetTime(useRealtime) < endTime)
                {
                    yield return null;

                    float time = Mathf.Min(GetTime(useRealtime), endTime) - startTime;
                    SetTime(previousTime, time, duration, durationWithLoops, loopType);
                    previousTime = time;

                    InvokeUpdate();
                }
            }

            HandleStop();
        }

        private float GetTime(bool useRealtime)
        {
            return useRealtime ? UnityTime.realtimeSinceStartup : UnityTime.time;
        }

        private List<PhasedData> GetSortedByPhaseData(float startTime, float endTime)
        {
            bool isBackward = startTime > endTime;
            List<PhasedData> phasedPlayableDatas = new List<PhasedData>();

            foreach (var playableData in _playbleDatas)
            {
                float tweenStartTime = isBackward ? playableData.StartTime + playableData.Playable.DurationWithLoops : playableData.StartTime;
                float tweenEndTime = isBackward ? playableData.StartTime : playableData.StartTime + playableData.Playable.DurationWithLoops;

                if (IsValueBetween(tweenEndTime, startTime, endTime) && tweenEndTime != startTime)
                {
                    if (isBackward && (tweenStartTime < startTime)) phasedPlayableDatas.Add(new PhasedData(Phase.Start, playableData));
                    else if (!isBackward && (tweenStartTime > startTime)) phasedPlayableDatas.Add(new PhasedData(Phase.Start, playableData));

                    phasedPlayableDatas.Add(new PhasedData(Phase.Complete, playableData));
                    continue;
                }

                if (isBackward && (tweenEndTime >= startTime || tweenStartTime < endTime)) continue;
                else if (!isBackward && (tweenEndTime <= startTime || tweenStartTime > endTime)) continue;

                if (isBackward && (tweenStartTime < startTime && tweenStartTime >= endTime)) phasedPlayableDatas.Add(new PhasedData(Phase.Start, playableData));
                else if (!isBackward && (tweenStartTime > startTime && tweenStartTime <= endTime)) phasedPlayableDatas.Add(new PhasedData(Phase.Start, playableData));
                else phasedPlayableDatas.Add(new PhasedData(Phase.Update, playableData));
            }

            for (int i = 0; i < _callbacksDatas.Count; i++)
                if (IsValueBetween(_callbacksDatas[i].StartTime, startTime, endTime) && _callbacksDatas[i].StartTime != startTime)
                    phasedPlayableDatas.Add(new PhasedData(Phase.Start, _callbacksDatas[i]));

            phasedPlayableDatas.Sort((p1, p2) =>
            {
                if (p1.Phase == Phase.Update && p2.Phase != Phase.Update) return 1;
                else if (p2.Phase == Phase.Update && p1.Phase != Phase.Update) return -1;
                else return p1.PlayableData.Value.Order.CompareTo(p2.PlayableData.Value.Order);
            });

            for (int i = 0; i < phasedPlayableDatas.Count - 1; i++)
            {
                if (phasedPlayableDatas[i].Phase == Phase.Update) break;

                float originTime = GetPhasedDataTimeForSorting(phasedPlayableDatas[i]);

                int j = i + 1;
                for (; j < phasedPlayableDatas.Count; j++) if (GetPhasedDataTimeForSorting(phasedPlayableDatas[j]) != originTime) break;

                if (j - i == 1) continue;

                phasedPlayableDatas.SortPart(i, j - i, (p1, p2) => GetPhasedDataOrder(p1).CompareTo(GetPhasedDataOrder(p2)));
                i = j - 1;
            }

            return phasedPlayableDatas;
        }

        private float GetPhasedDataTimeForSorting(PhasedData phasedData)
        {
            if (phasedData.PlayableData != null)
            {
                if (phasedData.Phase == Phase.Start) return phasedData.PlayableData.Value.StartTime;
                else return phasedData.PlayableData.Value.StartTime + phasedData.PlayableData.Value.Playable.DurationWithLoops;
            }
            else return phasedData.CallbackData.Value.StartTime;
        }

        private int GetPhasedDataOrder(PhasedData phasedData)
        {
            return phasedData.PlayableData != null ? phasedData.PlayableData.Value.Order : phasedData.CallbackData.Value.Order;
        }

        private bool IsValueBetween(float value, float startTime, float endTime)
        {
            return startTime < endTime ? value >= startTime && value <= endTime : value >= endTime && value <= startTime;
        }

        public void Stop()
        {
            if (!IsPlaying)
            {
                Debug.LogWarning(string.Format("Sequence with name \"{0}\" is already stoped.", Name));
                return;
            }

            HandleStop();
        }

        private void HandleStop()
        {
            RoutineHelper.Instance.StopCoroutine(_playTimeRoutine);
            _playTimeRoutine = null;

            _playRoutineOnStopCallback();
            _playRoutine = null;

            ResetCurrentTime();

            InvokeComplete();
            ClearCallbacks();
        }

        IPlayable IPlayable.OnStart(Action callback)
        {
            return OnStart(callback);
        }

        public Sequence OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        IPlayable IPlayable.OnUpdate(Action callback)
        {
            return OnUpdate(callback);
        }

        public Sequence OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        IPlayable IPlayable.OnComplete(Action callback)
        {
            return OnComplete(callback);
        }

        public Sequence OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }

        public void InvokeStart()
        {
            if (Started != null) Started();
            if (_onStartCallback != null) _onStartCallback();
        }

        public void InvokeUpdate()
        {
            if (Updated != null) Updated();
            if (_onUpdateCallback != null) _onUpdateCallback();
        }

        public void InvokeComplete()
        {
            if (Completed != null) Completed();
            if (_onCompleteCallback != null) _onCompleteCallback();
        }

        public void ClearCallbacks()
        {
            _onStartCallback = _onUpdateCallback = _onCompleteCallback = null;
        }
        #endregion
    }
}