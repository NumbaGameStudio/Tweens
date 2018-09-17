﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakQuaternion : Tweak<Quaternion>
    {
        private TweakQuaternion() { }

        public TweakQuaternion(Quaternion from, Quaternion to, Action<Quaternion> setter) : base(from, to, setter) { }

        protected override Quaternion Evaluate(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease(From, To, normalizedPassedTime, ease);
        }

        protected override Quaternion EvaluateBackward(float normalizedPassedTime, Ease ease)
        {
            return Easing.Ease(To, From, normalizedPassedTime, ease);
        }

        protected override Quaternion Evaluate(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(From, To, normalizedTime, curve);
        }

        protected override Quaternion EvaluateBackward(float normalizedTime, AnimationCurve curve)
        {
            return Easing.Ease(To, From, normalizedTime, curve);
        }
    }
}