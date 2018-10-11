using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Char value to other and call passed action.
    /// </summary>
    public sealed class TweakChar : Tweak<char>
    {
        private TweakChar() { }

        /// <summary>
        /// Create tweak with From and To Char values and passed setter action.
        /// </summary>
        /// <param name="from">From Char value.</param>
        /// <param name="to">To Char value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakChar(char from, char to, Action<char> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Char value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Char value interpolated by formula.</returns>
        public override char Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}