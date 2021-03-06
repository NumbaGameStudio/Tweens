﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweens;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent quintic formula with slowdown.
    /// </summary>
    internal sealed class QuinticOutFormula : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.QuintOut; } }

        /// <summary>
        /// Calculate time by formula.
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            --interpolation;
            return interpolation * interpolation * interpolation * interpolation * interpolation + 1f;
        }
    }
}