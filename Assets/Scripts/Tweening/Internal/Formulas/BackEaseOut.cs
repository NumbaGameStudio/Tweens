
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent BackEaseOut formula
    /// </summary>
    internal class BackEaseOut : InternalFormula
    {
        /// <summary>
        /// Associated ease type.
        /// </summary>
        public override Ease Ease { get { return Ease.BackOut; } }

        /// <summary>
        /// Calculate time by formula (just return passed time).
        /// </summary>
        /// <param name="interpolation">Interpolated time.</param>
        /// <returns>Time changed by formula.</returns>
        public override float Calculate(float interpolation)
        {
            float f = (1 - interpolation);
            return 1 - (f * f * f - f * Mathf.Sin(f * Mathf.PI));
        }
    }
}
