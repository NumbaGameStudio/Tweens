using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    internal static class Math 
	{
        public static float WrapCeil(float value, float max)
        {
            if (value == 0f) return 0f;

            float wrapped = value % max;
            return (wrapped == 0f) ? max : wrapped;
        }
    }
}