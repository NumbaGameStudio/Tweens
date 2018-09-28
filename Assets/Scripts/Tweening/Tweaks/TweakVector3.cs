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

        protected override Vector3 Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, ease));
        }

        protected override Vector3 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}