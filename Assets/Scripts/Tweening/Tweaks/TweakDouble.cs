using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;

namespace Numba.Tweening.Tweaks
{
	public sealed class TweakDouble : Tweak<double> 
	{
        private TweakDouble() { }

        public TweakDouble(double from, double to, Action<double> setter) : base(from, to, setter) { }

        public override double Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override double Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, FormulasUtility.GetFormula(ease), swapFromTo);
        }
    }
}