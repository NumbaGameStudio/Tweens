using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Vector2 value to other and call passed action.
    /// </summary>
    public sealed class TweakVector2 : Tweak<Vector2>
    {
        private TweakVector2() { }

        /// <summary>
        /// Create tweak with From and To Vector2 values and passed setter action.
        /// </summary>
        /// <param name="from">From Vector2 value.</param>
        /// <param name="to">To Vector2 value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakVector2(Vector2 from, Vector2 to, Action<Vector2> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Vector2 value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Vector2 value interpolated by formula.</returns>
        public override Vector2 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}