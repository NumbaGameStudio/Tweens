using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Quaternion value to other and call passed action.
    /// </summary>
    public sealed class TweakQuaternion : Tweak<Quaternion>
    {
        private TweakQuaternion() { }

        /// <summary>
        /// Create tweak with From and To Quaternion values and passed setter action.
        /// </summary>
        /// <param name="from">From Quaternion value.</param>
        /// <param name="to">To Quaternion value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakQuaternion(Quaternion from, Quaternion to, Action<Quaternion> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Quaternion value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Quaternion value interpolated by formula.</returns>
        public override Quaternion Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}