using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Numba.Tweening.Tweaks
{
    public abstract class Tweak
    {
        #region Create
        public static Tweak Create(float from, float to, Action<float> setter)
        {
            return new TweakFloat(from, to, setter);
        }

        public static Tweak Create(double from, double to, Action<double> setter)
        {
            return new TweakDouble(from, to, setter);
        }

        public static Tweak Create(int from, int to, Action<int> setter)
        {
            return new TweakInt(from, to, setter);
        }

        public static Tweak Create(long from, long to, Action<long> setter)
        {
            return new TweakLong(from, to, setter);
        }

        public static Tweak Create(Vector2 from, Vector2 to, Action<Vector2> setter)
        {
            return new TweakVector2(from, to, setter);
        }

        public static Tweak Create(Vector3 from, Vector3 to, Action<Vector3> setter)
        {
            return new TweakVector3(from, to, setter);
        }

        public static Tweak Create(Vector4 from, Vector4 to, Action<Vector4> setter)
        {
            return new TweakVector4(from, to, setter);
        }

        public static Tweak Create(Quaternion from, Quaternion to, Action<Quaternion> setter)
        {
            return new TweakQuaternion(from, to, setter);
        }

        public static Tweak Create(Color from, Color to, Action<Color> setter)
        {
            return new TweakColor(from, to, setter);
        }

        public static Tweak Create(Color32 from, Color32 to, Action<Color32> setter)
        {
            return new TweakColor32(from, to, setter);
        }

        public static Tweak Create(DateTime from, DateTime to, Action<DateTime> setter)
        {
            return new TweakDateTime(from, to, setter);
        }

        public static Tweak Create(Rect from, Rect to, Action<Rect> setter)
        {
            return new TweakRect(from, to, setter);
        }

        public static Tweak Create(Bounds from, Bounds to, Action<Bounds> setter)
        {
            return new TweakBounds(from, to, setter);
        }

        public static Tweak Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter)
        {
            return new TweakColorBlock(from, to, setter);
        }
        #endregion

        public abstract void SetTime(float interpolation, Ease ease, bool swapFromTo = false);

        public abstract void SetTime(float interpolation, AnimationCurve curve, bool swapFromTo = false);
    }

    public abstract class Tweak<T> : Tweak
	{
        #region Properties
        public T From { get; protected set; }

        public T To { get; protected set; }

        protected Action<T> _setter;
        #endregion

        #region Constructors
        protected Tweak() { }

        protected Tweak(T from, T to, Action<T> setter)
        {
            From = from;
            To = to;
            _setter = setter;
        }
        #endregion

        public void SetSetter(Action<T> setter)
        {
            _setter = setter;
        }

        public void CallSetter(T value)
        {
            if (_setter != null) _setter.Invoke(value);
        }

        protected abstract T Evaluate(float interpolation, Ease ease, bool swapFromTo = false);

        protected abstract T Evaluate(float interpolation, AnimationCurve curve, bool useSwap = false);

        public sealed override void SetTime(float interpolation, Ease ease, bool swapFromTo = false)
        {
            CallSetter(Evaluate(interpolation, ease, swapFromTo));
        }

        public override void SetTime(float interpolation, AnimationCurve curve, bool swapFromTo = false)
        {
            CallSetter(Evaluate(interpolation, curve, swapFromTo));
        }

        protected void GetSwapedFromTo(out T from, out T to, bool swapFromTo)
        {
            if (swapFromTo)
            {
                from = To;
                to = From;
            }
            else
            {
                from = From;
                to = To;
            }
        }

        protected T Evaluate(bool swapFromTo, Func<T, T, T> easer)
        {
            T from, to;
            GetSwapedFromTo(out from, out to, swapFromTo);

            return easer(from, to);
        }
    }
}