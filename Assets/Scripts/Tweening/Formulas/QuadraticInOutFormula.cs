﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Namespace
{
    public class QuadraticInOutFormula : Formula
    {
        public override float Calculate(float interpolation)
        {
            return interpolation * (interpolation - 2);
        }
    }
}