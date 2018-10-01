using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening.Engine
{
	public sealed class Time
    {
		public Tween DoTimeScale(float timeScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.timeScale, timeScale, (ts) => UnityEngine.Time.timeScale = ts, duration, formula, loopsCount, loopType);
        }

        public Tween DoTimeScale(float timeScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTimeScale(timeScale, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
    }
}