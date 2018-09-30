using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakBounds : Tweak<Bounds>
    {
        private TweakBounds() { }

        public TweakBounds(Bounds from, Bounds to, Action<Bounds> setter) : base(from, to, setter) { }

        public override Bounds Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => new Bounds(Easing.Ease(from.center, to.center, interpolation, formula), Easing.Ease(from.size, to.size, interpolation, formula)));
        }

        public override Bounds Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, FormulasUtility.GetFormula(ease), swapFromTo);
        }
    }
}