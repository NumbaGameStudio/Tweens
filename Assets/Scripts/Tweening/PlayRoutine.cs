using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    /// <summary>
    /// Represent tween animation (even if it paused). 
    /// Can be yielded for wait while complete.
    /// </summary>
    public sealed class PlayRoutine : CustomYieldInstruction
    {
        private bool _keepWaiting = true;

        /// <summary>
        /// Will be False when playing routine completed or stoped.
        /// </summary>
        public override bool keepWaiting { get { return _keepWaiting; } }

        private PlayRoutine() { }

        /// <summary>
        /// Create completed routine (useful for tweens with loops count equal to 0)
        /// </summary>
        /// <returns>Completed routine.</returns>
        public static PlayRoutine CreateCompleted()
        {
            return new PlayRoutine() { _keepWaiting = false };
        }

        /// <summary>
        /// Create routine.
        /// </summary>
        /// <param name="onStopCallback">Callback whose call will stop returned routine.</param>
        /// <returns>Playing routine.</returns>
        public static PlayRoutine Create(out Action onStopCallback)
        {
            PlayRoutine tweenRoutine = new PlayRoutine();
            onStopCallback = () => tweenRoutine._keepWaiting = false;

            return tweenRoutine;
        }
    }
}