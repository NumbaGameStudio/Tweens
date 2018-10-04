using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening.Static
{
	public sealed class Time
    {
        #region TimeScale
        public Tween DoTimeScale(float timeScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.timeScale, timeScale, (ts) => UnityEngine.Time.timeScale = ts, duration, formula, loopsCount, loopType);
        }

        public Tween DoTimeScale(float timeScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTimeScale(timeScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MaximumDeltaTime
        public Tween DoMaximumDeltaTime(float time, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.maximumDeltaTime, time, (t) => UnityEngine.Time.maximumDeltaTime = t, duration, formula, loopsCount, loopType);
        }

        public Tween DoMaximumDeltaTime(float time, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMaximumDeltaTime(time, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MaximumParticleDeltaTime
        public Tween DoMaximumParticleDeltaTime(float time, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.maximumParticleDeltaTime, time, (t) => UnityEngine.Time.maximumParticleDeltaTime = t, duration, formula, loopsCount, loopType);
        }

        public Tween DoMaximumParticleDeltaTime(float time, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMaximumParticleDeltaTime(time, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
    }
}