﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal sealed class SinusoidalInOutFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.InOutSine; } }

        public override float Calculate(float interpolation)
        {
            if (interpolation == 0f) return 0f;
            if (interpolation == 1f) return 1f;

            return -0.5f * (Mathf.Cos(Mathf.PI * interpolation) - 1f);
        }
    }
}