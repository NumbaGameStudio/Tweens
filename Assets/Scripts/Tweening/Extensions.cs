using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Tweaks;
using UnityEngine.UI;
using UnityEngine.XR.WSA;

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
        #region Color
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
        public static Tween DoSetMatrix(this Material material, string name, Matrix4x4 matrix, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetMatrix(name), matrix, (m) => material.SetMatrix(name, m), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetMatrix(this Material material, string name, Matrix4x4 matrix, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetMatrix(material, name, matrix, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region SetPass
        public static Tween DoSetPass(this Material material, string name, int pass, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.FindPass(name), pass, (p) => material.SetPass(p), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSetPass(this Material material, string name, int pass, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoSetPass(material, name, pass, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        #region AudioSource
        #region DopplerLevel
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
        public static Tween DoTimeSamples(this AudioSource audioSource, int samples, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.timeSamples, samples, (s) => audioSource.timeSamples = s, duration, formula, loopsCount, loopType);
        }

        public static Tween DoTimeSamples(this AudioSource audioSource, int samples, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoTimeSamples(audioSource, samples, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Valume
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

        #region Collider
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