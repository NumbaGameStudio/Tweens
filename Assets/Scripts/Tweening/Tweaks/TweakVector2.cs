using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakVector2 : Tweak<Vector2>
    {
        private TweakVector2() { }

        public TweakVector2(Vector2 from, Vector2 to, Action<Vector2> setter) : base(from, to, setter) { }

        protected override Vector2 Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, ease));
        }
        
        protected override Vector2 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}