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

        protected override Bounds Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => new Bounds(Easing.Ease(from.center, to.center, interpolation, ease), Easing.Ease(from.size, to.size, interpolation, ease)));
        }

        protected override Bounds Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => new Bounds(Easing.Ease(from.center, to.center, interpolation, formula), Easing.Ease(from.size, to.size, interpolation, formula)));
        }
    }
}