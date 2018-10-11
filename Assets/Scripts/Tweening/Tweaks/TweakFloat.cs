using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Float value to other and call passed action.
    /// </summary>
    public sealed class TweakFloat : Tweak<float>
    {
        private TweakFloat() { }

        /// <summary>
        /// Create tweak with From and To Float values and passed setter action.
        /// </summary>
        /// <param name="from">From Float value.</param>
        /// <param name="to">To Float value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakFloat(float from, float to, Action<float> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Float value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Float value interpolated by formula.</returns>
        public override float Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}