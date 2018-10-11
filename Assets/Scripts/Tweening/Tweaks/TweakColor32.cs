using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Color32 value to other and call passed action.
    /// </summary>
    public sealed class TweakColor32 : Tweak<Color32>
    {
        private TweakColor32() { }

        /// <summary>
        /// Create tweak with From and To Color32 values and passed setter action.
        /// </summary>
        /// <param name="from">From Color32 value.</param>
        /// <param name="to">To Color32 value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakColor32(Color32 from, Color32 to, Action<Color32> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Color32 value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Color32 value interpolated by formula.</returns>
        public override Color32 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}