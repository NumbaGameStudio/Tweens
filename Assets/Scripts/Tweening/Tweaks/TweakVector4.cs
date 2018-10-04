using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakVector4 : Tweak<Vector4>
    {
        private TweakVector4() { }

        public TweakVector4(Vector4 from, Vector4 to, Action<Vector4> setter) : base(from, to, setter) { }

        public override Vector4 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override Vector4 Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }
    }
}