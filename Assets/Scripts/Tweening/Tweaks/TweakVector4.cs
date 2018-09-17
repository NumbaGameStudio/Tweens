﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakVector4 : Tweak<Vector4>
    {
        private TweakVector4() { }

        public TweakVector4(Vector4 from, Vector4 to, Action<Vector4> setter) : base(from, to, setter) { }

        protected override Vector4 Evaluate(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease(From, To, normalizedPassedTime, ease);
        }

        protected override Vector4 EvaluateBackward(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease(To, From, normalizedPassedTime, ease);
        }

        protected override Vector4 Evaluate(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(From, To, normalizedTime, curve);
        }

        protected override Vector4 EvaluateBackward(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(To, From, normalizedTime, curve);
        }
    }
}