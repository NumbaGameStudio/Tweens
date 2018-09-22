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

        private Dictionary<IPlayable, float> _playableDurations = new Dictionary<IPlayable, float>();

        private Settings _settings;

        private float _currentTime = -1f;

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

        public Sequence(Settings settings) : this(string.Empty, settings) { }

        public Sequence(string name) : this(name, new Settings(1, LoopType.Forward)) { }

        public Sequence(string name, Settings settings)
        {
            Name = string.IsNullOrEmpty(name) ? "[noname]" : name;
            _settings = settings;
        }

        public Sequence(params IPlayable[] playables) : this(null, playables) { }

        public Sequence(int loopsCount, params IPlayable[] playables) : this(new Settings(loopsCount, LoopType.Forward), playables) { }

        public Sequence(LoopType loopType, params IPlayable[] playables) : this(new Settings(1, loopType), playables) { }

        public Sequence(int loopsCount, LoopType loopType, params IPlayable[] playables) : this(new Settings(loopsCount, loopType), playables) { }

        public Sequence(Settings settings, params IPlayable[] playables) : this(null, settings, playables) { }

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

            _settings = settings;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public float CurrentTime { get { return _currentTime; } }

        public float Duration { get; private set; }

        public float DurationWithLoops
        {
            get
            {
                return Duration * (LoopsCount == -1f ? 1f : LoopsCount) * (LoopType == LoopType.Yoyo || LoopType == LoopType.ReversedYoyo ? 2f : 1f);
            }
        }

        public int LoopsCount
        {
            get { return _settings.LoopsCount; }
            set { _settings.LoopsCount = Mathf.Max(value, -1); }
        }

        public bool IsPlaying { get { return _playTimeRoutine != null; } }

        public LoopType LoopType
        {
            get { return _settings.LoopType; }
            set
            {
                if (value == LoopType.Reversed)
                {
                    _settings.LoopType = LoopType.Backward;
                    return;
                }

                _settings.LoopType = value;
            }
        }

        public Settings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                _settings.Ease = Ease.Linear;
            }
        }

        public int NextOrder { get; private set; }
        #endregion

        #region Methods
        public Sequence Append(IPlayable playable)
        {
            _playbleDatas.Add(new PlayableData(NextOrder++, playable, Duration));
            Duration += CalculateAndCacheDuration(playable);

            return this;
        }

        public Sequence Append(IPlayable playable, int order)
        {
            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _playbleDatas.Add(new PlayableData(order, playable, Duration));
            Duration += CalculateAndCacheDuration(playable);

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
            _playbleDatas.Add(new PlayableData(NextOrder++, playable, time));
            Duration = Mathf.Max(Duration, time + CalculateAndCacheDuration(playable));

            return this;
        }

        public Sequence Insert(float time, IPlayable playable, int order)
        {
            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _playbleDatas.Add(new PlayableData(order, playable, time));
            Duration = Mathf.Max(Duration, time + CalculateAndCacheDuration(playable));

            return this;
        }

        public Sequence Insert(float time, Action callback)
        {
            _callbacksDatas.Add(new CallbackData(NextOrder++, callback, time));
            Duration = Mathf.Max(Duration, time);

            return this;
        }

        public Sequence Insert(float time, Action callback, int order)
        {
            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _callbacksDatas.Add(new CallbackData(order, callback, time));
            Duration = Mathf.Max(Duration, time);

            return this;
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

        private float CalculateAndCacheDuration(IPlayable playable)
        {
            int loopsCount = playable.LoopsCount == -1 ? 1 : playable.LoopsCount;

            float duration = loopsCount * playable.Duration;
            duration *= (playable.LoopType == LoopType.Yoyo || playable.LoopType == LoopType.ReversedYoyo ? 2f : 1f);

            _playableDurations.Add(playable, duration);

            return duration;
        }

        private float GetPlayableDuration(IPlayable playable)
        {
            return _playableDurations[playable];
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

        public void SetTime(float time)
        {
            SetTime(time, _settings);
        }

        private void SetTime(float time, Settings settings)
        {
            if (settings.LoopsCount == -1) settings.LoopsCount = 1;
            time = Mathf.Clamp(time, 0f, Duration * settings.LoopsCount * (settings.LoopType == LoopType.Yoyo || settings.LoopType == LoopType.ReversedYoyo ? 2f : 1f));

            switch (settings.LoopType)
            {
                case LoopType.Forward:
                    time = Engine.Math.WrapCeil(time, Duration);
                    UpdateTweensAndCallbacks(GetSortedByPhaseData(_currentTime, time), time, time < _currentTime);
                    break;
                case LoopType.Backward:
                    time = Engine.Math.WrapCeil(time, Duration);
                    time = Duration - time;
                    UpdateTweensAndCallbacks(GetSortedByPhaseData(_currentTime, time), time, time < _currentTime);
                    break;
                case LoopType.Yoyo:
                    float yoyoDuration = Duration * 2;
                    float repeatedYoyo = Engine.Math.WrapCeil(time, yoyoDuration);

                    if (repeatedYoyo <= Duration)
                    {
                        float repeatedForward = Engine.Math.WrapCeil(repeatedYoyo, Duration);
                        UpdateTweensAndCallbacks(GetSortedByPhaseData(_currentTime, repeatedForward), repeatedForward, repeatedForward < _currentTime);
                    }
                    else
                    {
                        float repeatedBackward = Engine.Math.WrapCeil(repeatedYoyo, Duration);
                        repeatedBackward = Duration - repeatedBackward;
                        UpdateTweensAndCallbacks(GetSortedByPhaseData(_currentTime, repeatedBackward), repeatedBackward, repeatedBackward < _currentTime);
                    }
                    break;
                case LoopType.ReversedYoyo:
                    float reversedYoyoDuration = Duration * 2;
                    float repeatedRevYoyo = Engine.Math.WrapCeil(time, reversedYoyoDuration);

                    if (repeatedRevYoyo <= Duration)
                    {
                        float repeatedBackward = Engine.Math.WrapCeil(repeatedRevYoyo, Duration);
                        repeatedBackward = Duration - repeatedBackward;
                        UpdateTweensAndCallbacks(GetSortedByPhaseData(_currentTime, repeatedBackward), repeatedBackward, repeatedBackward < _currentTime);
                    }
                    else
                    {
                        float repeatedForward = Engine.Math.WrapCeil(repeatedRevYoyo, Duration);
                        UpdateTweensAndCallbacks(GetSortedByPhaseData(_currentTime, repeatedForward), repeatedForward, repeatedForward < _currentTime);
                    }
                    break;
            }

            _currentTime = time;
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

        IPlayable IPlayable.SetSettings(Settings settings)
        {
            Settings = settings;
            return this;
        }

        public Sequence SetSettings(Settings settings)
        {
            _settings = settings;
            return this;
        }

        public Coroutine Play(bool useRealtime = false)
        {
            if (IsPlaying)
            {
                Debug.LogWarning(string.Format("Sequence with name \"{0}\" is already playing.", Name));
                return _playTimeRoutine;
            }

            return _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(useRealtime, _settings));
        }

        private IEnumerator PlayTime(bool useRealtime, Settings settings)
        {
            InvokeStart();

            bool isInfinityLoops = settings.LoopsCount == -1;
            if (isInfinityLoops) settings.LoopsCount = 1;

            float startTime = GetTime(useRealtime);
            float durationWithLoops = DurationWithLoops;
            float endTime = startTime + durationWithLoops;

            while (isInfinityLoops)
            {
                yield return null;

                float time = GetTime(useRealtime);

                while (endTime < time)
                {
                    startTime = endTime;
                    endTime = startTime + durationWithLoops;
                }

                SetTime(time - startTime, settings);

                InvokeUpdate();
            }

            while (GetTime(useRealtime) < endTime)
            {
                yield return null;

                float time = Mathf.Min(GetTime(useRealtime), endTime);
                SetTime(time - startTime, settings);

                InvokeUpdate();
            }

            HandleStop();
        }

        private float GetTime(bool useRealtime)
        {
            return useRealtime ? UnityTime.realtimeSinceStartup : UnityTime.time;
        }

        private void UpdateTweensAndCallbacks(List<PhasedData> phasedDatas, float time, bool useBackward)
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

        private List<PhasedData> GetSortedByPhaseData(float startTime, float endTime)
        {
            bool isBackward = startTime > endTime;
            List<PhasedData> phasedPlayableDatas = new List<PhasedData>();

            foreach (var playableData in _playbleDatas)
            {
                float tweenStartTime = isBackward ? playableData.StartTime + GetPlayableDuration(playableData.Playable) : playableData.StartTime;
                float tweenEndTime = isBackward ? playableData.StartTime : playableData.StartTime + GetPlayableDuration(playableData.Playable);

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
                else return p1.PlayableData.Value.Order.CompareTo(p1.PlayableData.Value.Order);
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

            _currentTime = LoopType == LoopType.Forward || LoopType == LoopType.Yoyo ? -1f : DurationWithLoops + 1f;

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