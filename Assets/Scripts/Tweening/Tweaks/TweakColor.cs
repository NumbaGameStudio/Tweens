using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Color value to other and call passed action.
    /// </summary>
    public sealed class TweakColor : Tweak<Color>
    {
        private TweakColor() { }

        /// <summary>
        /// Create tweak with From and To Color values and passed setter action.
        /// </summary>
        /// <param name="from">From Color value.</param>
        /// <param name="to">To Color value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakColor(Color from, Color to, Action<Color> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Color value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Color value interpolated by formula.</returns>
        public override Color Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}