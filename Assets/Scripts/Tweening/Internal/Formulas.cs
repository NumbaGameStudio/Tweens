using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Contain cached built-in formulas 
    /// and methods for work with them.
    /// </summary>
    internal static class Formulas
    {
        private static Formula[] _formulas = new Formula[31];

        #region Formulas
        /// <summary>
        /// Linear formula.
        /// </summary>
        internal static LinearFormula Linear { get; private set; }

        /// <summary>
        /// Quadratic formula with acceleration.
        /// </summary>
        internal static QuadraticInFormula InQuad { get; private set; }

        /// <summary>
        /// Quadratic formula with slowdown.
        /// </summary>
        internal static QuadraticOutFormula OutQuad { get; private set; }

        /// <summary>
        /// Quadratic formula with acceleration and slowdown.
        /// </summary>
        internal static QuadraticInOutFormula InOutQuad { get; private set; }

        /// <summary>
        /// Cubic formula with acceleration.
        /// </summary>
        internal static CubicInFormula InCubic { get; private set; }

        /// <summary>
        /// Cubic formula with slowdown.
        /// </summary>
        internal static CubicOutFormula OutCubic { get; private set; }

        /// <summary>
        /// Cubic formula with acceleration and slowdown.
        /// </summary>
        internal static CubicInOutFormula InOutCubic { get; private set; }

        /// <summary>
        /// Quartic formula with acceleration.
        /// </summary>
        internal static QuarticInFormula InQuart { get; private set; }

        /// <summary>
        /// Quartic formula with slowdown.
        /// </summary>
        internal static QuarticOutFormula OutQuart { get; private set; }

        /// <summary>
        /// Quartic formula with acceleration and slowdown.
        /// </summary>
        internal static QuarticInOutFormula InOutQuart { get; private set; }

        /// <summary>
        /// Quintic formula with acceleration.
        /// </summary>
        internal static QuinticInFormula InQuint { get; private set; }

        /// <summary>
        /// Quintic formula with slowdown.
        /// </summary>
        internal static QuinticOutFormula OutQuint { get; private set; }

        /// <summary>
        /// Quintic formula with acceleration and slowdown.
        /// </summary>
        internal static QuinticInOutFormula InOutQuint { get; private set; }

        /// <summary>
        /// Sinusoidal formula with acceleration.
        /// </summary>
        internal static SinusoidalInFormula InSine { get; private set; }

        /// <summary>
        /// Sinusoidal formula with slowdown.
        /// </summary>
        internal static SinusoidalOutFormula OutSine { get; private set; }

        /// <summary>
        /// Sinusoidal formula with acceleration and slowdown.
        /// </summary>
        internal static SinusoidalInOutFormula InOutSine { get; private set; }

        /// <summary>
        /// Exponential formula with acceleration.
        /// </summary>
        internal static ExponentialInFormula InExpo { get; private set; }

        /// <summary>
        /// Exponential formula with slowdown.
        /// </summary>
        internal static ExponentialOutFormula OutExpo { get; private set; }

        /// <summary>
        /// Exponential formula with acceleration and slowdown.
        /// </summary>
        internal static ExponentialInOutFormula InOutExpo { get; private set; }

        /// <summary>
        /// Circular formula with acceleration.
        /// </summary>
        internal static CircularInFormula InCirc { get; private set; }

        /// <summary>
        /// Circular formula with slowdown.
        /// </summary>
        internal static CircularOutFormula OutCirc { get; private set; }

        /// <summary>
        /// Circular formula with acceleration and slowdown.
        /// </summary>
        internal static CircularInOutFormula InOutCirc { get; private set; }

        /// <summary>
        /// Elastic formula slowdown.
        /// </summary>
        internal static ElasticEaseIn InElastic { get; private set; }

        /// <summary>
        /// Elastic formula with acceleration and slowdown.
        /// </summary>
        internal static ElasticEaseInOut InOutElastic { get; private set; }

        /// <summary>
        /// Elastic formula with acceleration.
        /// </summary>
        internal static ElasticEaseOut OutElastic { get; private set; }

        /// <summary>
        /// Back formula slowdown.
        /// </summary>
        internal static BackEaseIn InBack { get; private set; }

        /// <summary>
        /// Back formula with acceleration and slowdown.
        /// </summary>
        internal static BackEaseInOut InOutBack { get; private set; }

        /// <summary>
        /// Back formula with acceleration.
        /// </summary>
        internal static BackEaseOut OutBack { get; private set; }

        /// <summary>
        /// Bounce formula slowdown.
        /// </summary>
        internal static BounceEaseIn InBounce { get; private set; }

        /// <summary>
        /// Bounce formula with acceleration and slowdown.
        /// </summary>
        internal static BounceEaseInOut InOutBounce { get; private set; }

        /// <summary>
        /// Bounce formula with acceleration.
        /// </summary>
        internal static BounceEaseOut OutBounce { get; private set; }
        #endregion

        static Formulas()
        {
            _formulas[0] = Linear = new LinearFormula();
            _formulas[1] = InQuad = new QuadraticInFormula();
            _formulas[2] = OutQuad = new QuadraticOutFormula();
            _formulas[3] = InOutQuad = new QuadraticInOutFormula();
            _formulas[4] = InCubic = new CubicInFormula();
            _formulas[5] = OutCubic = new CubicOutFormula();
            _formulas[6] = InOutCubic = new CubicInOutFormula();
            _formulas[7] = InQuart = new QuarticInFormula();
            _formulas[8] = OutQuart = new QuarticOutFormula();
            _formulas[9] = InOutQuart = new QuarticInOutFormula();
            _formulas[10] = InQuint = new QuinticInFormula();
            _formulas[11] = OutQuint = new QuinticOutFormula();
            _formulas[12] = InOutQuint = new QuinticInOutFormula();
            _formulas[13] = InSine = new SinusoidalInFormula();
            _formulas[14] = OutSine = new SinusoidalOutFormula();
            _formulas[15] = InOutSine = new SinusoidalInOutFormula();
            _formulas[16] = InExpo = new ExponentialInFormula();
            _formulas[17] = OutExpo = new ExponentialOutFormula();
            _formulas[18] = InOutExpo = new ExponentialInOutFormula();
            _formulas[19] = InCirc = new CircularInFormula();
            _formulas[20] = OutCirc = new CircularOutFormula();
            _formulas[21] = InOutCirc = new CircularInOutFormula();
            _formulas[22] = InElastic = new ElasticEaseIn();
            _formulas[23] = InOutElastic = new ElasticEaseInOut();
            _formulas[24] = OutElastic = new ElasticEaseOut();
            _formulas[25] = InBack = new BackEaseIn();
            _formulas[26] = InOutBack = new BackEaseInOut();
            _formulas[27] = OutBack = new BackEaseOut();
            _formulas[28] = InBounce = new BounceEaseIn();
            _formulas[29] = InOutBounce = new BounceEaseInOut();
            _formulas[30] = OutBounce = new BounceEaseOut();
        }

        /// <summary>
        /// Get build-in formula by ease type.
        /// </summary>
        /// <param name="ease">Associated with built-in formula ease type.</param>
        /// <returns>Associated with ease type built-in formula.</returns>
        /// <exception cref="ArgumentException">Thrown when ease type is Ease.Other</exception>
        public static Formula GetFormula(Ease ease)
        {
            if (ease == Ease.Other)
                throw new ArgumentException("Can not find 'Other' formula", "ease");

            return _formulas[(int)ease];
        }
    }
}