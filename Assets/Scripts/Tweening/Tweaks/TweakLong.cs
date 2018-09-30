using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakLong : Tweak<long>
    {
        private TweakLong() { }

        public TweakLong(long from, long to, Action<long> setter) : base(from, to, setter) { }

        public override long Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override long Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, FormulasUtility.GetFormula(ease), swapFromTo);
        }
    }
}