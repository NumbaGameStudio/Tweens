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

        private Settings _settings;

        #region Durations
        private float _duration;

        private float _durationWithLoopType;

        private float _durationWithLoops;
        #endregion

        private int _playingLoopsCount;

        private LoopType _loopType;

        private float _playingStartTime;

        #region End times
        private float _playingEndTime;

        private float _playingLoopTypeEndTime;
        #endregion

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

        public Tween(Tweak tweak, float duration) : this(tweak, duration, new Settings(1, LoopType.Forward, Ease.Linear)) { }

        public Tween(Tweak tweak, float duration, int loopsCount) : this(tweak, duration, new Settings(loopsCount, LoopType.Forward, Ease.Linear)) { }

        public Tween(Tweak tweak, float duration, LoopType loopType) : this(tweak, duration, new Settings(1, loopType, Ease.Linear)) { }

        public Tween(Tweak tweak, float duration, int loopsCount, LoopType loopType) : this(tweak, duration, new Settings(loopsCount, loopType, Ease.Linear)) { }

        public Tween(Tweak tweak, float duration, Ease ease) : this(tweak, duration, new Settings(1, LoopType.Forward, ease)) { }

        public Tween(Tweak tweak, float duration, int loopsCount, Ease ease) : this(tweak, duration, new Settings(loopsCount, LoopType.Forward, ease)) { }

        public Tween(Tweak tweak, float duration, int loopsCount, LoopType loopType, Ease ease) : this(tweak, duration, new Settings(loopsCount, loopType, ease)) { }

        public Tween(Tweak tweak, float duration, AnimationCurve curve) : this(tweak, duration, new Settings(1, LoopType.Forward, curve)) { }

        public Tween(Tweak tweak, float duration, int loopsCount, AnimationCurve curve) : this(tweak, duration, new Settings(loopsCount, LoopType.Forward, curve)) { }

        public Tween(Tweak tweak, float duration, int loopsCount, LoopType loopType, AnimationCurve curve) : this(tweak, duration, new Settings(loopsCount, loopType, curve)) { }

        public Tween(Tweak tweak, float duration, Settings settings) : this(null, tweak, duration, settings) { }

        public Tween(string name, Tweak tweak, float duration) : this(name, tweak, duration, new Settings(1, LoopType.Forward, Ease.Linear)) { }

        public Tween(string name, Tweak tweak, float duration, int loopsCount) : this(name, tweak, duration, new Settings(loopsCount, LoopType.Forward, Ease.Linear)) { }

        public Tween(string name, Tweak tweak, float duration, LoopType loopType) : this(name, tweak, duration, new Settings(1, loopType, Ease.Linear)) { }

        public Tween(string name, Tweak tweak, float duration, int loopsCount, LoopType loopType) : this(name, tweak, duration, new Settings(loopsCount, loopType, Ease.Linear)) { }

        public Tween(string name, Tweak tweak, float duration, Ease ease) : this(name, tweak, duration, new Settings(1, LoopType.Forward, ease)) { }

        public Tween(string name, Tweak tweak, float duration, int loopsCount, Ease ease) : this(name, tweak, duration, new Settings(loopsCount, LoopType.Forward, ease)) { }

        public Tween(string name, Tweak tweak, float duration, int loopsCount, LoopType loopType, Ease ease) : this(name, tweak, duration, new Settings(loopsCount, loopType, ease)) { }

        public Tween(string name, Tweak tweak, float duration, AnimationCurve curve) : this(name, tweak, duration, new Settings(1, LoopType.Forward, curve)) { }

        public Tween(string name, Tweak tweak, float duration, int loopsCount, AnimationCurve curve) : this(name, tweak, duration, new Settings(loopsCount, LoopType.Forward, curve)) { }

        public Tween(string name, Tweak tweak, float duration, LoopType loopType, AnimationCurve curve) : this(name, tweak, duration, new Settings(1, loopType, curve)) { }

        public Tween(string name, Tweak tweak, float duration, int loopsCount, LoopType loopType, AnimationCurve curve) : this(name, tweak, duration, new Settings(loopsCount, loopType, curve)) { }

        public Tween(string name, Tweak tweak, float duration, Settings settings)
        {
            Name = name ?? "[noname]";
            Tweak = tweak;
            Duration = Mathf.Max(0f, duration);
            _settings = settings;
            _playingLoopsCount = _settings.LoopsCount;
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

        public float Duration
        {
            get { return _duration; }
            set
            {
                _duration = Mathf.Max(0f, value);

                CalculateDurations();
                CalculatePlayingEndTimes(_playingStartTime);
            }
        }

        public float DurationWithLoops { get { return _durationWithLoops; } }

        public EaseType EaseType { get { return _settings.EaseType; } }

        public Ease Ease
        {
            get { return _settings.Ease; }
            set { _settings.Ease = value; }
        }

        public AnimationCurve Curve
        {
            get { return _settings.Curve; }
            set { _settings.Curve = value; }
        }

        public int LoopsCount
        {
            get { return _settings.LoopsCount; }
            set
            {
                _settings.LoopsCount = value;
                _playingLoopsCount = _settings.LoopsCount;

                CalculateDurations();
                CalculatePlayingEndTimes(_playingStartTime);
            }
        }

        public LoopType LoopType
        {
            get { return _loopType; }
            set
            {
                _loopType = value;

                CalculateDurations();
                CalculatePlayingEndTimes(_playingStartTime);
            }
        }

        public Settings Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }

        public static Engine.Time Time { get; private set; }
        #endregion

        #region Methods
        private void CalculateDurations()
        {
            _durationWithLoopType = Duration * (IsYoyoTypedLoopType(LoopType) ? 2f : 1f);
            _durationWithLoops = _durationWithLoopType * Mathf.Abs(LoopsCount);
        }

        private bool IsYoyoTypedLoopType(LoopType loopType)
        {
            return loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo;
        }

        private void CalculatePlayingEndTimes(float startTime)
        {
            _playingLoopTypeEndTime = startTime + _durationWithLoopType;
            _playingEndTime = startTime + DurationWithLoops;
        }

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
            if (Duration == 0f)
            {
                if (_settings.EaseType == EaseType.Formula) Tweak.SetTime(LoopType == LoopType.Forward ? 1f : 0f, _settings.Ease);
                else Tweak.SetTime(LoopType == LoopType.Forward ? 1f : 0f, _settings.Curve);

                return;
            }

            float fullDuration = Duration * Mathf.Abs(_settings.LoopsCount);
            if (_settings.LoopType == LoopType.Yoyo || _settings.LoopType == LoopType.ReversedYoyo) fullDuration *= 2f;

            time = Mathf.Clamp(time, 0f, fullDuration);

            switch (_settings.LoopType)
            {
                case LoopType.Forward:
                    if (_settings.EaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Ease);
                    else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Curve);
                    break;
                case LoopType.Backward:
                    if (_settings.EaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Ease, true);
                    else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Curve, true);
                    break;
                case LoopType.Reversed:
                    if (_settings.EaseType == EaseType.Formula) Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Ease);
                    else Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Curve);
                    break;
                case LoopType.Yoyo:
                    if (_settings.EaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Ease, IsYoyoBackward(time));
                    else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Curve, IsYoyoBackward(time));
                    break;
                case LoopType.ReversedYoyo:
                    if (IsYoyoBackward(time))
                    {
                        if (_settings.EaseType == EaseType.Formula) Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Ease);
                        else Tweak.SetTime(1f - Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Curve);
                    }
                    else
                    {
                        if (_settings.EaseType == EaseType.Formula) Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Ease);
                        else Tweak.SetTime(Engine.Math.WrapCeil(time, Duration) / Duration, _settings.Curve);
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

        IPlayable IPlayable.SetSettings(Settings settings)
        {
            _settings = settings;
            return this;
        }

        public Tween SetSettings(Settings settings)
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

            if (_settings.LoopsCount == 0) return PlayRoutine.CreateCompleted();

            _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(useRealtime));
            return _playRoutine = PlayRoutine.Create(out _playRoutineOnStopCallback);
        }

        private IEnumerator PlayTime(bool useRealtime)
        {
            InvokeStart();

            _playingStartTime = GetTime(useRealtime);

            float changablePlayingStartTime = _playingStartTime;
            CalculatePlayingEndTimes(changablePlayingStartTime);

            bool isNeedWaitForFrame = true;

        MainLoop:
            while (_playingLoopsCount != 0)
            {
                while (_playingLoopsCount == -1 && Duration == 0f)
                {
                    if (isNeedWaitForFrame) yield return null;
                    else isNeedWaitForFrame = true;

                    if (!(_playingLoopsCount == -1 && Duration == 0f))
                    {
                        isNeedWaitForFrame = false;
                        break;
                    }

                    SetTime(0f);

                    CalculatePlayingEndTimes(changablePlayingStartTime = GetTime(useRealtime));

                    InvokeUpdate();
                }

                while (_playingLoopsCount == -1 && Duration != 0f)
                {
                    if (isNeedWaitForFrame) yield return null;
                    else isNeedWaitForFrame = true;

                    if (!(_playingLoopsCount == -1 && Duration != 0f))
                    {
                        isNeedWaitForFrame = false;
                        break;
                    }

                    float time = GetTime(useRealtime);

                    while (_playingLoopTypeEndTime < time)
                    {
                        CalculatePlayingEndTimes(changablePlayingStartTime = _playingLoopTypeEndTime);
                    }

                    SetTime(time - changablePlayingStartTime);

                    InvokeUpdate();
                }

                while (_playingLoopsCount > 0 && Duration == 0f)
                {
                    if (isNeedWaitForFrame) yield return null;
                    else isNeedWaitForFrame = true;

                    if (!(_playingLoopsCount > 0 && Duration == 0f))
                    {
                        isNeedWaitForFrame = false;
                        break;
                    }

                    SetTime(0f);
                    _playingLoopsCount = 0;
                }
                
                while (_playingLoopsCount > 0 && Duration != 0f)
                {
                    while (GetTime(useRealtime) < _playingLoopTypeEndTime)
                    {
                        if (isNeedWaitForFrame) yield return null;
                        else isNeedWaitForFrame = true;

                        if (!(_playingLoopsCount > 0 && Duration != 0f))
                        {
                            isNeedWaitForFrame = false;
                            goto MainLoop;
                        }

                        SetTime((Mathf.Min(GetTime(useRealtime), _playingEndTime) - _playingStartTime));

                        InvokeUpdate();
                    }

                    float countedDuration = _playingEndTime - _playingStartTime;
                    float timeLeft = GetTime(useRealtime) - _playingStartTime;

                    _playingLoopsCount = (int)Mathf.Ceil(Mathf.Max(0f, (countedDuration - timeLeft) / _durationWithLoopType));
                    changablePlayingStartTime += _durationWithLoopType;
                    _playingLoopTypeEndTime = _playingStartTime + _durationWithLoopType;
                }
            }

            if (LoopsCount == 0) SetTime(0f);

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
            if (_playTimeRoutine != null)
            {
                RoutineHelper.Instance.StopCoroutine(_playTimeRoutine);
                _playTimeRoutine = null;
                _playRoutine = null;
                _playRoutineOnStopCallback();
            }

            _playingLoopsCount = _settings.LoopsCount;

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