using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening
{
    public static class Easing
    {
        #region Ease by formula
        public static int Ease(int from, int to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static long Ease(long from, long to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static float Ease(float from, float to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static double Ease(double from, double to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static DateTime Ease(DateTime from, DateTime to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Vector2 Ease(Vector2 from, Vector2 to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Vector3 Ease(Vector3 from, Vector3 to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Vector4 Ease(Vector4 from, Vector4 to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Quaternion Ease(Quaternion from, Quaternion to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Rect Ease(Rect from, Rect to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Color Ease(Color from, Color to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }

        public static Color32 Ease(Color32 from, Color32 to, float interpolation, Formula formula)
        {
            return Linear(from, to, formula.Calculate(interpolation));
        }
        #endregion

        #region Ease by formulas
        public static int Ease(int from, int to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return 0;
        }

        public static long Ease(long from, long to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return 0L;
        }

        public static float Ease(float from, float to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return 0f;
        }

        public static double Ease(double from, double to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return 0d;
        }

        public static DateTime Ease(DateTime from, DateTime to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return DateTime.MinValue;
        }

        public static Vector2 Ease(Vector2 from, Vector2 to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return Vector2.zero;
        }

        public static Vector3 Ease(Vector3 from, Vector3 to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return Vector3.zero;
        }

        public static Vector4 Ease(Vector4 from, Vector4 to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return Vector4.zero;
        }

        public static Quaternion Ease(Quaternion from, Quaternion to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return Quaternion.identity;
        }

        public static Rect Ease(Rect from, Rect to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return Rect.zero;
        }

        public static Color Ease(Color from, Color to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return Color.black;
        }

        public static Color32 Ease(Color32 from, Color32 to, float interpolation, Ease ease)
        {
            if (ease == Tweening.Ease.Linear) return Linear(from, to, interpolation);
            if (ease == Tweening.Ease.InQuad) return QuadraticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuad) return QuadraticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuad) return QuadraticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCubic) return CubicInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCubic) return CubicOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCubic) return CubicInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuart) return QuarticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuart) return QuarticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuart) return QuarticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InQuint) return QuinticInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutQuint) return QuinticOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutQuint) return QuinticInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InSine) return SinusoidalInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutSine) return SinusoidalOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutSine) return SinusoidalInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InExpo) return ExponentialInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutExpo) return ExponentialOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutExpo) return ExponentialInOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InCirc) return CircularInEase(from, to, interpolation);
            if (ease == Tweening.Ease.OutCirc) return CircularOutEase(from, to, interpolation);
            if (ease == Tweening.Ease.InOutCirc) return CircularInOutEase(from, to, interpolation);

            return new Color32(0, 0, 0, 0);
        }

        #region Formulas
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

        #region Quadratic
        #region In
        public static int QuadraticInEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t + from);
        }

        public static long QuadraticInEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t + from);
        }

        public static float QuadraticInEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t + from;
        }

        public static double QuadraticInEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t + from;
        }

        public static DateTime QuadraticInEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuadraticInEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuadraticInEase(from.x, to.x, interpolation), QuadraticInEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuadraticInEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuadraticInEase(from.x, to.x, interpolation), QuadraticInEase(from.y, to.y, interpolation), QuadraticInEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuadraticInEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuadraticInEase(from.x, to.x, interpolation), QuadraticInEase(from.y, to.y, interpolation), QuadraticInEase(from.z, to.z, interpolation), QuadraticInEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuadraticInEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuadraticInEase(0f, 1f, interpolation));
        }

        public static Rect QuadraticInEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuadraticInEase(from.position, to.position, interpolation), QuadraticInEase(from.size, to.size, interpolation));
        }

        public static Color QuadraticInEase(Color from, Color to, float interpolation)
        {
            return QuadraticInEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuadraticInEase(Color32 from, Color32 to, float interpolation)
        {
            return QuadraticInEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region Out
        public static int QuadraticOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) * t * (t - 2) + from);
        }

        public static long QuadraticOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) * t * (t - 2) + from);
        }

        public static float QuadraticOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * t * (t - 2) + from;
        }

        public static double QuadraticOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * t * (t - 2) + from;
        }

        public static DateTime QuadraticOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuadraticOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuadraticOutEase(from.x, to.x, interpolation), QuadraticOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuadraticOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuadraticOutEase(from.x, to.x, interpolation), QuadraticOutEase(from.y, to.y, interpolation), QuadraticOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuadraticOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuadraticOutEase(from.x, to.x, interpolation), QuadraticOutEase(from.y, to.y, interpolation), QuadraticOutEase(from.z, to.z, interpolation), QuadraticOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuadraticOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuadraticOutEase(0f, 1f, interpolation));
        }

        public static Rect QuadraticOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuadraticOutEase(from.position, to.position, interpolation), QuadraticOutEase(from.size, to.size, interpolation));
        }

        public static Color QuadraticOutEase(Color from, Color to, float interpolation)
        {
            return QuadraticOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuadraticOutEase(Color32 from, Color32 to, float interpolation)
        {
            return QuadraticOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region InOut
        public static int QuadraticInOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t + from);
            --t;
            return (int)(-(to - from) / 2 * (t * (t - 2) - 1) + from);
        }

        public static long QuadraticInOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t + from);
            --t;
            return (long)(-(to - from) / 2 * (t * (t - 2) - 1) + from);
        }

        public static float QuadraticInOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t + from;
            --t;
            return -(to - from) / 2 * (t * (t - 2) - 1) + from;
        }

        public static double QuadraticInOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t + from;
            --t;
            return -(to - from) / 2 * (t * (t - 2) - 1) + from;
        }

        public static DateTime QuadraticInOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuadraticInOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuadraticInOutEase(from.x, to.x, interpolation), QuadraticInOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuadraticInOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuadraticInOutEase(from.x, to.x, interpolation), QuadraticInOutEase(from.y, to.y, interpolation), QuadraticInOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuadraticInOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuadraticInOutEase(from.x, to.x, interpolation), QuadraticInOutEase(from.y, to.y, interpolation), QuadraticInOutEase(from.z, to.z, interpolation), QuadraticInOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuadraticInOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuadraticInOutEase(0f, 1f, interpolation));
        }

        public static Rect QuadraticInOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuadraticInOutEase(from.position, to.position, interpolation), QuadraticInOutEase(from.size, to.size, interpolation));
        }

        public static Color QuadraticInOutEase(Color from, Color to, float interpolation)
        {
            return QuadraticInOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuadraticInOutEase(Color32 from, Color32 to, float interpolation)
        {
            return QuadraticInOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion
        #endregion

        #region Cubic
        #region In
        public static int CubicInEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t + from);
        }

        public static long CubicInEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t + from);
        }

        public static float CubicInEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t + from;
        }

        public static double CubicInEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t + from;
        }

        public static DateTime CubicInEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 CubicInEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(CubicInEase(from.x, to.x, interpolation), CubicInEase(from.y, to.y, interpolation));
        }

        public static Vector3 CubicInEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(CubicInEase(from.x, to.x, interpolation), CubicInEase(from.y, to.y, interpolation), CubicInEase(from.z, to.z, interpolation));
        }

        public static Vector4 CubicInEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(CubicInEase(from.x, to.x, interpolation), CubicInEase(from.y, to.y, interpolation), CubicInEase(from.z, to.z, interpolation), CubicInEase(from.w, to.w, interpolation));
        }

        public static Quaternion CubicInEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, CubicInEase(0f, 1f, interpolation));
        }

        public static Rect CubicInEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(CubicInEase(from.position, to.position, interpolation), CubicInEase(from.size, to.size, interpolation));
        }

        public static Color CubicInEase(Color from, Color to, float interpolation)
        {
            return CubicInEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 CubicInEase(Color32 from, Color32 to, float interpolation)
        {
            return CubicInEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region Out
        public static int CubicOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * (t * t * t + 1) + from);
        }

        public static long CubicOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * (t * t * t + 1) + from);
        }

        public static float CubicOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static double CubicOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static DateTime CubicOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 CubicOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(CubicOutEase(from.x, to.x, interpolation), CubicOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 CubicOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(CubicOutEase(from.x, to.x, interpolation), CubicOutEase(from.y, to.y, interpolation), CubicOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 CubicOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(CubicOutEase(from.x, to.x, interpolation), CubicOutEase(from.y, to.y, interpolation), CubicOutEase(from.z, to.z, interpolation), CubicOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion CubicOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, CubicOutEase(0f, 1f, interpolation));
        }

        public static Rect CubicOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(CubicOutEase(from.position, to.position, interpolation), CubicOutEase(from.size, to.size, interpolation));
        }

        public static Color CubicOutEase(Color from, Color to, float interpolation)
        {
            return CubicOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 CubicOutEase(Color32 from, Color32 to, float interpolation)
        {
            return CubicOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region InOut
        public static int CubicInOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t + from);
            t -= 2;
            return (int)((to - from) / 2 * (t * t * t + 2) + from);
        }

        public static long CubicInOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t + from);
            t -= 2;
            return (long)((to - from) / 2 * (t * t * t + 2) + from);
        }

        public static float CubicInOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t + 2) + from;
        }

        public static double CubicInOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t + 2) + from;
        }

        public static DateTime CubicInOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 CubicInOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(CubicInOutEase(from.x, to.x, interpolation), CubicInOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 CubicInOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(CubicInOutEase(from.x, to.x, interpolation), CubicInOutEase(from.y, to.y, interpolation), CubicInOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 CubicInOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(CubicInOutEase(from.x, to.x, interpolation), CubicInOutEase(from.y, to.y, interpolation), CubicInOutEase(from.z, to.z, interpolation), CubicInOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion CubicInOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, CubicInOutEase(0f, 1f, interpolation));
        }

        public static Rect CubicInOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(CubicInOutEase(from.position, to.position, interpolation), CubicInOutEase(from.size, to.size, interpolation));
        }

        public static Color CubicInOutEase(Color from, Color to, float interpolation)
        {
            return CubicInOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 CubicInOutEase(Color32 from, Color32 to, float interpolation)
        {
            return CubicInOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion
        #endregion

        #region Quartic
        #region In
        public static int QuarticInEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t * t + from);
        }

        public static long QuarticInEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t * t + from);
        }

        public static float QuarticInEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t + from;
        }

        public static double QuarticInEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t + from;
        }

        public static DateTime QuarticInEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuarticInEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuarticInEase(from.x, to.x, interpolation), QuarticInEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuarticInEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuarticInEase(from.x, to.x, interpolation), QuarticInEase(from.y, to.y, interpolation), QuarticInEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuarticInEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuarticInEase(from.x, to.x, interpolation), QuarticInEase(from.y, to.y, interpolation), QuarticInEase(from.z, to.z, interpolation), QuarticInEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuarticInEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuarticInEase(0f, 1f, interpolation));
        }

        public static Rect QuarticInEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuarticInEase(from.position, to.position, interpolation), QuarticInEase(from.size, to.size, interpolation));
        }

        public static Color QuarticInEase(Color from, Color to, float interpolation)
        {
            return QuarticInEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuarticInEase(Color32 from, Color32 to, float interpolation)
        {
            return QuarticInEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region Out
        public static int QuarticOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)(-(to - from) * (t * t * t * t - 1) + from);
        }

        public static long QuarticOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)(-(to - from) * (t * t * t * t - 1) + from);
        }

        public static float QuarticOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static double QuarticOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static DateTime QuarticOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuarticOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuarticOutEase(from.x, to.x, interpolation), QuarticOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuarticOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuarticOutEase(from.x, to.x, interpolation), QuarticOutEase(from.y, to.y, interpolation), QuarticOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuarticOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuarticOutEase(from.x, to.x, interpolation), QuarticOutEase(from.y, to.y, interpolation), QuarticOutEase(from.z, to.z, interpolation), QuarticOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuarticOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuarticOutEase(0f, 1f, interpolation));
        }

        public static Rect QuarticOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuarticOutEase(from.position, to.position, interpolation), QuarticOutEase(from.size, to.size, interpolation));
        }

        public static Color QuarticOutEase(Color from, Color to, float interpolation)
        {
            return QuarticOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuarticOutEase(Color32 from, Color32 to, float interpolation)
        {
            return QuarticOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region InOut

        public static int QuarticInOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t * t + from);
            t -= 2;
            return (int)(-(to - from) / 2 * (t * t * t * t - 2) + from);
        }

        public static long QuarticInOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t * t + from);
            t -= 2;
            return (long)(-(to - from) / 2 * (t * t * t * t - 2) + from);
        }

        public static float QuarticInOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t + from;
            t -= 2;
            return -(to - from) / 2 * (t * t * t * t - 2) + from;
        }

        public static double QuarticInOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t + from;
            t -= 2;
            return -(to - from) / 2 * (t * t * t * t - 2) + from;
        }

        public static DateTime QuarticInOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuarticInOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuarticInOutEase(from.x, to.x, interpolation), QuarticInOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuarticInOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuarticInOutEase(from.x, to.x, interpolation), QuarticInOutEase(from.y, to.y, interpolation), QuarticInOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuarticInOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuarticInOutEase(from.x, to.x, interpolation), QuarticInOutEase(from.y, to.y, interpolation), QuarticInOutEase(from.z, to.z, interpolation), QuarticInOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuarticInOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuarticInOutEase(0f, 1f, interpolation));
        }

        public static Rect QuarticInOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuarticInOutEase(from.position, to.position, interpolation), QuarticInOutEase(from.size, to.size, interpolation));
        }

        public static Color QuarticInOutEase(Color from, Color to, float interpolation)
        {
            return QuarticInOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuarticInOutEase(Color32 from, Color32 to, float interpolation)
        {
            return QuarticInOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion
        #endregion

        #region Quintic
        #region In
        public static int QuinticInEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t * t * t + from);
        }

        public static long QuinticInEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t * t * t + from);
        }

        public static float QuinticInEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t * t + from;
        }

        public static double QuinticInEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t * t + from;
        }

        public static DateTime QuinticInEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuinticInEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuinticInEase(from.x, to.x, interpolation), QuinticInEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuinticInEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuinticInEase(from.x, to.x, interpolation), QuinticInEase(from.y, to.y, interpolation), QuinticInEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuinticInEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuinticInEase(from.x, to.x, interpolation), QuinticInEase(from.y, to.y, interpolation), QuinticInEase(from.z, to.z, interpolation), QuinticInEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuinticInEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuinticInEase(0f, 1f, interpolation));
        }

        public static Rect QuinticInEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuinticInEase(from.position, to.position, interpolation), QuinticInEase(from.size, to.size, interpolation));
        }

        public static Color QuinticInEase(Color from, Color to, float interpolation)
        {
            return QuinticInEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuinticInEase(Color32 from, Color32 to, float interpolation)
        {
            return QuinticInEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region Out
        public static int QuinticOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * (t * t * t * t * t + 1) + from);
        }

        public static long QuinticOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * (t * t * t * t * t + 1) + from);
        }

        public static float QuinticOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static double QuinticOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static DateTime QuinticOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuinticOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuinticOutEase(from.x, to.x, interpolation), QuinticOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuinticOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuinticOutEase(from.x, to.x, interpolation), QuinticOutEase(from.y, to.y, interpolation), QuinticOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuinticOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuinticOutEase(from.x, to.x, interpolation), QuinticOutEase(from.y, to.y, interpolation), QuinticOutEase(from.z, to.z, interpolation), QuinticOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuinticOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuinticOutEase(0f, 1f, interpolation));
        }

        public static Rect QuinticOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuinticOutEase(from.position, to.position, interpolation), QuinticOutEase(from.size, to.size, interpolation));
        }

        public static Color QuinticOutEase(Color from, Color to, float interpolation)
        {
            return QuinticOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuinticOutEase(Color32 from, Color32 to, float interpolation)
        {
            return QuinticOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region InOut
        public static int QuinticInOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t * t * t + from);
            t -= 2;
            return (int)((to - from) / 2 * (t * t * t * t * t + 2) + from);
        }

        public static long QuinticInOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t * t * t + from);
            t -= 2;
            return (long)((to - from) / 2 * (t * t * t * t * t + 2) + from);
        }

        public static float QuinticInOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t * t * t + 2) + from;
        }

        public static double QuinticInOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t * t * t + 2) + from;
        }

        public static DateTime QuinticInOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 QuinticInOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(QuinticInOutEase(from.x, to.x, interpolation), QuinticInOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 QuinticInOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(QuinticInOutEase(from.x, to.x, interpolation), QuinticInOutEase(from.y, to.y, interpolation), QuinticInOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 QuinticInOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(QuinticInOutEase(from.x, to.x, interpolation), QuinticInOutEase(from.y, to.y, interpolation), QuinticInOutEase(from.z, to.z, interpolation), QuinticInOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion QuinticInOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, QuinticInOutEase(0f, 1f, interpolation));
        }

        public static Rect QuinticInOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(QuinticInOutEase(from.position, to.position, interpolation), QuinticInOutEase(from.size, to.size, interpolation));
        }

        public static Color QuinticInOutEase(Color from, Color to, float interpolation)
        {
            return QuinticInOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 QuinticInOutEase(Color32 from, Color32 to, float interpolation)
        {
            return QuinticInOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion
        #endregion

        #region Sinusoidal
        #region In
        public static int SinusoidalInEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return (int)(-c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from);
        }

        public static long SinusoidalInEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return (long)(-c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from);
        }

        public static float SinusoidalInEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return -c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from;
        }

        public static double SinusoidalInEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            double c = to - from;

            return -c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from;
        }

        public static DateTime SinusoidalInEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 SinusoidalInEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(SinusoidalInEase(from.x, to.x, interpolation), SinusoidalInEase(from.y, to.y, interpolation));
        }

        public static Vector3 SinusoidalInEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(SinusoidalInEase(from.x, to.x, interpolation), SinusoidalInEase(from.y, to.y, interpolation), SinusoidalInEase(from.z, to.z, interpolation));
        }

        public static Vector4 SinusoidalInEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(SinusoidalInEase(from.x, to.x, interpolation), SinusoidalInEase(from.y, to.y, interpolation), SinusoidalInEase(from.z, to.z, interpolation), SinusoidalInEase(from.w, to.w, interpolation));
        }

        public static Quaternion SinusoidalInEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, SinusoidalInEase(0f, 1f, interpolation));
        }

        public static Rect SinusoidalInEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(SinusoidalInEase(from.position, to.position, interpolation), SinusoidalInEase(from.size, to.size, interpolation));
        }

        public static Color SinusoidalInEase(Color from, Color to, float interpolation)
        {
            return SinusoidalInEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 SinusoidalInEase(Color32 from, Color32 to, float interpolation)
        {
            return SinusoidalInEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region Out
        public static int SinusoidalOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from);
        }

        public static long SinusoidalOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from);
        }

        public static float SinusoidalOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from;
        }

        public static double SinusoidalOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from;
        }

        public static DateTime SinusoidalOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 SinusoidalOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(SinusoidalOutEase(from.x, to.x, interpolation), SinusoidalOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 SinusoidalOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(SinusoidalOutEase(from.x, to.x, interpolation), SinusoidalOutEase(from.y, to.y, interpolation), SinusoidalOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 SinusoidalOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(SinusoidalOutEase(from.x, to.x, interpolation), SinusoidalOutEase(from.y, to.y, interpolation), SinusoidalOutEase(from.z, to.z, interpolation), SinusoidalOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion SinusoidalOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, SinusoidalOutEase(0f, 1f, interpolation));
        }

        public static Rect SinusoidalOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(SinusoidalOutEase(from.position, to.position, interpolation), SinusoidalOutEase(from.size, to.size, interpolation));
        }

        public static Color SinusoidalOutEase(Color from, Color to, float interpolation)
        {
            return SinusoidalOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 SinusoidalOutEase(Color32 from, Color32 to, float interpolation)
        {
            return SinusoidalOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region InOut
        public static int SinusoidalInOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from);
        }

        public static long SinusoidalInOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from);
        }

        public static float SinusoidalInOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from;
        }

        public static double SinusoidalInOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from;
        }

        public static DateTime SinusoidalInOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 SinusoidalInOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(SinusoidalInOutEase(from.x, to.x, interpolation), SinusoidalInOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 SinusoidalInOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(SinusoidalInOutEase(from.x, to.x, interpolation), SinusoidalInOutEase(from.y, to.y, interpolation), SinusoidalInOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 SinusoidalInOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(SinusoidalInOutEase(from.x, to.x, interpolation), SinusoidalInOutEase(from.y, to.y, interpolation), SinusoidalInOutEase(from.z, to.z, interpolation), SinusoidalInOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion SinusoidalInOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, SinusoidalInOutEase(0f, 1f, interpolation));
        }

        public static Rect SinusoidalInOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(SinusoidalInOutEase(from.position, to.position, interpolation), SinusoidalOutEase(from.size, to.size, interpolation));
        }

        public static Color SinusoidalInOutEase(Color from, Color to, float interpolation)
        {
            return SinusoidalInOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 SinusoidalInOutEase(Color32 from, Color32 to, float interpolation)
        {
            return SinusoidalInOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion
        #endregion

        #region Exponential
        #region In
        public static int ExponentialInEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * Mathf.Pow(2, 10 * (t - 1)) + from);
        }

        public static long ExponentialInEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * Mathf.Pow(2, 10 * (t - 1)) + from);
        }

        public static float ExponentialInEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Pow(2, 10 * (t - 1)) + from;
        }

        public static double ExponentialInEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Pow(2, 10 * (t - 1)) + from;
        }

        public static DateTime ExponentialInEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 ExponentialInEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(ExponentialInEase(from.x, to.x, interpolation), ExponentialInEase(from.y, to.y, interpolation));
        }

        public static Vector3 ExponentialInEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(ExponentialInEase(from.x, to.x, interpolation), ExponentialInEase(from.y, to.y, interpolation), ExponentialInEase(from.z, to.z, interpolation));
        }

        public static Vector4 ExponentialInEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(ExponentialInEase(from.x, to.x, interpolation), ExponentialInEase(from.y, to.y, interpolation), ExponentialInEase(from.z, to.z, interpolation), ExponentialInEase(from.w, to.w, interpolation));
        }

        public static Quaternion ExponentialInEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, ExponentialInEase(0f, 1f, interpolation));
        }

        public static Rect ExponentialInEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(ExponentialInEase(from.position, to.position, interpolation), ExponentialInEase(from.size, to.size, interpolation));
        }

        public static Color ExponentialInEase(Color from, Color to, float interpolation)
        {
            return ExponentialInEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 ExponentialInEase(Color32 from, Color32 to, float interpolation)
        {
            return ExponentialInEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region Out
        public static int ExponentialOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from);
        }

        public static long ExponentialOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from);
        }

        public static float ExponentialOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from;
        }

        public static double ExponentialOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from;
        }

        public static DateTime ExponentialOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 ExponentialOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(ExponentialOutEase(from.x, to.x, interpolation), ExponentialOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 ExponentialOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(ExponentialOutEase(from.x, to.x, interpolation), ExponentialOutEase(from.y, to.y, interpolation), ExponentialOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 ExponentialOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(ExponentialOutEase(from.x, to.x, interpolation), ExponentialOutEase(from.y, to.y, interpolation), ExponentialOutEase(from.z, to.z, interpolation), ExponentialOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion ExponentialOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, ExponentialOutEase(0f, 1f, interpolation));
        }

        public static Rect ExponentialOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(ExponentialOutEase(from.position, to.position, interpolation), ExponentialOutEase(from.size, to.size, interpolation));
        }

        public static Color ExponentialOutEase(Color from, Color to, float interpolation)
        {
            return ExponentialOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 ExponentialOutEase(Color32 from, Color32 to, float interpolation)
        {
            return ExponentialOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region InOut
        public static int ExponentialInOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from);
            --t;
            return (int)((to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from);
        }

        public static long ExponentialInOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from);
            --t;
            return (long)((to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from);
        }

        public static float ExponentialInOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from;
            --t;
            return (to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from;
        }

        public static double ExponentialInOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from;
            --t;
            return (to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from;
        }

        public static DateTime ExponentialInOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 ExponentialInOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(ExponentialInOutEase(from.x, to.x, interpolation), ExponentialInOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 ExponentialInOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(ExponentialInOutEase(from.x, to.x, interpolation), ExponentialInOutEase(from.y, to.y, interpolation), ExponentialInOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 ExponentialInOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(ExponentialInOutEase(from.x, to.x, interpolation), ExponentialInOutEase(from.y, to.y, interpolation), ExponentialInOutEase(from.z, to.z, interpolation), ExponentialInOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion ExponentialInOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, ExponentialInOutEase(0f, 1f, interpolation));
        }

        public static Rect ExponentialInOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(ExponentialInOutEase(from.position, to.position, interpolation), ExponentialInOutEase(from.size, to.size, interpolation));
        }

        public static Color ExponentialInOutEase(Color from, Color to, float interpolation)
        {
            return ExponentialInOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 ExponentialInOutEase(Color32 from, Color32 to, float interpolation)
        {
            return ExponentialInOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion
        #endregion

        #region Circular
        #region In
        public static int CircularInEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from);
        }

        public static long CircularInEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from);
        }

        public static float CircularInEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from;
        }

        public static double CircularInEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from;
        }

        public static DateTime CircularInEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 CircularInEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(CircularInEase(from.x, to.x, interpolation), CircularInEase(from.y, to.y, interpolation));
        }

        public static Vector3 CircularInEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(CircularInEase(from.x, to.x, interpolation), CircularInEase(from.y, to.y, interpolation), CircularInEase(from.z, to.z, interpolation));
        }

        public static Vector4 CircularInEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(CircularInEase(from.x, to.x, interpolation), CircularInEase(from.y, to.y, interpolation), CircularInEase(from.z, to.z, interpolation), CircularInEase(from.w, to.w, interpolation));
        }

        public static Quaternion CircularInEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, CircularInEase(0f, 1f, interpolation));
        }

        public static Rect CircularInEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(CircularInEase(from.position, to.position, interpolation), CircularInEase(from.size, to.size, interpolation));
        }

        public static Color CircularInEase(Color from, Color to, float interpolation)
        {
            return CircularInEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 CircularInEase(Color32 from, Color32 to, float interpolation)
        {
            return CircularInEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region Out
        public static int CircularOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * Mathf.Sqrt(1 - t * t) + from);
        }

        public static long CircularOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * Mathf.Sqrt(1 - t * t) + from);
        }

        public static float CircularOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * Mathf.Sqrt(1 - t * t) + from;
        }

        public static double CircularOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * Mathf.Sqrt(1 - t * t) + from;
        }

        public static DateTime CircularOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 CircularOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(CircularOutEase(from.x, to.x, interpolation), CircularOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 CircularOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(CircularOutEase(from.x, to.x, interpolation), CircularOutEase(from.y, to.y, interpolation), CircularOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 CircularOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(CircularOutEase(from.x, to.x, interpolation), CircularOutEase(from.y, to.y, interpolation), CircularOutEase(from.z, to.z, interpolation), CircularOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion CircularOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, CircularOutEase(0f, 1f, interpolation));
        }

        public static Rect CircularOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(CircularOutEase(from.position, to.position, interpolation), CircularOutEase(from.size, to.size, interpolation));
        }

        public static Color CircularOutEase(Color from, Color to, float interpolation)
        {
            return CircularOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 CircularOutEase(Color32 from, Color32 to, float interpolation)
        {
            return CircularOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion

        #region InOut
        public static int CircularInOutEase(int from, int to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)(-(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from);
            t -= 2;
            return (int)((to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from);
        }

        public static long CircularInOutEase(long from, long to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)(-(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from);
            t -= 2;
            return (long)((to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from);
        }

        public static float CircularInOutEase(float from, float to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return -(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from;
            t -= 2;
            return (to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from;
        }

        public static double CircularInOutEase(double from, double to, float interpolation)
        {
            float t = interpolation;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return -(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from;
            t -= 2;
            return (to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from;
        }

        public static DateTime CircularInOutEase(DateTime from, DateTime to, float interpolation)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, interpolation)));
        }

        public static Vector2 CircularInOutEase(Vector2 from, Vector2 to, float interpolation)
        {
            return new Vector2(CircularInOutEase(from.x, to.x, interpolation), CircularInOutEase(from.y, to.y, interpolation));
        }

        public static Vector3 CircularInOutEase(Vector3 from, Vector3 to, float interpolation)
        {
            return new Vector3(CircularInOutEase(from.x, to.x, interpolation), CircularInOutEase(from.y, to.y, interpolation), CircularInOutEase(from.z, to.z, interpolation));
        }

        public static Vector4 CircularInOutEase(Vector4 from, Vector4 to, float interpolation)
        {
            return new Vector4(CircularInOutEase(from.x, to.x, interpolation), CircularInOutEase(from.y, to.y, interpolation), CircularInOutEase(from.z, to.z, interpolation), CircularInOutEase(from.w, to.w, interpolation));
        }

        public static Quaternion CircularInOutEase(Quaternion from, Quaternion to, float interpolation)
        {
            return Quaternion.Lerp(from, to, CircularInOutEase(0f, 1f, interpolation));
        }

        public static Rect CircularInOutEase(Rect from, Rect to, float interpolation)
        {
            return new Rect(CircularInOutEase(from.position, to.position, interpolation), CircularInOutEase(from.size, to.size, interpolation));
        }

        public static Color CircularInOutEase(Color from, Color to, float interpolation)
        {
            return CircularInOutEase((Vector4)from, (Vector4)to, interpolation);
        }

        public static Color32 CircularInOutEase(Color32 from, Color32 to, float interpolation)
        {
            return CircularInOutEase((Color)from, (Color)to, interpolation);
        }
        #endregion
        #endregion
        #endregion
        #endregion
    }
}