using System.Collections;
using UnityEngine;
using Numba.Tweening.Tweaks;
using Numba.Tweening.Engine;
using System;
using UnityEngine.UI;
using UnityTime = UnityEngine.Time;

namespace Numba.Tweening
{
    public class Tween : IPlayable
    {
        #region Create
        #region Float
        public static Tween Create(float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Double
        public static Tween Create(double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Int
        public static Tween Create(int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Long
        public static Tween Create(long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Vector2
        public static Tween Create(Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Vector3
        public static Tween Create(Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Vector4
        public static Tween Create(Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Quaternion
        public static Tween Create(Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Color
        public static Tween Create(Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Color32
        public static Tween Create(Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region DateTime
        public static Tween Create(DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Rect
        public static Tween Create(Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Bounds
        public static Tween Create(Bounds from, Bounds to, Action<Bounds> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Bounds from, Bounds to, Action<Bounds> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region ColorBlock
        public static Tween Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, from, to, setter, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, ColorBlock from, ColorBlock to, Action<ColorBlock> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Tweak
        public static Tween Create(Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Create(null, tweak, duration, ease, loopsCount, loopType);
        }

        public static Tween Create(string name, Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(name, tweak, duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Fields
        private Coroutine _playTimeRoutine;

        private PlayRoutine _playRoutine;

        private Action _playRoutineOnStopCallback;

        private float _duration;

        private Ease _ease;

        private Formula _formula;

        private int _loopsCount;

        private LoopType _loopType;

        #region Events
        public event Action Started;

        public event Action Updated;

        public event Action Completed;
        #endregion

        #region Callback
        private Action _onStartCallback;

        private Action _onUpdateCallback;

        private Action _onCompleteCallback;
        #endregion
        #endregion

        #region Constructors
        private Tween() { }

        public Tween(Tweak tweak, float duration) : this(null, tweak, duration) { }

        public Tween(string name, Tweak tweak, float duration)
        {
            ConstructBase(name, tweak, duration, 1, LoopType.Forward);
        }

        public Tween(Tweak tweak, float duration, EasedSettings settings) : this(null, tweak, duration, settings) { }

        public Tween(string name, Tweak tweak, float duration, EasedSettings settings)
        {
            ConstructBase(name, tweak, duration, settings.LoopsCount, settings.LoopType);

            if (settings.EaseType == EaseType.Integrated) Ease = settings.Ease;
            else Formula = settings.Formula;
        }

        static Tween()
        {
            Time = new Engine.Time();
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public Tweak Tweak { get; set; }

        public float Duration
        {
            get { return _duration; }
            set
            {
                _duration = Mathf.Max(0f, value);
                DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
            }
        }

        public float DurationWithLoops { get; private set; }

        public EaseType EaseType { get; private set; }

        public Ease Ease
        {
            get { return _ease; }
            set
            {
                _ease = value;
                EaseType = EaseType.Integrated;
                _formula = null;
            }
        }

        public Formula Formula
        {
            get { return _formula; }
            set
            {
                _formula = value;
                EaseType = EaseType.Custom;
            }
        }

        public int LoopsCount
        {
            get { return _loopsCount; }
            set
            {
                _loopsCount = Mathf.Max(value, -1);
                DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
            }
        }

        public LoopType LoopType
        {
            get { return _loopType; }
            set
            {
                _loopType = value;
                DurationWithLoops = CalculateDurationWithLoops(Duration, LoopsCount, LoopType);
            }
        }

        public EasedSettings Settings
        {
            get
            {
                if (EaseType == EaseType.Integrated) return new EasedSettings(_loopsCount, _loopType, _ease);
                else return new EasedSettings(_loopsCount, _loopType, _formula);
            }
            set
            {
                LoopsCount = value.LoopsCount;
                LoopType = value.LoopType;

                if (value.EaseType == EaseType.Integrated) Ease = value.Ease;
                else Formula = value.Formula;
            }
        }

        public bool IsPlaying { get { return _playTimeRoutine != null; } }

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

        private bool IsYoyoTypedLoopType(LoopType loopType)
        {
            return loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo;
        }

        private float GetLoopTypeDurationMultiplier(LoopType loopType)
        {
            return IsYoyoTypedLoopType(loopType) ? 2f : 1f;
        }

        public Tween SetEase(Ease ease)
        {
            Ease = ease;
            return this;
        }

        public Tween SetEase(Formula formula)
        {
            Formula = formula;
            return this;
        }

        IPlayable IPlayable.SetLoops(int loopsCount)
        {
            return SetLoops(loopsCount, LoopType);
        }

        public Tween SetLoops(int loopsCount)
        {
            return SetLoops(loopsCount, LoopType);
        }

        IPlayable IPlayable.SetLoops(LoopType loopType)
        {
            return SetLoops(loopType);
        }

        public Tween SetLoops(LoopType loopType)
        {
            return SetLoops(LoopsCount, loopType);
        }

        IPlayable IPlayable.SetLoops(int loopsCount, LoopType loopType)
        {
            return SetLoops(loopsCount, loopType);
        }

        public Tween SetLoops(int loopsCount, LoopType loopType)
        {
            LoopsCount = loopsCount;
            LoopType = loopType;

            return this;
        }

        public void SetTime(float time)
        {
            SetTime(Tweak, time, Duration, DurationWithLoops, EaseType, Ease, Formula, LoopType);
        }

        public void SetTime(Tweak tweak, float time, float duration, float durationWithLoops, EaseType easeType, Ease ease, Formula formula, LoopType loopType)
        {
            if (duration == 0f)
            {
                SetTweakTime(tweak, easeType, ease, formula, () => LoopType == LoopType.Forward ? 1f : 0f);
                return;
            }

            time = Mathf.Clamp(time, 0f, durationWithLoops);

            if (loopType == LoopType.Forward)
                SetTweakTime(tweak, easeType, ease, formula, () => Engine.Math.WrapCeil(time, duration) / duration);
            else if (loopType == LoopType.Backward)
                SetTweakTime(tweak, easeType, ease, formula, () => Engine.Math.WrapCeil(time, duration) / duration, true);
            else if (loopType == LoopType.Reversed)
                SetTweakTime(tweak, easeType, ease, formula, () => 1f - Engine.Math.WrapCeil(time, duration) / duration);
            else if (loopType == LoopType.Yoyo)
                SetTweakTime(tweak, easeType, ease, formula, () => Engine.Math.WrapCeil(time, duration) / duration, IsYoyoBackward(time, duration));
            else
            {
                if (IsYoyoBackward(time, duration)) SetTweakTime(tweak, easeType, ease, formula, () => 1f - Engine.Math.WrapCeil(time, duration) / duration);
                else SetTweakTime(tweak, easeType, ease, formula, () => Engine.Math.WrapCeil(time, duration) / duration);
            }
        }

        private void SetTweakTime(Tweak tweak, EaseType easeType, Ease ease, Formula formula, Func<float> timeGetter, bool swapFromTo = false)
        {
            if (tweak == null) return;

            if (easeType == EaseType.Integrated) tweak.SetTime(timeGetter(), ease, swapFromTo);
            else tweak.SetTime(timeGetter(), formula, swapFromTo);
        }

        private float CalculateDurationWithLoops(float duration, int loopsCount, LoopType loopType)
        {
            return duration * GetLoopTypeDurationMultiplier(loopType) * Mathf.Abs(loopsCount);
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

        public Tween SetSettings(EasedSettings settings)
        {
            Settings = settings;
            return this;
        }

        public PlayRoutine Play(bool useRealtime = false)
        {
            if (IsPlaying)
            {
                Debug.LogWarning(string.Format("Tween with name \"{0}\" already playing.", Name));
                return _playRoutine;
            }

            if (LoopsCount == 0) return PlayRoutine.CreateCompleted();

            _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(useRealtime, Tweak, Duration, DurationWithLoops, EaseType, Ease, Formula, LoopsCount, LoopType));
            return _playRoutine = PlayRoutine.Create(out _playRoutineOnStopCallback);
        }

        private IEnumerator PlayTime(bool useRealtime, Tweak tweak, float duration, float durationWithLoops, EaseType easeType, Ease ease, Formula formula, int loopsCount, LoopType loopType)
        {
            InvokeStart();

            float startTime = GetTime(useRealtime);
            float endTime = startTime + durationWithLoops;

            while (loopsCount == -1)
            {
                yield return null;

                float time = GetTime(useRealtime);

                if (duration == 0f)
                {
                    SetTime(tweak, 0f, duration, durationWithLoops, easeType, ease, formula, loopType);
                }
                else
                {
                    while (endTime < time)
                    {
                        startTime = endTime;
                        endTime = startTime + durationWithLoops;
                    }

                    SetTime(tweak, time - startTime, duration, durationWithLoops, easeType, ease, formula, loopType);
                }

                InvokeUpdate();
            }

            if (duration == 0f)
            {
                yield return null;

                SetTime(tweak, 0f, duration, durationWithLoops, easeType, ease, formula, loopType);
            }
            else
            {
                while (GetTime(useRealtime) < endTime)
                {
                    yield return null;

                    SetTime(tweak, (Mathf.Min(GetTime(useRealtime), endTime) - startTime), duration, durationWithLoops, easeType, ease, formula, loopType);

                    InvokeUpdate();
                }
            }

            HandleStop();
        }

        private float GetTime(bool useRealtime)
        {
            return useRealtime ? UnityTime.realtimeSinceStartup : UnityTime.time;
        }

        public void Stop()
        {
            if (!IsPlaying)
            {
                Debug.LogWarning(string.Format("Tween with name \"{0}\" already stoped.", Name));
                return;
            }

            HandleStop();
        }

        private void HandleStop()
        {
            RoutineHelper.Instance.StopCoroutine(_playTimeRoutine);
            _playTimeRoutine = null;
            _playRoutineOnStopCallback();
            _playRoutine = null;

            InvokeComplete();
        }

        IPlayable IPlayable.OnStart(Action callback)
        {
            return OnStart(callback);
        }

        public Tween OnStart(Action callback)
        {
            _onStartCallback = callback;
            return this;
        }

        IPlayable IPlayable.OnUpdate(Action callback)
        {
            return OnUpdate(callback);
        }

        public Tween OnUpdate(Action callback)
        {
            _onUpdateCallback = callback;
            return this;
        }

        IPlayable IPlayable.OnComplete(Action callback)
        {
            return OnComplete(callback);
        }

        public Tween OnComplete(Action callback)
        {
            _onCompleteCallback = callback;
            return this;
        }

        public void InvokeStart()
        {
            InvokePhase(Started, _onStartCallback);
        }

        public void InvokeUpdate()
        {
            InvokePhase(Updated, _onUpdateCallback);
        }

        public void InvokeComplete()
        {
            InvokePhase(Completed, _onCompleteCallback);
        }

        private void InvokePhase(Action phaseEvent, Action callback)
        {
            if (phaseEvent != null) phaseEvent();
            if (callback != null) callback();
        }

        public void ClearCallbacks()
        {
            _onStartCallback = _onUpdateCallback = _onCompleteCallback = null;
        }
        #endregion
    }
}