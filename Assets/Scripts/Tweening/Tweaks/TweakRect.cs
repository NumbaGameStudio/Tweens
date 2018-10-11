using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Rect value to other and call passed action.
    /// </summary>
    public sealed class TweakRect : Tweak<Rect>
    {
        private TweakRect() { }

        /// <summary>
        /// Create tweak with From and To Rect values and passed setter action.
        /// </summary>
        /// <param name="from">From Rect value.</param>
        /// <param name="to">To Rect value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakRect(Rect from, Rect to, Action<Rect> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Rect value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Rect value interpolated by formula.</returns>
        public override Rect Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}