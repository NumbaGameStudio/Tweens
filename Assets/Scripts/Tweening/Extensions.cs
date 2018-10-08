using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Tweaks;
using UnityEngine.UI;
using UnityEngine.XR.WSA;

namespace Numba.Tweening
{
    /// <summary>
    /// Extensions for a lot of unity types.
    /// </summary>
    public static class Extensions
    {
        #region UnityEngine.Object
        /// <summary>
        /// Create and return tween which animate name of the object.
        /// </summary>
        /// <param name="obj">Target object.</param>
        /// <param name="name">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate object's name.</returns>
        public static Tween DoName(this UnityEngine.Object obj, string name, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(obj.name, name, (n) => obj.name = n, duration, formula, loopsCount, loopType);
        }

        public static Tween DoName(this UnityEngine.Object obj, string name, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoName(obj, name, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Transform
        #region Move
        #region Global
        #region X axis
        /// <summary>
        /// Create and return tween which move transform along global x axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global x axis' position.</returns>
        public static Tween DoPositionX(this Transform transform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.position.x, (px) => ChangeTransformPosition(transform, Space.World, 0, px), x, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPositionX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPositionX(transform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        /// <summary>
        /// Create and return tween which move transform along global y axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global y axis' position.</returns>
        public static Tween DoPositionY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.position.y, (py) => ChangeTransformPosition(transform, Space.World, 1, py), y, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPositionY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPositionY(transform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        /// <summary>
        /// Create and return tween which move transform along global z axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global z axis' position.</returns>
        public static Tween DoPositionZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.position.z, (pz) => ChangeTransformPosition(transform, Space.World, 2, pz), z, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPositionZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPositionZ(transform, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        /// <summary>
        /// Create and return tween which move transform in global space.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="z">Z axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global position.</returns>
        public static Tween DoPosition(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.World, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move transform in global space.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="position">Global position end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global position.</returns>
        public static Tween DoPosition(this Transform transform, Vector3 position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.World, position, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPosition(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, position, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Local
        #region X axis
        /// <summary>
        /// Create and return tween which move transform along local x axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local x axis' position.</returns>
        public static Tween DoLocalPositionX(this Transform transform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.localPosition.x, (lpx) => ChangeTransformPosition(transform, Space.Self, 0, lpx), x, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPositionX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPositionX(transform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        /// <summary>
        /// Create and return tween which move transform along local y axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local y axis' position.</returns>
        public static Tween DoLocalPositionY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.localPosition.y, (lpy) => ChangeTransformPosition(transform, Space.Self, 1, lpy), y, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPositionY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPositionY(transform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        /// <summary>
        /// Create and return tween which move transform along local z axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="z">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local z axis' position.</returns>
        public static Tween DoLocalPositionZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.localPosition.z, (lpz) => ChangeTransformPosition(transform, Space.Self, 2, lpz), z, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPositionZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPositionZ(transform, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        /// <summary>
        /// Create and return tween which move transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="z">Z axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local position.</returns>
        public static Tween DoLocalPosition(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.Self, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPosition(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="localPosition">Local position end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local position.</returns>
        public static Tween DoLocalPosition(this Transform transform, Vector3 localPosition, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.Self, localPosition, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPosition(this Transform transform, Vector3 localPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPosition(transform, localPosition, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        private static Tween DoPosition(Transform transform, Space space, Vector3 position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World)
                return Tween.Create(transform.position, position, (p) => transform.position = p, duration, formula, loopsCount, loopType);
            else
                return Tween.Create(transform.localPosition, position, (p) => transform.localPosition = p, duration, formula, loopsCount, loopType);
        }

        private static Tween DoMoveAlongAxis(Func<float> axisValueGetter, Action<float> axisValueSetter, float axisValue, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(axisValueGetter(), axisValue, axisValueSetter, duration, formula, loopsCount, loopType);
        }

        private static void ChangeTransformPosition(Transform transform, Space space, int axis, float value)
        {
            if (space == Space.World) transform.position = SetVectorValue(transform.position, axis, value);
            else transform.localPosition = SetVectorValue(transform.localPosition, axis, value);
        }
        #endregion

        #region Rotation
        #region Global
        #region X axis
        /// <summary>
        /// Create and return tween which rotate transform around global x axis.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global x axis euler angle.</returns>
        public static Tween DoEulerAnglesX(this Transform transform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.eulerAngles.x, x, (eax) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 0, eax), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAnglesX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAnglesX(transform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        /// <summary>
        /// Create and return tween which rotate transform around global y axis.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global y axis euler angle.</returns>
        public static Tween DoEulerAnglesY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.eulerAngles.y, y, (eay) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 1, eay), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAnglesY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAnglesY(transform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        /// <summary>
        /// Create and return tween which rotate transform around global z axis.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's global z axis euler angle.</returns>
        public static Tween DoEulerAnglesZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.eulerAngles.z, z, (eaz) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 2, eaz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAnglesZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAnglesZ(transform, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        /// <summary>
        /// Create and return tween which rotate transform in global space.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="z">Z axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which rotate transform in global space.</returns>
        public static Tween DoEulerAngles(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, Quaternion.Euler(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAngles(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which rotate transform in global space.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="eulerAngles">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which rotate transform in global space.</returns>
        public static Tween DoEulerAngles(this Transform transform, Vector3 eulerAngles, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, Quaternion.Euler(eulerAngles), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, Vector3 eulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAngles(transform, eulerAngles, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which rotate transform in global space.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="rotation">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which rotate transform in global space.</returns>
        public static Tween DoRotation(this Transform transform, Quaternion rotation, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, rotation, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRotation(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, rotation, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Local
        #region X axis
        /// <summary>
        /// Create and return tween which rotate transform around local x axis.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local x axis euler angle.</returns>
        public static Tween DoLocalEulerAnglesX(this Transform transform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.localEulerAngles.x, x, (leax) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 0, leax), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAnglesX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAnglesX(transform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        /// <summary>
        /// Create and return tween which rotate transform around local y axis.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local y axis euler angle.</returns>
        public static Tween DoLocalEulerAnglesY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.localEulerAngles.y, y, (leay) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 1, leay), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAnglesY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAnglesY(transform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        /// <summary>
        /// Create and return tween which rotate transform around local z axis.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local z axis euler angle.</returns>
        public static Tween DoLocalEulerAnglesZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.localEulerAngles.z, z, (leaz) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 2, leaz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAnglesZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAnglesZ(transform, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        /// <summary>
        /// Create and return tween which rotate transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="z">Z axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which rotate transform in local space.</returns>
        public static Tween DoLocalEulerAngles(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, Quaternion.Euler(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAngles(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which rotate transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="eulerAngles">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which rotate transform in local space.</returns>
        public static Tween DoLocalEulerAngles(this Transform transform, Vector3 localEulerAngles, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, Quaternion.Euler(localEulerAngles), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, Vector3 localEulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAngles(transform, localEulerAngles, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which rotate transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform</param>
        /// <param name="rotation">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which rotate transform in local space.</returns>
        public static Tween DoLocalRotation(this Transform transform, Quaternion localRotation, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, localRotation, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalRotation(this Transform transform, Quaternion localRotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalRotation(transform, localRotation, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        private static Tween DoRotateAroundAxis(Func<float> angleGetter, float axisValue, Action<float> angleSetter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(angleGetter(), axisValue, angleSetter, duration, formula, loopsCount, loopType);
        }

        private static Tween DoRotation(Transform transform, Space space, Quaternion rotation, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World)
                return Tween.Create(transform.rotation, rotation, (q) => transform.rotation = q, duration, formula, loopsCount, loopType);
            else
                return Tween.Create(transform.localRotation, rotation, (q) => transform.localRotation = q, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region Scale
        #region X axis
        /// <summary>
        /// Create and return tween which scale transform along local x axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local x axis' scale.</returns>
        public static Tween DoLocalScaleX(this Transform transform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale.x, x, (lsx) => transform.localScale = SetVectorValue(transform.localScale, 0, lsx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScaleX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleX(transform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        /// <summary>
        /// Create and return tween which scale transform along local y axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local y axis' scale.</returns>
        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale.y, y, (lsy) => transform.localScale = SetVectorValue(transform.localScale, 1, lsy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleY(transform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        /// <summary>
        /// Create and return tween which scale transform along local z axis.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local z axis' scale.</returns>
        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale.z, z, (lsz) => transform.localScale = SetVectorValue(transform.localScale, 2, lsz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleZ(transform, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        /// <summary>
        /// Create and return tween which scale transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="uniformScale">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local scale.</returns>
        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, new Vector3(uniformScale, uniformScale, uniformScale), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, uniformScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which scale transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="x">Y axis end value.</param>
        /// <param name="x">Z axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local scale.</returns>
        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which scale transform in local space.
        /// </summary>
        /// <param name="transform">Target tranform.</param>
        /// <param name="localScale">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate transform's local scale.</returns>
        public static Tween DoLocalScale(this Transform transform, Vector3 localScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale, localScale, (ls) => transform.localScale = ls, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, Vector3 localScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, localScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion
        #endregion

        #region RectTransform
        #region Anchored position
        /// <summary>
        /// Create and return tween which move rect transform anchored position along x axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored position x axis value.</returns>
        public static Tween DoAnchoredPositionX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition.x, x, (apx) => rectTransform.anchoredPosition = SetVectorValue(rectTransform.anchoredPosition, 0, apx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPositionX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPositionX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchored position along y axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored position y axis value.</returns>
        public static Tween DoAnchoredPositionY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition.y, y, (apy) => rectTransform.anchoredPosition = SetVectorValue(rectTransform.anchoredPosition, 1, apy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPositionY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPositionY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchored position.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored position.</returns>
        public static Tween DoAnchoredPosition(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition, new Vector2(x, y), (ap) => rectTransform.anchoredPosition = ap, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchored position.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="anchoredPosition">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored position.</returns>
        public static Tween DoAnchoredPosition(this RectTransform rectTransform, Vector2 anchoredPosition, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition, anchoredPosition, (ap) => rectTransform.anchoredPosition = ap, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, Vector2 anchoredPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition(rectTransform, anchoredPosition, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Anchored position 3D
        /// <summary>
        /// Create and return tween which move rect transform anchored 3D position along x axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored 3D position x axis value.</returns>
        public static Tween DoAnchoredPosition3DX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.x, x, (ap3dx) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 0, ap3dx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3DX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchored 3D position along y axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored 3D position y axis value.</returns>
        public static Tween DoAnchoredPosition3DY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.y, y, (ap3dy) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 1, ap3dy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3DY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchored 3D position along z axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="z">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored 3D position z axis value.</returns>
        public static Tween DoAnchoredPosition3DZ(this RectTransform rectTransform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.z, z, (ap3dz) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 2, ap3dz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DZ(this RectTransform rectTransform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3DZ(rectTransform, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchored 3D position.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="z">Z axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored 3D position.</returns>
        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D, new Vector3(x, y, z), (ap3d) => rectTransform.anchoredPosition3D = ap3d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3D(rectTransform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchored 3D position.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="anchoredPosition3D">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchored 3D position.</returns>
        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, Vector3 anchoredPosition3D, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D, anchoredPosition3D, (ap3d) => rectTransform.anchoredPosition3D = ap3d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, Vector3 anchoredPosition3D, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3D(rectTransform, anchoredPosition3D, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region AnchorMax
        /// <summary>
        /// Create and return tween which move rect transform anchor max value along x axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor max value along x axis.</returns>
        public static Tween DoAnchorMaxX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax.x, x, (amx) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 0, amx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMaxX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMaxX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchor max value along y axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor max value along y axis.</returns>
        public static Tween DoAnchorMaxY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax.y, y, (amy) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 1, amy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMaxY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMaxY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchor max value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor max value.</returns>
        public static Tween DoAnchorMax(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax, new Vector2(x, y), (am) => rectTransform.anchorMax = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMax(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMax(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchor max value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="anchorMax">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor max value.</returns>
        public static Tween DoAnchorMax(this RectTransform rectTransform, Vector2 anchorMax, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax, anchorMax, (am) => rectTransform.anchorMax = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMax(this RectTransform rectTransform, Vector2 anchorMax, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMax(rectTransform, anchorMax, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region AnchorMin
        /// <summary>
        /// Create and return tween which move rect transform anchor min value along x axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor min value along x axis.</returns>
        public static Tween DoAnchorMinX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin.x, x, (amx) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 0, amx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMinX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMinX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchor min value along y axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor min value along y axis.</returns>
        public static Tween DoAnchorMinY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin.y, y, (amy) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 1, amy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMinY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMinY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchor min value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor min value.</returns>
        public static Tween DoAnchorMin(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin, new Vector2(x, y), (am) => rectTransform.anchorMin = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMin(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMin(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform anchor min value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="anchorMin">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor min value.</returns>
        public static Tween DoAnchorMin(this RectTransform rectTransform, Vector2 anchorMin, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin, anchorMin, (am) => rectTransform.anchorMin = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMin(this RectTransform rectTransform, Vector2 anchorMin, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMin(rectTransform, anchorMin, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region OffsetMax
        /// <summary>
        /// Create and return tween which move rect transform offset max value along x axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform offset max value along x axis.</returns>
        public static Tween DoOffsetMaxX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax.x, x, (omx) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 0, omx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMaxX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMaxX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform offset max value along y axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform offset max value along y axis.</returns>
        public static Tween DoOffsetMaxY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax.y, y, (omy) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 1, omy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMaxY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMaxY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform offset max value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform offset max value.</returns>
        public static Tween DoOffsetMax(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax, new Vector2(x, y), (om) => rectTransform.offsetMax = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMax(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMax(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform offset max value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="offsetMax">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform offset max value.</returns>
        public static Tween DoOffsetMax(this RectTransform rectTransform, Vector2 offsetMax, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax, offsetMax, (om) => rectTransform.offsetMax = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMax(this RectTransform rectTransform, Vector2 offsetMax, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMax(rectTransform, offsetMax, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region OffsetMin
        /// <summary>
        /// Create and return tween which move rect transform offset min value along x axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform anchor offset value along x axis.</returns>
        public static Tween DoOffsetMinX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin.x, x, (omx) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 0, omx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMinX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMinX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform offset min value along y axis.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform offset min value along y axis.</returns>
        public static Tween DoOffsetMinY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin.y, y, (omy) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 1, omy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMinY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMinY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform offset min value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform offset min value.</returns>
        public static Tween DoOffsetMin(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin, new Vector2(x, y), (om) => rectTransform.offsetMin = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMin(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMin(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform offset min value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="offsetMin">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform offset min value.</returns>
        public static Tween DoOffsetMin(this RectTransform rectTransform, Vector2 offsetMin, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin, offsetMin, (om) => rectTransform.offsetMin = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMin(this RectTransform rectTransform, Vector2 offsetMin, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMin(rectTransform, offsetMin, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Pivot
        /// <summary>
        /// Create and return tween which move rect transform pivot x axis value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform pivot x axis value.</returns>
        public static Tween DoPivotX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot.x, x, (px) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 0, px), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivotX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPivotX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform pivot y axis value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform pivot y axis value.</returns>
        public static Tween DoPivotY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot.y, y, (py) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 1, py), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivotY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPivotY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform pivot.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform pivot.</returns>
        public static Tween DoPivot(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot, new Vector2(x, y), (p) => rectTransform.pivot = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivot(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPivot(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform pivot.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="pivot">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform pivot.</returns>
        public static Tween DoPivot(this RectTransform rectTransform, Vector2 pivot, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot, pivot, (p) => rectTransform.pivot = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivot(this RectTransform rectTransform, Vector2 pivot, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPivot(rectTransform, pivot, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SizeDelta
        /// <summary>
        /// Create and return tween which move rect transform size delta x axis value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform size delta x axis value.</returns>
        public static Tween DoSizeDeltaX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta.x, x, (sdx) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 0, sdx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDeltaX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSizeDeltaX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform size delta y axis value.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="y">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform size delta y axis value.</returns>
        public static Tween DoSizeDeltaY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta.y, y, (sdy) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 1, sdy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDeltaY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSizeDeltaY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform size delta.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="x">X axis end value.</param>
        /// <param name="y">Y axis end value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform size delta.</returns>
        public static Tween DoSizeDelta(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta, new Vector2(x, y), (sd) => rectTransform.sizeDelta = sd, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDelta(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSizeDelta(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        /// <summary>
        /// Create and return tween which move rect transform size delta.
        /// </summary>
        /// <param name="rectTransform">Target rect tranform.</param>
        /// <param name="sizeDelta">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate rect transform size delta.</returns>
        public static Tween DoSizeDelta(this RectTransform rectTransform, Vector2 sizeDelta, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta, sizeDelta, (sd) => rectTransform.sizeDelta = sd, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDelta(this RectTransform rectTransform, Vector2 sizeDelta, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSizeDelta(rectTransform, sizeDelta, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Material
        #region Color
        /// <summary>
        /// Create and return tween which animate material's color.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's color.</returns>
        public static Tween DoColor(this Material material, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.color, color, (c) => material.color = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoColor(this Material material, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoColor(material, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MainTextureOffset
        /// <summary>
        /// Create and return tween which animate material's main texture offset.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="textureOffset">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's main texture offset.</returns>
        public static Tween DoMainTextureOffset(this Material material, Vector2 textureOffset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.mainTextureOffset, textureOffset, (to) => material.mainTextureOffset = to, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMainTextureOffset(this Material material, Vector2 textureOffset, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMainTextureOffset(material, textureOffset, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MainTextureScale
        /// <summary>
        /// Create and return tween which animate material's main texture scale.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="textureScale">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's main texture scale.</returns>
        public static Tween DoMainTextureScale(this Material material, Vector2 textureScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.mainTextureScale, textureScale, (ts) => material.mainTextureScale = ts, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMainTextureScale(this Material material, Vector2 textureScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMainTextureScale(material, textureScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetTextureOffset
        /// <summary>
        /// Create and return tween which animate material's custom Texture offset.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="name">Custom texture name.</param>
        /// <param name="textureOffset">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's custom texture offset.</returns>
        public static Tween DoSetTextureOffset(this Material material, string name, Vector2 textureOffset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetTextureOffset(name), textureOffset, (to) => material.SetTextureOffset(name, to), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetTextureOffset(this Material material, string name, Vector2 textureOffset, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetTextureOffset(material, name, textureOffset, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetTextureScale
        /// <summary>
        /// Create and return tween which animate material's custom Texture scale.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="name">Custom texture name.</param>
        /// <param name="textureScale">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's custom texture scale.</returns>
        public static Tween DoSetTextureScale(this Material material, string name, Vector2 textureScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetTextureOffset(name), textureScale, (ts) => material.SetTextureScale(name, ts), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetTextureScale(this Material material, string name, Vector2 textureScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetTextureScale(material, name, textureScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region RenderQueue
        /// <summary>
        /// Create and return tween which animate material's render queue value.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="queue">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's render queue value.</returns>
        public static Tween DoRenderQueue(this Material material, int queue, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.renderQueue, queue, (q) => material.renderQueue = q, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRenderQueue(this Material material, int queue, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRenderQueue(material, queue, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetInt
        /// <summary>
        /// Create and return tween which animate material's custom Int value.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="name">Custom int value name.</param>
        /// <param name="value">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's custom int value.</returns>
        public static Tween DoSetInt(this Material material, string name, int value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetInt(name), value, (i) => material.SetInt(name, i), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetInt(this Material material, string name, int value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetInt(material, name, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetFloat
        /// <summary>
        /// Create and return tween which animate material's custom Float value.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="name">Custom float value name.</param>
        /// <param name="value">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's custom float value.</returns>
        public static Tween DoSetFloat(this Material material, string name, float value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetFloat(name), value, (f) => material.SetFloat(name, f), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetFloat(this Material material, string name, int value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetFloat(material, name, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetVector
        /// <summary>
        /// Create and return tween which animate material's custom Vector4 value.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="name">Custom Vector4 value name.</param>
        /// <param name="vector">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's custom Vector4 value.</returns>
        public static Tween DoSetVector(this Material material, string name, Vector4 vector, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetVector(name), vector, (v) => material.SetVector(name, v), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetVector(this Material material, string name, Vector4 vector, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetVector(material, name, vector, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetColor
        /// <summary>
        /// Create and return tween which animate material's custom Color value.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="name">Custom Color value name.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's custom Color value.</returns>
        public static Tween DoSetColor(this Material material, string name, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetColor(name), color, (c) => material.SetColor(name, c), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetColor(this Material material, string name, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetColor(material, name, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetMatrix4x4
        /// <summary>
        /// Create and return tween which animate material's custom Matrix4x4 value.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="name">Custom Matrix4x4 value name.</param>
        /// <param name="matrix">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate material's custom Matrix4x4 value.</returns>
        public static Tween DoSetMatrix(this Material material, string name, Matrix4x4 matrix, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetMatrix(name), matrix, (m) => material.SetMatrix(name, m), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetMatrix(this Material material, string name, Matrix4x4 matrix, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetMatrix(material, name, matrix, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region AudioSource
        #region DopplerLevel
        /// <summary>
        /// Create and return tween which animate audio source's doppler level.
        /// </summary>
        /// <param name="material">Target material.</param>
        /// <param name="level">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's doppler level.</returns>
        public static Tween DoDopplerLevel(this AudioSource audioSource, float level, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.dopplerLevel, level, (l) => audioSource.dopplerLevel = l, duration, formula, loopsCount, loopType);
        }

        public static Tween DoDopplerLevel(this AudioSource audioSource, float level, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoDopplerLevel(audioSource, level, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MaxDistance
        /// <summary>
        /// Create and return tween which animate audio source's max distance.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's max distance.</returns>
        public static Tween DoMaxDistance(this AudioSource audioSource, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.maxDistance, distance, (d) => audioSource.maxDistance = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMaxDistance(this AudioSource audioSource, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMaxDistance(audioSource, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MinDistance
        /// <summary>
        /// Create and return tween which animate audio source's min distance.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's min distance.</returns>
        public static Tween DoMinDistance(this AudioSource audioSource, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.minDistance, distance, (d) => audioSource.minDistance = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMinDistance(this AudioSource audioSource, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMinDistance(audioSource, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region PanStereo
        /// <summary>
        /// Create and return tween which animate audio source's stereo panning.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="stereo">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's stereo panning.</returns>
        public static Tween DoPanStereo(this AudioSource audioSource, float stereo, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.panStereo, stereo, (s) => audioSource.panStereo = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPanStereo(this AudioSource audioSource, float stereo, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPanStereo(audioSource, stereo, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Pitch
        /// <summary>
        /// Create and return tween which animate audio source's pitch value.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="pitch">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's pitch value.</returns>
        public static Tween DoPitch(this AudioSource audioSource, float pitch, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.pitch, pitch, (p) => audioSource.pitch = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPitch(this AudioSource audioSource, float pitch, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPitch(audioSource, pitch, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Priority
        /// <summary>
        /// Create and return tween which animate audio source's priority value.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="priority">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's priority value.</returns>
        public static Tween DoPriority(this AudioSource audioSource, int priority, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.priority, priority, (p) => audioSource.priority = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPriority(this AudioSource audioSource, int priority, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPriority(audioSource, priority, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ReverbZoneMix
        /// <summary>
        /// Create and return tween which animate audio source's reverb zone mix value.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="mix">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's reverb zone mix value.</returns>
        public static Tween DoReverbZoneMix(this AudioSource audioSource, float mix, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.reverbZoneMix, mix, (m) => audioSource.reverbZoneMix = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoReverbZoneMix(this AudioSource audioSource, float mix, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoReverbZoneMix(audioSource, mix, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SpatialBlend
        /// <summary>
        /// Create and return tween which animate audio source's spatial blending value.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="blend">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's spatial blending value.</returns>
        public static Tween DoSpatialBlend(this AudioSource audioSource, float blend, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.spatialBlend, blend, (b) => audioSource.spatialBlend = b, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSpatialBlend(this AudioSource audioSource, float blend, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSpatialBlend(audioSource, blend, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Spread
        /// <summary>
        /// Create and return tween which animate audio source's spread value.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="spread">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's spread value.</returns>
        public static Tween DoSpread(this AudioSource audioSource, float spread, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.spread, spread, (s) => audioSource.spread = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSpread(this AudioSource audioSource, float spread, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSpread(audioSource, spread, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Time
        /// <summary>
        /// Create and return tween which animate audio source's time value.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="time">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's time value.</returns>
        public static Tween DoTime(this AudioSource audioSource, float time, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.time, time, (t) => audioSource.time = t, duration, formula, loopsCount, loopType);
        }

        public static Tween DoTime(this AudioSource audioSource, float time, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTime(audioSource, time, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region TimeSamples
        /// <summary>
        /// Create and return tween which animate audio source's time samples value.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="samples">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's time samples value.</returns>
        public static Tween DoTimeSamples(this AudioSource audioSource, int samples, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.timeSamples, samples, (s) => audioSource.timeSamples = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoTimeSamples(this AudioSource audioSource, int samples, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTimeSamples(audioSource, samples, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Volume
        /// <summary>
        /// Create and return tween which animate audio source's volume.
        /// </summary>
        /// <param name="audioSource">Target audio source.</param>
        /// <param name="volume">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate audio source's volume.</returns>
        public static Tween DoVolume(this AudioSource audioSource, float volume, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.volume, volume, (v) => audioSource.volume = v, duration, formula, loopsCount, loopType);
        }

        public static Tween DoVolume(this AudioSource audioSource, float volume, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoVolume(audioSource, volume, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Camera
        #region Aspect
        /// <summary>
        /// Create and return tween which animate camera's aspect value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="aspect">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's aspect value.</returns>
        public static Tween DoAspect(this Camera camera, float aspect, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.aspect, aspect, (a) => camera.aspect = a, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAspect(this Camera camera, float aspect, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAspect(camera, aspect, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region BackgroundColor
        /// <summary>
        /// Create and return tween which animate camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's background color.</returns>
        public static Tween DoBackgroundColor(this Camera camera, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.backgroundColor, color, (c) => camera.backgroundColor = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoBackgroundColor(this Camera camera, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoBackgroundColor(camera, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CullingMask
        /// <summary>
        /// Create and return tween which animate camera's culling mask value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="mask">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's culling mask value.</returns>
        public static Tween DoCullingMask(this Camera camera, int mask, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.cullingMask, mask, (m) => camera.cullingMask = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCullingMask(this Camera camera, int mask, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCullingMask(camera, mask, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CullingMatrix
        /// <summary>
        /// Create and return tween which animate camera's culling matrix.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="matrix">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's culling matrix.</returns>
        public static Tween DoCullingMatrix(this Camera camera, Matrix4x4 matrix, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.cullingMatrix, matrix, (m) => camera.cullingMatrix = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCullingMatrix(this Camera camera, Matrix4x4 matrix, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCullingMatrix(camera, matrix, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Depth
        /// <summary>
        /// Create and return tween which animate camera's depth value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="depth">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's depth value.</returns>
        public static Tween DoDepth(this Camera camera, float depth, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.depth, depth, (d) => camera.depth = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoDepth(this Camera camera, float depth, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoDepth(camera, depth, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region EventMask
        /// <summary>
        /// Create and return tween which animate camera's event mask value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="mask">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's event mask value.</returns>
        public static Tween DoEventMask(this Camera camera, int mask, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.eventMask, mask, (m) => camera.eventMask = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoEventMask(this Camera camera, int mask, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEventMask(camera, mask, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region FarClipPlane
        /// <summary>
        /// Create and return tween which animate camera's far clip plane value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's far clip plane value.</returns>
        public static Tween DoFarClipPlane(this Camera camera, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.farClipPlane, distance, (d) => camera.farClipPlane = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoFarClipPlane(this Camera camera, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFarClipPlane(camera, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region FieldOfView
        /// <summary>
        /// Create and return tween which animate camera's field of view value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="fieldOfView">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's field of view value.</returns>
        public static Tween DoFieldOfView(this Camera camera, float fieldOfView, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.fieldOfView, fieldOfView, (fov) => camera.fieldOfView = fov, duration, formula, loopsCount, loopType);
        }

        public static Tween DoFieldOfView(this Camera camera, float fieldOfView, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFieldOfView(camera, fieldOfView, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region FocalLength
        /// <summary>
        /// Create and return tween which animate camera's focal length value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="length">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's focal length value.</returns>
        public static Tween DoFocalLength(this Camera camera, float length, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.focalLength, length, (l) => camera.focalLength = l, duration, formula, loopsCount, loopType);
        }

        public static Tween DoFocalLength(this Camera camera, float length, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFocalLength(camera, length, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region LensShift
        /// <summary>
        /// Create and return tween which animate camera's lens shift value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="shift">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's lens shift value.</returns>
        public static Tween DoLensShift(this Camera camera, Vector2 shift, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.lensShift, shift, (s) => camera.lensShift = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLensShift(this Camera camera, Vector2 shift, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLensShift(camera, shift, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region NearClipPlane
        /// <summary>
        /// Create and return tween which animate camera's near clip plane value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's near clip plane value.</returns>
        public static Tween DoNearClipPlane(this Camera camera, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.nearClipPlane, distance, (d) => camera.nearClipPlane = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNearClipPlane(this Camera camera, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNearClipPlane(camera, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region NonJitteredProjectionMatrix
        /// <summary>
        /// Create and return tween which animate camera's non jittered projection matrix.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="matrix">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's non jittered projection matrix.</returns>
        public static Tween DoNonJitteredProjectionMatrix(this Camera camera, Matrix4x4 matrix, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.nonJitteredProjectionMatrix, matrix, (m) => camera.nonJitteredProjectionMatrix = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNonJitteredProjectionMatrix(this Camera camera, Matrix4x4 matrix, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNonJitteredProjectionMatrix(camera, matrix, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region OrthographicSize
        /// <summary>
        /// Create and return tween which animate camera's orthographic size.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's orthographic size.</returns>
        public static Tween DoOrthographicSize(this Camera camera, float size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.orthographicSize, size, (s) => camera.orthographicSize = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOrthographicSize(this Camera camera, float size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOrthographicSize(camera, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ProjectionMatrix
        /// <summary>
        /// Create and return tween which animate camera's projection matrix.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="matrix">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's projection matrix.</returns>
        public static Tween DoProjectionMatrix(this Camera camera, Matrix4x4 matrix, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.projectionMatrix, matrix, (m) => camera.projectionMatrix = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoProjectionMatrix(this Camera camera, Matrix4x4 matrix, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoProjectionMatrix(camera, matrix, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Rect
        /// <summary>
        /// Create and return tween which animate camera's rect.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="rect">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's rect.</returns>
        public static Tween DoRect(this Camera camera, Rect rect, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.rect, rect, (r) => camera.rect = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRect(this Camera camera, Rect rect, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRect(camera, rect, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SensorSize
        /// <summary>
        /// Create and return tween which animate camera's sensor size.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's sensor size.</returns>
        public static Tween DoSensorSize(this Camera camera, Vector2 size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.sensorSize, size, (s) => camera.sensorSize = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSensorSize(this Camera camera, Vector2 size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSensorSize(camera, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region StereoConvergence
        /// <summary>
        /// Create and return tween which animate camera's stereo convergence value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="convergence">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's stereo convergence value.</returns>
        public static Tween DoStereoConvergence(this Camera camera, float convergence, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.stereoConvergence, convergence, (c) => camera.stereoConvergence = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoStereoConvergence(this Camera camera, float convergence, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoStereoConvergence(camera, convergence, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region StereoSeparation
        /// <summary>
        /// Create and return tween which animate camera's stereo separation value.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="separation">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's stereo separation value.</returns>
        public static Tween DoStereoSeparation(this Camera camera, float separation, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.stereoSeparation, separation, (s) => camera.stereoSeparation = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoStereoSeparation(this Camera camera, float convergence, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoStereoSeparation(camera, convergence, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region TargetDisplay
        /// <summary>
        /// Create and return tween which animate camera's target display index.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="display">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's target display index.</returns>
        public static Tween DoTargetDisplay(this Camera camera, int display, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.targetDisplay, display, (d) => camera.targetDisplay = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoTargetDisplay(this Camera camera, int display, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTargetDisplay(camera, display, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region TransparencySortAxis
        /// <summary>
        /// Create and return tween which animate camera's transparency sort axis.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="axis">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's transparency sort axis.</returns>
        public static Tween DoTransparencySortAxis(this Camera camera, Vector3 axis, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.transparencySortAxis, axis, (a) => camera.transparencySortAxis = a, duration, formula, loopsCount, loopType);
        }

        public static Tween DoTransparencySortAxis(this Camera camera, Vector3 axis, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTransparencySortAxis(camera, axis, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region WorldToCameraMatrix
        /// <summary>
        /// Create and return tween which animate camera's world to camera matrix.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="matrix">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate camera's world to camera matrix.</returns>
        public static Tween DoWorldToCameraMatrix(this Camera camera, Matrix4x4 matrix, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.worldToCameraMatrix, matrix, (m) => camera.worldToCameraMatrix = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoWorldToCameraMatrix(this Camera camera, Matrix4x4 matrix, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoWorldToCameraMatrix(camera, matrix, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region CanvasGroup
        /// <summary>
        /// Create and return tween which animate canvas group's alpha value.
        /// </summary>
        /// <param name="canvasGroup">Target canvas group.</param>
        /// <param name="alpha">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate canvas group's alpha value.</returns>
        public static Tween DoAlpha(this CanvasGroup canvasGroup, float alpha, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(canvasGroup.alpha, alpha, (a) => canvasGroup.alpha = a, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAlpha(this CanvasGroup canvasGroup, float alpha, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAlpha(canvasGroup, alpha, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Graphic
        /// <summary>
        /// Create and return tween which animate graphic's base color.
        /// </summary>
        /// <param name="graphic">Target graphic.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate graphic's base color.</returns>
        public static Tween DoColor(this Graphic graphic, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(graphic.color, color, (c) => graphic.color = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoColor(this Graphic graphic, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoColor(graphic, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Text
        #region FontSize
        /// <summary>
        /// Create and return tween which animate text component's font size.
        /// </summary>
        /// <param name="text">Target text component.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate text component's font size.</returns>
        public static Tween DoFontSize(this Text text, int size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(text.fontSize, size, (s) => text.fontSize = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoFontSize(this Text text, int size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFontSize(text, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region LineSpacing
        /// <summary>
        /// Create and return tween which animate text component's line spacing.
        /// </summary>
        /// <param name="text">Target text component.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate text component's line spacing.</returns>
        public static Tween DoLineSpacing(this Text text, float spacing, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(text.lineSpacing, spacing, (s) => text.lineSpacing = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLineSpacing(this Text text, float spacing, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLineSpacing(text, spacing, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Text
        /// <summary>
        /// Create and return tween which animate text component's text (symbols) value.
        /// </summary>
        /// <param name="text">Target text component.</param>
        /// <param name="targetText">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate text component's text (symbols) value.</returns>
        public static Tween DoText(this Text text, string targetText, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(text.text, targetText, (t) => text.text = t, duration, formula, loopsCount, loopType);
        }

        public static Tween DoText(this Text text, string targetText, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoText(text, targetText, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Image
        /// <summary>
        /// Create and return tween which animate image's fill amount.
        /// </summary>
        /// <param name="image">Target image.</param>
        /// <param name="amount">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate image's fill amount.</returns>
        public static Tween DoFillAmount(this Image image, float amount, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(image.fillAmount, amount, (a) => image.fillAmount = a, duration, formula, loopsCount, loopType);
        }

        public static Tween DoFillAmount(this Image image, float amount, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFillAmount(image, amount, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Selectable
        /// <summary>
        /// Create and return tween which animate selectable's colors.
        /// </summary>
        /// <param name="selectable">Target selectable.</param>
        /// <param name="colors">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate selectable's colors.</returns>
        public static Tween DoColors(this Selectable selectable, ColorBlock colors, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(selectable.colors, colors, (cs) => selectable.colors = cs, duration, formula, loopsCount, loopType);
        }

        public static Tween DoColors(this Selectable selectable, ColorBlock colors, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoColors(selectable, colors, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Slider
        #region MinValue
        /// <summary>
        /// Create and return tween which animate slider's min value.
        /// </summary>
        /// <param name="slider">Target slider.</param>
        /// <param name="min">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate slider's min value.</returns>
        public static Tween DoMinValue(this Slider slider, float min, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(slider.minValue, min, (mv) => slider.minValue = mv, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMinValue(this Slider slider, float min, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMinValue(slider, min, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MaxValue
        /// <summary>
        /// Create and return tween which animate slider's max value.
        /// </summary>
        /// <param name="slider">Target slider.</param>
        /// <param name="max">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate slider's max value.</returns>
        public static Tween DoMaxValue(this Slider slider, float max, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(slider.maxValue, max, (mv) => slider.maxValue = mv, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMaxValue(this Slider slider, float max, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMaxValue(slider, max, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region NormalizedValue
        /// <summary>
        /// Create and return tween which animate slider's normalized value.
        /// </summary>
        /// <param name="slider">Target slider.</param>
        /// <param name="value">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate slider's normalized value.</returns>
        public static Tween DoNormalizedValue(this Slider slider, float value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(slider.normalizedValue, value, (nv) => slider.normalizedValue = nv, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNormalizedValue(this Slider slider, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNormalizedValue(slider, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Value
        /// <summary>
        /// Create and return tween which animate slider's value (handle position).
        /// </summary>
        /// <param name="slider">Target slider.</param>
        /// <param name="value">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate slider's value (handle position).</returns>
        public static Tween DoValue(this Slider slider, float value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(slider.value, value, (nv) => slider.value = nv, duration, formula, loopsCount, loopType);
        }

        public static Tween DoValue(this Slider slider, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoValue(slider, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Scrollbar
        #region NumberOfSteps
        /// <summary>
        /// Create and return tween which animate scrollbar's number of steps.
        /// </summary>
        /// <param name="scrollbar">Target scrollbar.</param>
        /// <param name="steps">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scrollbar's number of steps.</returns>
        public static Tween DoNumberOfSteps(this Scrollbar scrollbar, int steps, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollbar.numberOfSteps, steps, (s) => scrollbar.numberOfSteps = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNumberOfSteps(this Scrollbar scrollbar, int steps, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNumberOfSteps(scrollbar, steps, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Size
        /// <summary>
        /// Create and return tween which animate scrollbar's size.
        /// </summary>
        /// <param name="scrollbar">Target scrollbar.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scrollbar's size.</returns>
        public static Tween DoSize(this Scrollbar scrollbar, float size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollbar.size, size, (s) => scrollbar.size = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSize(this Scrollbar scrollbar, float size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSize(scrollbar, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Value
        /// <summary>
        /// Create and return tween which animate scrollbar's value (handle position).
        /// </summary>
        /// <param name="scrollbar">Target scrollbar.</param>
        /// <param name="value">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scrollbar's value (handle position).</returns>
        public static Tween DoValue(this Scrollbar scrollbar, float value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollbar.value, value, (v) => scrollbar.value = v, duration, formula, loopsCount, loopType);
        }

        public static Tween DoValue(this Scrollbar scrollbar, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoValue(scrollbar, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Dropdown
        /// <summary>
        /// Create and return tween which animate dropdown's value index.
        /// </summary>
        /// <param name="dropdown">Target dropdown.</param>
        /// <param name="value">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate dropdown's value index.</returns>
        public static Tween DoValue(this Dropdown dropdown, int value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(dropdown.value, value, (v) => dropdown.value = v, duration, formula, loopsCount, loopType);
        }

        public static Tween DoValue(this Dropdown dropdown, int value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoValue(dropdown, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region InputField
        #region CaretBlinkRate
        /// <summary>
        /// Create and return tween which animate input field's caret blink rate value.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="rate">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's caret blink rate value.</returns>
        public static Tween DoCaretBlinkRate(this InputField inputField, float rate, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.caretBlinkRate, rate, (r) => inputField.caretBlinkRate = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCaretBlinkRate(this InputField inputField, float rate, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCaretBlinkRate(inputField, rate, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CaretColor
        /// <summary>
        /// Create and return tween which animate input field's caret color.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's caret color.</returns>
        public static Tween DoCaretColor(this InputField inputField, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.caretColor, color, (c) => inputField.caretColor = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCaretColor(this InputField inputField, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCaretColor(inputField, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CaretPosition
        /// <summary>
        /// Create and return tween which animate input field's caret position.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="position">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's caret position.</returns>
        public static Tween DoCaretPosition(this InputField inputField, int position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.caretPosition, position, (p) => inputField.caretPosition = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCaretPosition(this InputField inputField, int position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCaretPosition(inputField, position, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CaretWidth
        /// <summary>
        /// Create and return tween which animate input field's caret width.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="width">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's caret width.</returns>
        public static Tween DoCaretWidth(this InputField inputField, int width, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.caretWidth, width, (w) => inputField.caretWidth = w, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCaretWidth(this InputField inputField, int width, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCaretWidth(inputField, width, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CharacterLimit
        /// <summary>
        /// Create and return tween which animate input field's character limit value.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="limit">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's character limit value.</returns>
        public static Tween DoCharacterLimit(this InputField inputField, int limit, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.characterLimit, limit, (l) => inputField.characterLimit = l, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCharacterLimit(this InputField inputField, int limit, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCharacterLimit(inputField, limit, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SelectionAnchorPosition
        /// <summary>
        /// Create and return tween which animate input field's selection anchor position.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="position">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's selection anchor position.</returns>
        public static Tween DoSelectionAnchorPosition(this InputField inputField, int position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.selectionAnchorPosition, position, (p) => inputField.selectionAnchorPosition = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSelectionAnchorPosition(this InputField inputField, int position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSelectionAnchorPosition(inputField, position, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SelectionColor
        /// <summary>
        /// Create and return tween which animate input field's selection color.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's selection color.</returns>
        public static Tween DoSelectionColor(this InputField inputField, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.selectionColor, color, (c) => inputField.selectionColor = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSelectionColor(this InputField inputField, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSelectionColor(inputField, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SelectionFocusPosition
        /// <summary>
        /// Create and return tween which animate input field's selection focus position.
        /// </summary>
        /// <param name="inputField">Target input field.</param>
        /// <param name="position">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate inputField's selection focus position.</returns>
        public static Tween DoSelectionFocusPosition(this InputField inputField, int position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(inputField.selectionFocusPosition, position, (p) => inputField.selectionFocusPosition = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSelectionFocusPosition(this InputField inputField, int position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSelectionFocusPosition(inputField, position, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region ScrollRect
        #region DecelerationRate
        /// <summary>
        /// Create and return tween which animate scroll rect's deceleration rate.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="rate">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's deceleration rate.</returns>
        public static Tween DoDecelerationRate(this ScrollRect scrollRect, float rate, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.decelerationRate, rate, (r) => scrollRect.decelerationRate = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoDecelerationRate(this ScrollRect scrollRect, float rate, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoDecelerationRate(scrollRect, rate, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Elasticity
        /// <summary>
        /// Create and return tween which animate scroll rect's elasticity.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="elasticity">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's elasticity.</returns>
        public static Tween DoElasticity(this ScrollRect scrollRect, float elasticity, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.elasticity, elasticity, (e) => scrollRect.elasticity = e, duration, formula, loopsCount, loopType);
        }

        public static Tween DoElasticity(this ScrollRect scrollRect, float elasticity, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoElasticity(scrollRect, elasticity, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region HorizontalNormalizedPosition
        /// <summary>
        /// Create and return tween which animate scroll rect's horizontal normalized position.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="position">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's horizontal normalized position.</returns>
        public static Tween DoHorizontalNormalizedPosition(this ScrollRect scrollRect, float position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.horizontalNormalizedPosition, position, (p) => scrollRect.horizontalNormalizedPosition = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoHorizontalNormalizedPosition(this ScrollRect scrollRect, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoHorizontalNormalizedPosition(scrollRect, position, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region HorizontalScrollbarSpacing
        /// <summary>
        /// Create and return tween which animate scroll rect's horizontal scrollbar spacing.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="space">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's horizontal scrollbar spacing.</returns>
        public static Tween DoHorizontalScrollbarSpacing(this ScrollRect scrollRect, float space, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.horizontalScrollbarSpacing, space, (p) => scrollRect.horizontalScrollbarSpacing = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoHorizontalScrollbarSpacing(this ScrollRect scrollRect, float space, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoHorizontalScrollbarSpacing(scrollRect, space, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region NormalizedPosition
        /// <summary>
        /// Create and return tween which animate scroll rect's normalized position.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="position">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's normalized position.</returns>
        public static Tween DoNormalizedPosition(this ScrollRect scrollRect, Vector2 position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.normalizedPosition, position, (p) => scrollRect.normalizedPosition = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNormalizedPosition(this ScrollRect scrollRect, Vector2 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNormalizedPosition(scrollRect, position, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ScrollSensitivity
        /// <summary>
        /// Create and return tween which animate scroll rect's scroll sensetivity.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="sensitivity">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's scroll sensetivity.</returns>
        public static Tween DoScrollSensitivity(this ScrollRect scrollRect, float sensitivity, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.scrollSensitivity, sensitivity, (s) => scrollRect.scrollSensitivity = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoScrollSensitivity(this ScrollRect scrollRect, float sensitivity, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoScrollSensitivity(scrollRect, sensitivity, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region VerticalNormalizedPosition
        /// <summary>
        /// Create and return tween which animate scroll rect's vertical normalized position.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="position">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's vertical normalized position.</returns>
        public static Tween DoVerticalNormalizedPosition(this ScrollRect scrollRect, float position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.verticalNormalizedPosition, position, (p) => scrollRect.verticalNormalizedPosition = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoVerticalNormalizedPosition(this ScrollRect scrollRect, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoVerticalNormalizedPosition(scrollRect, position, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region VerticalScrollbarSpacing
        /// <summary>
        /// Create and return tween which animate scroll rect's vertical scrollbar spacing.
        /// </summary>
        /// <param name="scrollRect">Target scroll rect.</param>
        /// <param name="space">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate scroll rect's vertical scrollbar spacing.</returns>
        public static Tween DoVerticalScrollbarSpacing(this ScrollRect scrollRect, float space, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(scrollRect.verticalScrollbarSpacing, space, (p) => scrollRect.verticalScrollbarSpacing = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoVerticalScrollbarSpacing(this ScrollRect scrollRect, float space, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoVerticalScrollbarSpacing(scrollRect, space, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Collider
        /// <summary>
        /// Create and return tween which animate collider's contact offset value.
        /// </summary>
        /// <param name="collider">Target collider.</param>
        /// <param name="offset">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate collider's contact offset value.</returns>
        public static Tween DoContactOffset(this Collider collider, float offset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.contactOffset, offset, (o) => collider.contactOffset = o, duration, formula, loopsCount, loopType);
        }

        public static Tween DoContactOffset(this Collider collider, float offset, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoContactOffset(collider, offset, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region BoxCollider
        #region Center
        /// <summary>
        /// Create and return tween which animate box collider's center.
        /// </summary>
        /// <param name="collider">Target box collider.</param>
        /// <param name="center">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate box collider's center.</returns>
        public static Tween DoCenter(this BoxCollider collider, Vector3 center, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.center, center, (c) => collider.center = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCenter(this BoxCollider collider, Vector3 center, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCenter(collider, center, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Size
        /// <summary>
        /// Create and return tween which animate box collider's size.
        /// </summary>
        /// <param name="collider">Target box collider.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate box collider's size.</returns>
        public static Tween DoSize(this BoxCollider collider, Vector3 size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.size, size, (s) => collider.size = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSize(this BoxCollider collider, Vector3 size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSize(collider, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region CapsuleCollider
        #region Center
        /// <summary>
        /// Create and return tween which animate capsule collider's center.
        /// </summary>
        /// <param name="collider">Target capsule collider.</param>
        /// <param name="center">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate capsule collider's center.</returns>
        public static Tween DoCenter(this CapsuleCollider collider, Vector3 center, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.center, center, (c) => collider.center = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCenter(this CapsuleCollider collider, Vector3 center, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCenter(collider, center, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Height
        /// <summary>
        /// Create and return tween which animate capsule collider's height.
        /// </summary>
        /// <param name="collider">Target capsule collider.</param>
        /// <param name="height">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate capsule collider's height.</returns>
        public static Tween DoHeight(this CapsuleCollider collider, float height, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.height, height, (h) => collider.height = h, duration, formula, loopsCount, loopType);
        }

        public static Tween DoHeight(this CapsuleCollider collider, float height, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoHeight(collider, height, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Radius
        /// <summary>
        /// Create and return tween which animate capsule collider's radius.
        /// </summary>
        /// <param name="collider">Target capsule collider.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate capsule collider's radius.</returns>
        public static Tween DoRadius(this CapsuleCollider collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.radius, radius, (r) => collider.radius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRadius(this CapsuleCollider collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region SphereCollider
        #region Center
        /// <summary>
        /// Create and return tween which animate sphere collider's center.
        /// </summary>
        /// <param name="collider">Target sphere collider.</param>
        /// <param name="center">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate sphere collider's center.</returns>
        public static Tween DoCenter(this SphereCollider collider, Vector3 center, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.center, center, (c) => collider.center = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCenter(this SphereCollider collider, Vector3 center, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCenter(collider, center, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Radius
        /// <summary>
        /// Create and return tween which animate sphere collider's radius.
        /// </summary>
        /// <param name="collider">Target sphere collider.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate sphere collider's radius.</returns>
        public static Tween DoRadius(this SphereCollider collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.radius, radius, (r) => collider.radius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRadius(this SphereCollider collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region WheelCollider
        #region BrakeTorque
        /// <summary>
        /// Create and return tween which animate wheel collider's brake torque.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="torque">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's brake torque.</returns>
        public static Tween DoBrakeTorque(this WheelCollider collider, float torque, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.brakeTorque, torque, (bt) => collider.brakeTorque = bt, duration, formula, loopsCount, loopType);
        }

        public static Tween DoBrakeTorque(this WheelCollider collider, float torque, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoBrakeTorque(collider, torque, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Center
        /// <summary>
        /// Create and return tween which animate wheel collider's center.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="center">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's center.</returns>
        public static Tween DoCenter(this WheelCollider collider, Vector3 center, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.center, center, (c) => collider.center = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCenter(this WheelCollider collider, Vector3 center, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCenter(collider, center, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ForceAppPointDistance
        /// <summary>
        /// Create and return tween which animate wheel collider's force app point distance value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's force app point distance value.</returns>
        public static Tween DoForceAppPointDistance(this WheelCollider collider, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.forceAppPointDistance, distance, (bt) => collider.forceAppPointDistance = bt, duration, formula, loopsCount, loopType);
        }

        public static Tween DoForceAppPointDistance(this WheelCollider collider, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoForceAppPointDistance(collider, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ForwardFriction
        /// <summary>
        /// Create and return tween which animate wheel collider's forward friction value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="friction">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's forward friction value.</returns>
        public static Tween DoForwardFriction(this WheelCollider collider, WheelFrictionCurve friction, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.forwardFriction, friction, (f) => collider.forwardFriction = f, duration, formula, loopsCount, loopType);
        }

        public static Tween DoForwardFriction(this WheelCollider collider, WheelFrictionCurve friction, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoForwardFriction(collider, friction, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Mass
        /// <summary>
        /// Create and return tween which animate wheel collider's mass value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="mass">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's mass value.</returns>
        public static Tween DoMass(this WheelCollider collider, float mass, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.mass, mass, (m) => collider.mass = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMass(this WheelCollider collider, float mass, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMass(collider, mass, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region MotorTorque
        /// <summary>
        /// Create and return tween which animate wheel collider's motor torque value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="torque">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's motor torque value.</returns>
        public static Tween DoMotorTorque(this WheelCollider collider, float torque, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.motorTorque, torque, (t) => collider.motorTorque = t, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMotorTorque(this WheelCollider collider, float torque, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMotorTorque(collider, torque, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Radius
        /// <summary>
        /// Create and return tween which animate wheel collider's radius.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's radius.</returns>
        public static Tween DoRadius(this WheelCollider collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.radius, radius, (r) => collider.radius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRadius(this WheelCollider collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SidewayFriction
        /// <summary>
        /// Create and return tween which animate wheel collider's sideway friction value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="friction">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's sideway friction value.</returns>
        public static Tween DoSidewayFriction(this WheelCollider collider, WheelFrictionCurve friction, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.sidewaysFriction, friction, (f) => collider.sidewaysFriction = f, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSidewayFriction(this WheelCollider collider, WheelFrictionCurve friction, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSidewayFriction(collider, friction, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SteerAngle
        /// <summary>
        /// Create and return tween which animate wheel collider's steer angle.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="angle">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's steer angle.</returns>
        public static Tween DoSteerAngle(this WheelCollider collider, float angle, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.steerAngle, angle, (a) => collider.steerAngle = a, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSteerAngle(this WheelCollider collider, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSteerAngle(collider, angle, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SuspensionDistance
        /// <summary>
        /// Create and return tween which animate wheel collider's suspension distance value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's suspension distance value.</returns>
        public static Tween DoSuspensionDistance(this WheelCollider collider, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.suspensionDistance, distance, (d) => collider.suspensionDistance = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSuspensionDistance(this WheelCollider collider, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSuspensionDistance(collider, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SuspensionSpring
        /// <summary>
        /// Create and return tween which animate wheel collider's suspension spring value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="spring">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's suspension spring value.</returns>
        public static Tween DoSuspensionSpring(this WheelCollider collider, JointSpring spring, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.suspensionSpring, spring, (s) => collider.suspensionSpring = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSuspensionSpring(this WheelCollider collider, JointSpring spring, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSuspensionSpring(collider, spring, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region WheelDampingRate
        /// <summary>
        /// Create and return tween which animate wheel collider's wheel damping rate value.
        /// </summary>
        /// <param name="collider">Target wheel collider.</param>
        /// <param name="rate">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate wheel collider's wheel damping rate value.</returns>
        public static Tween DoWheelDampingRate(this WheelCollider collider, float rate, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.wheelDampingRate, rate, (r) => collider.wheelDampingRate = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoWheelDampingRate(this WheelCollider collider, float rate, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoWheelDampingRate(collider, rate, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region SpatialMappingBase
        #region HalfBoxExtents
        /// <summary>
        /// Create and return tween which animate spatial mapping base's half box extents.
        /// </summary>
        /// <param name="collider">Target spatial mapping base.</param>
        /// <param name="extents">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate spatial mapping base's half box extents.</returns>
        public static Tween DoHalfBoxExtents(this SpatialMappingBase collider, Vector3 extents, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.halfBoxExtents, extents, (e) => collider.halfBoxExtents = e, duration, formula, loopsCount, loopType);
        }

        public static Tween DoHalfBoxExtents(this SpatialMappingBase collider, Vector3 extents, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoHalfBoxExtents(collider, extents, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region NumUpdatesBeforeRemoval
        /// <summary>
        /// Create and return tween which animate spatial mapping base's number updates before removal.
        /// </summary>
        /// <param name="collider">Target spatial mapping base.</param>
        /// <param name="updates">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate spatial mapping base's number updates before removal.</returns>
        public static Tween DoNumUpdatesBeforeRemoval(this SpatialMappingBase collider, int updates, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.numUpdatesBeforeRemoval, updates, (u) => collider.numUpdatesBeforeRemoval = u, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNumUpdatesBeforeRemoval(this SpatialMappingBase collider, int updates, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNumUpdatesBeforeRemoval(collider, updates, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SecondsBetweenUpdates
        /// <summary>
        /// Create and return tween which animate spatial mapping base's seconds between updates.
        /// </summary>
        /// <param name="collider">Target spatial mapping base.</param>
        /// <param name="seconds">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate spatial mapping base's seconds between updates.</returns>
        public static Tween DoSecondsBetweenUpdates(this SpatialMappingBase collider, float seconds, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.secondsBetweenUpdates, seconds, (s) => collider.secondsBetweenUpdates = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSecondsBetweenUpdates(this SpatialMappingBase collider, float seconds, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSecondsBetweenUpdates(collider, seconds, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SphereRadius
        /// <summary>
        /// Create and return tween which animate spatial mapping base's sphere radius.
        /// </summary>
        /// <param name="collider">Target spatial mapping base.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate spatial mapping base's sphere radius.</returns>
        public static Tween DoSphereRadius(this SpatialMappingBase collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.sphereRadius, radius, (r) => collider.sphereRadius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSphereRadius(this SpatialMappingBase collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSphereRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Collider2D
        #region Density
        /// <summary>
        /// Create and return tween which animate 2D collider's density value.
        /// </summary>
        /// <param name="collider">Target 2D collider.</param>
        /// <param name="density">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D collider's density value.</returns>
        public static Tween DoDensity(this Collider2D collider, float density, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.density, density, (d) => collider.density = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoDensity(this Collider2D collider, float density, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoDensity(collider, density, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Offset
        /// <summary>
        /// Create and return tween which animate 2D collider's offset value.
        /// </summary>
        /// <param name="collider">Target 2D collider.</param>
        /// <param name="density">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D collider's offset value.</returns>
        public static Tween DoOffset(this Collider2D collider, Vector2 offset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.offset, offset, (o) => collider.offset = o, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffset(this Collider2D collider, Vector2 offset, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffset(collider, offset, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region BoxCollider2D
        #region EdgeRadius
        /// <summary>
        /// Create and return tween which animate 2D box collider's edge radius.
        /// </summary>
        /// <param name="collider">Target 2D box collider.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D box collider's edge radius.</returns>
        public static Tween DoEdgeRadius(this BoxCollider2D collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.edgeRadius, radius, (r) => collider.edgeRadius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoEdgeRadius(this BoxCollider2D collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEdgeRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Size
        /// <summary>
        /// Create and return tween which animate 2D box collider's size value.
        /// </summary>
        /// <param name="collider">Target 2D box collider.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D box collider's size value.</returns>
        public static Tween DoSize(this BoxCollider2D collider, Vector2 size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.size, size, (s) => collider.size = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSize(this BoxCollider2D collider, Vector2 size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSize(collider, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region CapsuleCollider2D
        /// <summary>
        /// Create and return tween which animate 2D capsule collider's size value.
        /// </summary>
        /// <param name="collider">Target 2D capsule collider.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D capsule collider's size value.</returns>
        public static Tween DoSize(this CapsuleCollider2D collider, Vector2 size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.size, size, (s) => collider.size = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSize(this CapsuleCollider2D collider, Vector2 size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSize(collider, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CircleCollider2D
        /// <summary>
        /// Create and return tween which animate 2D circle collider's radius.
        /// </summary>
        /// <param name="collider">Target 2D circle collider.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D circle collider's radius.</returns>
        public static Tween DoRadius(this CircleCollider2D collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.radius, radius, (r) => collider.radius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRadius(this CircleCollider2D collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CompositeCollider2D
        #region EdgeRadius
        /// <summary>
        /// Create and return tween which animate 2D composite collider's edge radius.
        /// </summary>
        /// <param name="collider">Target 2D composite collider.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D composite collider's edge radius.</returns>
        public static Tween DoEdgeRadius(this CompositeCollider2D collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.edgeRadius, radius, (r) => collider.edgeRadius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoEdgeRadius(this CompositeCollider2D collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEdgeRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region VertexDistance
        /// <summary>
        /// Create and return tween which animate 2D composite collider's vertex distance.
        /// </summary>
        /// <param name="collider">Target 2D composite collider.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D composite collider's vertex distance.</returns>
        public static Tween DoVertexDistance(this CompositeCollider2D collider, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.vertexDistance, distance, (d) => collider.vertexDistance = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoVertexDistance(this CompositeCollider2D collider, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoVertexDistance(collider, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region EdgeCollider2D
        /// <summary>
        /// Create and return tween which animate 2D edge collider's edge radius.
        /// </summary>
        /// <param name="collider">Target 2D edge collider.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D edge collider's edge radius.</returns>
        public static Tween DoEdgeRadius(this EdgeCollider2D collider, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.edgeRadius, radius, (r) => collider.edgeRadius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoEdgeRadius(this EdgeCollider2D collider, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEdgeRadius(collider, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region PolygonCollider2D
        /// <summary>
        /// Create and return tween which animate 2D polygon collider's path count value.
        /// </summary>
        /// <param name="collider">Target 2D polygon collider.</param>
        /// <param name="count">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D polygon collider's path count value.</returns>
        public static Tween DoPathCount(this PolygonCollider2D collider, int count, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(collider.pathCount, count, (c) => collider.pathCount = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPathCount(this PolygonCollider2D collider, int count, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPathCount(collider, count, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Light
        #region AreaSize
        /// <summary>
        /// Create and return tween which animate light's area size.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's area size.</returns>
        public static Tween DoAreaSize(this Light light, Vector2 size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.areaSize, size, (s) => light.areaSize = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAreaSize(this Light light, Vector2 size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAreaSize(light, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region BounceIntensity
        /// <summary>
        /// Create and return tween which animate light's bounce intensity value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="intensity">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's bounce intensity value.</returns>
        public static Tween DoBounceIntensity(this Light light, float intensity, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.bounceIntensity, intensity, (i) => light.bounceIntensity = i, duration, formula, loopsCount, loopType);
        }

        public static Tween DoBounceIntensity(this Light light, float intensity, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoBounceIntensity(light, intensity, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Color
        /// <summary>
        /// Create and return tween which animate light's color.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's color.</returns>
        public static Tween DoColor(this Light light, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.color, color, (c) => light.color = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoColor(this Light light, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoColor(light, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ColorTemperature
        /// <summary>
        /// Create and return tween which animate light's color temperature.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="temperature">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's color temperature.</returns>
        public static Tween DoColorTemperature(this Light light, float temperature, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.colorTemperature, temperature, (t) => light.colorTemperature = t, duration, formula, loopsCount, loopType);
        }

        public static Tween DoColorTemperature(this Light light, float temperature, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoColorTemperature(light, temperature, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CoockieSize
        /// <summary>
        /// Create and return tween which animate light's coockie size value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="size">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's coockie size value.</returns>
        public static Tween DoCoockieSize(this Light light, float size, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.cookieSize, size, (t) => light.cookieSize = t, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCoockieSize(this Light light, float size, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCoockieSize(light, size, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CullingMask
        /// <summary>
        /// Create and return tween which animate light's culling mask value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="mask">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's culling mask value.</returns>
        public static Tween DoCullingMask(this Light light, int mask, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.cullingMask, mask, (m) => light.cullingMask = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoCullingMask(this Light light, int mask, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoCullingMask(light, mask, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Intensity
        /// <summary>
        /// Create and return tween which animate light's intensity.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="intensity">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's intensity.</returns>
        public static Tween DoIntensity(this Light light, float intensity, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.intensity, intensity, (i) => light.intensity = i, duration, formula, loopsCount, loopType);
        }

        public static Tween DoIntensity(this Light light, float intensity, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoIntensity(light, intensity, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Range
        /// <summary>
        /// Create and return tween which animate light's range value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="range">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's range value.</returns>
        public static Tween DoRange(this Light light, float range, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.range, range, (r) => light.range = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRange(this Light light, float range, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRange(light, range, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ShadowAngle
        /// <summary>
        /// Create and return tween which animate light's shadow angle.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="angle">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow angle.</returns>
        public static Tween DoShadowAngle(this Light light, float angle, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.shadowAngle, angle, (a) => light.shadowAngle = a, duration, formula, loopsCount, loopType);
        }

        public static Tween DoShadowAngle(this Light light, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoShadowAngle(light, angle, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ShadowBias
        /// <summary>
        /// Create and return tween which animate light's shadow bias.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="bias">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow bias.</returns>
        public static Tween DoShadowBias(this Light light, float bias, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.shadowBias, bias, (b) => light.shadowBias = b, duration, formula, loopsCount, loopType);
        }

        public static Tween DoShadowBias(this Light light, float bias, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoShadowBias(light, bias, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ShadowCustomResolution
        /// <summary>
        /// Create and return tween which animate light's shadow custom resolution value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="resolution">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow custom resolution value.</returns>
        public static Tween DoShadowCustomResolution(this Light light, int resolution, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.shadowCustomResolution, resolution, (r) => light.shadowCustomResolution = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoShadowCustomResolution(this Light light, int resolution, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoShadowCustomResolution(light, resolution, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ShadowNearPlane
        /// <summary>
        /// Create and return tween which animate light's shadow near plane value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="distance">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow near plane value.</returns>
        public static Tween DoShadowNearPlane(this Light light, float distance, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.shadowNearPlane, distance, (d) => light.shadowNearPlane = d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoShadowNearPlane(this Light light, float distance, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoShadowNearPlane(light, distance, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ShadowNormalBias
        /// <summary>
        /// Create and return tween which animate light's shadow normal bias value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="bias">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow normal bias value.</returns>
        public static Tween DoShadowNormalBias(this Light light, float bias, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.shadowNormalBias, bias, (b) => light.shadowNormalBias = b, duration, formula, loopsCount, loopType);
        }

        public static Tween DoShadowNormalBias(this Light light, float bias, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoShadowNormalBias(light, bias, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ShadowRadius
        /// <summary>
        /// Create and return tween which animate light's shadow radius.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="radius">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow radius.</returns>
        public static Tween DoShadowRadius(this Light light, float radius, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.shadowRadius, radius, (r) => light.shadowRadius = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoShadowRadius(this Light light, float radius, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoShadowRadius(light, radius, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ShadowStrength
        /// <summary>
        /// Create and return tween which animate light's shadow strenght.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="strenght">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow strenght.</returns>
        public static Tween DoShadowStrength(this Light light, float strenght, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.shadowStrength, strenght, (s) => light.shadowStrength = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoShadowStrength(this Light light, float strenght, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoShadowStrength(light, strenght, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SpotAngle
        /// <summary>
        /// Create and return tween which animate light's spot angle value.
        /// </summary>
        /// <param name="light">Target light.</param>
        /// <param name="angle">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate light's shadow spot angle value.</returns>
        public static Tween DoSpotAngle(this Light light, float angle, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(light.spotAngle, angle, (a) => light.spotAngle = a, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSpotAngle(this Light light, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSpotAngle(light, angle, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region LineRenderer
        #region EndColor
        /// <summary>
        /// Create and return tween which animate line renderer's end color.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's end color.</returns>
        public static Tween DoEndColor(this LineRenderer renderer, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.endColor, color, (c) => renderer.endColor = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoEndColor(this LineRenderer renderer, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEndColor(renderer, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region EndWidth
        /// <summary>
        /// Create and return tween which animate line renderer's end width.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="width">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's end width.</returns>
        public static Tween DoEndWidth(this LineRenderer renderer, float width, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.endWidth, width, (w) => renderer.endWidth = w, duration, formula, loopsCount, loopType);
        }

        public static Tween DoEndWidth(this LineRenderer renderer, float width, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEndWidth(renderer, width, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region NumCapVertices
        /// <summary>
        /// Create and return tween which animate line renderer's number of cap vertices.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="vertices">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's number of cap vertices.</returns>
        public static Tween DoNumCapVertices(this LineRenderer renderer, int vertices, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.numCapVertices, vertices, (v) => renderer.numCapVertices = v, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNumCapVertices(this LineRenderer renderer, int vertices, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNumCapVertices(renderer, vertices, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region NumCornerVertices
        /// <summary>
        /// Create and return tween which animate line renderer's number of corner vertices.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="vertices">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's number of corner vertices.</returns>
        public static Tween DoNumCornerVertices(this LineRenderer renderer, int vertices, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.numCornerVertices, vertices, (v) => renderer.numCornerVertices = v, duration, formula, loopsCount, loopType);
        }

        public static Tween DoNumCornerVertices(this LineRenderer renderer, int vertices, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoNumCornerVertices(renderer, vertices, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region PositionCount
        /// <summary>
        /// Create and return tween which animate line renderer's position count value.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="count">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's position count value.</returns>
        public static Tween DoPositionCount(this LineRenderer renderer, int count, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.positionCount, count, (c) => renderer.positionCount = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPositionCount(this LineRenderer renderer, int count, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPositionCount(renderer, count, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region StartColor
        /// <summary>
        /// Create and return tween which animate line renderer's start color.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="color">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's start color.</returns>
        public static Tween DoStartColor(this LineRenderer renderer, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.startColor, color, (c) => renderer.startColor = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoStartColor(this LineRenderer renderer, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoStartColor(renderer, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region StartWidth
        /// <summary>
        /// Create and return tween which animate line renderer's start width.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="width">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's start width.</returns>
        public static Tween DoStartWidth(this LineRenderer renderer, float width, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.startWidth, width, (w) => renderer.startWidth = w, duration, formula, loopsCount, loopType);
        }

        public static Tween DoStartWidth(this LineRenderer renderer, float width, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoStartWidth(renderer, width, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region WidthMultiplier
        /// <summary>
        /// Create and return tween which animate line renderer's width multiplier value.
        /// </summary>
        /// <param name="renderer">Target line renderer.</param>
        /// <param name="multiplier">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate line renderer's start width multiplier value.</returns>
        public static Tween DoWidthMultiplier(this LineRenderer renderer, float multiplier, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(renderer.widthMultiplier, multiplier, (m) => renderer.widthMultiplier = m, duration, formula, loopsCount, loopType);
        }

        public static Tween DoWidthMultiplier(this LineRenderer renderer, float multiplier, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoWidthMultiplier(renderer, multiplier, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region PhysicMaterial
        #region Bounciness
        /// <summary>
        /// Create and return tween which animate physic material's bounciness value.
        /// </summary>
        /// <param name="material">Target physic material.</param>
        /// <param name="bounciness">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate physic material's bounciness value.</returns>
        public static Tween DoBounciness(this PhysicMaterial material, float bounciness, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.bounciness, bounciness, (b) => material.bounciness = b, duration, formula, loopsCount, loopType);
        }

        public static Tween DoBounciness(this PhysicMaterial material, float bounciness, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoBounciness(material, bounciness, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region DynamicFriction
        /// <summary>
        /// Create and return tween which animate physic material's dynamic friction.
        /// </summary>
        /// <param name="material">Target physic material.</param>
        /// <param name="friction">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate physic material's dynamic friction.</returns>
        public static Tween DoDynamicFriction(this PhysicMaterial material, float friction, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.dynamicFriction, friction, (f) => material.dynamicFriction = f, duration, formula, loopsCount, loopType);
        }

        public static Tween DoDynamicFriction(this PhysicMaterial material, float friction, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoDynamicFriction(material, friction, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region StaticFriction
        /// <summary>
        /// Create and return tween which animate physic material's static friction.
        /// </summary>
        /// <param name="material">Target physic material.</param>
        /// <param name="friction">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate physic material's static friction.</returns>
        public static Tween DoStaticFriction(this PhysicMaterial material, float friction, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.staticFriction, friction, (f) => material.staticFriction = f, duration, formula, loopsCount, loopType);
        }

        public static Tween DoStaticFriction(this PhysicMaterial material, float friction, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoStaticFriction(material, friction, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region PhysicsMaterial2D
        #region Bounciness
        /// <summary>
        /// Create and return tween which animate 2D physics material's bounciness value.
        /// </summary>
        /// <param name="material">Target 2D physics material.</param>
        /// <param name="bounciness">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D physics material's bounciness value.</returns>
        public static Tween DoBounciness(this PhysicsMaterial2D material, float bounciness, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.bounciness, bounciness, (b) => material.bounciness = b, duration, formula, loopsCount, loopType);
        }

        public static Tween DoBounciness(this PhysicsMaterial2D material, float bounciness, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoBounciness(material, bounciness, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Friction
        /// <summary>
        /// Create and return tween which animate 2D physics material's friction.
        /// </summary>
        /// <param name="material">Target 2D physics material.</param>
        /// <param name="friction">End value.</param>
        /// <param name="duration">Tween duration.</param>
        /// <param name="formula"> Tween formula for easing.</param>
        /// <param name="loopsCount">Tween loops count.</param>
        /// <param name="loopType">Tween loop type for cycling.</param>
        /// <returns>Tween which animate 2D physics material's friction.</returns>
        public static Tween DoFriction(this PhysicsMaterial2D material, float friction, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.friction, friction, (f) => material.friction = f, duration, formula, loopsCount, loopType);
        }

        public static Tween DoFriction(this PhysicsMaterial2D material, float friction, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFriction(material, friction, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        private static Vector2 SetVectorValue(Vector2 vector2, int axis, float value)
        {
            vector2[axis] = value;
            return vector2;
        }

        private static Vector3 SetVectorValue(Vector3 vector3, int axis, float value)
        {
            vector3[axis] = value;
            return vector3;
        }

        private static Vector4 SetVectorValue(Vector4 vector4, int axis, float value)
        {
            vector4[axis] = value;
            return vector4;
        }
    }
}