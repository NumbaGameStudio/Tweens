using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Namespace
{
    public class MyFormula : Formula
    {
        [SerializeField]
        private AnimationCurve _animationCurve;

        public override float Calculate(float interpolation)
        {
            return _animationCurve.Evaluate(interpolation);
        }
    }
}