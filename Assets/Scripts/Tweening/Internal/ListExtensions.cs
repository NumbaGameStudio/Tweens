using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
    /// <summary>
    /// Extensions for generic List class.
    /// </summary>
	internal static class ListExtensions 
	{
        /// <summary>
        /// Sort part of list.
        /// </summary>
        /// <typeparam name="T">Base list type.</typeparam>
        /// <param name="list">Target list.</param>
        /// <param name="startIndex">Start from this index.</param>
        /// <param name="count">Elements count for sorting.</param>
        /// <param name="comparison">Comparison object.</param>
		public static void SortPart<T>(this List<T> list, int startIndex, int count, Comparison<T> comparison)
        {
            var part = list.GetRange(startIndex, count);

            part.Sort(comparison);

            int endIndex = startIndex + count;
            for (int i = startIndex; i < endIndex; i++) list[i] = part[i - startIndex];
        }
	}
}