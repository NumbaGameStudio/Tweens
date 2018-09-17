using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Namespace
{
	public class Test : MonoBehaviour 
	{
        [SerializeField]
        private Transform _cube;

		private IEnumerator Start()
		{
            yield return _cube.DoPositionX(1f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            Debug.Log("Awaited");
		}
	}
}