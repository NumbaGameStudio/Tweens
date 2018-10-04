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

        public override float Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override float Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }
    }
}