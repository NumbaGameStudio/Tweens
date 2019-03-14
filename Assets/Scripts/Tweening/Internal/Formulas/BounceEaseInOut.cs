
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent BounceEaseInOut formula
    /// </summary>
    internal class BounceEaseInOut : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.BounceInOut; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            if (interpolation < 0.5f)
            {
                return 0.5f * new BounceEaseIn().Calculate(interpolation * 2);
            }
            else
            {
                return 0.5f * new BounceEaseOut().Calculate(interpolation * 2 - 1) + 0.5f;
            }
        }
    }
}
