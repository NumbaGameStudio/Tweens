using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Vector4 value to other and call passed action.
    /// </summary>
    public sealed class TweakVector4 : Tweak<Vector4>
    {
        private TweakVector4() { }

        /// <summary>
        /// Create tweak with From and To Vector4 values and passed setter action.
        /// </summary>
        /// <param name="from">From Vector4 value.</param>
        /// <param name="to">To Vector4 value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakVector4(Vector4 from, Vector4 to, Action<Vector4> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Vector4 value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Vector4 value interpolated by formula.</returns>
        public override Vector4 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}