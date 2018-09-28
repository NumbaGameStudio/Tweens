using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakQuaternion : Tweak<Quaternion>
    {
        private TweakQuaternion() { }

        public TweakQuaternion(Quaternion from, Quaternion to, Action<Quaternion> setter) : base(from, to, setter) { }

        protected override Quaternion Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, ease));
        }

        protected override Quaternion Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}