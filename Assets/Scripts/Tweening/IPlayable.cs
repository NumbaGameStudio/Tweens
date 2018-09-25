using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    public interface IPlayable
    {
        #region Events
        event Action Started;

        event Action Updated;

        event Action Completed;
        #endregion

        string Name { get; }

        float Duration { get; }

        float DurationWithLoops { get; }

        int LoopsCount { get; set; }

        LoopType LoopType { get; set; }

        Settings Settings { get; set; }

        bool IsPlaying { get; }

        IPlayable SetLoops(int loopsCount);

        IPlayable SetLoops(LoopType loopType);

        IPlayable SetLoops(int loopsCount, LoopType loopType);

        void SetTime(float time);

        IPlayable SetSettings(Settings settings);

        PlayRoutine Play(bool useRealtime = false);

        void Stop();

        IPlayable OnStart(Action callback);

        IPlayable OnUpdate(Action callback);

        IPlayable OnComplete(Action callback);

        void InvokeStart();

        void InvokeUpdate();

        void InvokeComplete();

        void ClearCallbacks();
    }
}