using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one JointSpring value to other and call passed action.
    /// </summary>
    public sealed class TweakJointSpring : Tweak<JointSpring>
    {
        private TweakJointSpring() { }

        /// <summary>
        /// Create tweak with From and To JointSpring values and passed setter action.
        /// </summary>
        /// <param name="from">From JointSpring value.</param>
        /// <param name="to">To JointSpring value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakJointSpring(JointSpring from, JointSpring to, Action<JointSpring> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate JointSpring value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>JointSpring value interpolated by formula.</returns>
        public override JointSpring Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}