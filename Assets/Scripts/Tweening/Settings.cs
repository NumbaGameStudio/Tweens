using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    public struct Settings
    {
        #region Fields
        private int _loopsCount;

        private Ease _ease;

        private AnimationCurve _curve;
        #endregion

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
                EaseType = EaseType.Formula;
                _curve = null;
            }
        }

        public AnimationCurve Curve
        {
            get { return _curve; }
            set
            {
                _curve = value;
                EaseType = EaseType.Curve;
            }
        }

        public Settings(int loopsCount, LoopType loopType)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;
            EaseType = EaseType.Formula;
            _ease = Ease.Linear;
            _curve = null;
        }

        public Settings(int loopsCount, LoopType loopType, Ease ease)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;
            EaseType = EaseType.Formula;
            _ease = ease;
            _curve = null;
        }

        public Settings(int loopsCount, LoopType loopType, AnimationCurve curve)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;
            EaseType = EaseType.Curve;
            _ease = Ease.Linear;
            _curve = curve;
        }
    }
}