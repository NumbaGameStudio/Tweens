using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Enumeration for organizing loops
    /// </summary>
    public enum LoopType
    {
        /// <summary>
        /// After play forward completed, instantly teleport to start value.
        /// </summary>
        Forward,

        /// <summary>
        /// Starts from end. After play backward completed, instantly teleport to end value.
        /// </summary>
        Backward,

        /// <summary>
        /// <para>Starts from end.</para>
        /// <para>For Tween when playing as backward, but use reversed formula.</para>
        /// <para>For Sequence is similar to Backward loop type.</para>
        /// </summary>
        Reversed,

        /// <summary>
        /// Starts from start. After play forward comlpeted Backward loop type will be used.
        /// </summary>
        Yoyo,

        /// <summary>
        /// <para>For Tween:</para> 
        /// <para>Starts from start.</para> 
        /// <para>After play forward comlpeted Reversed loop type will be used.</para>
        /// <para>For Sequence:</para>
        /// <para>Starts from end.</para> 
        /// <para>After play backward comlpeted Forward loop type will be used.</para>
        /// </summary>
        ReversedYoyo
    }
}