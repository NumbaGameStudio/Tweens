using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
	internal static class ListExtensions 
	{
		public static void SortPart<T>(this List<T> list, int startIndex, int count, Comparison<T> comparison)
        {
            var part = list.GetRange(startIndex, count);

            part.Sort(comparison);

            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++) list[i] = part[i - startIndex];
        }
	}
}