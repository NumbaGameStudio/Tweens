using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Numba.Tweening.Engine;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakColorBlock : Tweak<ColorBlock>
    {
        private TweakColorBlock() { }

        public TweakColorBlock(ColorBlock from, ColorBlock to, Action<ColorBlock> setter) : base(from, to, setter) { }

        public override ColorBlock Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }

        public override ColorBlock Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(interpolation, Formulas.GetFormula(ease), swapFromTo);
        }
    }
}