using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTime = UnityEngine.Time;

namespace Numba.Tweening
{
    public abstract class Playable
    {
        #region Fields
        protected IEnumerator _playTimeEnumerator;

        protected PlayRoutine _playRoutine;

        protected Action _playRoutineOnStopCallback;

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
        public event Action Started;

        public event Action Updated;

        public event Action Completed;
        #endregion

        #region Callback
        protected Action _onStartCallback;

        protected Action _onUpdateCallback;

        protected Action _onCompleteCallback;
        #endregion
        #endregion

        #region Properties
        public string Name { get; protected set; }

        protected abstract string PlayableName { get; }

        public float Duration { get { return _duration; } }

        public float DurationWithLoops { get; protected set; }

        public abstract int LoopsCount { get; set; }

        public abstract LoopType LoopType { get; set; }

        public PlayState PlayState { get; protected set; }
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

        public Playable SetLoops(int loopsCount)
        {
            LoopsCount = LoopsCount;
            return this;
        }

        public Playable SetLoops(LoopType loopType)
        {
            LoopType = loopType;
            return this;
        }

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

        public abstract void SetTime(float time);

        public abstract PlayRoutine Play(bool useRealtime = false);

        public void Stop()
        {
            if (PlayState == PlayState.Stop)
            {
                Debug.LogWarning(string.Format("{0} with name \"{1}\" is already stoped.", PlayableName, Name));
                return;
            }

            HandleStop();
        }

        protected abstract void HandleStop();

        public void Pause()
        {
            if (PlayState != PlayState.Play)
            {
                Debug.LogWarning(string.Format("{0} with name \"{1}\" already stoped or paused.", PlayableName, Name));
                return;
            }

            RoutineHelper.Instance.StopCoroutine(_playTimeEnumerator);
            PlayState = PlayState.Pause;
        }

        public Playable OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        public Playable OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        public Playable OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }

        public void InvokeStart()
        {
            InvokePhase(Started, _onStartCallback);
        }

        public void InvokeUpdate()
        {
            InvokePhase(Updated, _onUpdateCallback);
        }

        public void InvokeComplete()
        {
            InvokePhase(Completed, _onCompleteCallback);
        }

        private void InvokePhase(Action phaseEvent, Action callback)
        {
            if (phaseEvent != null) phaseEvent();
            if (callback != null) callback();
        }

        public void ClearCallbacks()
        {
            _onStartCallback = _onUpdateCallback = _onCompleteCallback = null;
        }
        #endregion
    }
}