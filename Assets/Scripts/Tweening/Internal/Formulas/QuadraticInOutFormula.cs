﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweens;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent quadratic formula with acceleration and slowdown.
    /// </summary>
    internal sealed class QuadraticInOutFormula : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.QuadInOut; } }

        /// <summary>
        /// Calculate time by formula.
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            interpolation /= 0.5f;

            if (interpolation < 1f) return interpolation * interpolation / 2f;

            --interpolation;
            return -(interpolation * (interpolation - 2f) - 1f) / 2f;
        }
    }
}