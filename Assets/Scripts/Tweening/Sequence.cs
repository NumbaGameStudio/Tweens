﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;
using UnityTime = UnityEngine.Time;

namespace Numba.Tweening
{
    /// <summary>
    /// Represent a tweens container. May play them all sequentially.
    /// </summary>
	public class Sequence
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

        private struct SortedTweensAndCallbacks
        {
            public List<TweenData> StartedTweens { get; set; }

            public List<TweenData> ContinuousTweens { get; set; }

            public List<TweenData> CompletedTweens { get; set; }

            public List<CallbackData> CompletedCallbacks { get; set; }

            public SortedTweensAndCallbacks(List<TweenData> startedTweens, List<TweenData> continuousTweens, List<TweenData> completedTweens, List<CallbackData> completedCallbacks)
            {
                StartedTweens = startedTweens;
                ContinuousTweens = continuousTweens;
                CompletedTweens = completedTweens;
                CompletedCallbacks = completedCallbacks;
            }
        }
        #endregion

        #region Fields
        private List<TweenData> _tweensDatas = new List<TweenData>();

        private List<CallbackData> _callbacksDatas = new List<CallbackData>();

        private Coroutine _playTimeRoutine;

        private Dictionary<Tween, float> _tweenDurations = new Dictionary<Tween, float>();

        private int _loopsCount = 1;

        private bool _stopRequested;
        #endregion

        #region Constructors
        /// <summary>
        /// Create empty sequence.
        /// </summary>
        public Sequence() : this(string.Empty) { }

        /// <summary>
        /// Create empty sequence with name.
        /// </summary>
        public Sequence(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Create sequence and add all tweens in zero time position.
        /// </summary>
        /// <param name="tweens">Tweens which will be added.</param>
        public Sequence(params Tween[] tweens) : this(string.Empty, tweens) { }

        /// <summary>
        /// Create sequence with name and add all tweens in zero time position.
        /// </summary>
        /// <param name="tweens">Tweens which will be added.</param>
        public Sequence(string name, params Tween[] tweens)
        {
            foreach (var tween in tweens)
            {
                Insert(0f, tween);
            }
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public float Duration { get; private set; }

        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        public bool IsPlaying { get { return _playTimeRoutine != null; } }
        #endregion

        #region Methods
        public void Append(Tween tween)
        {
            _tweensDatas.Add(new TweenData(tween, Duration));
            Duration += CalculateAndCacheDuration(tween);
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

        public void Insert(float time, Action callback)
        {
            _callbacksDatas.Add(new CallbackData(callback, time));
            Duration = Mathf.Max(Duration, time);
        }

        private float CalculateAndCacheDuration(Tween tween)
        {
            int loopsCount = tween.LoopsCount == -1 ? 1 : tween.LoopsCount;
            float duration = loopsCount * tween.Duration;
            if (tween.LoopType == LoopType.Yoyo || tween.LoopType == LoopType.ReversedYoyo) duration *= 2f;

            _tweenDurations.Add(tween, duration);

            return duration;
        }

        private float GetTweenDuration(Tween tween)
        {
            return _tweenDurations[tween];
        }

        public Sequence SetLoopsCount(int loopsCount)
        {
            LoopsCount = loopsCount;
            return this;
        }

        public Coroutine Play(bool useRealtime = false)
        {
            if (IsPlaying)
            {
                Debug.LogWarning(string.Format("Sequence with name \"{0}\"is already playing.", Name));
                return _playTimeRoutine;
            }

            return _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(useRealtime, LoopsCount));
        }

        private IEnumerator PlayTime(bool useRealtime, int loopsCount)
        {
            float startTime = 0f;
            float previousTime = 0f;
            float endTime = 0f;
            float timePassed = 0f;

            while (loopsCount != 0)
            {
                startTime = GetTime(useRealtime);
                endTime = startTime + Duration;
                previousTime = -1f;

                while (GetTime(useRealtime) < endTime)
                {
                    yield return null;

                    timePassed = Mathf.Min(GetTime(useRealtime), endTime) - startTime;
                    UpdateTweensAndCallbacks(FindTweensAndCallbacksBetween(previousTime, timePassed), timePassed);

                    previousTime = timePassed;

                    if (_stopRequested)
                    {
                        HandleStop();
                        yield break;
                    }
                }

                if (loopsCount != -1) --loopsCount;
            }

            timePassed = endTime - startTime;
            UpdateTweensAndCallbacks(FindTweensAndCallbacksBetween(previousTime, timePassed), timePassed);
            
            _playTimeRoutine = null;
        }

        private float GetTime(bool useRealtime)
        {
            return useRealtime ? UnityTime.realtimeSinceStartup : UnityTime.time;
        }

        private void UpdateTweensAndCallbacks(SortedTweensAndCallbacks sortedTweensAndCallbacks, float timePassed)
        {
            foreach (var tweenData in sortedTweensAndCallbacks.StartedTweens)
                tweenData.Tween.SetTime((timePassed - tweenData.StartTime) / GetTweenDuration(tweenData.Tween));

            foreach (var tweenData in sortedTweensAndCallbacks.ContinuousTweens)
                tweenData.Tween.SetTime((timePassed - tweenData.StartTime) / GetTweenDuration(tweenData.Tween));

            foreach (var tweenData in sortedTweensAndCallbacks.CompletedTweens)
                tweenData.Tween.SetTime(1f);

            foreach (var callbackData in sortedTweensAndCallbacks.CompletedCallbacks) callbackData.Callback();
        }

        private SortedTweensAndCallbacks FindTweensAndCallbacksBetween(float startTime, float endTime)
        {
            List<TweenData> startedTweens = new List<TweenData>();
            List<TweenData> continuousTweens = new List<TweenData>();
            List<TweenData> completedTweens = new List<TweenData>();
            List<CallbackData> completedCallbacks = new List<CallbackData>();

            foreach (var tweenData in _tweensDatas)
            {
                float tweenEndTime = tweenData.StartTime + GetTweenDuration(tweenData.Tween);

                if (IsValueBetween(tweenEndTime, startTime, endTime) && tweenEndTime != startTime)
                {
                    completedTweens.Add(tweenData);
                    continue;
                }

                if (tweenEndTime <= startTime || tweenData.StartTime > endTime) continue;

                if (tweenData.StartTime > startTime && tweenData.StartTime <= endTime) startedTweens.Add(tweenData);
                else continuousTweens.Add(tweenData);
            }

            foreach (var callbackData in _callbacksDatas)
                if (IsValueBetween(callbackData.StartTime, startTime, endTime) && callbackData.StartTime != startTime) completedCallbacks.Add(callbackData);

            startedTweens.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
            continuousTweens.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
            completedTweens.Sort((x, y) => (x.StartTime + GetTweenDuration(x.Tween)).CompareTo(y.StartTime + GetTweenDuration(y.Tween)));
            completedCallbacks.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));

            return new SortedTweensAndCallbacks(startedTweens, continuousTweens, completedTweens, completedCallbacks);
        }

        private bool IsValueBetween(float value, float startTime, float endTime)
        {
            return value >= startTime && value <= endTime;
        }

        public void Stop()
        {
            if (!IsPlaying)
            {
                Debug.LogWarning(string.Format("Sequence with name \"{0}\" already stoped.", Name));
                return;
            }

            _stopRequested = true;
        }

        private void HandleStop()
        {
            _stopRequested = false;
            _playTimeRoutine = null;
        }
        #endregion
    }
}