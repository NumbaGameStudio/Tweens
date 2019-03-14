
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent BounceEaseIn formula
    /// </summary>
    internal class BounceEaseIn : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.BounceIn; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            return 1 - new BounceEaseOut().Calculate(1 - interpolation);
        }
    }
}