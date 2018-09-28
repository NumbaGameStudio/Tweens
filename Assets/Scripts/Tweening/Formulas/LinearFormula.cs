using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Namespace
{
    public class LinearFormula : Formula
    {
        public override float Calculate(float interpolation)
        {
            return interpolation;
        }
    }
}