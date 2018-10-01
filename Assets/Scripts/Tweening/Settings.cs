using Numba.Tweening.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    public struct Settings
    {
        private int _loopsCount;

        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        public LoopType LoopType { get; set; }

        public Settings(int loopsCount, LoopType loopType)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;
        }

        public static implicit operator FormulaSettings(Settings settings)
        {
            return new FormulaSettings(settings._loopsCount, settings.LoopType, FormulasUtility.Linear);
        }
    }

    public struct FormulaSettings
    {
        private int _loopsCount;

        private Formula _formula;

        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        public LoopType LoopType { get; set; }

        public Formula Formula
        {
            get { return _formula; }
            set
            {
                if (value == null) throw new ArgumentNullException("value", "Formula can not be a null");
                _formula = value;
            }
        }

        public Ease Ease
        {
            get { return _formula.Ease; }
            set { _formula = FormulasUtility.GetFormula(value); }
        }

        public FormulaSettings(int loopsCount, LoopType loopType, Formula formula)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;

            if (formula == null) throw new ArgumentNullException("value", "Formula can not be a null");
            _formula = formula;
        }

        public FormulaSettings(int loopsCount, LoopType loopType, Ease ease) : this(loopsCount, loopType, FormulasUtility.GetFormula(ease)) { }

        public static implicit operator Settings(FormulaSettings easedSettings)
        {
            return new Settings(easedSettings._loopsCount, easedSettings.LoopType);
        }
    }
}