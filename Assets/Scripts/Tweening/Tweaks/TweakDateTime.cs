using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakDateTime : Tweak<DateTime>
    {
        private TweakDateTime() { }

        public TweakDateTime(DateTime from, DateTime to, Action<DateTime> setter) : base(from, to, setter) { }

        public override DateTime Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override DateTime Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }
    }
}