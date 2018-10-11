using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Bounds value to other and call passed action.
    /// </summary>
    public sealed class TweakBounds : Tweak<Bounds>
    {
        private TweakBounds() { }

        /// <summary>
        /// Create tweak with From and To Bounds values and passed setter action.
        /// </summary>
        /// <param name="from">From Bounds value.</param>
        /// <param name="to">To Bounds value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakBounds(Bounds from, Bounds to, Action<Bounds> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Bounds value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Bounds value interpolated by formula.</returns>
        public override Bounds Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}