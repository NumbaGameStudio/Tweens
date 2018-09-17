﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
	public sealed class TweakDouble : Tweak<double> 
	{
        private TweakDouble() { }

        public TweakDouble(double from, double to, Action<double> setter) : base(from, to, setter) { }

        protected override double Evaluate(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease((float)From, (float)To, normalizedPassedTime, ease);
        }

        protected override double EvaluateBackward(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease((float)To, (float)From, normalizedPassedTime, ease);
        }

        protected override double Evaluate(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(From, To, normalizedTime, curve);
        }

        protected override double EvaluateBackward(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(To, From, normalizedTime, curve);
        }
    }
}