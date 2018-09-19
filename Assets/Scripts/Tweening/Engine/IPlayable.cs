using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening.Engine
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

        int LoopsCount { get; set; }

        LoopType LoopType { get; set; }

        bool IsPlaying { get; }

        float GetDurationWithLoops();

        void SetTime(float time);

        Coroutine Play(bool useRealtime = false);

        void Stop();
    }
}