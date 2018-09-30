using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal class QuarticOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.OutQuart; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            --interpolation;
            return -(interpolation * interpolation * interpolation * interpolation - 1f);
        }
    }
}