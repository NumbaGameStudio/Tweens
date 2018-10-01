using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class QuinticOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.OutQuint; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            --interpolation;
            return interpolation * interpolation * interpolation * interpolation * interpolation + 1f;
        }
    }
}