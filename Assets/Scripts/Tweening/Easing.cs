using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Engine;

namespace Numba.Tweening
{
    public static class Easing
    {
        private static void CheckFormula(Formula formula)
        {
            if (formula == null) throw new ArgumentNullException("value", "Formula can not be a null");
        }

        #region Ease
        #region Int
        public static int Ease(int from, int to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static int Ease(int from, int to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Long
        public static long Ease(long from, long to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static long Ease(long from, long to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Float
        public static float Ease(float from, float to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static float Ease(float from, float to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Double
        public static double Ease(double from, double to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static double Ease(double from, double to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region DateTime
        public static DateTime Ease(DateTime from, DateTime to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static DateTime Ease(DateTime from, DateTime to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Vector2
        public static Vector2 Ease(Vector2 from, Vector2 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Vector2 Ease(Vector2 from, Vector2 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Vector3
        public static Vector3 Ease(Vector3 from, Vector3 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Vector3 Ease(Vector3 from, Vector3 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Vector4
        public static Vector4 Ease(Vector4 from, Vector4 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Vector4 Ease(Vector4 from, Vector4 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Quaternion
        public static Quaternion Ease(Quaternion from, Quaternion to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Quaternion Ease(Quaternion from, Quaternion to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Rect
        public static Rect Ease(Rect from, Rect to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Rect Ease(Rect from, Rect to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Color
        public static Color Ease(Color from, Color to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Color Ease(Color from, Color to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion

        #region Color32
        public static Color32 Ease(Color32 from, Color32 to, float interpolation, Formula formula)
        {
            CheckFormula(formula);
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Color32 Ease(Color32 from, Color32 to, float interpolation, Ease ease)
        {
            return Ease(from, to, interpolation, Formulas.GetFormula(ease));
        }
        #endregion
        #endregion

        #region Linear
        public static int Linear(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t + from);
        }

        public static long Linear(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t + from);
        }

        public static float Linear(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        public static double Linear(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        public static DateTime Linear(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(Linear(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 Linear(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(Linear(from.x, to.x, interpolation), Linear(from.y, to.y, interpolation));
        }

        public static Vector3 Linear(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(Linear(from.x, to.x, interpolation), Linear(from.y, to.y, interpolation), Linear(from.z, to.z, interpolation));
        }

        public static Vector4 Linear(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(Linear(from.x, to.x, interpolation), Linear(from.y, to.y, interpolation), Linear(from.z, to.z, interpolation), Linear(from.w, to.w, interpolation));
        }

        public static Quaternion Linear(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, interpolation);
        }

        public static Rect Linear(Rect from, Rect to, float interpolation)
        {
            return new Rect(Linear(from.position, to.position, interpolation), Linear(from.size, to.size, interpolation));
        }

        public static Color Linear(Color from, Color to, float interpolation)
        {
            return Linear((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 Linear(Color32 from, Color32 to, float interpolation)
        {
            return Linear((Color)from, (Color)to, interpolation);
        }
        #endregion
    }
}