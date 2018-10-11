using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one Vector3 value to other and call passed action.
    /// </summary>
    public sealed class TweakVector3 : Tweak<Vector3>
    {
        private TweakVector3() { }

        /// <summary>
        /// Create tweak with From and To Vector3 values and passed setter action.
        /// </summary>
        /// <param name="from">From Vector3 value.</param>
        /// <param name="to">To Vector3 value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakVector3(Vector3 from, Vector3 to, Action<Vector3> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate Vector3 value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>Vector3 value interpolated by formula.</returns>
        public override Vector3 Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}