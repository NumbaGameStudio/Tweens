using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakWheelFrictionCurve : Tweak<WheelFrictionCurve>
    {
        private TweakWheelFrictionCurve() { }

        public TweakWheelFrictionCurve(WheelFrictionCurve from, WheelFrictionCurve to, Action<WheelFrictionCurve> setter) : base(from, to, setter) { }

        public override WheelFrictionCurve Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override WheelFrictionCurve Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }
    }
}