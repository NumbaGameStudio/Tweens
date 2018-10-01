using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class SinusoidalOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.OutSine; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            return Mathf.Sin(interpolation * (Mathf.PI / 2f));
        }
    }
}