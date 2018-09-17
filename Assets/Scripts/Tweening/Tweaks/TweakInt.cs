using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakInt : Tweak<int>
    {
        private TweakInt() { }

        public TweakInt(int from, int to, Action<int> setter) : base(from, to, setter) { }

        protected override int Evaluate(float normalizedPassedTime, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedPassedTime, ease));
        }
        
        protected override int Evaluate(float normalizedTime, AnimationCurve curve, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedTime, curve));
        }
    }
}