using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one String value to other and call passed action.
    /// </summary>
    public sealed class TweakString : Tweak<string>
    {
        private TweakString() { }

        /// <summary>
        /// Create tweak with From and To String values and passed setter action.
        /// </summary>
        /// <param name="from">From String value.</param>
        /// <param name="to">To String value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakString(string from, string to, Action<string> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate String value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>String value interpolated by formula.</returns>
        public override string Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}