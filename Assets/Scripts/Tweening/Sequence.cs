using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens
{
    /// <summary>
    /// <para>Represent container for other playables (Tween and Sequence) or callbacks.</para>
    /// <para>
    /// You can add other playables or callbacks in sequence and play/pause/stop them.
    /// </para>
    /// </summary>
    public sealed class Sequence : Playable
    {
        #region Structures and classes
        private struct PlayableData
        {
            public int Order { get; set; }

            public float StartTime { get; private set; }

            public Playable Playable { get; private set; }

            public PlayableData(int order, Playable playable, float startTime)
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

        private struct PlayableDataToAppend
        {
            public int Order { get; set; }

            public Playable Playable { get; set; }

            public PlayableDataToAppend(int order, Playable playable)
            {
                Order = order;
                Playable = playable;
            }
        }

        private struct CallbackDataToAppend
        {
            public int Order { get; set; }

            public Action Callback { get; set; }

            public CallbackDataToAppend(int order, Action callback)
            {
                Order = order;
                Callback = callback;
            }
        }

        private struct PlayableDataToInsert
        {
            public int Order { get; set; }

            public float Time { get; set; }

            public Playable Playable { get; set; }

            public PlayableDataToInsert(int order, float time, Playable playable)
            {
                Order = order;
                Time = time;
                Playable = playable;
            }
        }

        private struct CallbackDataToInsert
        {
            public int Order { get; set; }

            public float Time { get; set; }

            public Action Callback { get; set; }

            public CallbackDataToInsert(int order, float time, Action callback)
            {
                Order = order;
                Time = time;
                Callback = callback;
            }
        }

        private enum AddType
        {
            AppendPlayable,
            AppendCallback,
            InsertPlayable,
            InsertCallback
        }
        #endregion

        #region Fields
        private List<PlayableData> _playbleDatas = new List<PlayableData>();

        private List<CallbackData> _callbacksDatas = new List<CallbackData>();

        private Queue<PlayableDataToAppend> _playableDatasToAppend = new Queue<PlayableDataToAppend>(0);

        private Queue<CallbackDataToAppend> _callbackDatasToAppend = new Queue<CallbackDataToAppend>(0);

        private Queue<PlayableDataToInsert> _playableDatasToInsert = new Queue<PlayableDataToInsert>(0);

        private Queue<CallbackDataToInsert> _callbackDatasToInsert = new Queue<CallbackDataToInsert>(0);

        private Queue<AddType> _addQueue = new Queue<AddType>(0);
        #endregion

        #region Constructors
        /// <summary>
        /// Create empty sequence.
        /// </summary>
        /// <returns>Empty sequence.</returns>
        public Sequence() : this(string.Empty) { }

        /// <summary>
        /// Create sequence with name.
        /// </summary>
        /// <param name="name">Sequence name.</param>
        /// <returns>Named sequence.</returns>
        public Sequence(string name)
        {
            Name = string.IsNullOrEmpty(name) ? "[noname]" : name;
            ResetCurrentTime();
        }

        /// <summary>
        /// Create sequence with settings.
        /// </summary>
        /// <param name="settings">Sequence settings.</param>
        /// <returns>Sequence with settings.</returns>
        public Sequence(SequenceSettings settings) : this(null, settings) { }

        /// <summary>
        /// Create named sequence with settings.
        /// </summary>
        /// <param name="name">Sequence name.</param>
        /// <param name="settings">Sequence settings.</param>
        /// <returns>Named sequence with settings.</returns>
        public Sequence(string name, SequenceSettings settings) : this(name)
        {
            Settings = settings;
        }
        #endregion

        #region Properties
        protected override string PlayableTypeName { get { return "Sequence"; } }

        /// <summary>
        /// Sequence duration (without LoopsCount and LoopType).
        /// </summary>
        public new float Duration
        {
            get { return _duration; }
            private set
            {
                _duration = value;
                DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
                ResetCurrentTime();
            }
        }

        /// <summary>
        /// How many times repeat the animation (-1 for infinity).
        /// </summary>
        public override int LoopsCount
        {
            get { return _loopsCount; }
            set
            {
                if (SetLoopsCount(value)) ResetCurrentTime();
            }
        }

        /// <summary>
        /// What behaviour need use when playing.
        /// </summary>
        public override LoopType LoopType
        {
            get { return _loopType; }
            set
            {
                if (value == LoopType.Reversed) value = LoopType.Backward;
                if (SetLoopType(value)) ResetCurrentTime();
            }
        }

        /// <summary>
        /// Sequence settings (represent LoopsCount and LoopType).
        /// </summary>
        public SequenceSettings Settings
        {
            get { return new SequenceSettings(_loopsCount, _loopType); }
            set
            {
                LoopsCount = value.LoopsCount;
                LoopType = value.LoopType;
            }
        }

        /// <summary>
        /// Order for next playable or callback.
        /// </summary>
        public int NextOrder { get; private set; }

        /// <summary>
        /// Last handled time by sequence.
        /// </summary>
        private float CurrentTime { get; set; }
        #endregion

        #region Methods
        #region Append and Insert
        /// <summary>
        /// Add playable to end.
        /// </summary>
        /// <param name="playable">Playable to add.</param>
        /// <returns>This sequence.</returns>
        public Sequence Append(Playable playable)
        {
            if (PlayState == PlayState.Play)
            {
                _playableDatasToAppend.Enqueue(new PlayableDataToAppend(-1, playable));
                _addQueue.Enqueue(AddType.AppendPlayable);
                return this;
            }

            _playbleDatas.Add(new PlayableData(NextOrder++, playable, Duration));
            Duration += playable.DurationWithLoops;

            return this;
        }

        /// <summary>
        /// Add playable to end at passed order. Other playables and callbacks order will be shifts forward by 1.
        /// </summary>
        /// <param name="playable">Playable to add.</param>
        /// <param name="order">Order to put at.</param>
        /// <returns>This sequence.</returns>
        public Sequence Append(Playable playable, int order)
        {
            if (PlayState == PlayState.Play)
            {
                _playableDatasToAppend.Enqueue(new PlayableDataToAppend(order, playable));
                _addQueue.Enqueue(AddType.AppendPlayable);
                return this;
            }

            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _playbleDatas.Add(new PlayableData(order, playable, Duration));
            Duration += playable.DurationWithLoops;

            return this;
        }

        /// <summary>
        /// Add callback to end.
        /// </summary>
        /// <param name="callback">Callback to add.</param>
        /// <returns>This sequence.</returns>
        public Sequence Append(Action callback)
        {
            if (PlayState == PlayState.Play)
            {
                _callbackDatasToAppend.Enqueue(new CallbackDataToAppend(-1, callback));
                _addQueue.Enqueue(AddType.AppendCallback);
                return this;
            }

            _callbacksDatas.Add(new CallbackData(NextOrder++, callback, Duration));
            return this;
        }

        /// <summary>
        /// Add callback to end at passed order. Other playables and callbacks order will be shifts forward by 1.
        /// </summary>
        /// <param name="callback">Callback to add.</param>
        /// <param name="order">Order to put at.</param>
        /// <returns>This sequence.</returns>
        public Sequence Append(Action callback, int order)
        {
            if (PlayState == PlayState.Play)
            {
                _callbackDatasToAppend.Enqueue(new CallbackDataToAppend(order, callback));
                _addQueue.Enqueue(AddType.AppendCallback);
                return this;
            }

            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _callbacksDatas.Add(new CallbackData(order, callback, Duration));
            return this;
        }

        /// <summary>
        /// Add playable at passed time.
        /// </summary>
        /// <param name="time">Time to put at.</param>
        /// <param name="playable">Playable to add.</param>
        /// <returns>This sequence.</returns>
        public Sequence Insert(float time, Playable playable)
        {
            if (PlayState == PlayState.Play)
            {
                _playableDatasToInsert.Enqueue(new PlayableDataToInsert(-1, time, playable));
                _addQueue.Enqueue(AddType.InsertPlayable);
                return this;
            }

            time = Mathf.Max(0f, time);

            _playbleDatas.Add(new PlayableData(NextOrder++, playable, time));
            Duration = Mathf.Max(Duration, time + playable.DurationWithLoops);

            return this;
        }

        /// <summary>
        /// Add playable at passed time and order. Other playables and callbacks order will be shifts forward by 1.
        /// </summary>
        /// <param name="time">Time to put at.</param>
        /// <param name="playable">Playable to add.</param>
        /// <param name="order">Order to put at.</param>
        /// <returns>This sequence.</returns>
        public Sequence Insert(float time, Playable playable, int order)
        {
            if (PlayState == PlayState.Play)
            {
                _playableDatasToInsert.Enqueue(new PlayableDataToInsert(order, time, playable));
                _addQueue.Enqueue(AddType.InsertPlayable);
                return this;
            }

            time = Mathf.Max(0f, time);

            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _playbleDatas.Add(new PlayableData(order, playable, time));
            Duration = Mathf.Max(Duration, time + playable.DurationWithLoops);

            return this;
        }

        /// <summary>
        /// Add callback at passed time.
        /// </summary>
        /// <param name="time">Time to put at.</param>
        /// <param name="callback">Callback to add.</param>
        /// <returns>This sequence.</returns>
        public Sequence Insert(float time, Action callback)
        {
            if (PlayState == PlayState.Play)
            {
                _callbackDatasToInsert.Enqueue(new CallbackDataToInsert(-1, time, callback));
                _addQueue.Enqueue(AddType.InsertCallback);
                return this;
            }

            time = Mathf.Max(0f, time);

            _callbacksDatas.Add(new CallbackData(NextOrder++, callback, time));
            Duration = Mathf.Max(Duration, time);

            return this;
        }

        /// <summary>
        /// Add callback at passed time and order. Other playables and callbacks order will be shifts forward by 1.
        /// </summary>
        /// <param name="time">Time to put at.</param>
        /// <param name="callback">Callback to add.</param>
        /// <param name="order">Order to put at.</param>
        /// <returns>This sequence.</returns>
        public Sequence Insert(float time, Action callback, int order)
        {
            if (PlayState == PlayState.Play)
            {
                _callbackDatasToInsert.Enqueue(new CallbackDataToInsert(order, time, callback));
                _addQueue.Enqueue(AddType.InsertCallback);
                return this;
            }

            time = Mathf.Max(0f, time);
            ShiftAllOrdersByOne(Mathf.Clamp(order, 0, NextOrder));

            _callbacksDatas.Add(new CallbackData(order, callback, time));
            Duration = Mathf.Max(Duration, time);

            return this;
        }
        #endregion

        /// <summary>
        /// Reset current time to initial position (-1 for forward and 
        /// yoyo loop type, and DurationWithLoops + 1 for other).
        /// </summary>
        private void ResetCurrentTime()
        {
            CurrentTime = GetPreviousTimeInitialPosition(LoopType);
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

        /// <summary>
        /// Set loops count.
        /// </summary>
        /// <param name="loopsCount">Loops count (-1 for infinity).</param>
        /// <returns>This playable.</returns>
        public new Sequence SetLoops(int loopsCount)
        {
            LoopsCount = loopsCount;
            return this;
        }

        /// <summary>
        /// Set loop type.
        /// </summary>
        /// <param name="loopType">Loop type.</param>
        /// <returns>This playable.</returns>
        public new Sequence SetLoops(LoopType loopType)
        {
            LoopType = loopType;
            return this;
        }

        /// <summary>
        /// Set loops count and loop type.
        /// </summary>
        /// <param name="loopsCount">Loops count (-1 for infinity).</param>
        /// <param name="loopType">Loop type.</param>
        /// <returns>This playable.</returns>
        public new Sequence SetLoops(int loopsCount, LoopType loopType)
        {
            LoopsCount = loopsCount;
            LoopType = loopType;

            return this;
        }

        /// <summary>
        /// Set sequence current play time.
        /// </summary>
        /// <param name="time">Time (not interpolated).</param>
        internal override void SetTime(float currentTime)
        {
            SetTime(CurrentTime, currentTime, Duration, DurationWithLoops, LoopType);
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
                    UpdatePlayables(loopType, Math.WrapCeil(previousTime, duration), duration, duration);
                    UpdatePlayables(loopType, Math.WrapCeil(previousTime, duration) - duration, currentTime, duration);

                    return;
                }
            }

            if (previousTime >= 0f && previousTime <= durationWithLoops) previousTime = Math.WrapCeil(previousTime, duration);

            UpdatePlayables(loopType, previousTime, currentTime, duration);
        }

        private void UpdatePlayables(LoopType loopType, float previousTime, float currentTime, float duration)
        {
            if (loopType == LoopType.Forward)
                UpdatePlayables(previousTime, () => Math.WrapCeil(currentTime, duration));
            else if (loopType == LoopType.Backward)
                UpdatePlayables(previousTime, () => duration - Math.WrapCeil(currentTime, duration));
            else if (loopType == LoopType.Yoyo)
            {
                float repeatedYoyo = Math.WrapCeil(currentTime, duration * 2);

                if (repeatedYoyo <= duration)
                    UpdatePlayables(previousTime, () => Math.WrapCeil(repeatedYoyo, duration));
                else
                    UpdatePlayables(previousTime, () => duration - Math.WrapCeil(repeatedYoyo, duration));
            }
            else
            {
                float repeatedRevYoyo = Math.WrapCeil(currentTime, duration * 2);

                if (repeatedRevYoyo <= duration)
                    UpdatePlayables(previousTime, () => duration - Math.WrapCeil(repeatedRevYoyo, duration));
                else
                    UpdatePlayables(previousTime, () => Math.WrapCeil(repeatedRevYoyo, duration));
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

        /// <summary>
        /// Set settings for this sequence.
        /// </summary>
        /// <param name="settings">Sequence settings.</param>
        /// <returns>This sequence.</returns>
        public Sequence SetSettings(SequenceSettings settings)
        {
            Settings = settings;
            return this;
        }

        /// <summary>
        /// Starts playing this sequence (or resume if was paused).
        /// </summary>
        /// <param name="useRealtime">Realtime (system time) will be used if true.</param>
        /// <returns>Object that represent playing (can be yielded).</returns>
        public new Sequence Play(bool useRealtime = false)
        {
            return (Sequence)base.Play(useRealtime);
        }

        protected override sealed IEnumerator PlayTimeWithCurrentParameters()
        {
            return PlayTime(GetPreviousTimeInitialPosition(LoopType), Duration, DurationWithLoops, LoopsCount, LoopType);
        }

        private IEnumerator PlayTime(float previousTime, float duration, float durationWithLoops, int loopsCount, LoopType loopType)
        {
            InvokeStart();

            _playStartTime = GetTime(_useRealtime);
            _playCurrentTime = _playStartTime;
            _playEndTime = _playStartTime + durationWithLoops;

            while (loopsCount == -1)
            {
                yield return null;

                if (duration == 0f)
                {
                    SetTime(previousTime, 0f, duration, durationWithLoops, loopType);
                    InvokeUpdate();
                    continue;
                }

                _playCurrentTime = GetTime(_useRealtime);

                while (_playEndTime < _playCurrentTime)
                {
                    _playStartTime = _playEndTime;
                    _playEndTime = _playStartTime + durationWithLoops;
                }

                _playCurrentTime -= _playStartTime;
                SetTime(previousTime, _playCurrentTime, duration, durationWithLoops, LoopType);
                previousTime = _playCurrentTime;

                InvokeUpdate();
            }

            if (duration == 0f)
            {
                yield return null;
                SetTime(previousTime, 0f, duration, durationWithLoops, loopType);
            }
            else
            {
                while (_playCurrentTime < _playEndTime)
                {
                    yield return null;

                    _playCurrentTime = GetTime(_useRealtime);

                    float time = Mathf.Min(_playCurrentTime, _playEndTime) - _playStartTime;
                    SetTime(previousTime, time, duration, durationWithLoops, loopType);
                    previousTime = time;

                    InvokeUpdate();
                }
            }

            HandleStop();
        }

        private List<PhasedData> GetSortedByPhaseData(float startTime, float endTime)
        {
            bool isBackward = startTime > endTime;
            List<PhasedData> phasedDatas = new List<PhasedData>();

            foreach (var playableData in _playbleDatas)
            {
                float tweenStartTime = isBackward ? playableData.StartTime + playableData.Playable.DurationWithLoops : playableData.StartTime;
                float tweenEndTime = isBackward ? playableData.StartTime : playableData.StartTime + playableData.Playable.DurationWithLoops;

                // If playable not in played zone - just skip it.
                if (isBackward && (tweenEndTime >= startTime || tweenStartTime < endTime)) continue;
                else if (!isBackward && (tweenEndTime <= startTime || tweenStartTime > endTime)) continue;

                // If playable starts in played zone - add it to start phase.
                if (isBackward && (tweenStartTime < startTime && tweenStartTime >= endTime)) phasedDatas.Add(new PhasedData(Phase.Start, playableData));
                else if (!isBackward && (tweenStartTime > startTime && tweenStartTime <= endTime)) phasedDatas.Add(new PhasedData(Phase.Start, playableData));

                // If playable starts before played zone, but yet not comlpeted - add it to update phase.
                if (isBackward && (tweenStartTime > endTime && tweenEndTime < endTime)) phasedDatas.Add(new PhasedData(Phase.Update, playableData));
                else if (!isBackward && (tweenStartTime < endTime && tweenEndTime > endTime)) phasedDatas.Add(new PhasedData(Phase.Update, playableData));

                // If playable ends in played zone - add it to complete phase.
                if (isBackward && (tweenEndTime < startTime && tweenEndTime >= endTime)) phasedDatas.Add(new PhasedData(Phase.Complete, playableData));
                else if (!isBackward && (tweenEndTime > startTime && tweenEndTime <= endTime)) phasedDatas.Add(new PhasedData(Phase.Complete, playableData));
            }

            // Adding callbacks which in played zone.
            for (int i = 0; i < _callbacksDatas.Count; i++)
            {
                CallbackData callbackData = _callbacksDatas[i];

                if (callbackData.StartTime > startTime && callbackData.StartTime <= endTime)
                    phasedDatas.Add(new PhasedData(Phase.Complete, _callbacksDatas[i]));
            }

            phasedDatas.Sort((p1, p2) =>
            {
                float p1Time = GetPhasedDataTimeForSorting(p1, endTime);
                float p2Time = GetPhasedDataTimeForSorting(p2, endTime);

                if (p1Time != p2Time) return p1Time.CompareTo(p2Time);
                else return GetPhasedDataOrder(p1).CompareTo(GetPhasedDataOrder(p2));
            });

            return phasedDatas;
        }

        private float GetPhasedDataTimeForSorting(PhasedData phasedData, float endTime)
        {
            if (phasedData.PlayableData != null)
            {
                if (phasedData.Phase == Phase.Start) return phasedData.PlayableData.Value.StartTime;
                else if (phasedData.Phase == Phase.Update) return endTime;
                else return phasedData.PlayableData.Value.StartTime + phasedData.PlayableData.Value.Playable.DurationWithLoops;
            }
            else return phasedData.CallbackData.Value.StartTime;
        }

        private int GetPhasedDataOrder(PhasedData phasedData)
        {
            return phasedData.PlayableData != null ? phasedData.PlayableData.Value.Order : phasedData.CallbackData.Value.Order;
        }

        protected override void HandleStop()
        {
            if (PlayState != PlayState.Pause) RoutineHelper.Instance.StopCoroutine(_playTimeEnumerator);
            _playTimeEnumerator = null;

            ResetCurrentTime();

            PlayState = PlayState.Stop;

            InvokeComplete();

            AddSavedDatasToSequence();
        }

        private void AddSavedDatasToSequence()
        {
            while (_addQueue.Count > 0)
            {
                AddType addType = _addQueue.Dequeue();

                if (addType == AddType.AppendPlayable)
                {
                    var playableDataToAppend = _playableDatasToAppend.Dequeue();
                    if (playableDataToAppend.Order == -1)
                        Append(playableDataToAppend.Playable);
                    else
                        Append(playableDataToAppend.Playable, playableDataToAppend.Order);
                }
                else if (addType == AddType.AppendCallback)
                {
                    var callbackDataToAppend = _callbackDatasToAppend.Dequeue();
                    if (callbackDataToAppend.Order == -1)
                        Append(callbackDataToAppend.Callback);
                    else
                        Append(callbackDataToAppend.Callback, callbackDataToAppend.Order);
                }
                else if (addType == AddType.InsertPlayable)
                {
                    var playableDataToInsert = _playableDatasToInsert.Dequeue();
                    if (playableDataToInsert.Order == -1)
                        Insert(playableDataToInsert.Time, playableDataToInsert.Playable);
                    else
                        Insert(playableDataToInsert.Time, playableDataToInsert.Playable, playableDataToInsert.Order);
                }
                else
                {
                    var callbackDataToInsert = _callbackDatasToInsert.Dequeue();
                    if (callbackDataToInsert.Order == -1)
                        Insert(callbackDataToInsert.Time, callbackDataToInsert.Callback);
                    else
                        Insert(callbackDataToInsert.Time, callbackDataToInsert.Callback, callbackDataToInsert.Order);
                }
            }
        }

        /// <summary>
        /// Set callback on Start event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public new Sequence OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        /// <summary>
        /// Set callback on Update event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public new Sequence OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        /// <summary>
        /// Set callback on Complete event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public new Sequence OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }
        #endregion
    }
}