using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one WheelFrictionCurve value to other and call passed action.
    /// </summary>
    public sealed class TweakWheelFrictionCurve : Tweak<WheelFrictionCurve>
    {
        private TweakWheelFrictionCurve() { }

        /// <summary>
        /// Create tweak with From and To WheelFrictionCurve values and passed setter action.
        /// </summary>
        /// <param name="from">From WheelFrictionCurve value.</param>
        /// <param name="to">To WheelFrictionCurve value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakWheelFrictionCurve(WheelFrictionCurve from, WheelFrictionCurve to, Action<WheelFrictionCurve> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate WheelFrictionCurve value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>WheelFrictionCurve value interpolated by formula.</returns>
        public override WheelFrictionCurve Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}