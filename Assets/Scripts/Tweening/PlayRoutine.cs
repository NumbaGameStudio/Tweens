using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    public sealed class PlayRoutine : CustomYieldInstruction
    {
        private bool _keepWaiting = true;

        public override bool keepWaiting { get { return _keepWaiting; } }

        private PlayRoutine() { }

        public static PlayRoutine CreateCompleted()
        {
            return new PlayRoutine() { _keepWaiting = false };
        }

        public static PlayRoutine Create(out Action onStopCallback)
        {
            PlayRoutine tweenRoutine = new PlayRoutine();
            onStopCallback = () => tweenRoutine._keepWaiting = false;

            return tweenRoutine;
        }
    }
}