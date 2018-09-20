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
        private struct TweenData
        {
            public Tween Tween { get; private set; }

            public float StartTime { get; private set; }

            public TweenData(Tween tween, float startTime)
            {
                Tween = tween;
                StartTime = startTime;
            }
        }

        private struct SequenceData
        {
            public Sequence Sequence { get; private set; }

            public float StartTime { get; private set; }

            public SequenceData(Sequence sequence, float startTime)
            {
                Sequence = sequence;
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

        private struct PlayablePhaseData<T>
        {
            public List<T> Started { get; set; }

            public List<T> Continuous { get; set; }

            public List<T> Completed { get; set; }

            public PlayablePhaseData(List<T> startedTweens, List<T> continuousTweens, List<T> completedTweens)
            {
                Started = startedTweens;
                Continuous = continuousTweens;
                Completed = completedTweens;
            }

            public static PlayablePhaseData<T> Create() { return new PlayablePhaseData<T>(new List<T>(), new List<T>(), new List<T>()); }
        }

        private struct SortedByPhaseData
        {
            public PlayablePhaseData<TweenData> TweenPhaseData;

            public PlayablePhaseData<SequenceData> SequencePhaseData;

            public List<CallbackData> CompletedCallbacks { get; set; }

            public SortedByPhaseData(PlayablePhaseData<TweenData> tweenPhaseData, PlayablePhaseData<SequenceData> sequencePhaseData, List<CallbackData> completedCallbacks)
            {
                TweenPhaseData = tweenPhaseData;
                SequencePhaseData = sequencePhaseData;
                CompletedCallbacks = completedCallbacks;
            }
        }
        #endregion

        #region Fields
        private List<TweenData> _tweensDatas = new List<TweenData>();

        private List<SequenceData> _sequencesDatas = new List<SequenceData>();

        private List<CallbackData> _callbacksDatas = new List<CallbackData>();

        private Coroutine _playTimeRoutine;

        private Dictionary<Tween, float> _tweenDurations = new Dictionary<Tween, float>();

        private Dictionary<Sequence, float> _sequenceDurations = new Dictionary<Sequence, float>();

        private int _loopsCount = 1;

        private LoopType _loopType;

        Tween.Accessor _tweenAccessor = new Tween.Accessor();

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
        public void Append(Tween tween)
        {
            _tweensDatas.Add(new TweenData(tween, Duration));
            Duration += CalculateAndCacheDuration(tween);
        }

        public void Append(Sequence sequence)
        {
            _sequencesDatas.Add(new SequenceData(sequence, Duration));
            Duration += CalculateAndCacheDuration(sequence);
        }

        public void Append(Action callback)
        {
            _callbacksDatas.Add(new CallbackData(callback, Duration));
        }

        public void Insert(float time, Tween tween)
        {
            _tweensDatas.Add(new TweenData(tween, time));
            Duration = Mathf.Max(Duration, time + CalculateAndCacheDuration(tween));
        }

        public void Insert(float time, Sequence sequence)
        {
            _sequencesDatas.Add(new SequenceData(sequence, time));
            Duration = Mathf.Max(Duration, time + CalculateAndCacheDuration(sequence));
        }

        public void Insert(float time, Action callback)
        {
            _callbacksDatas.Add(new CallbackData(callback, time));
            Duration = Mathf.Max(Duration, time);
        }

        private float CalculateAndCacheDuration(Tween tween)
        {
            float duration = CalculateDuration(tween);
            _tweenDurations.Add(tween, duration);

            return duration;
        }

        private float CalculateAndCacheDuration(Sequence sequence)
        {
            float duration = CalculateDuration(sequence);
            _sequenceDurations.Add(sequence, duration);

            return duration;
        }

        private float CalculateDuration(IPlayable playable)
        {
            int loopsCount = playable.LoopsCount == -1 ? 1 : playable.LoopsCount;
            float duration = loopsCount * playable.Duration;
            return duration * (playable.LoopType == LoopType.Yoyo || playable.LoopType == LoopType.ReversedYoyo ? 2f : 1f);
        }

        private float GetTweenDuration(Tween tween)
        {
            return _tweenDurations[tween];
        }

        private float GetSequenceDuration(Sequence sequence)
        {
            return _sequenceDurations[sequence];
        }

        public Sequence SetLoops(int loopsCount)
        {
            return SetLoops(loopsCount, LoopType);
        }

        public Sequence SetLoops(LoopType loopType)
        {
            return SetLoops(_loopsCount, loopType);
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
            HandleStart();

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

                HandleUpdate();
            }

            while (GetTime(useRealtime) < endTime)
            {
                yield return null;

                float time = Mathf.Min(GetTime(useRealtime), endTime);
                SetTime(time - startTime, loopsCount, _loopType);

                HandleUpdate();
            }

            HandleStop();
        }

        private float GetTime(bool useRealtime)
        {
            return useRealtime ? UnityTime.realtimeSinceStartup : UnityTime.time;
        }

        private void UpdateTweensAndCallbacks(SortedByPhaseData sortedByPhaseData, float time, bool useBackward)
        {
            foreach (var tweenData in sortedByPhaseData.TweenPhaseData.Started)
            {
                _tweenAccessor.CallHandleStart(tweenData.Tween);
                tweenData.Tween.SetTime(time - tweenData.StartTime);
            }

            foreach (var tweenData in sortedByPhaseData.TweenPhaseData.Continuous)
            {
                tweenData.Tween.SetTime(time - tweenData.StartTime);
                _tweenAccessor.CallHandleUpdate(tweenData.Tween);
            }

            foreach (var tweenData in sortedByPhaseData.TweenPhaseData.Completed)
            {
                if (useBackward) tweenData.Tween.SetTime(0f);
                else tweenData.Tween.SetTime(tweenData.Tween.GetDurationWithLoops());

                _tweenAccessor.CallHandleComplete(tweenData.Tween);
            }

            foreach (var callbackData in sortedByPhaseData.CompletedCallbacks) callbackData.Callback();
        }

        private SortedByPhaseData GetSortedByPhaseData(float startTime, float endTime)
        {
            bool isBackward = startTime > endTime;

            PlayablePhaseData<TweenData> tweenPhaseData = PlayablePhaseData<TweenData>.Create();
            PlayablePhaseData<SequenceData> sequencePhaseData = PlayablePhaseData<SequenceData>.Create();

            List<CallbackData> completedCallbacks = new List<CallbackData>();

            foreach (var tweenData in _tweensDatas)
            {
                float tweenStartTime = isBackward ? tweenData.StartTime + GetTweenDuration(tweenData.Tween) : tweenData.StartTime;
                float tweenEndTime = isBackward ? tweenData.StartTime : tweenData.StartTime + GetTweenDuration(tweenData.Tween);

                if (IsValueBetween(tweenEndTime, startTime, endTime) && tweenEndTime != startTime)
                {
                    if (isBackward && (tweenStartTime < startTime)) tweenPhaseData.Started.Add(tweenData);
                    else if (!isBackward && (tweenStartTime > startTime)) tweenPhaseData.Started.Add(tweenData);

                    tweenPhaseData.Completed.Add(tweenData);
                    continue;
                }

                if (isBackward && (tweenEndTime >= startTime || tweenStartTime < endTime)) continue;
                else if (!isBackward && (tweenEndTime <= startTime || tweenStartTime > endTime)) continue;

                if (isBackward && (tweenStartTime < startTime && tweenStartTime >= endTime)) tweenPhaseData.Started.Add(tweenData);
                else if (!isBackward && (tweenStartTime > startTime && tweenStartTime <= endTime)) tweenPhaseData.Started.Add(tweenData);
                else tweenPhaseData.Continuous.Add(tweenData);
            }

            foreach (var callbackData in _callbacksDatas)
                if (IsValueBetween(callbackData.StartTime, startTime, endTime) && callbackData.StartTime != startTime) completedCallbacks.Add(callbackData);

            Comparison<TweenData> startedAndContinuousComparison;
            if (isBackward) startedAndContinuousComparison = (x, y) => (x.StartTime + GetTweenDuration(x.Tween)).CompareTo(y.StartTime + GetTweenDuration(y.Tween)) * -1;
            else startedAndContinuousComparison = (x, y) => x.StartTime.CompareTo(y.StartTime);

            Comparison<TweenData> completedComparison;
            if (isBackward) completedComparison = (x, y) => x.StartTime.CompareTo(y.StartTime) * -1;
            else completedComparison = (x, y) => (x.StartTime + GetTweenDuration(x.Tween)).CompareTo(y.StartTime + GetTweenDuration(y.Tween));

            Comparison<CallbackData> callbackComparison;
            if (isBackward) callbackComparison = (x, y) => x.StartTime.CompareTo(y.StartTime) * -1;
            else callbackComparison = (x, y) => x.StartTime.CompareTo(y.StartTime);

            tweenPhaseData.Started.Sort(startedAndContinuousComparison);
            tweenPhaseData.Continuous.Sort(startedAndContinuousComparison);
            tweenPhaseData.Completed.Sort(completedComparison);
            completedCallbacks.Sort(callbackComparison);

            return new SortedByPhaseData(tweenPhaseData, sequencePhaseData, completedCallbacks);
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

            HandleComplete();

            _onStartCallback = _onUpdateCallback = _onCompleteCallback = null;
        }

        private void HandleStart()
        {
            if (Started != null) Started();
            if (_onStartCallback != null) _onStartCallback();
        }

        private void HandleUpdate()
        {
            if (Updated != null) Updated();
            if (_onUpdateCallback != null) _onUpdateCallback();
        }

        private void HandleComplete()
        {
            if (Completed != null) Completed();
            if (_onCompleteCallback != null) _onCompleteCallback();
        }

        public Sequence OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        public Sequence OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        public Sequence OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }
        #endregion
    }
}