using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class QuinticInOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.InOutQuint; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            interpolation /= 0.5f;
            if (interpolation < 1f) return interpolation * interpolation * interpolation * interpolation * interpolation  / 2f;

            interpolation -= 2f;
            return (interpolation * interpolation * interpolation * interpolation * interpolation + 2f) / 2f;
        }
    }
}