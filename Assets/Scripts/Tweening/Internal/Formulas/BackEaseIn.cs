
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent BackEaseIn formula
    /// </summary>
    internal class BackEaseIn : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.BackIn; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            return interpolation * interpolation * interpolation - interpolation * Mathf.Sin(interpolation * Mathf.PI);
        }
    }
}
