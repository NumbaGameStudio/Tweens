using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakBounds : Tweak<Bounds>
    {
        private TweakBounds() { }

        public TweakBounds(Bounds from, Bounds to, Action<Bounds> setter) : base(from, to, setter) { }

        protected override Bounds Evaluate(float normalizedPassedTime, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => new Bounds(Easing.Ease(from.center, to.center, normalizedPassedTime, ease), Easing.Ease(from.size, to.size, normalizedPassedTime, ease)));
        }

        protected override Bounds Evaluate(float normalizedTime, AnimationCurve curve, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => new Bounds(Easing.Ease(from.center, to.center, normalizedTime, curve), Easing.Ease(from.size, to.size, normalizedTime, curve)));
        }
    }
}