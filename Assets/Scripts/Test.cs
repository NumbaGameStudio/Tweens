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
        [Range(0f, 6f)]
        private float _time;

		private void Awake()
		{
            _sequence = new Sequence().SetLoops(2, LoopType.Forward);

            var tween = _cube1.DoPositionZ(1.5f, 1f, Ease.InOutExpo);
            tween.Started += () => Debug.Log("Start");
            tween.Updated += () => Debug.Log("Update");
            tween.Completed += () => Debug.Log("Complete");
            _sequence.Append(tween);
            //_sequence.Insert(0f, _cube2.DoPositionZ(-1.5f, 1f, Ease.InOutExpo));
            //_sequence.Append(_cube1.DoPositionY(-1f, 1f, Ease.InOutExpo));
            //_sequence.Append(_cube2.DoPositionY(1f, 0.5f, Ease.InOutExpo));
            //_sequence.Insert(1f, _cube1.DoEulerAngles(45f, 45f, 45, 0.5f, Ease.InOutExpo));
            //_sequence.Insert(1f, _cube2.DoEulerAngles(45f, 45f, 45, 0.5f, Ease.InOutExpo));
        }

        private void Update()
        {
            _sequence.SetTime(_time);
        }
    }
}