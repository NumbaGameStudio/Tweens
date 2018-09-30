using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal class CubicInFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.InCubic; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            return interpolation * interpolation * interpolation;
        }
    }
}