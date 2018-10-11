using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Text;

namespace Numba.Tweens
{
    /// <summary>
    /// Contain ease methods for a lot of system or unity classes.
    /// </summary>
    public static class Easing
    {
        private static void CheckFormula(Formula formula)
        {
            if (formula == null) throw new ArgumentNullException("value", "Formula can not be a null");
        }

        #region Ease
        #region Int
        /// <summary>
        /// Easing between two Int values with custom formula.
        /// </summary>
        /// <param name="from">From Int value.</param>
        /// <param name="to">To Int value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Int value</returns>
        public static int Ease(int from, int to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Int values with custom formula.
        /// </summary>
        /// <param name="from">From Int value.</param>
        /// <param name="to">To Int value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Int value</returns>
        public static int Ease(int from, int to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Long
        /// <summary>
        /// Easing between two Long values with custom formula.
        /// </summary>
        /// <param name="from">From Long value.</param>
        /// <param name="to">To Long value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Long value</returns>
        public static long Ease(long from, long to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Long values with custom formula.
        /// </summary>
        /// <param name="from">From Long value.</param>
        /// <param name="to">To Long value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Long value</returns>
        public static long Ease(long from, long to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Float
        /// <summary>
        /// Easing between two Float values with custom formula.
        /// </summary>
        /// <param name="from">From Float value.</param>
        /// <param name="to">To Float value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Float value</returns>
        public static float Ease(float from, float to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Float values with custom formula.
        /// </summary>
        /// <param name="from">From Float value.</param>
        /// <param name="to">To Float value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Float value</returns>
        public static float Ease(float from, float to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Double
        /// <summary>
        /// Easing between two Double values with custom formula.
        /// </summary>
        /// <param name="from">From Double value.</param>
        /// <param name="to">To Double value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Double value</returns>
        public static double Ease(double from, double to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Double values with custom formula.
        /// </summary>
        /// <param name="from">From Double value.</param>
        /// <param name="to">To Double value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Double value</returns>
        public static double Ease(double from, double to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Char
        /// <summary>
        /// Easing between two Char values with custom formula.
        /// </summary>
        /// <param name="from">From Char value.</param>
        /// <param name="to">To Char value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Char value</returns>
        public static char Ease(char from, char to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return (char)Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Char values with custom formula.
        /// </summary>
        /// <param name="from">From Char value.</param>
        /// <param name="to">To Char value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Char value</returns>
        public static char Ease(char from, char to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region String
        /// <summary>
        /// Easing between two String values with custom formula.
        /// </summary>
        /// <param name="from">From String value.</param>
        /// <param name="to">To String value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased String value</returns>
        public static string Ease(string from, string to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two String values with custom formula.
        /// </summary>
        /// <param name="from">From String value.</param>
        /// <param name="to">To String value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased String value</returns>
        public static string Ease(string from, string to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region DateTime
        /// <summary>
        /// Easing between two DateTime values with custom formula.
        /// </summary>
        /// <param name="from">From DateTime value.</param>
        /// <param name="to">To DateTime value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased DateTime value</returns>
        public static DateTime Ease(DateTime from, DateTime to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two DateTime values with custom formula.
        /// </summary>
        /// <param name="from">From DateTime value.</param>
        /// <param name="to">To DateTime value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased DateTime value</returns>
        public static DateTime Ease(DateTime from, DateTime to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Vector2
        /// <summary>
        /// Easing between two Vector2 values with custom formula.
        /// </summary>
        /// <param name="from">From Vector2 value.</param>
        /// <param name="to">To Vector2 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Vector2 value</returns>
        public static Vector2 Ease(Vector2 from, Vector2 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Vector2 values with custom formula.
        /// </summary>
        /// <param name="from">From Vector2 value.</param>
        /// <param name="to">To Vector2 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Vector2 value</returns>
        public static Vector2 Ease(Vector2 from, Vector2 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Vector3
        /// <summary>
        /// Easing between two Vector3 values with custom formula.
        /// </summary>
        /// <param name="from">From Vector3 value.</param>
        /// <param name="to">To Vector3 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Vector3 value</returns>
        public static Vector3 Ease(Vector3 from, Vector3 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Vector3 values with custom formula.
        /// </summary>
        /// <param name="from">From Vector3 value.</param>
        /// <param name="to">To Vector3 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Vector3 value</returns>
        public static Vector3 Ease(Vector3 from, Vector3 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Vector4
        /// <summary>
        /// Easing between two Vector4 values with custom formula.
        /// </summary>
        /// <param name="from">From Vector4 value.</param>
        /// <param name="to">To Vector4 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Vector4 value</returns>
        public static Vector4 Ease(Vector4 from, Vector4 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Vector4 values with custom formula.
        /// </summary>
        /// <param name="from">From Vector4 value.</param>
        /// <param name="to">To Vector4 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Vector4 value</returns>
        public static Vector4 Ease(Vector4 from, Vector4 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Quaternion
        /// <summary>
        /// Easing between two Quaternion values with custom formula.
        /// </summary>
        /// <param name="from">From Quaternion value.</param>
        /// <param name="to">To Quaternion value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Quaternion value</returns>
        public static Quaternion Ease(Quaternion from, Quaternion to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Quaternion values with custom formula.
        /// </summary>
        /// <param name="from">From Quaternion value.</param>
        /// <param name="to">To Quaternion value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Quaternion value</returns>
        public static Quaternion Ease(Quaternion from, Quaternion to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Rect
        /// <summary>
        /// Easing between two Rect values with custom formula.
        /// </summary>
        /// <param name="from">From Rect value.</param>
        /// <param name="to">To Rect value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Rect value</returns>
        public static Rect Ease(Rect from, Rect to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Rect values with custom formula.
        /// </summary>
        /// <param name="from">From Rect value.</param>
        /// <param name="to">To Rect value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Rect value</returns>
        public static Rect Ease(Rect from, Rect to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Color
        /// <summary>
        /// Easing between two Color values with custom formula.
        /// </summary>
        /// <param name="from">From Color value.</param>
        /// <param name="to">To Color value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Color value</returns>
        public static Color Ease(Color from, Color to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Color values with custom formula.
        /// </summary>
        /// <param name="from">From Color value.</param>
        /// <param name="to">To Color value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Color value</returns>
        public static Color Ease(Color from, Color to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Color32
        /// <summary>
        /// Easing between two Color32 values with custom formula.
        /// </summary>
        /// <param name="from">From Color32 value.</param>
        /// <param name="to">To Color32 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Color32 value</returns>
        public static Color32 Ease(Color32 from, Color32 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Color32 values with custom formula.
        /// </summary>
        /// <param name="from">From Color32 value.</param>
        /// <param name="to">To Color32 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Color32 value</returns>
        public static Color32 Ease(Color32 from, Color32 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region ColorBlock
        /// <summary>
        /// Easing between two ColorBlock values with custom formula.
        /// </summary>
        /// <param name="from">From ColorBlock value.</param>
        /// <param name="to">To ColorBlock value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased ColorBlock value</returns>
        public static ColorBlock Ease(ColorBlock from, ColorBlock to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two ColorBlock values with custom formula.
        /// </summary>
        /// <param name="from">From ColorBlock value.</param>
        /// <param name="to">To ColorBlock value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased ColorBlock value</returns>
        public static ColorBlock Ease(ColorBlock from, ColorBlock to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Bounds
        /// <summary>
        /// Easing between two Bounds values with custom formula.
        /// </summary>
        /// <param name="from">From Bounds value.</param>
        /// <param name="to">To Bounds value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Bounds value</returns>
        public static Bounds Ease(Bounds from, Bounds to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Bounds values with custom formula.
        /// </summary>
        /// <param name="from">From Bounds value.</param>
        /// <param name="to">To Bounds value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Bounds value</returns>
        public static Bounds Ease(Bounds from, Bounds to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Matrix4x4
        /// <summary>
        /// Easing between two Matrix4x4 values with custom formula.
        /// </summary>
        /// <param name="from">From Matrix4x4 value.</param>
        /// <param name="to">To Matrix4x4 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased Matrix4x4 value</returns>
        public static Matrix4x4 Ease(Matrix4x4 from, Matrix4x4 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two Matrix4x4 values with custom formula.
        /// </summary>
        /// <param name="from">From Matrix4x4 value.</param>
        /// <param name="to">To Matrix4x4 value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased Matrix4x4 value</returns>
        public static Matrix4x4 Ease(Matrix4x4 from, Matrix4x4 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region WheelFrictionCurve
        /// <summary>
        /// Easing between two WheelFrictionCurve values with custom formula.
        /// </summary>
        /// <param name="from">From WheelFrictionCurve value.</param>
        /// <param name="to">To WheelFrictionCurve value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased WheelFrictionCurve value</returns>
        public static WheelFrictionCurve Ease(WheelFrictionCurve from, WheelFrictionCurve to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two WheelFrictionCurve values with custom formula.
        /// </summary>
        /// <param name="from">From WheelFrictionCurve value.</param>
        /// <param name="to">To WheelFrictionCurve value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased WheelFrictionCurve value</returns>
        public static WheelFrictionCurve Ease(WheelFrictionCurve from, WheelFrictionCurve to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region JointSpring
        /// <summary>
        /// Easing between two JointSpring values with custom formula.
        /// </summary>
        /// <param name="from">From JointSpring value.</param>
        /// <param name="to">To JointSpring value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Custom formula.</param>
        /// <returns>Eased JointSpring value</returns>
        public static JointSpring Ease(JointSpring from, JointSpring to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        /// <summary>
        /// Easing between two JointSpring values with custom formula.
        /// </summary>
        /// <param name="from">From JointSpring value.</param>
        /// <param name="to">To JointSpring value.</param>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>Eased JointSpring value</returns>
        public static JointSpring Ease(JointSpring from, JointSpring to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion
        #endregion

        #region Linear
        private static int Linear(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return  (int)((to - from) * t + from);
        }

        private static long Linear(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t + from);
        }

        private static float Linear(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        private static double Linear(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        private static string Linear(string from, string to, float interpolation)
        {
            if (interpolation == 0f) return from;
            if (interpolation == 1f) return to;

            StringBuilder result = new StringBuilder(from);
            if (result.Length < to.Length) result.Append(' ', to.Length - from.Length);

            int matchedLength = Linear(0, result.Length, interpolation);
            int toLength = Mathf.Min(matchedLength, to.Length);

            for (int i = 0; i < toLength; ++i) result[i] = to[i];
            for (int i = toLength; i < matchedLength; ++i) result[i] = ' ';

            return result.ToString();
        }

        private static DateTime Linear(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(Linear(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        private static Vector2 Linear(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(Linear(from.x, to.x, interpolation), Linear(from.y, to.y, interpolation));
        }

        private static Vector3 Linear(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(Linear(from.x, to.x, interpolation), Linear(from.y, to.y, interpolation), Linear(from.z, to.z, interpolation));
        }

        private static Vector4 Linear(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(Linear(from.x, to.x, interpolation), Linear(from.y, to.y, interpolation), Linear(from.z, to.z, interpolation), Linear(from.w, to.w, interpolation));
        }

        private static Quaternion Linear(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, interpolation);
        }

        private static Rect Linear(Rect from, Rect to, float interpolation)
        {
            return new Rect(Linear(from.position, to.position, interpolation), Linear(from.size, to.size, interpolation));
        }

        private static Color Linear(Color from, Color to, float interpolation)
        {
            return Linear((Vector4)from, (Vector4)to, interpolation);
        }

        private static Color32 Linear(Color32 from, Color32 to, float interpolation)
        {
            return Linear((Color)from, (Color)to, interpolation);
        }

        private static ColorBlock Linear(ColorBlock from, ColorBlock to, float interpolation)
        {
            return new ColorBlock()
            {
                colorMultiplier = Linear(from.colorMultiplier, to.colorMultiplier, interpolation),
                disabledColor = Linear(from.disabledColor, to.disabledColor, interpolation),
                fadeDuration = Linear(from.fadeDuration, to.fadeDuration, interpolation),
                highlightedColor = Linear(from.highlightedColor, to.highlightedColor, interpolation),
                normalColor = Linear(from.normalColor, to.normalColor, interpolation),
                pressedColor = Linear(from.pressedColor, to.pressedColor, interpolation)
            };
        }

        private static Bounds Linear(Bounds from, Bounds to, float interpolation)
        {
            return new Bounds(Linear(from.center, to.center, interpolation), Linear(from.size, to.size, interpolation));
        }

        private static Matrix4x4 Linear(Matrix4x4 from, Matrix4x4 to, float interpolation)
        {
            return new Matrix4x4(Linear(from.GetColumn(0), to.GetColumn(0), interpolation),
                Linear(from.GetColumn(1), to.GetColumn(1), interpolation),
                Linear(from.GetColumn(2), to.GetColumn(2), interpolation),
                Linear(from.GetColumn(3), to.GetColumn(3), interpolation));
        }

        private static WheelFrictionCurve Linear(WheelFrictionCurve from, WheelFrictionCurve to, float interpolation)
        {
            return new WheelFrictionCurve()
            {
                asymptoteSlip = Linear(from.asymptoteSlip, to.asymptoteSlip, interpolation),
                asymptoteValue = Linear(from.asymptoteValue, to.asymptoteValue, interpolation),
                extremumSlip = Linear(from.extremumSlip, to.extremumSlip, interpolation),
                extremumValue = Linear(from.extremumValue, to.extremumValue, interpolation),
                stiffness = Linear(from.stiffness, to.stiffness, interpolation),
            };
        }

        private static JointSpring Linear(JointSpring from, JointSpring to, float interpolation)
        {
            return new JointSpring()
            {
                damper = Linear(from.damper, to.damper, interpolation),
                spring = Linear(from.spring, to.spring, interpolation),
                targetPosition = Linear(from.targetPosition, to.targetPosition, interpolation)
            };
        }
        #endregion
    }
}