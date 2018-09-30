using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Numba.Tweening
{
    internal class LinearFormula : InternalFormula
    {
        public override Ease Ease { get { return Ease.Linear; } }

        public override float Calculate(float interpolation)
        {
            return interpolation;
        }
    }
}