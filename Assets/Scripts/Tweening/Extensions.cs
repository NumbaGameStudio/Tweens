using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Tweaks;
using Numba.Tweening.Engine;
using UnityEngine.UI;

namespace Numba.Tweening
{
    public static class Extensions
    {
        #region Transform
        #region Move
        #region Global
        #region X axis
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
        public static Tween DoPosition(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.World, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoLocalPosition(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.Self, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPosition(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoEulerAngles(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, Quaternion.Euler(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAngles(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, Vector3 eulerAngles, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, Quaternion.Euler(eulerAngles), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, Vector3 eulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAngles(transform, eulerAngles, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoLocalEulerAngles(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, Quaternion.Euler(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAngles(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, Vector3 localEulerAngles, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, Quaternion.Euler(localEulerAngles), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, Vector3 localEulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAngles(transform, localEulerAngles, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, new Vector3(uniformScale, uniformScale, uniformScale), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, uniformScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoAnchoredPositionX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition.x, x, (apx) => rectTransform.anchoredPosition = SetVectorValue(rectTransform.anchoredPosition, 0, apx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPositionX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPositionX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchoredPositionY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition.y, y, (apy) => rectTransform.anchoredPosition = SetVectorValue(rectTransform.anchoredPosition, 1, apy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPositionY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPositionY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition, new Vector2(x, y), (ap) => rectTransform.anchoredPosition = ap, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoAnchoredPosition3DX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.x, x, (ap3dx) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 0, ap3dx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3DX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.y, y, (ap3dy) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 1, ap3dy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3DY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DZ(this RectTransform rectTransform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.z, z, (ap3dz) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 2, ap3dz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DZ(this RectTransform rectTransform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3DZ(rectTransform, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D, new Vector3(x, y, z), (ap3d) => rectTransform.anchoredPosition3D = ap3d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchoredPosition3D(rectTransform, x, y, z, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoAnchorMaxX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax.x, x, (amx) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 0, amx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMaxX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMaxX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchorMaxY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax.y, y, (amy) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 1, amy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMaxY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMaxY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchorMax(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax, new Vector2(x, y), (am) => rectTransform.anchorMax = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMax(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMax(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoAnchorMinX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin.x, x, (amx) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 0, amx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMinX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMinX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchorMinY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin.y, y, (amy) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 1, amy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMinY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMinY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoAnchorMin(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin, new Vector2(x, y), (am) => rectTransform.anchorMin = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMin(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoAnchorMin(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoOffsetMaxX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax.x, x, (omx) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 0, omx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMaxX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMaxX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoOffsetMaxY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax.y, y, (omy) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 1, omy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMaxY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMaxY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoOffsetMax(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax, new Vector2(x, y), (om) => rectTransform.offsetMax = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMax(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMax(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoOffsetMinX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin.x, x, (omx) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 0, omx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMinX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMinX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoOffsetMinY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin.y, y, (omy) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 1, omy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMinY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMinY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoOffsetMin(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin, new Vector2(x, y), (om) => rectTransform.offsetMin = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMin(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoOffsetMin(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoPivotX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot.x, x, (px) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 0, px), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivotX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPivotX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoPivotY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot.y, y, (py) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 1, py), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivotY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPivotY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoPivot(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot, new Vector2(x, y), (p) => rectTransform.pivot = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivot(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPivot(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoSizeDeltaX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta.x, x, (sdx) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 0, sdx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDeltaX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSizeDeltaX(rectTransform, x, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoSizeDeltaY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta.y, y, (sdy) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 1, sdy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDeltaY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSizeDeltaY(rectTransform, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoSizeDelta(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta, new Vector2(x, y), (sd) => rectTransform.sizeDelta = sd, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDelta(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSizeDelta(rectTransform, x, y, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

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
        public static Tween DoColor(this Material material, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.color, color, (c) => material.color = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoColor(this Material material, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoColor(material, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoColor(this Material material, string name, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetColor(name), color, (c) => material.SetColor(name, c), duration, formula, loopsCount, loopType);
        }

        public static Tween DoColor(this Material material, string name, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoColor(material, name, color, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoMainTextureOffset(this Material material, Vector2 textureOffset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.mainTextureOffset, textureOffset, (to) => material.mainTextureOffset = to, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMainTextureOffset(this Material material, Vector2 textureOffset, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMainTextureOffset(material, textureOffset, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoMainTextureScale(this Material material, Vector2 textureScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.mainTextureScale, textureScale, (ts) => material.mainTextureScale = ts, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMainTextureScale(this Material material, Vector2 textureScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMainTextureScale(material, textureScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoTextureOffset(this Material material, string name, Vector2 textureOffset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetTextureOffset(name), textureOffset, (to) => material.SetTextureOffset(name, to), duration, formula, loopsCount, loopType);
        }

        public static Tween DoTextureOffset(this Material material, string name, Vector2 textureOffset, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTextureOffset(material, name, textureOffset, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoTextureScale(this Material material, string name, Vector2 textureScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetTextureOffset(name), textureScale, (ts) => material.SetTextureScale(name, ts), duration, formula, loopsCount, loopType);
        }

        public static Tween DoTextureScale(this Material material, string name, Vector2 textureScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTextureScale(material, name, textureScale, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoInt(this Material material, string name, int value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetInt(name), value, (i) => material.SetInt(name, i), duration, formula, loopsCount, loopType);
        }

        public static Tween DoInt(this Material material, string name, int value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoInt(material, name, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoFloat(this Material material, string name, float value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetFloat(name), value, (f) => material.SetFloat(name, f), duration, formula, loopsCount, loopType);
        }

        public static Tween DoFloat(this Material material, string name, int value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFloat(material, name, value, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoVector(this Material material, string name, Vector4 vector, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetVector(name), vector, (v) => material.SetVector(name, v), duration, formula, loopsCount, loopType);
        }

        public static Tween DoVector(this Material material, string name, Vector4 vector, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoVector(material, name, vector, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region AudioSource
        public static Tween DoVolume(this AudioSource audioSource, float volume, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.volume, volume, (v) => audioSource.volume = v, duration, formula, loopsCount, loopType);
        }

        public static Tween DoVolume(this AudioSource audioSource, float volume, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoVolume(audioSource, volume, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Camera
        public static Tween DoFieldOfView(this Camera camera, float fieldOfView, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.fieldOfView, fieldOfView, (fov) => camera.fieldOfView = fov, duration, formula, loopsCount, loopType);
        }

        public static Tween DoFieldOfView(this Camera camera, float fieldOfView, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoFieldOfView(camera, fieldOfView, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoRect(this Camera camera, Rect rect, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.rect, rect, (r) => camera.rect = r, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRect(this Camera camera, Rect rect, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRect(camera, rect, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region CanvasGroup
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
        public static Tween DoLineSpacing(this Text text, float spacing, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(text.lineSpacing, spacing, (s) => text.lineSpacing = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLineSpacing(this Text text, float spacing, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLineSpacing(text, spacing, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Image
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