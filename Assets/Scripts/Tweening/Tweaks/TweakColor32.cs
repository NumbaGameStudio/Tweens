﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakColor32 : Tweak<Color32>
    {
        private TweakColor32() { }

        public TweakColor32(Color32 from, Color32 to, Action<Color32> setter) : base(from, to, setter) { }

        protected override Color32 Evaluate(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease((Color)From, (Color)To, normalizedPassedTime, ease);
        }

        protected override Color32 EvaluateBackward(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease((Color)To, (Color)From, normalizedPassedTime, ease);
        }

        protected override Color32 Evaluate(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(From, To, normalizedTime, curve);
        }

        protected override Color32 EvaluateBackward(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(To, From, normalizedTime, curve);
        }
    }
}