
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent ElasticEaseInOut formula
    /// </summary>
    internal class ElasticEaseInOut : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.ElasticInOut; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            if (interpolation < 0.5f)
            {
                return 0.5f * Mathf.Sin(13 * (Mathf.PI / 2f) * (2 * interpolation)) * Mathf.Pow(2, 10 * ((2 * interpolation) - 1));
            }
            else
            {
                return 0.5f * (Mathf.Sin(-13 * (Mathf.PI / 2f) * ((2 * interpolation - 1) + 1)) * Mathf.Pow(2, -10 * (2 * interpolation - 1)) + 2);
            }
        }
    }
}