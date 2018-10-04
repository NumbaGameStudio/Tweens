using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakJointSpring : Tweak<JointSpring>
    {
        private TweakJointSpring() { }

        public TweakJointSpring(JointSpring from, JointSpring to, Action<JointSpring> setter) : base(from, to, setter) { }

        public override JointSpring Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override JointSpring Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }
    }
}