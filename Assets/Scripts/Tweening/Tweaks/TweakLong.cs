using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakLong : Tweak<long>
    {
        private TweakLong() { }

        public TweakLong(long from, long to, Action<long> setter) : base(from, to, setter) { }

        protected override long Evaluate(float normalizedPassedTime, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedPassedTime, ease));
        }

        protected override long Evaluate(float normalizedTime, AnimationCurve curve, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedTime, curve));
        }
    }
}