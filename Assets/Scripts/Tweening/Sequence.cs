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
            public IPlayable Playable { get; private set; }

            public float StartTime { get; private set; }

            public PlayableData(IPlayable playable, float startTime)
            {
                Playable = playable;
                StartTime = startTime;
            }
        }

        private struct CallbackData
        {
            public Action Callback { get; private set; }

            public float StartTime { get; private set; }

            public CallbackData(Action callback, float startTime)
            {
                Callback = callback;
                StartTime = startTime;
            }
        }

        private struct SortedByPhasePlayableData
        {
            public List<PlayableData> Started { get; set; }

            public List<PlayableData> Continuous { get; set; }

            public List<PlayableData> Completed { get; set; }

            public List<CallbackData> CompletedCallbacks { get; set; }

            public SortedByPhasePlayableData(List<PlayableData> startedPlayables, List<PlayableData> continuousPlayables, List<PlayableData> completedPlayables, List<CallbackData> completedCallbacks)
            {
                Started = startedPlayables;
                Continuous = continuousPlayables;
                Completed = completedPlayables;
                CompletedCallbacks = completedCallbacks;
            }
        }
        #endregion

        #region Fields
        private List<PlayableData> _plyableDatas = new List<PlayableData>();

        private List<CallbackData> _callbacksDatas = new List<CallbackData>();

        private Coroutine _playTimeRoutine;

        private Dictionary<IPlayable, float> _playableDurations = new Dictionary<IPlayable, float>();
        
        private int _loopsCount = 1;

        private LoopType _loopType;

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

        public Sequence(string name)
        {
            Name = string.IsNullOrEmpty(name) ? "[noname]" : name;
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public float CurrentTime { get { return _currentTime; } }

        public float Duration { get; private set; }

        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        public bool IsPlaying { get { return _playTimeRoutine != null; } }

        public LoopType LoopType
        {
            get { return _loopType; }
            set
            {
                if (value == LoopType.Reversed)
                {
                    _loopType = LoopType.Backward;
                    return;
                }

                _loopType = value;
            }
        }
        #endregion

        #region Methods
        public Sequence Append(IPlayable playable)
        {
            _plyableDatas.Add(new PlayableData(playable, Duration));
            Duration += CalculateAndCacheDuration(playable);

            return this;
        }

        public Sequence Append(Action callback)
        {
            _callbacksDatas.Add(new CallbackData(callback, Duration));
            return this;
        }

        public Sequence Insert(float time, IPlayable playable)
        {
            _plyableDatas.Add(new PlayableData(playable, time));
            Duration = Mathf.Max(Duration, time + CalculateAndCacheDuration(playable));

            return this;
        }

        public Sequence Insert(float time, Action callback)
        {
            _callbacksDatas.Add(new CallbackData(callback, time));
            Duration = Mathf.Max(Duration, time);

            return this;
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
            return SetLoops(_loopsCount, loopType);
        }

        IPlayable IPlayable.SetLoops(int loopsCount, LoopType loopType)
        {
            return SetLoops(loopsCount, loopType);
        }

        public Sequence SetLoops(int loopsCount, LoopType loopType)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;

            return this;
        }

        public float GetDurationWithLoops()
        {
            return Duration * (_loopsCount == -1f ? 1f : _loopsCount) * (LoopType == LoopType.Yoyo || LoopType == LoopType.ReversedYoyo ? 2f : 1f);
        }

        public void SetTime(float time)
        {
            SetTime(time, _loopsCount, _loopType);
        }

        private void SetTime(float time, int loopsCount, LoopType loopType)
        {
            if (loopsCount == -1) loopsCount = 1;
            time = Mathf.Min(time, Duration * loopsCount * (loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo ? 2f : 1f));

            switch (loopType)
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

        public Coroutine Play(bool useRealtime = false)
        {
            if (IsPlaying)
            {
                Debug.LogWarning(string.Format("Sequence with name \"{0}\" is already playing.", Name));
                return _playTimeRoutine;
            }

            return _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(useRealtime, LoopsCount));
        }

        private IEnumerator PlayTime(bool useRealtime, int loopsCount)
        {
            InvokeStart();

            bool isInfinityLoops = loopsCount == -1;
            if (isInfinityLoops) loopsCount = 1;

            float startTime = GetTime(useRealtime);
            float durationWithLoops = GetDurationWithLoops();
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

                SetTime(time - startTime, loopsCount, _loopType);

                InvokeUpdate();
            }

            while (GetTime(useRealtime) < endTime)
            {
                yield return null;

                float time = Mathf.Min(GetTime(useRealtime), endTime);
                SetTime(time - startTime, loopsCount, _loopType);

                InvokeUpdate();
            }

            HandleStop();
        }

        private float GetTime(bool useRealtime)
        {
            return useRealtime ? UnityTime.realtimeSinceStartup : UnityTime.time;
        }

        private void UpdateTweensAndCallbacks(SortedByPhasePlayableData sortedByPhaseData, float time, bool useBackward)
        {
            foreach (var tweenData in sortedByPhaseData.Started)
            {
                tweenData.Playable.InvokeStart();
                tweenData.Playable.SetTime(time - tweenData.StartTime);
            }

            foreach (var tweenData in sortedByPhaseData.Continuous)
            {
                tweenData.Playable.SetTime(time - tweenData.StartTime);
                tweenData.Playable.InvokeUpdate();
            }

            foreach (var tweenData in sortedByPhaseData.Completed)
            {
                if (useBackward) tweenData.Playable.SetTime(0f);
                else tweenData.Playable.SetTime(tweenData.Playable.GetDurationWithLoops());

                tweenData.Playable.InvokeComplete();
            }

            foreach (var callbackData in sortedByPhaseData.CompletedCallbacks) callbackData.Callback();
        }

        private SortedByPhasePlayableData GetSortedByPhaseData(float startTime, float endTime)
        {
            bool isBackward = startTime > endTime;

            List<PlayableData> startedPlayable = new List<PlayableData>();
            List<PlayableData> continuousPlayable = new List<PlayableData>();
            List<PlayableData> completedPlayable = new List<PlayableData>();
            List<CallbackData> completedCallbacks = new List<CallbackData>();

            foreach (var playableData in _plyableDatas)
            {
                float tweenStartTime = isBackward ? playableData.StartTime + GetPlayableDuration(playableData.Playable) : playableData.StartTime;
                float tweenEndTime = isBackward ? playableData.StartTime : playableData.StartTime + GetPlayableDuration(playableData.Playable);

                if (IsValueBetween(tweenEndTime, startTime, endTime) && tweenEndTime != startTime)
                {
                    if (isBackward && (tweenStartTime < startTime)) startedPlayable.Add(playableData);
                    else if (!isBackward && (tweenStartTime > startTime)) startedPlayable.Add(playableData);

                    completedPlayable.Add(playableData);
                    continue;
                }

                if (isBackward && (tweenEndTime >= startTime || tweenStartTime < endTime)) continue;
                else if (!isBackward && (tweenEndTime <= startTime || tweenStartTime > endTime)) continue;

                if (isBackward && (tweenStartTime < startTime && tweenStartTime >= endTime)) startedPlayable.Add(playableData);
                else if (!isBackward && (tweenStartTime > startTime && tweenStartTime <= endTime)) startedPlayable.Add(playableData);
                else continuousPlayable.Add(playableData);
            }

            foreach (var callbackData in _callbacksDatas) if (IsValueBetween(callbackData.StartTime, startTime, endTime) && callbackData.StartTime != startTime) completedCallbacks.Add(callbackData);

            #region Comparisons
            Comparison<PlayableData> startedAndContinuousComparison;
            if (isBackward) startedAndContinuousComparison = (x, y) => (x.StartTime + GetPlayableDuration(x.Playable)).CompareTo(y.StartTime + GetPlayableDuration(y.Playable)) * -1;
            else startedAndContinuousComparison = (x, y) => x.StartTime.CompareTo(y.StartTime);

            Comparison<PlayableData> completedComparison;
            if (isBackward) completedComparison = (x, y) => x.StartTime.CompareTo(y.StartTime) * -1;
            else completedComparison = (x, y) => (x.StartTime + GetPlayableDuration(x.Playable)).CompareTo(y.StartTime + GetPlayableDuration(y.Playable));

            Comparison<CallbackData> callbackComparison;
            if (isBackward) callbackComparison = (x, y) => x.StartTime.CompareTo(y.StartTime) * -1;
            else callbackComparison = (x, y) => x.StartTime.CompareTo(y.StartTime);
            #endregion

            startedPlayable.Sort(startedAndContinuousComparison);
            continuousPlayable.Sort(startedAndContinuousComparison);
            completedPlayable.Sort(completedComparison);
            completedCallbacks.Sort(callbackComparison);

            return new SortedByPhasePlayableData(startedPlayable, continuousPlayable, completedPlayable, completedCallbacks);
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

            _currentTime = LoopType == LoopType.Forward || LoopType == LoopType.Yoyo ? -1f : GetDurationWithLoops() + 1f;

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