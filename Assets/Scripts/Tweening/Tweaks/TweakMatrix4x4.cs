using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakMatrix4x4 : Tweak<Matrix4x4>
    {
        private TweakMatrix4x4() { }

        public TweakMatrix4x4(Matrix4x4 from, Matrix4x4 to, Action<Matrix4x4> setter) : base(from, to, setter) { }

        public override Matrix4x4 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override Matrix4x4 Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }
    }
}