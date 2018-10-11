using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Double value to other and call passed action.
    /// </summary>
	public sealed class TweakDouble : Tweak<double> 
	{
        private TweakDouble() { }

        /// <summary>
        /// Create tweak with From and To Double values and passed setter action.
        /// </summary>
        /// <param name="from">From Double value.</param>
        /// <param name="to">To Double value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakDouble(double from, double to, Action<double> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Double value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Double value interpolated by formula.</returns>
        public override double Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}