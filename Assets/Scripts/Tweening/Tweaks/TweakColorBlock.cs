using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakColorBlock : Tweak<ColorBlock>
    {
        private TweakColorBlock() { }

        public TweakColorBlock(ColorBlock from, ColorBlock to, Action<ColorBlock> setter) : base(from, to, setter) { }

        protected override ColorBlock Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => new ColorBlock()
            {
                colorMultiplier = Easing.Ease(From.colorMultiplier, To.colorMultiplier, interpolation, ease),
                disabledColor = Easing.Ease(From.disabledColor, To.disabledColor, interpolation, ease),
                fadeDuration = Easing.Ease(From.fadeDuration, To.fadeDuration, interpolation, ease),
                highlightedColor = Easing.Ease(From.highlightedColor, To.highlightedColor, interpolation, ease),
                normalColor = Easing.Ease(From.normalColor, To.normalColor, interpolation, ease),
                pressedColor = Easing.Ease(From.pressedColor, To.pressedColor, interpolation, ease)
            });
        }

        protected override ColorBlock Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => new ColorBlock()
            {
                colorMultiplier = Easing.Ease(From.colorMultiplier, To.colorMultiplier, interpolation, formula),
                disabledColor = Easing.Ease(From.disabledColor, To.disabledColor, interpolation, formula),
                fadeDuration = Easing.Ease(From.fadeDuration, To.fadeDuration, interpolation, formula),
                highlightedColor = Easing.Ease(From.highlightedColor, To.highlightedColor, interpolation, formula),
                normalColor = Easing.Ease(From.normalColor, To.normalColor, interpolation, formula),
                pressedColor = Easing.Ease(From.pressedColor, To.pressedColor, interpolation, formula)
            });
        }
    }
}