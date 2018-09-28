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

        public static implicit operator EasedSettings(Settings settings)
        {
            return new EasedSettings(settings._loopsCount, settings.LoopType, Ease.Linear);
        }
    }

    public struct EasedSettings
    {
        private int _loopsCount;

        private Ease _ease;

        private Formula _formula;

        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        public LoopType LoopType { get; set; }

        public EaseType EaseType { get; private set; }

        public Ease Ease
        {
            get { return _ease; }
            set
            {
                _ease = value;
                EaseType = EaseType.Integrated;
                _formula = null;
            }
        }

        public Formula Formula
        {
            get { return _formula; }
            set
            {
                _formula = value;
                EaseType = EaseType.Custom;
            }
        }

        public EasedSettings(int loopsCount, LoopType loopType, Ease ease)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;
            EaseType = EaseType.Integrated;
            _ease = ease;
            _formula = null;
        }

        public EasedSettings(int loopsCount, LoopType loopType, Formula formula)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;
            EaseType = EaseType.Custom;
            _ease = Ease.Linear;
            _formula = formula;
        }

        public static implicit operator Settings(EasedSettings easedSettings)
        {
            return new Settings(easedSettings._loopsCount, easedSettings.LoopType);
        }
    }
}