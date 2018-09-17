﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakColor : Tweak<Color>
    {
        private TweakColor() { }

        public TweakColor(Color from, Color to, Action<Color> setter) : base(from, to, setter) { }

        protected override Color Evaluate(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease(From, To, normalizedPassedTime, ease);
        }

        protected override Color EvaluateBackward(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease(To, From, normalizedPassedTime, ease);
        }

        protected override Color Evaluate(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(From, To, normalizedTime, curve);
        }

        protected override Color EvaluateBackward(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(To, From, normalizedTime, curve);
        }
    }
}