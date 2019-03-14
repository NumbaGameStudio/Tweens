
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent BounceEaseOut formula
    /// </summary>
    internal class BounceEaseOut : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.BounceOut; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            if (interpolation < 4 / 11.0f)
            {
                return (121 * interpolation * interpolation) / 16.0f;
            }
            else if (interpolation < 8 / 11.0f)
            {
                return (363 / 40.0f * interpolation * interpolation) - (99 / 10.0f * interpolation) + 17 / 5.0f;
            }
            else if (interpolation < 9 / 10.0f)
            {
                return (4356 / 361.0f * interpolation * interpolation) - (35442 / 1805.0f * interpolation) + 16061 / 1805.0f;
            }
            else
            {
                return (54 / 5.0f * interpolation * interpolation) - (513 / 25.0f * interpolation) + 268 / 25.0f;
            }
        }
    }
}
