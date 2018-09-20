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

        //private Tween _tween;

        [SerializeField]
        [Range(0f, 10f)]
        private float _time;

		private void Awake()
		{
            //_tween = _cube1.DoPositionX(1.5f, 2f).SetEase(Ease.InExpo).SetLoops(2, LoopType.ReversedYoyo);

            _sequence = new Sequence().SetLoops(2, LoopType.ReversedYoyo);
            _sequence.Append(_cube1.DoPositionX(1.5f, 1f).SetEase(Ease.Linear).SetLoops(1, LoopType.Forward));
            _sequence.Insert(0f, _cube2.DoPositionX(1.5f, 1f).SetEase(Ease.InOutExpo));

            //_sequence.Play();
        }

        private void Update()
        {
            _sequence.SetTime(_time);
        }
    }
}