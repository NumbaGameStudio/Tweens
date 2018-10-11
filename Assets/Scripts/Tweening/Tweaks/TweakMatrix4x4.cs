using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Matrix4x4 value to other and call passed action.
    /// </summary>
    public sealed class TweakMatrix4x4 : Tweak<Matrix4x4>
    {
        private TweakMatrix4x4() { }

        /// <summary>
        /// Create tweak with From and To Matrix4x4 values and passed setter action.
        /// </summary>
        /// <param name="from">From Matrix4x4 value.</param>
        /// <param name="to">To Matrix4x4 value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakMatrix4x4(Matrix4x4 from, Matrix4x4 to, Action<Matrix4x4> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Matrix4x4 value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Matrix4x4 value interpolated by formula.</returns>
        public override Matrix4x4 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}