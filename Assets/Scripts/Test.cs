using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Namespace
{
	public class Test : MonoBehaviour 
	{
        [SerializeField]
        private Transform _cube1;

        [SerializeField]
        private Transform _cube2;

        private Sequence _sequence;

        [SerializeField]
        //[Range(0f, 6f)]
        private float _time;

		private void Awake()
		{
            _sequence = new Sequence().SetLoops(2, LoopType.Forward);

            _sequence.Append(_cube1.DoPositionZ(1.5f, 1f, Ease.InOutExpo));
            _sequence.Insert(0f, _cube2.DoPositionZ(-1.5f, 1f, Ease.InOutExpo));
            _sequence.Append(_cube1.DoPositionY(-1f, 1f, Ease.InOutExpo));
            _sequence.Append(_cube2.DoPositionY(1f, 0.5f, Ease.InOutExpo));
        }

        private void Update()
        {
            _sequence.SetTime(_time);
        }
    }
}