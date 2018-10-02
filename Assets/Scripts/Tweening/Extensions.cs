using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Tweaks;
using Numba.Tweening.Engine;

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
            return DoPositionX(transform, x, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        public static Tween DoPositionY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.position.y, (py) => ChangeTransformPosition(transform, Space.World, 1, py), y, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPositionY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPositionY(transform, y, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        public static Tween DoPositionZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.position.z, (pz) => ChangeTransformPosition(transform, Space.World, 2, pz), z, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPositionZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPositionZ(transform, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        public static Tween DoPosition(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.World, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, x, y, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoPosition(this Transform transform, Vector3 position, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.World, position, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPosition(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, position, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
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
            return DoLocalPositionX(transform, x, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        public static Tween DoLocalPositionY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.localPosition.y, (lpy) => ChangeTransformPosition(transform, Space.Self, 1, lpy), y, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPositionY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPositionY(transform, y, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        public static Tween DoLocalPositionZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoMoveAlongAxis(() => transform.localPosition.z, (lpz) => ChangeTransformPosition(transform, Space.Self, 2, lpz), z, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPositionZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPositionZ(transform, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        public static Tween DoLocalPosition(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.Self, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPosition(transform, x, y, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoLocalPosition(this Transform transform, Vector3 localPosition, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoPosition(transform, Space.Self, localPosition, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalPosition(this Transform transform, Vector3 localPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalPosition(transform, localPosition, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
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
            return DoEulerAnglesX(transform, x, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        public static Tween DoEulerAnglesY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.eulerAngles.y, y, (eay) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 1, eay), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAnglesY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAnglesY(transform, y, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        public static Tween DoEulerAnglesZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.eulerAngles.z, z, (eaz) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 2, eaz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAnglesZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAnglesZ(transform, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        public static Tween DoEulerAngles(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, Quaternion.Euler(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAngles(transform, x, y, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, Vector3 eulerAngles, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, Quaternion.Euler(eulerAngles), duration, formula, loopsCount, loopType);
        }

        public static Tween DoEulerAngles(this Transform transform, Vector3 eulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoEulerAngles(transform, eulerAngles, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoRotation(this Transform transform, Quaternion rotation, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.World, rotation, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRotation(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, rotation, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
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
            return DoLocalEulerAnglesX(transform, x, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        public static Tween DoLocalEulerAnglesY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.localEulerAngles.y, y, (leay) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 1, leay), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAnglesY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAnglesY(transform, y, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        public static Tween DoLocalEulerAnglesZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotateAroundAxis(() => transform.localEulerAngles.z, z, (leaz) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 2, leaz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAnglesZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAnglesZ(transform, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        public static Tween DoLocalEulerAngles(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, Quaternion.Euler(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAngles(transform, x, y, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, Vector3 localEulerAngles, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, Quaternion.Euler(localEulerAngles), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalEulerAngles(this Transform transform, Vector3 localEulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalEulerAngles(transform, localEulerAngles, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoLocalRotation(this Transform transform, Quaternion localRotation, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotation(transform, Space.Self, localRotation, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalRotation(this Transform transform, Quaternion localRotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalRotation(transform, localRotation, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
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
            return DoLocalScaleX(transform, x, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Y axis
        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale.y, y, (lsy) => transform.localScale = SetVectorValue(transform.localScale, 1, lsy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleY(transform, y, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Z axis
        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale.z, z, (lsz) => transform.localScale = SetVectorValue(transform.localScale, 2, lsz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleZ(transform, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region XYZ axis
        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, new Vector3(uniformScale, uniformScale, uniformScale), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, uniformScale, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, new Vector3(x, y, z), duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, x, y, z, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, Vector3 localScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale, localScale, (ls) => transform.localScale = ls, duration, formula, loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, Vector3 localScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScale(transform, localScale, duration, FormulasUtility.GetFormula(ease), loopsCount, loopType);
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

        public static Tween DoAnchoredPositionY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition.y, y, (apy) => rectTransform.anchoredPosition = SetVectorValue(rectTransform.anchoredPosition, 1, apy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition, new Vector2(x, y), (ap) => rectTransform.anchoredPosition = ap, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, Vector2 anchoredPosition, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition, anchoredPosition, (ap) => rectTransform.anchoredPosition = ap, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region Anchored position 3D
        public static Tween DoAnchoredPosition3DX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.x, x, (ap3dx) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 0, ap3dx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.y, y, (ap3dy) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 1, ap3dy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3DZ(this RectTransform rectTransform, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D.z, z, (ap3dz) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 2, ap3dz), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, float x, float y, float z, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D, new Vector3(x, y, z), (ap3d) => rectTransform.anchoredPosition3D = ap3d, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, Vector3 anchoredPosition3D, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchoredPosition3D, anchoredPosition3D, (ap3d) => rectTransform.anchoredPosition3D = ap3d, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region AnchorMax
        public static Tween DoAnchorMaxX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax.x, x, (amx) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 0, amx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMaxY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax.y, y, (amy) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 1, amy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMax(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax, new Vector2(x, y), (am) => rectTransform.anchorMax = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMax(this RectTransform rectTransform, Vector2 anchorMax, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMax, anchorMax, (am) => rectTransform.anchorMax = am, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region AnchorMin
        public static Tween DoAnchorMinX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin.x, x, (amx) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 0, amx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMinY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin.y, y, (amy) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 1, amy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMin(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin, new Vector2(x, y), (am) => rectTransform.anchorMin = am, duration, formula, loopsCount, loopType);
        }

        public static Tween DoAnchorMin(this RectTransform rectTransform, Vector2 anchorMin, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.anchorMin, anchorMin, (am) => rectTransform.anchorMin = am, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region OffsetMax
        public static Tween DoOffsetMaxX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax.x, x, (omx) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 0, omx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMaxY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax.y, y, (omy) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 1, omy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMax(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax, new Vector2(x, y), (om) => rectTransform.offsetMax = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMax(this RectTransform rectTransform, Vector2 offsetMax, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMax, offsetMax, (om) => rectTransform.offsetMax = om, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region OffsetMin
        public static Tween DoOffsetMinX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin.x, x, (omx) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 0, omx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMinY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin.y, y, (omy) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 1, omy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMin(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin, new Vector2(x, y), (om) => rectTransform.offsetMin = om, duration, formula, loopsCount, loopType);
        }

        public static Tween DoOffsetMin(this RectTransform rectTransform, Vector2 offsetMin, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.offsetMin, offsetMin, (om) => rectTransform.offsetMin = om, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region Pivot
        public static Tween DoPivotX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot.x, x, (px) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 0, px), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivotY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot.y, y, (py) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 1, py), duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivot(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot, new Vector2(x, y), (p) => rectTransform.pivot = p, duration, formula, loopsCount, loopType);
        }

        public static Tween DoPivot(this RectTransform rectTransform, Vector2 pivot, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.pivot, pivot, (p) => rectTransform.pivot = p, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region SizeDelta
        public static Tween DoSizeDeltaX(this RectTransform rectTransform, float x, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta.x, x, (sdx) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 0, sdx), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDeltaY(this RectTransform rectTransform, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta.y, y, (sdy) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 1, sdy), duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDelta(this RectTransform rectTransform, float x, float y, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta, new Vector2(x, y), (sd) => rectTransform.sizeDelta = sd, duration, formula, loopsCount, loopType);
        }

        public static Tween DoSizeDelta(this RectTransform rectTransform, Vector2 sizeDelta, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(rectTransform.sizeDelta, sizeDelta, (sd) => rectTransform.sizeDelta = sd, duration, formula, loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Material
        public static Tween DoColor(this Material material, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.color, color, (c) => material.color = c, duration, formula, loopsCount, loopType);
        }

        public static Tween DoColor(this Material material, string name, Color color, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetColor(name), color, (c) => material.SetColor(name, c), duration, formula, loopsCount, loopType);
        }

        public static Tween DoMainTextureOffset(this Material material, Vector2 textureOffset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.mainTextureOffset, textureOffset, (to) => material.mainTextureOffset = to, duration, formula, loopsCount, loopType);
        }

        public static Tween DoMainTextureScale(this Material material, Vector2 textureScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.mainTextureScale, textureScale, (ts) => material.mainTextureScale = ts, duration, formula, loopsCount, loopType);
        }

        public static Tween DoTextureOffset(this Material material, string name, Vector2 textureOffset, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetTextureOffset(name), textureOffset, (to) => material.SetTextureOffset(name, to), duration, formula, loopsCount, loopType);
        }

        public static Tween DoTextureScale(this Material material, string name, Vector2 textureScale, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetTextureOffset(name), textureScale, (ts) => material.SetTextureScale(name, ts), duration, formula, loopsCount, loopType);
        }

        public static Tween DoInt(this Material material, string name, int value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetInt(name), value, (i) => material.SetInt(name, i), duration, formula, loopsCount, loopType);
        }

        public static Tween DoFloat(this Material material, string name, float value, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetFloat(name), value, (f) => material.SetFloat(name, f), duration, formula, loopsCount, loopType);
        }

        public static Tween DoVector(this Material material, string name, Vector4 vector, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(material.GetVector(name), vector, (v) => material.SetVector(name, v), duration, formula, loopsCount, loopType);
        }
        #endregion

        #region AudioSource
        public static Tween DoVolume(this AudioSource audioSource, float volume, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(audioSource.volume, volume, (v) => audioSource.volume = v, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region Camera
        public static Tween DoFieldOfView(this Camera camera, float fieldOfView, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.fieldOfView, fieldOfView, (fov) => camera.fieldOfView = fov, duration, formula, loopsCount, loopType);
        }

        public static Tween DoRect(this Camera camera, Rect rect, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(camera.rect, rect, (r) => camera.rect = r, duration, formula, loopsCount, loopType);
        }
        #endregion

        #region CanvasGroup
        public static Tween DoAlpha(this CanvasGroup canvasGroup, float alpha, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(canvasGroup.alpha, alpha, (a) => canvasGroup.alpha = a, duration, formula, loopsCount, loopType);
        }
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