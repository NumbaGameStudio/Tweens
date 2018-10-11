using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Numba.Tweens.Tweaks;

namespace Numba.Tweens
{
    /// <summary>
    /// <para>Base class for tweaking.</para>
    /// <para>If you want create custom tweak - you need inherite from generic Tweak class.</para>
    /// </summary>
    public abstract class Tweak
    {
        #region Create
        /// <summary>
        /// Create Int tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(int from, int to, Action<int> setter)
        {
            return new TweakInt(from, to, setter);
        }

        /// <summary>
        /// Create Long tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(long from, long to, Action<long> setter)
        {
            return new TweakLong(from, to, setter);
        }

        /// <summary>
        /// Create Float tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(float from, float to, Action<float> setter)
        {
            return new TweakFloat(from, to, setter);
        }

        /// <summary>
        /// Create Double tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(double from, double to, Action<double> setter)
        {
            return new TweakDouble(from, to, setter);
        }

        /// <summary>
        /// Create Char tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(char from, char to, Action<char> setter)
        {
            return new TweakChar(from, to, setter);
        }

        /// <summary>
        /// Create String tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(string from, string to, Action<string> setter)
        {
            return new TweakString(from, to, setter);
        }

        /// <summary>
        /// Create DateTime tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(DateTime from, DateTime to, Action<DateTime> setter)
        {
            return new TweakDateTime(from, to, setter);
        }

        /// <summary>
        /// Create Vector2 tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Vector2 from, Vector2 to, Action<Vector2> setter)
        {
            return new TweakVector2(from, to, setter);
        }
        
        /// <summary>
        /// Create Vector3 tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Vector3 from, Vector3 to, Action<Vector3> setter)
        {
            return new TweakVector3(from, to, setter);
        }

        /// <summary>
        /// Create Vector4 tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Vector4 from, Vector4 to, Action<Vector4> setter)
        {
            return new TweakVector4(from, to, setter);
        }
        
        /// <summary>
        /// Create Quaternion tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Quaternion from, Quaternion to, Action<Quaternion> setter)
        {
            return new TweakQuaternion(from, to, setter);
        }
        
        /// <summary>
        /// Create Rect tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Rect from, Rect to, Action<Rect> setter)
        {
            return new TweakRect(from, to, setter);
        }
        
        /// <summary>
        /// Create Color tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Color from, Color to, Action<Color> setter)
        {
            return new TweakColor(from, to, setter);
        }
        
        /// <summary>
        /// Create Color32 tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Color32 from, Color32 to, Action<Color32> setter)
        {
            return new TweakColor32(from, to, setter);
        }
        
        /// <summary>
        /// Create ColorBlock tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter)
        {
            return new TweakColorBlock(from, to, setter);
        }
        
        /// <summary>
        /// Create Bounds tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Bounds from, Bounds to, Action<Bounds> setter)
        {
            return new TweakBounds(from, to, setter);
        }
        
        /// <summary>
        /// Create Matrix4x4 tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(Matrix4x4 from, Matrix4x4 to, Action<Matrix4x4> setter)
        {
            return new TweakMatrix4x4(from, to, setter);
        }
        
        /// <summary>
        /// Create WheelFrictionCurve tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(WheelFrictionCurve from, WheelFrictionCurve to, Action<WheelFrictionCurve> setter)
        {
            return new TweakWheelFrictionCurve(from, to, setter);
        }
        
        /// <summary>
        /// Create JointSpring tweaker.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter in which will be passed tweaked value.</param>
        /// <returns></returns>
        public static Tweak Create(JointSpring from, JointSpring to, Action<JointSpring> setter)
        {
            return new TweakJointSpring(from, to, setter);
        }
        #endregion

        /// <summary>
        /// Calculate tweaked value and pass it to setter.
        /// </summary>
        /// <param name="interpolation">Interpolation between From and To values.</param>
        /// <param name="formula">Formula which affect on interpolation.</param>
        /// <param name="swapFromTo">Is need swap From and To values.</param>
        public abstract void SetTo(float interpolation, Formula formula, bool swapFromTo = false);

        /// <summary>
        /// Calculate tweaked value and pass it to setter.
        /// </summary>
        /// <param name="interpolation">Interpolation between From and To values.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <param name="swapFromTo">Is need swap From and To values.</param>
        public abstract void SetTo(float interpolation, Ease ease, bool swapFromTo = false);

        /// <summary>
        /// Cast to concrete tweak type.
        /// </summary>
        /// <typeparam name="T">Concrete tweak type.</typeparam>
        /// <returns>Casted tweak.</returns>
        public Tweak<T> As<T>() { return (Tweak<T>)this; }
    }

    /// <summary>
    /// Generic class for tweaking.
    /// Inherite from it for create your own tweak classes.
    /// </summary>
    /// <typeparam name="T">Concrete type for tweak From and To values</typeparam>
    public abstract class Tweak<T> : Tweak
	{
        #region Properties
        /// <summary>
        /// From value. Used in calculating tweaked value as start value.
        /// </summary>
        public T From { get; set; }

        /// <summary>
        /// To value. Used in calculating tweaked value as end value.
        /// </summary>
        public T To { get; set; }

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

        /// <summary>
        /// Set setter callback.
        /// </summary>
        /// <param name="setter">Setter callback.</param>
        public void SetSetter(Action<T> setter)
        {
            _setter = setter;
        }

        /// <summary>
        /// Invoke setter callback if it do not equal to null.
        /// </summary>
        /// <param name="value">Value which passed in setter callback.</param>
        public void CallSetter(T value)
        {
            if (_setter != null) _setter.Invoke(value);
        }

        /// <summary>
        /// Evaluate tweaked value and return it.
        /// </summary>
        /// <param name="interpolation">Interpolation between From and To values.</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="useSwap">Is need swap From and To values.</param>
        /// <returns>Calculated value.</returns>
        public abstract T Evaluate(float interpolation, Formula formula, bool useSwap = false);

        /// <summary>
        /// Evaluate tweaked value and return it.
        /// </summary>
        /// <param name="interpolation">Interpolation between From and To values.</param>
        /// <param name="ease">Ease type associated with built-in formula, which will be used in calculations.</param>
        /// <param name="useSwap">Is need swap From and To values.</param>
        /// <returns>Calculated value.</returns>
        public T Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }

        /// <summary>
        /// Evaluate tweaked value and call setter callback.
        /// </summary>
        /// <param name="interpolation">Interpolation between From and To values.</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="swapFromTo">Is need swap From and To values.</param>
        public override void SetTo(float interpolation, Formula formula, bool swapFromTo = false)
        {
            CallSetter(Evaluate(interpolation, formula, swapFromTo));
        }

        /// <summary>
        /// Evaluate tweaked value and call setter callback.
        /// </summary>
        /// <param name="interpolation">Interpolation between From and To values.</param>
        /// <param name="ease">Ease type associated with built-in formula, which will be used in calculations.</param>
        /// <param name="swapFromTo">Is need swap From and To values.</param>
        public sealed override void SetTo(float interpolation, Ease ease, bool swapFromTo = false)
        {
            SetTo(interpolation, Formulas.GetFormula(ease), swapFromTo);
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