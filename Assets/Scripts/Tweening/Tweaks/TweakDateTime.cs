using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one DateTime value to other and call passed action.
    /// </summary>
    public sealed class TweakDateTime : Tweak<DateTime>
    {
        private TweakDateTime() { }

        /// <summary>
        /// Create tweak with From and To DateTime values objects and passed setter action.
        /// </summary>
        /// <param name="from">From DateTime value.</param>
        /// <param name="to">To DateTime value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakDateTime(DateTime from, DateTime to, Action<DateTime> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate DateTime value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>DateTime value interpolated by formula.</returns>
        public override DateTime Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}