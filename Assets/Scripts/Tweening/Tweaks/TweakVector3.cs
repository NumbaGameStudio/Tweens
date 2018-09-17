using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakVector3 : Tweak<Vector3>
    {
        private TweakVector3() { }

        public TweakVector3(Vector3 from, Vector3 to, Action<Vector3> setter) : base(from, to, setter) { }

        protected override Vector3 Evaluate(float normalizedPassedTime, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedPassedTime, ease));
        }

        protected override Vector3 Evaluate(float normalizedTime, AnimationCurve curve, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, normalizedTime, curve));
        }
    }
}