﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakRect : Tweak<Rect>
    {
        private TweakRect() { }

        public TweakRect(Rect from, Rect to, Action<Rect> setter) : base(from, to, setter) { }

        protected override Rect Evaluate(float interpolation, Ease ease, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, ease));
        }

        protected override Rect Evaluate(float interpolation, Formula formula, bool swapFromTo = false)
        {
            return Evaluate(swapFromTo, (from, to) => Easing.Ease(from, to, interpolation, formula));
        }
    }
}