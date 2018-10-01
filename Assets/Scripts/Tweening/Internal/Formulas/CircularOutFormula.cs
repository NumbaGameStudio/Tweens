using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class CircularOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.OutCirc; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            --interpolation;
            return Mathf.Sqrt(1f - interpolation * interpolation);
        }
    }
}