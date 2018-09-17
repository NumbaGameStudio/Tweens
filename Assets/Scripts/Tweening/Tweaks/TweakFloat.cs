using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakFloat : Tweak<float>
    {
        private TweakFloat() { }

        public TweakFloat(float from, float to, Action<float> setter) : base(from, to, setter) { }

        protected override float Evaluate(float normalizedPassedTime, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedPassedTime, ease));
        }

        protected override float Evaluate(float normalizedTime, AnimationCurve curve, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedTime, curve));
        }
    }
}