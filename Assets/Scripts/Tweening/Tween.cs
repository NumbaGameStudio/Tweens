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
            return (Tween)new Tween(name, tweak, duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }
        #endregion
        #endregion

        #region Fields
        private Coroutine _playTimeRoutine;

        private int _loopsCount = 1;

        private Ease _ease;

        private AnimationCurve _curve = new AnimationCurve();

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
            Name = name ?? "[noname]";
            Tweak = tweak;
            Duration = Mathf.Max(0f, duration);
        }

        static Tween()
        {
            Time = new Engine.Time();
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public Tweak Tweak { get; private set; }

        public bool IsPlaying { get { return _playTimeRoutine != null; } }

        public float Duration { get; private set; }

        public float DurationWithLoops
        {
            get
            {
                float durationWithLoops = Duration * (_loopsCount == -1f ? 1f : _loopsCount);
                if (LoopType == LoopType.Yoyo || LoopType == LoopType.ReversedYoyo) durationWithLoops *= 2f;

                return durationWithLoops;
            }
        }

        public EaseType UsedEaseType { get; set; }

        public Ease Ease
        {
            get { return _ease; }
            set
            {
                _ease = value;
                UsedEaseType = EaseType.Formula;
            }
        }

        public AnimationCurve Curve
        {
            get { return _curve; }
            set
            {
                _curve.keys = value.keys;
                UsedEaseType = EaseType.Curve;
            }
        }

        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        public LoopType LoopType { get; set; }

        public static Engine.Time Time { get; private set; }
        #endregion

        #region Methods
        public Tween SetEase(Ease ease)
        {
            Ease = ease;
            return this;
        }

        public Tween SetEase(AnimationCurve curve)
        {
            Curve = curve;
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
            return SetLoops(_loopsCount, loopType);
        }

        IPlayable IPlayable.SetLoops(int loopsCount, LoopType loopType)
        {
            return SetLoops(loopsCount, loopType);
        }

        public Tween SetLoops(int loopsCount, LoopType loopType)
        {
            _loopsCount = loopsCount;
            LoopType = loopType;

            return this;
        }

        public void SetTime(float time)
        {
            SetTime(time, UsedEaseType, Ease, _curve, _loopsCount, LoopType);
        }

        private void SetTime(float time, EaseType usedEaseType, Ease ease, AnimationCurve curve, int loopsCount, LoopType loopType)
        {
            if (loopsCount == -1) loopsCount = 1;

            float fullDuration = Duration * loopsCount;
            if (loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo) fullDuration *= 2f;

            time = Mathf.Min(time, fullDuration);

            switch (loopType)
            {
                case LoopType.Forward:
                    if (usedEaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, ease);
                    else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, curve);
                    break;
                case LoopType.Backward:
                    if (usedEaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, ease, true);
                    else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, curve, true);
                    break;
                case LoopType.Reversed:
                    if (usedEaseType == EaseType.Formula) Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, ease);
                    else Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, curve);
                    break;
                case LoopType.Yoyo:
                    if (usedEaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, ease, IsYoyoBackward(time));
                    else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, curve, IsYoyoBackward(time));
                    break;
                case LoopType.ReversedYoyo:
                    if (IsYoyoBackward(time))
                    {
                        if (usedEaseType == EaseType.Formula) Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, ease);
                        else Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, curve);
                    }
                    else
                    {
                        if (usedEaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, ease);
                        else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, curve);
                    }
                    break;
            }
        }

        private bool IsYoyoBackward(float time)
        {
            float repeated = time / Duration;
            if (repeated <= 1f) return false;

            int intPart = (int)repeated;
            float fraction = repeated - intPart;

            bool isEven = intPart % 2 == 0;

            return (!isEven && fraction == 0f) || (isEven && fraction != 0f) ? false : true;
        }

        public Coroutine Play(bool useRealtime = false)
        {
            if (IsPlaying)
            {
                Debug.LogWarning(string.Format("Tween with name \"{0}\" already playing.", Name));
                return _playTimeRoutine;
            }

            return _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(useRealtime, UsedEaseType, Ease, new AnimationCurve(_curve.keys), LoopsCount, LoopType));
        }

        private IEnumerator PlayTime(bool useRealtime, EaseType usedEaseType, Ease ease, AnimationCurve curve, int loopsCount, LoopType loopType)
        {
            InvokeStart();

            float startTime = GetTime(useRealtime);

            bool isInfinityLoops = loopsCount == -1;
            if (isInfinityLoops) loopsCount = 1;

            float duration = Duration * loopsCount;
            if (loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo) duration *= 2f;

            float endTime = startTime + duration;

            while (isInfinityLoops)
            {
                yield return null;

                float time = GetTime(useRealtime);

                while (endTime < time)
                {
                    startTime = endTime;
                    endTime = startTime + duration;
                }

                SetTime(time - startTime, usedEaseType, ease, curve, loopsCount, loopType);

                InvokeUpdate();
            }

            while (GetTime(useRealtime) < endTime)
            {
                yield return null;

                SetTime((Mathf.Min(GetTime(useRealtime), endTime) - startTime), usedEaseType, ease, curve, loopsCount, loopType);

                InvokeUpdate();
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

            InvokeComplete();
            ClearCallbacks();
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
            if (Started != null) Started();
            if (_onStartCallback != null) _onStartCallback();
        }

        public void InvokeUpdate()
        {
            if (Updated != null) Updated();
            if (_onUpdateCallback != null) _onUpdateCallback();
        }

        public void InvokeComplete()
        {
            if (Completed != null) Completed();
            if (_onCompleteCallback != null) _onCompleteCallback();
        }

        public void ClearCallbacks()
        {
            _onStartCallback = _onUpdateCallback = _onCompleteCallback = null;
        }
        #endregion
    }
}