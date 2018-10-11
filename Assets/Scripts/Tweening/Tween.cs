using System.Collections;
using UnityEngine;
using Numba.Tweens.Tweaks;
using System;
using UnityEngine.UI;
using Numba.Tweens.Static;

namespace Numba.Tweens
{
    /// <summary>
    /// Can animate any tweak in time.
    /// Just set needed settings and call Play/Pause/Stop methods.
    /// </summary>
    public sealed class Tween : Playable
    {
        #region Create
        #region Int
        /// <summary>
        /// Create tween for animate Int value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(int from, int to, Action<int> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Int value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, int from, int to, Action<int> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Int value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Int value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Long
        /// <summary>
        /// Create tween for animate Long value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(long from, long to, Action<long> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Long value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, long from, long to, Action<long> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Long value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Long value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Float
        /// <summary>
        /// Create tween for animate Float value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(float from, float to, Action<float> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Float value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, float from, float to, Action<float> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Float value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Float value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Double
        /// <summary>
        /// Create tween for animate Double value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(double from, double to, Action<double> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Double value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, double from, double to, Action<double> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Double value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Double value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Char
        /// <summary>
        /// Create tween for animate Char value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(char from, char to, Action<char> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Char value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, char from, char to, Action<char> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Char value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(char from, char to, Action<char> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Char value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, char from, char to, Action<char> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region String
        /// <summary>
        /// Create tween for animate String value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string from, string to, Action<string> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate String value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, string from, string to, Action<string> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate String value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string from, string to, Action<string> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate String value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, string from, string to, Action<string> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region DateTime
        /// <summary>
        /// Create tween for animate DateTime value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(DateTime from, DateTime to, Action<DateTime> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate DateTime value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, DateTime from, DateTime to, Action<DateTime> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate DateTime value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate DateTime value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Vector2
        /// <summary>
        /// Create tween for animate Vector2 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Vector2 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Vector2 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Vector2 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Vector3
        /// <summary>
        /// Create tween for animate Vector3 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Vector3 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Vector3 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Vector3 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Vector4
        /// <summary>
        /// Create tween for animate Vector4 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Vector4 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Vector4 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Vector4 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Quaternion
        /// <summary>
        /// Create tween for animate Quaternion value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Quaternion value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Quaternion value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Quaternion value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Rect
        /// <summary>
        /// Create tween for animate Rect value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Rect from, Rect to, Action<Rect> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Rect value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Rect from, Rect to, Action<Rect> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Rect value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Rect value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Color
        /// <summary>
        /// Create tween for animate Color value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Color from, Color to, Action<Color> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Color value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Color from, Color to, Action<Color> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Color value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Color value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Color32
        /// <summary>
        /// Create tween for animate Color32 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Color32 from, Color32 to, Action<Color32> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Color32 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Color32 from, Color32 to, Action<Color32> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Color32 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Color32 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ColorBlock
        /// <summary>
        /// Create tween for animate ColorBlock value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate ColorBlock value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate ColorBlock value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate ColorBlock value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Bounds
        /// <summary>
        /// Create tween for animate Bounds value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Bounds from, Bounds to, Action<Bounds> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Bounds value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Bounds from, Bounds to, Action<Bounds> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Bounds value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Bounds from, Bounds to, Action<Bounds> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Bounds value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Bounds from, Bounds to, Action<Bounds> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Matrix4x4
        /// <summary>
        /// Create tween for animate Matrix4x4 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Matrix4x4 from, Matrix4x4 to, Action<Matrix4x4> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate Matrix4x4 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Matrix4x4 from, Matrix4x4 to, Action<Matrix4x4> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Matrix4x4 value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Matrix4x4 from, Matrix4x4 to, Action<Matrix4x4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate Matrix4x4 value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Matrix4x4 from, Matrix4x4 to, Action<Matrix4x4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region WheelFrictionCurve
        /// <summary>
        /// Create tween for animate WheelFrictionCurve value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(WheelFrictionCurve from, WheelFrictionCurve to, Action<WheelFrictionCurve> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate WheelFrictionCurve value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, WheelFrictionCurve from, WheelFrictionCurve to, Action<WheelFrictionCurve> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate WheelFrictionCurve value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(WheelFrictionCurve from, WheelFrictionCurve to, Action<WheelFrictionCurve> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate WheelFrictionCurve value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, WheelFrictionCurve from, WheelFrictionCurve to, Action<WheelFrictionCurve> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region JointSpring
        /// <summary>
        /// Create tween for animate JointSpring value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(JointSpring from, JointSpring to, Action<JointSpring> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate JointSpring value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, JointSpring from, JointSpring to, Action<JointSpring> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate JointSpring value.
        /// </summary>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(JointSpring from, JointSpring to, Action<JointSpring> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate JointSpring value.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="from">From value.</param>
        /// <param name="to">To value.</param>
        /// <param name="setter">Setter callback.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, JointSpring from, JointSpring to, Action<JointSpring> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Settings
        /// <summary>
        /// Create tween with settings for animate existed tweak.
        /// </summary>
        /// <param name="tweak">Existed tweak.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="settings">Tween settings.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Tweak tweak, float duration, TweenSettings settings)
        {
            return Create(null, tweak, duration, settings.Formula, settings.LoopsCount, settings.LoopType);
        }

        /// <summary>
        /// Create named tween with settings for animate existed tweak.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="tweak">Existed tweak.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="settings">Tween settings.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Tweak tweak, float duration, TweenSettings settings)
        {
            return Create(name, tweak, duration, settings.Formula, settings.LoopsCount, settings.LoopType);
        }
        #endregion

        #region Tweak
        /// <summary>
        /// Create tween for animate existed tweak.
        /// </summary>
        /// <param name="tweak">Existed tweak.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Tweak tweak, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, tweak, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate existed tweak.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="tweak">Existed tweak.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="formula">Formula used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Tweak tweak, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(name, tweak, duration).SetEase(formula).SetLoops(loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for animate existed tweak.
        /// </summary>
        /// <param name="tweak">Existed tweak.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, tweak, duration, ease, loopsCount, loopType);
        }

        /// <summary>
        /// Create named tween for animate existed tweak.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="tweak">Existed tweak.</param>
        /// <param name="duration">Tween duration (without loops count and loop type).</param>
        /// <param name="ease">Ease type associated with built-in formula which used in calculations.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Created tween.</returns>
        public static Tween Create(string name, Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, tweak, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        private Formula _formula = Formulas.Linear;

        #region Constructors
        private Tween() { }

        /// <summary>
        /// Create tween with tweak and duration.
        /// </summary>
        /// <param name="tweak">Tweak.</param>
        /// <param name="duration">Tween duration.</param>
        public Tween(Tweak tweak, float duration) : this(null, tweak, duration) { }

        /// <summary>
        /// Create named tween with tweak and duration.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="tweak">Tweak.</param>
        /// <param name="duration">Tween duration.</param>
        public Tween(string name, Tweak tweak, float duration)
        {
            ConstructBase(name, tweak, duration, 1, LoopType.Forward);
            Formula = Formulas.Linear;
        }

        /// <summary>
        /// Create tween with tweak, duration and settings.
        /// </summary>
        /// <param name="tweak">Tweak.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="settings">Tween settings.</param>
        public Tween(Tweak tweak, float duration, TweenSettings settings) : this(null, tweak, duration, settings) { }

        /// <summary>
        /// Create named tween with tweak, duration and settings.
        /// </summary>
        /// <param name="name">Tween name.</param>
        /// <param name="tweak">Tweak.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="settings">Tween settings.</param>
        public Tween(string name, Tweak tweak, float duration, TweenSettings settings)
        {
            ConstructBase(name, tweak, duration, settings.LoopsCount, settings.LoopType);
            Formula = settings.Formula;
        }

        static Tween()
        {
            Time = new Static.Time();
        }
        #endregion

        #region Properties
        protected override string PlayableTypeName { get { return "Tween"; } }

        /// <summary>
        /// Tweak which used by tween.
        /// </summary>
        public Tweak Tweak { get; set; }

        /// <summary>
        /// Tween duration (without loops count and loop type).
        /// </summary>
        public new float Duration
        {
            get { return _duration; }
            set
            {
                _duration = Mathf.Max(0f, value);
                DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
            }
        }

        /// <summary>
        /// Formula which will be used in calculations.
        /// </summary>
        public Formula Formula
        {
            get { return _formula; }
            set
            {
                if (value == null) throw new ArgumentNullException("value", "Formula can not be a null");
                _formula = value;
            }
        }

        /// <summary>
        /// Ease type associated with built-in formula.
        /// Set value to this property will rewrite formula used in calculations.
        /// </summary>
        public Ease Ease
        {
            get { return _formula.Ease; }
            set { _formula = Formulas.GetFormula(value); }
        }

        /// <summary>
        /// How many times repeat the animation (-1 for infinity).
        /// </summary>
        public override int LoopsCount
        {
            get { return _loopsCount; }
            set
            {
                SetLoopsCount(value);
            }
        }

        /// <summary>
        /// What behaviour need use when playing.
        /// </summary>
        public override LoopType LoopType
        {
            get { return _loopType; }
            set
            {
                SetLoopType(value);
            }
        }

        /// <summary>
        /// Tween settings (represent LoopsCount, LoopType and Formula).
        /// </summary>
        public TweenSettings Settings
        {
            get
            {
                return new TweenSettings(_loopsCount, _loopType, Formula);
            }
            set
            {
                LoopsCount = value.LoopsCount;
                LoopType = value.LoopType;
                Formula = value.Formula;
            }
        }

        /// <summary>
        /// Give you access to tweening UnityEngine.Time class properties.
        /// </summary>
        public static Static.Time Time { get; private set; }
        #endregion

        #region Methods
        private void ConstructBase(string name, Tweak tweak, float duration, int loopsCount, LoopType loopType)
        {
            Name = name ?? "[noname]";
            Tweak = tweak;
            Duration = Mathf.Max(0f, duration);

            LoopsCount = loopsCount;
            LoopType = loopType;
        }

        /// <summary>
        /// Set formula which will be used for easing.
        /// </summary>
        /// <param name="formula">Formula.</param>
        /// <returns>This tween.</returns>
        public Tween SetEase(Formula formula)
        {
            Formula = formula;
            return this;
        }

        /// <summary>
        /// Set built-in formula through ease type enumeration, which will be used for easing.
        /// </summary>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        /// <returns>This tween.</returns>
        public Tween SetEase(Ease ease)
        {
            Ease = ease;
            return this;
        }

        /// <summary>
        /// Set loops count.
        /// </summary>
        /// <param name="loopsCount">Loops count (-1 for infinity).</param>
        /// <returns>This playable.</returns>
        public new Tween SetLoops(int loopsCount)
        {
            LoopsCount = LoopsCount;
            return this;
        }

        /// <summary>
        /// Set loop type.
        /// </summary>
        /// <param name="loopType">Loop type.</param>
        /// <returns>This playable.</returns>
        public new Tween SetLoops(LoopType loopType)
        {
            LoopType = loopType;
            return this;
        }

        /// <summary>
        /// Set loops count and loop type.
        /// </summary>
        /// <param name="loopsCount">Loops count (-1 for infinity).</param>
        /// <param name="loopType">Loop type.</param>
        /// <returns>This playable.</returns>
        public new Tween SetLoops(int loopsCount, LoopType loopType)
        {
            LoopsCount = loopsCount;
            LoopType = loopType;

            return this;
        }

        private bool IsYoyoBackward(float time, float duration)
        {
            float repeated = time / duration;
            if (repeated <= 1f) return false;

            int intPart = (int)repeated;
            float fraction = repeated - intPart;

            bool isEven = intPart % 2 == 0;

            return (!isEven && fraction == 0f) || (isEven && fraction != 0f) ? false : true;
        }

        /// <summary>
        /// Set tween current play time.
        /// </summary>
        /// <param name="time">Time (not interpolated).</param>
        internal override void SetTime(float time)
        {
            SetTime(Tweak, time, Duration, DurationWithLoops, Formula, LoopType);
        }

        private void SetTime(Tweak tweak, float time, float duration, float durationWithLoops, Formula formula, LoopType loopType)
        {
            if (duration == 0f)
            {
                SetTweakTime(tweak, formula, () => LoopType == LoopType.Forward ? 1f : 0f);
                return;
            }

            time = Mathf.Clamp(time, 0f, durationWithLoops);

            if (loopType == LoopType.Forward)
                SetTweakTime(tweak, formula, () => Math.WrapCeil(time, duration) / duration);
            else if (loopType == LoopType.Backward)
                SetTweakTime(tweak, formula, () => Math.WrapCeil(time, duration) / duration, true);
            else if (loopType == LoopType.Reversed)
                SetTweakTime(tweak, formula, () => 1f - Math.WrapCeil(time, duration) / duration);
            else if (loopType == LoopType.Yoyo)
                SetTweakTime(tweak, formula, () => Math.WrapCeil(time, duration) / duration, IsYoyoBackward(time, duration));
            else
            {
                if (IsYoyoBackward(time, duration)) SetTweakTime(tweak, formula, () => 1f - Math.WrapCeil(time, duration) / duration);
                else SetTweakTime(tweak, formula, () => Math.WrapCeil(time, duration) / duration);
            }
        }

        private void SetTweakTime(Tweak tweak, Formula formula, Func<float> timeGetter, bool swapFromTo = false)
        {
            if (tweak == null) return;
            tweak.SetTo(timeGetter(), formula, swapFromTo);
        }

        /// <summary>
        /// Set settings for this tween.
        /// </summary>
        /// <param name="settings">Sequence settings.</param>
        /// <returns>This tween.</returns>
        public Tween SetSettings(TweenSettings settings)
        {
            Settings = settings;
            return this;
        }

        /// <summary>
        /// Starts playing this tween (or resume if was paused).
        /// </summary>
        /// <param name="useRealtime">Realtime (system time) will be used if true.</param>
        /// <returns>Object that represent playing (can be yielded).</returns>
        public new Tween Play(bool useRealtime = false)
        {
            return (Tween)base.Play(useRealtime);
        }

        protected override sealed IEnumerator PlayTimeWithCurrentParameters()
        {
            return PlayTime(Tweak, Duration, DurationWithLoops, Formula, LoopsCount, LoopType);
        }

        private IEnumerator PlayTime(Tweak tweak, float duration, float durationWithLoops, Formula formula, int loopsCount, LoopType loopType)
        {
            InvokeStart();

            _playStartTime = GetTime(_useRealtime);
            _playCurrentTime = _playStartTime;
            _playEndTime = _playStartTime + durationWithLoops;

            while (loopsCount == -1)
            {
                yield return null;

                _playCurrentTime = GetTime(_useRealtime);

                if (duration == 0f)
                {
                    SetTime(tweak, 0f, duration, durationWithLoops, formula, loopType);
                }
                else
                {
                    while (_playEndTime < _playCurrentTime)
                    {
                        _playStartTime = _playEndTime;
                        _playEndTime = _playStartTime + durationWithLoops;
                    }

                    SetTime(tweak, _playCurrentTime - _playStartTime, duration, durationWithLoops, formula, loopType);
                }

                InvokeUpdate();
            }

            if (duration == 0f)
            {
                yield return null;

                SetTime(tweak, 0f, duration, durationWithLoops, formula, loopType);
            }
            else
            {
                while (_playCurrentTime < _playEndTime)
                {
                    yield return null;

                    _playCurrentTime = GetTime(_useRealtime);
                    SetTime(tweak, (Mathf.Min(_playCurrentTime, _playEndTime) - _playStartTime), duration, durationWithLoops, formula, loopType);

                    InvokeUpdate();
                }
            }

            HandleStop();
        }

        protected override void HandleStop()
        {
            if (PlayState != PlayState.Pause) RoutineHelper.Instance.StopCoroutine(_playTimeEnumerator);
            _playTimeEnumerator = null;

            PlayState = PlayState.Stop;

            InvokeComplete();
        }

        /// <summary>
        /// Set callback on Start event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public new Tween OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        /// <summary>
        /// Set callback on Update event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public new Tween OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        /// <summary>
        /// Set callback on Complete event.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>This playable</returns>
        public new Tween OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }
        #endregion
    }
}