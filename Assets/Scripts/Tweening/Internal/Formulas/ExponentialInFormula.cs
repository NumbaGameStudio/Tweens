using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class ExponentialInFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.InExpo; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            return Mathf.Pow(2f, 10f * (interpolation - 1f));
        }
    }
}