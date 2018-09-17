using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
	public sealed class TweakDouble : Tweak<double> 
	{
        private TweakDouble() { }

        public TweakDouble(double from, double to, Action<double> setter) : base(from, to, setter) { }

        protected override double Evaluate(float normalizedPassedTime, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedPassedTime, ease));
        }

        protected override double Evaluate(float normalizedTime, AnimationCurve curve, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedTime, curve));
        }
    }
}