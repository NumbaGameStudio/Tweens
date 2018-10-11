using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Int value to other and call passed action.
    /// </summary>
    public sealed class TweakInt : Tweak<int>
    {
        private TweakInt() { }

        /// <summary>
        /// Create tweak with From and To Int values and passed setter action.
        /// </summary>
        /// <param name="from">From Int value.</param>
        /// <param name="to">To Int value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakInt(int from, int to, Action<int> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Int value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Int value interpolated by formula.</returns>
        public override int Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}