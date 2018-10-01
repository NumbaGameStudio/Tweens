using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class CircularInOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.InOutCirc; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            interpolation /= 0.5f;
            if (interpolation < 1f) return -(Mathf.Sqrt(1f - interpolation * interpolation) - 1f) / 2f;
            interpolation -= 2f;
            return (Mathf.Sqrt(1f - interpolation * interpolation) + 1f) / 2f;
        }
    }
}