using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent settings for Sequence class. 
    /// </summary>
    public struct SequenceSettings
    {
        private int _loopsCount;

        /// <summary>
        /// How many times repeat the animation (-1 for infinity).
        /// </summary>
        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        /// <summary>
        /// What behaviour need use when playing.
        /// </summary>
        public LoopType LoopType { get; set; }

        /// <summary>
        /// Create settings with loops count and loop type.
        /// </summary>
        /// <param name="loopsCount">Loops count.</param>
        /// <param name="loopType">Loop type.</param>
        public SequenceSettings(int loopsCount, LoopType loopType)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;
        }

        public static implicit operator TweenSettings(SequenceSettings settings)
        {
            return new TweenSettings(settings._loopsCount, settings.LoopType, Formulas.Linear);
        }
    }

    /// <summary>
    /// Represent settings for Tween class. 
    /// </summary>
    public struct TweenSettings
    {
        private int _loopsCount;

        private Formula _formula;

        /// <summary>
        /// How many times repeat the animation (-1 for infinity).
        /// </summary>
        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        /// <summary>
        /// What behaviour need use when playing.
        /// </summary>
        public LoopType LoopType { get; set; }

        /// <summary>
        /// Formula used when playing.
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
        /// </summary>
        public Ease Ease
        {
            get { return _formula.Ease; }
            set { _formula = Formulas.GetFormula(value); }
        }

        /// <summary>
        /// Create settings with loops count, loop type and formula.
        /// </summary>
        /// <param name="loopsCount">Loops count.</param>
        /// <param name="loopType">Loop type.</param>
        /// <param name="formula">Formula.</param>
        public TweenSettings(int loopsCount, LoopType loopType, Formula formula)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;

            if (formula == null) throw new ArgumentNullException("value", "Formula can not be a null");
            _formula = formula;
        }

        /// <summary>
        /// Create settings with loops count, loop type and formula.
        /// </summary>
        /// <param name="loopsCount">Loops count.</param>
        /// <param name="loopType">Loop type.</param>
        /// <param name="ease">Ease type associated with built-in formula.</param>
        public TweenSettings(int loopsCount, LoopType loopType, Ease ease) : this(loopsCount, loopType, Formulas.GetFormula(ease)) { }

        public static implicit operator SequenceSettings(TweenSettings easedSettings)
        {
            return new SequenceSettings(easedSettings._loopsCount, easedSettings.LoopType);
        }
    }
}