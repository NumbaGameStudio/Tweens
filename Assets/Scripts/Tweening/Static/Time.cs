using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens.Static
{
    /// <summary>
    /// Represent time extension methods.
    /// </summary>
	public sealed class Time
    {
        #region TimeScale
        /// <summary>
        /// Create tween for <c>Time.timeScale</c>.
        /// </summary>
        /// <param name="timeScale">Target timeScale.</param>
        /// <param name="duration">Tween Duration.</param>
        /// <param name="formula">Tween formula.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Tween for <c>Time.timeScale</c> with passed parameters.</returns>
        public Tween DoTimeScale(float timeScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.timeScale, timeScale, (ts) => UnityEngine.Time.timeScale = ts, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for <c>Time.timeScale</c>.
        /// </summary>
        /// <param name="timeScale">Target timeScale.</param>
        /// <param name="duration">Tween Duration.</param>
        /// <param name="ease">Tween ease type associated with formula.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Tween for <c>Time.timeScale</c> with passed parameters.</returns>
        public Tween DoTimeScale(float timeScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTimeScale(timeScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MaximumDeltaTime
        /// <summary>
        /// Create tween for <c>Time.maximumDeltaTime</c>.
        /// </summary>
        /// <param name="maximumDeltaTime">Target maximumDeltaTime.</param>
        /// <param name="duration">Tween Duration.</param>
        /// <param name="formula">Tween formula.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Tween for <c>Time.maximumDeltaTime</c> with passed parameters.</returns>
        public Tween DoMaximumDeltaTime(float maximumDeltaTime, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.maximumDeltaTime, maximumDeltaTime, (t) => UnityEngine.Time.maximumDeltaTime = t, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for <c>Time.maximumDeltaTime</c>.
        /// </summary>
        /// <param name="maximumDeltaTime">Target maximumDeltaTime.</param>
        /// <param name="duration">Tween Duration.</param>
        /// <param name="ease">Tween ease type associated with formula.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Tween for <c>Time.maximumDeltaTime</c> with passed parameters.</returns>
        public Tween DoMaximumDeltaTime(float maximumDeltaTime, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMaximumDeltaTime(maximumDeltaTime, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MaximumParticleDeltaTime
        /// <summary>
        /// Create tween for <c>Time.maximumParticleDeltaTime</c>.
        /// </summary>
        /// <param name="maximumParticleDeltaTime">Target maximumParticleDeltaTime.</param>
        /// <param name="duration">Tween Duration.</param>
        /// <param name="formula">Tween formula.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Tween for <c>Time.maximumParticleDeltaTime</c> with passed parameters.</returns>
        public Tween DoMaximumParticleDeltaTime(float maximumParticleDeltaTime, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.maximumParticleDeltaTime, maximumParticleDeltaTime, (t) => UnityEngine.Time.maximumParticleDeltaTime = t, duration, formula, loopsCount, loopType);
        }

        /// <summary>
        /// Create tween for <c>Time.maximumParticleDeltaTime</c>.
        /// </summary>
        /// <param name="maximumParticleDeltaTime">Target maximumParticleDeltaTime.</param>
        /// <param name="duration">Tween Duration.</param>
        /// <param name="ease">Tween ease type associated with formula.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type.</param>
        /// <returns>Tween for <c>Time.maximumParticleDeltaTime</c> with passed parameters.</returns>
        public Tween DoMaximumParticleDeltaTime(float maximumParticleDeltaTime, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMaximumParticleDeltaTime(maximumParticleDeltaTime, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
    }
}