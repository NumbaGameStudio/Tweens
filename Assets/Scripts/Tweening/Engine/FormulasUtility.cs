using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening.Engine
{
    internal static class FormulasUtility
    {
        private static Formula[] _formulas = new Formula[22];

        #region Formulas
        internal static LinearFormula Linear { get; private set; }

        internal static QuadraticInFormula InQuad { get; private set; }

        internal static QuadraticOutFormula OutQuad { get; private set; }

        internal static QuadraticInOutFormula InOutQuad { get; private set; }

        internal static CubicInFormula InCubic { get; private set; }

        internal static CubicOutFormula OutCubic { get; private set; }

        internal static CubicInOutFormula InOutCubic { get; private set; }

        internal static QuarticInFormula InQuart { get; private set; }

        internal static QuarticOutFormula OutQuart { get; private set; }

        internal static QuarticInOutFormula InOutQuart { get; private set; }

        internal static QuinticInFormula InQuint { get; private set; }

        internal static QuinticOutFormula OutQuint { get; private set; }

        internal static QuinticInOutFormula InOutQuint { get; private set; }

        internal static SinusoidalInFormula InSine { get; private set; }

        internal static SinusoidalOutFormula OutSine { get; private set; }

        internal static SinusoidalInOutFormula InOutSine { get; private set; }

        internal static ExponentialInFormula InExpo { get; private set; }

        internal static ExponentialOutFormula OutExpo { get; private set; }

        internal static ExponentialInOutFormula InOutExpo { get; private set; }

        internal static CircularInFormula InCirc { get; private set; }

        internal static CircularOutFormula OutCirc { get; private set; }

        internal static CircularInOutFormula InOutCirc { get; private set; }
        #endregion

        static FormulasUtility()
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
        }

        public static Formula GetFormula(Ease ease)
        {
            if (ease == Ease.Other)
                throw new ArgumentException("Can not find 'Other' formula", "ease");

            return _formulas[(int)ease];
        }
    }
}