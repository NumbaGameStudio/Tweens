using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Numba.Tweens.Tweaks
{
    /// <summary>
    /// Interpolate one ColorBlock value to other and call passed action.
    /// </summary>
    public sealed class TweakColorBlock : Tweak<ColorBlock>
    {
        private TweakColorBlock() { }

        /// <summary>
        /// Create tweak with From and To ColorBlock values objects and passed setter action.
        /// </summary>
        /// <param name="from">From ColorBlock value.</param>
        /// <param name="to">To ColorBlock value.</param>
        /// <param name="setter">Setter which invoked after SetTo method.</param>
        public TweakColorBlock(ColorBlock from, ColorBlock to, Action<ColorBlock> setter) : base(from, to, setter) { }

        /// <summary>
        /// Calculate ColorBlock value by formula and interpolation.
        /// </summary>
        /// <param name="interpolation">Interpolation.</param>
        /// <param name="formula">Formula for tweaking.</param>
        /// <param name="swapFromTo">Is need swap from and to?</param>
        /// <returns>ColorBlock value interpolated by formula.</returns>
        public override ColorBlock Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}