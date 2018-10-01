using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class ExponentialInOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.InOutExpo; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            interpolation /= 0.5f;
            if (interpolation < 1f) return Mathf.Pow(2f, 10f * (interpolation - 1f)) / 2f;

            --interpolation;
            return (-Mathf.Pow(2f, -10f * interpolation) + 2f) / 2f;
        }
    }
}