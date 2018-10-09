using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Base class for aby formula.
    /// </summary>
    public abstract class Formula
    {
        /// <summary>
        /// Ease type associated to this formula (for custom formulas is setted to Ease.Other).
        /// </summary>
        internal virtual Ease Ease
        {
            get
            {
                InternalFormula formula = this as InternalFormula;

                if (formula != null) return formula.Ease;
                else return Ease.Other;
            }
        }

        /// <summary>
        /// Calculate interpolation value affected by formula.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <returns>Value affected by formula.</returns>
        public abstract float Calculate(float interpolation);
    }
}