using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweens;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent linear formula.
    /// </summary>
    internal sealed class LinearFormula : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.Linear; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            return interpolation;
        }
    }
}