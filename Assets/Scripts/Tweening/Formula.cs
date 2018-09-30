using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    public abstract class Formula
    {
        public abstract float Calculate(float interpolation);

        public virtual Ease Ease
        {
            get
            {
                InternalFormula formula = this as InternalFormula;

                if (formula != null) return formula.Ease;
                else return Ease.Other;
            }
        }
    }
}