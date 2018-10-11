using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTime = UnityEngine.Time;

namespace Numba.Tweens
{
    /// <summary>
    /// Base class for all playables (like Tween or Sequence).
    /// </summary>
    public abstract class Playable : CustomYieldInstruction
    {
        #region Fields
        protected IEnumerator _playTimeEnumerator;

        protected float _duration;

        protected int _loopsCount = 1;

        protected LoopType _loopType;

        #region Playing
        protected float _playStartTime;

        protected float _playEndTime;

        protected float _playCurrentTime;

        protected bool _useRealtime;
        #endregion

        #region Events
        /// <summary>
        /// Emits when start playing.
        /// </summary>
        public event Action Started;

        /// <summary>
        /// Emits every update while playing.
        /// </summary>
        public event Action Updated;

        /// <summary>
        /// Emits when playing stoped or completed.
        /// </summary>
        public event Action Completed;
        #endregion

        #region Callback
        protected Action _onStartCallback;

        protected Action _onUpdateCallback;

        protected Action _onCompleteCallback;
        #endregion
        #endregion

        #region Properties
        /// <summary>
        /// Playable name.
        /// </summary>
        public string Name { get; protected set; }

        protected abstract string PlayableTypeName { get; }

        /// <summary>
        /// Duration of playable (without loops count and loop type).
        /// </summary>
        public float Duration { get { return _duration; } }

        /// <summary>
        /// Duration with loops count and loop type.
        /// </summary>
        public float DurationWithLoops { get; protected set; }

        /// <summary>
        /// How many times repeat the animation (-1 for infinity).
        /// </summary>
        public abstract int LoopsCount { get; set; }

        /// <summary>
        /// What behaviour need use when playing.
        /// </summary>
        public abstract LoopType LoopType { get; set; }

        /// <summary>
        /// Playing state.
        /// </summary>
        public PlayState PlayState { get; protected set; }

        /// <summary>
        /// Is need wait animation (true when playing or paused)?
        /// </summary>
        public override bool keepWaiting { get { return PlayState != PlayState.Stop; } }
        #endregion

        #region Methods
        protected bool SetLoopsCount(int loopsCount)
        {
            loopsCount = Mathf.Max(loopsCount, -1);

            if (loopsCount == _loopsCount) return false;

            _loopsCount = loopsCount;
            DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);

            return true;
        }

        protected bool SetLoopType(LoopType loopType)
        {
            if (_loopType == loopType) return false;

            _loopType = loopType;
            DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);

            return true;
        }

        /// <summary>
        /// Set loops count.
        /// </summary>
        /// <param name="loopsCount">Loops count (-1 for infinity).</param>
        /// <returns>This playable.</returns>
        public Playable SetLoops(int loopsCount)
        {
            LoopsCount = LoopsCount;
            return this;
        }

        /// <summary>
        /// Set loop type.
        /// </summary>
        /// <param name="loopType">Loop type.</param>
        /// <returns>This playable.</returns>
        public Playable SetLoops(LoopType loopType)
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
        public Playable SetLoops(int loopsCount, LoopType loopType)
        {
            LoopsCount = loopsCount;
            LoopType = loopType;
            return this;
        }

        protected float CalculateDurationWithLoops(float duration, int loopsCount, LoopType loopType)
        {
            return duration * GetLoopTypeDurationMultiplier(loopType) * Mathf.Abs(loopsCount);
        }

        protected float GetLoopTypeDurationMultiplier(LoopType loopType)
        {
            return IsYoyoTypedLoopType(loopType) ? 2f : 1f;
        }

        protected bool IsYoyoTypedLoopType(LoopType loopType)
        {
            return loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo;
        }

        protected float GetTime(bool useRealtime)
        {
            return useRealtime ? UnityTime.realtimeSinceStartup : UnityTime.time;
        }

        /// <summary>
        /// Set time to this playable.
        /// </summary>
        /// <param name="time">Time (not interpolated).</param>
        internal abstract void SetTime(float time);

        /// <summary>
        /// Starts playing animation.
        /// </summary>
        /// <param name="useRealtime">Realtime (system time) will be used if true.</param>
        /// <returns>Object that represent playing (can be yielded).</returns>
        public virtual Playable Play(bool useRealtime = false)
        {
            if (PlayState == PlayState.Play)
            {
                Debug.LogWarning(string.Format("{0} with name \"{1}\" already playing.", PlayableTypeName, Name));
                return this;
            }

            if (PlayState == PlayState.Pause)
            {
                float currentTime = GetTime(_useRealtime);

                _playStartTime = currentTime - (_playCurrentTime - _playStartTime);
                _playEndTime = currentTime + (_playEndTime - _playCurrentTime);

                PlayState = PlayState.Play;
                RoutineHelper.Instance.StartCoroutine(_playTimeEnumerator);

                return this;
            }

            if (LoopsCount == 0) return this;

            PlayState = PlayState.Play;

            _useRealtime = useRealtime;

            _playTimeEnumerator = PlayTimeWithCurrentParameters();
            RoutineHelper.Instance.StartCoroutine(_playTimeEnumerator);

            return this;
        }

        protected abstract IEnumerator PlayTimeWithCurrentParameters();

        /// <summary>
        /// Stop playing.
        /// </summary>
        public void Stop()
        {
            if (PlayState == PlayState.Stop)
            {
                Debug.LogWarning(string.Format("{0} with name \"{1}\" is already stoped.", PlayableTypeName, Name));
                return;
            }

            HandleStop();
        }

        protected abstract void HandleStop();

        /// <summary>
        /// Pause playing (call Play if need continue animation).
        /// </summary>
        public void Pause()
        {
            if (PlayState != PlayState.Play)
            {
                Debug.LogWarning(string.Format("{0} with name \"{1}\" already stoped or paused.", PlayableTypeName, Name));
                return;
            }

            RoutineHelper.Instance.StopCoroutine(_playTimeEnumerator);
            PlayState = PlayState.Pause;
        }

        /// <summary>
        /// Set callback on Start event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public Playable OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        /// <summary>
        /// Set callback on Update event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public Playable OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        /// <summary>
        /// Set callback on Complete event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public Playable OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }

        /// <summary>
        /// Call Start event and callback.
        /// </summary>
        internal void InvokeStart()
        {
            InvokePhase(Started, _onStartCallback);
        }

        /// <summary>
        /// Call Update event and callback.
        /// </summary>
        internal void InvokeUpdate()
        {
            InvokePhase(Updated, _onUpdateCallback);
        }

        /// <summary>
        /// Call Complete event and callback.
        /// </summary>
        internal void InvokeComplete()
        {
            InvokePhase(Completed, _onCompleteCallback);
        }

        private void InvokePhase(Action phaseEvent, Action callback)
        {
            if (phaseEvent != null) phaseEvent();
            if (callback != null) callback();
        }

        /// <summary>
        /// Clear all callbacks (onStart, onUpdate and onComplete).
        /// </summary>
        public void ClearCallbacks()
        {
            _onStartCallback = _onUpdateCallback = _onCompleteCallback = null;
        }
        #endregion
    }
}