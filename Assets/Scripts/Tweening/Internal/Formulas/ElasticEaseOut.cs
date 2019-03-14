
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent ElasticEaseOut formula
    /// </summary>
    internal class ElasticEaseOut : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.ElasticOut; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            return Mathf.Sin(-13 * (Mathf.PI / 2f) * (interpolation + 1)) * Mathf.Pow(2, -10 * interpolation) + 1;
        }
    }
}