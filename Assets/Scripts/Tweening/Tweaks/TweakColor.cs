using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakColor : Tweak<Color>
    {
        private TweakColor() { }

        public TweakColor(Color from, Color to, Action<Color> setter) : base(from, to, setter) { }

        public override Color Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override Color Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, FormulasUtility.GetFormula(ease), swapFromTo);
        }
    }
}