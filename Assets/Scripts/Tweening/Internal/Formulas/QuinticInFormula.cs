﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    /// <summary>
    /// Represent quintic formula with acceleration.
    /// </summary>
    internal sealed class QuinticInFormula : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.InQuint; } }

        /// <summary>
        /// Calculate time by formula.
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            return interpolation * interpolation * interpolation * interpolation * interpolation;
        }
    }
}