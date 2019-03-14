
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent BackEaseInOut formula
    /// </summary>
    internal class BackEaseInOut : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.BackInOut; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            if (interpolation < 0.5f)
            {
                float f = 2 * interpolation;
                return 0.5f * (f * f * f - f * Mathf.Sin(f * Mathf.PI));
            }
            else
            {
                float f = (1 - (2 * interpolation - 1));
                return 0.5f * (1 - (f * f * f - f * Mathf.Sin(f * Mathf.PI))) + 0.5f;
            }
        }
    }
}
