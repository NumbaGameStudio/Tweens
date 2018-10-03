using System.Collections;
using UnityEngine;
using Numba.Tweening.Tweaks;
using Numba.Tweening.Engine;
using System;
using UnityEngine.UI;
using UnityTime = UnityEngine.Time;

namespace Numba.Tweening
{
    public sealed class Tween : Playable
    {
        #region Create
        #region Float
        public static Tween Create(float from, float to, Action<float> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, float from, float to, Action<float> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Double
        public static Tween Create(double from, double to, Action<double> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, double from, double to, Action<double> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Int
        public static Tween Create(int from, int to, Action<int> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, int from, int to, Action<int> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Long
        public static Tween Create(long from, long to, Action<long> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, long from, long to, Action<long> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Vector2
        public static Tween Create(Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Vector3
        public static Tween Create(Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Vector4
        public static Tween Create(Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Quaternion
        public static Tween Create(Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Color
        public static Tween Create(Color from, Color to, Action<Color> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Color from, Color to, Action<Color> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Color32
        public static Tween Create(Color32 from, Color32 to, Action<Color32> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Color32 from, Color32 to, Action<Color32> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region DateTime
        public static Tween Create(DateTime from, DateTime to, Action<DateTime> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, DateTime from, DateTime to, Action<DateTime> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Rect
        public static Tween Create(Rect from, Rect to, Action<Rect> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Rect from, Rect to, Action<Rect> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Bounds
        public static Tween Create(Bounds from, Bounds to, Action<Bounds> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Bounds from, Bounds to, Action<Bounds> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(Bounds from, Bounds to, Action<Bounds> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Bounds from, Bounds to, Action<Bounds> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region ColorBlock
        public static Tween Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, formula, loopsCount, loopType);
        }

        public static Tween Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, from, to, setter, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion

        #region Settings
        public static Tween Create(Tweak tweak, float duration, FormulaSettings settings)
        {
            return Create(null, tweak, duration, settings.Formula, settings.LoopsCount, settings.LoopType);
        }

        public static Tween Create(string name, Tweak tweak, float duration, FormulaSettings settings)
        {
            return Create(name, tweak, duration, settings.Formula, settings.LoopsCount, settings.LoopType);
        }
        #endregion

        #region Tweak
        public static Tween Create(Tweak tweak, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, tweak, duration, formula, loopsCount, loopType);
        }

        public static Tween Create(string name, Tweak tweak, float duration, Formula formula, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(name, tweak, duration).SetEase(formula).SetLoops(loopsCount, loopType);
        }

        public static Tween Create(Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, tweak, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, tweak, duration, Formulas.GetFormula(ease), loopsCount, loopType);
        }
        #endregion
        #endregion

        private Formula _formula = Formulas.Linear;

        #region Constructors
        private Tween() { }

        public Tween(Tweak tweak, float duration) : this(null, tweak, duration) { }

        public Tween(string name, Tweak tweak, float duration)
        {
            ConstructBase(name, tweak, duration, 1, LoopType.Forward);
            Formula = Formulas.Linear;
        }

        public Tween(Tweak tweak, float duration, FormulaSettings settings) : this(null, tweak, duration, settings) { }

        public Tween(string name, Tweak tweak, float duration, FormulaSettings settings)
        {
            ConstructBase(name, tweak, duration, settings.LoopsCount, settings.LoopType);
            Formula = settings.Formula;
        }

        static Tween()
        {
            Time = new Engine.Time();
        }
        #endregion

        #region Properties
        protected override string PlayableName { get { return "Tween"; } }

        public Tweak Tweak { get; set; }

        public new float Duration
        {
            get { return _duration; }
            set
            {
                _duration = Mathf.Max(0f, value);
                DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
            }
        }

        public Formula Formula
        {
            get { return _formula; }
            set
            {
                if (value == null) throw new ArgumentNullException("value", "Formula can not be a null");
                _formula = value;
            }
        }

        public Ease Ease
        {
            get { return _formula.Ease; }
            set { _formula = Formulas.GetFormula(value); }
        }

        public override int LoopsCount
        {
            get { return _loopsCount; }
            set
            {
                SetLoopsCount(value);
            }
        }

        public override LoopType LoopType
        {
            get { return _loopType; }
            set
            {
                SetLoopType(value);
            }
        }

        public FormulaSettings Settings
        {
            get
            {
                return new FormulaSettings(_loopsCount, _loopType, Formula);
            }
            set
            {
                LoopsCount = value.LoopsCount;
                LoopType = value.LoopType;
                Formula = value.Formula;
            }
        }

        public static Engine.Time Time { get; private set; }
        #endregion

        #region Methods
        private void ConstructBase(string name, Tweak tweak, float duration, int loopsCount, LoopType loopType)
        {
            Name = name ?? "[noname]";
            Tweak = tweak;
            Duration = Mathf.Max(0f, duration);

            LoopsCount = loopsCount;
            LoopType = loopType;
        }

        public Tween SetEase(Formula formula)
        {
            Formula = formula;
            return this;
        }

        public Tween SetEase(Ease ease)
        {
            Ease = ease;
            return this;
        }

        public new Tween SetLoops(int loopsCount)
        {
            LoopsCount = LoopsCount;
            return this;
        }

        public new Tween SetLoops(LoopType loopType)
        {
            LoopType = loopType;
            return this;
        }

        public new Tween SetLoops(int loopsCount, LoopType loopType)
        {
            LoopsCount = loopsCount;
            LoopType = loopType;

            return this;
        }

        private bool IsYoyoBackward(float time, float duration)
        {
            float repeated = time / duration;
            if (repeated <= 1f) return false;

            int intPart = (int)repeated;
            float fraction = repeated - intPart;

            bool isEven = intPart % 2 == 0;

            return (!isEven && fraction == 0f) || (isEven && fraction != 0f) ? false : true;
        }

        public override void SetTime(float time)
        {
            SetTime(Tweak, time, Duration, DurationWithLoops, Formula, LoopType);
        }

        private void SetTime(Tweak tweak, float time, float duration, float durationWithLoops, Formula formula, LoopType loopType)
        {
            if (duration == 0f)
            {
                SetTweakTime(tweak, formula, () => LoopType == LoopType.Forward ? 1f : 0f);
                return;
            }

            time = Mathf.Clamp(time, 0f, durationWithLoops);

            if (loopType == LoopType.Forward)
                SetTweakTime(tweak, formula, () => Engine.Math.WrapCeil(time, duration) / duration);
            else if (loopType == LoopType.Backward)
                SetTweakTime(tweak, formula, () => Engine.Math.WrapCeil(time, duration) / duration, true);
            else if (loopType == LoopType.Reversed)
                SetTweakTime(tweak, formula, () => 1f - Engine.Math.WrapCeil(time, duration) / duration);
            else if (loopType == LoopType.Yoyo)
                SetTweakTime(tweak, formula, () => Engine.Math.WrapCeil(time, duration) / duration, IsYoyoBackward(time, duration));
            else
            {
                if (IsYoyoBackward(time, duration)) SetTweakTime(tweak, formula, () => 1f - Engine.Math.WrapCeil(time, duration) / duration);
                else SetTweakTime(tweak, formula, () => Engine.Math.WrapCeil(time, duration) / duration);
            }
        }

        private void SetTweakTime(Tweak tweak, Formula formula, Func<float> timeGetter, bool swapFromTo = false)
        {
            if (tweak == null) return;
            tweak.SetTo(timeGetter(), formula, swapFromTo);
        }

        public Tween SetSettings(FormulaSettings settings)
        {
            Settings = settings;
            return this;
        }

        public override PlayRoutine Play(bool useRealtime = false)
        {
            if (PlayState == PlayState.Play)
            {
                Debug.LogWarning(string.Format("Tween with name \"{0}\" already playing.", Name));
                return _playRoutine;
            }

            if (PlayState == PlayState.Pause)
            {
                float currentTime = GetTime(_useRealtime);

                _playStartTime = currentTime - (_playCurrentTime - _playStartTime);
                _playEndTime = currentTime + (_playEndTime - _playCurrentTime);

                PlayState = PlayState.Play;
                RoutineHelper.Instance.StartCoroutine(_playTimeEnumerator);

                return _playRoutine;
            }

            if (LoopsCount == 0) return PlayRoutine.CreateCompleted();

            PlayState = PlayState.Play;

            _useRealtime = useRealtime;

            _playTimeEnumerator = PlayTime(Tweak, Duration, DurationWithLoops, Formula, LoopsCount, LoopType);
            RoutineHelper.Instance.StartCoroutine(_playTimeEnumerator);

            return _playRoutine = PlayRoutine.Create(out _playRoutineOnStopCallback);
        }

        private IEnumerator PlayTime(Tweak tweak, float duration, float durationWithLoops, Formula formula, int loopsCount, LoopType loopType)
        {
            InvokeStart();

            _playStartTime = GetTime(_useRealtime);
            _playCurrentTime = _playStartTime;
            _playEndTime = _playStartTime + durationWithLoops;

            while (loopsCount == -1)
            {
                yield return null;

                _playCurrentTime = GetTime(_useRealtime);

                if (duration == 0f)
                {
                    SetTime(tweak, 0f, duration, durationWithLoops, formula, loopType);
                }
                else
                {
                    while (_playEndTime < _playCurrentTime)
                    {
                        _playStartTime = _playEndTime;
                        _playEndTime = _playStartTime + durationWithLoops;
                    }

                    SetTime(tweak, _playCurrentTime - _playStartTime, duration, durationWithLoops, formula, loopType);
                }

                InvokeUpdate();
            }

            if (duration == 0f)
            {
                yield return null;

                SetTime(tweak, 0f, duration, durationWithLoops, formula, loopType);
            }
            else
            {
                while (_playCurrentTime < _playEndTime)
                {
                    yield return null;

                    _playCurrentTime = GetTime(_useRealtime);
                    SetTime(tweak, (Mathf.Min(_playCurrentTime, _playEndTime) - _playStartTime), duration, durationWithLoops, formula, loopType);

                    InvokeUpdate();
                }
            }

            HandleStop();
        }

        protected override void HandleStop()
        {
            if (PlayState != PlayState.Pause) RoutineHelper.Instance.StopCoroutine(_playTimeEnumerator);
            _playTimeEnumerator = null;

            _playRoutineOnStopCallback();
            _playRoutine = null;
            PlayState = PlayState.Stop;

            InvokeComplete();
        }

        public new Tween OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        public new Tween OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        public new Tween OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }
        #endregion
    }
}