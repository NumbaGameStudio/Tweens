using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Enumeration for represent playing state.
    /// </summary>
    public enum PlayState
    {
        /// <summary>
        /// Not playing.
        /// </summary>
        Stop,

        /// <summary>
        /// Currently playing.
        /// </summary>
        Play,

        /// <summary>
        /// Temporarily paused.
        /// </summary>
        Pause
    }
}