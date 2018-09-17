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

		private void Start()
		{
            new Sequence(_cube.DoPositionX(1f, 1f, Ease.InOutExpo, -1, LoopType.Yoyo)
                .OnStart(() => Debug.Log("Started"))
                .OnUpdate(() => Debug.Log("Updated"))
                .OnComplete(() => Debug.Log("Completed"))).Play();
		}
	}
}