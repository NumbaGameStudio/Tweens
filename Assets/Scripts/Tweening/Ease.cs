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
        QuadIn,

        /// <summary>
        /// Quadratic formula with slowdown.
        /// </summary>
        QuadOut,

        /// <summary>
        /// Quadratic formula with acceleration and slowdown.
        /// </summary>
        QuadInOut,

        /// <summary>
        /// Cubic formula with acceleration.
        /// </summary>
        CubicIn,

        /// <summary>
        /// Cubic formula with slowdown.
        /// </summary>
        CubicOut,

        /// <summary>
        /// Cubic formula with acceleration and slowdown.
        /// </summary>
        CubicInOut,

        /// <summary>
        /// Quartic formula with acceleration.
        /// </summary>
        QuartsIn,

        /// <summary>
        /// Quartic formula with slowdown.
        /// </summary>
        QuartsOut,

        /// <summary>
        /// Quartic formula with acceleration and slowdown.
        /// </summary>
        QuartsInOut,

        /// <summary>
        /// Quintic formula with acceleration.
        /// </summary>
        QuintIn,

        /// <summary>
        /// Quintic formula with slowdown.
        /// </summary>
        QuintOut,

        /// <summary>
        /// Quintic formula with acceleration and slowdown.
        /// </summary>
        QuintInOut,

        /// <summary>
        /// Sinusoidal formula with acceleration.
        /// </summary>
        SineIn,

        /// <summary>
        /// Sinusoidal formula with slowdown.
        /// </summary>
        SineOut,

        /// <summary>
        /// Sinusoidal formula with acceleration and slowdown.
        /// </summary>
        SineInOut,

        /// <summary>
        /// Exponential formula with acceleration.
        /// </summary>
        ExpoIn,

        /// <summary>
        /// Exponential formula with slowdown.
        /// </summary>
        ExpoOut,

        /// <summary>
        /// Exponential formula with acceleration and slowdown.
        /// </summary>
        ExpoInOut,

        /// <summary>
        /// Circular formula with acceleration.
        /// </summary>
        CircIn,

        /// <summary>
        /// Circular formula with slowdown.
        /// </summary>
        CircOut,

        /// <summary>
        /// Circular formula with acceleration and slowdown.
        /// </summary>
        CircInOut,

        /// <summary>
        /// Elastic formula with acceleration.
        /// </summary>
        ElasticIn,

        /// <summary>
        /// Elastic formula with slowdown.
        /// </summary>
        ElasticOut,

        /// <summary>
        /// Elastic formula with acceleration and slowdown.
        /// </summary>
        ElasticInOut,

        /// <summary>
        /// Back formula with acceleration.
        /// </summary>
        BackIn,

        /// <summary>
        /// Back formula with slowdown.
        /// </summary>
        BackOut,

        /// <summary>
        /// Back formula with acceleration and slowdown.
        /// </summary>
        BackInOut,

        /// <summary>
        /// Bounce formula with acceleration.
        /// </summary>
        BounceIn,

        /// <summary>
        /// Bounce formula with slowdown.
        /// </summary>
        BounceOut,

        /// <summary>
        /// Bounce formula with acceleration and slowdown.
        /// </summary>
        BounceInOut,

        /// <summary>
        /// Other formula.
        /// </summary>
        Other
    }
}