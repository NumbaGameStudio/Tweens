using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Long value to other and call passed action.
    /// </summary>
    public sealed class TweakLong : Tweak<long>
    {
        private TweakLong() { }

        /// <summary>
        /// Create tweak with From and To Long values and passed setter action.
        /// </summary>
        /// <param name="from">From Long value.</param>
        /// <param name="to">To Long value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakLong(long from, long to, Action<long> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Long value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Long value interpolated by formula.</returns>
        public override long Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}