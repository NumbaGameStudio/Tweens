using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Special math functions.
    /// </summary>
    internal static class Math 
	{
        /// <summary>
        /// Wrap value between 0 and max (inclusive).
        /// </summary>
        /// <param name="value">Value to wrap.</param>
        /// <param name="max">Max thresold for value.</param>
        /// <returns>Wrapped value.</returns>
        public static float WrapCeil(float value, float max)
        {
            if (value == 0f) return 0f;

            float wrapped = value % max;
            return (wrapped == 0f) ? max : wrapped;
        }
    }
}