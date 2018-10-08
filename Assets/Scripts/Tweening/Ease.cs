using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Enumeration for built-in formulas.
    /// </summary>
    public enum Ease
    {
        /// <summary>
        /// Linear formula.
        /// </summary>
        Linear,

        /// <summary>
        /// Quadratic formula with acceleration.
        /// </summary>
        InQuad,

        /// <summary>
        /// Quadratic formula with slowdown.
        /// </summary>
        OutQuad,

        /// <summary>
        /// Quadratic formula with acceleration and slowdown.
        /// </summary>
        InOutQuad,

        /// <summary>
        /// Cubic formula with acceleration.
        /// </summary>
        InCubic,

        /// <summary>
        /// Cubic formula with slowdown.
        /// </summary>
        OutCubic,

        /// <summary>
        /// Cubic formula with acceleration and slowdown.
        /// </summary>
        InOutCubic,

        /// <summary>
        /// Quartic formula with acceleration.
        /// </summary>
        InQuart,

        /// <summary>
        /// Quartic formula with slowdown.
        /// </summary>
        OutQuart,

        /// <summary>
        /// Quartic formula with acceleration and slowdown.
        /// </summary>
        InOutQuart,

        /// <summary>
        /// Quintic formula with acceleration.
        /// </summary>
        InQuint,

        /// <summary>
        /// Quintic formula with slowdown.
        /// </summary>
        OutQuint,

        /// <summary>
        /// Quintic formula with acceleration and slowdown.
        /// </summary>
        InOutQuint,

        /// <summary>
        /// Sinusoidal formula with acceleration.
        /// </summary>
        InSine,

        /// <summary>
        /// Sinusoidal formula with slowdown.
        /// </summary>
        OutSine,

        /// <summary>
        /// Sinusoidal formula with acceleration and slowdown.
        /// </summary>
        InOutSine,

        /// <summary>
        /// Exponential formula with acceleration.
        /// </summary>
        InExpo,

        /// <summary>
        /// Exponential formula with slowdown.
        /// </summary>
        OutExpo,

        /// <summary>
        /// Exponential formula with acceleration and slowdown.
        /// </summary>
        InOutExpo,

        /// <summary>
        /// Circular formula with acceleration.
        /// </summary>
        InCirc,

        /// <summary>
        /// Circular formula with slowdown.
        /// </summary>
        OutCirc,

        /// <summary>
        /// Circular formula with acceleration and slowdown.
        /// </summary>
        InOutCirc,

        /// <summary>
        /// Other formula.
        /// </summary>
        Other
    }
}