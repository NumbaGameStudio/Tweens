using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;
using Numba.Tweening.Engine;
using Numba.Tweening.Tweaks;
using UnityEngine.UI;

namespace Namespace
{
    public class Test : MonoBehaviour
    {
        [SerializeField]
        private Transform _cube1;

        [SerializeField]
        private Transform _cube2;

        [SerializeField]
        private Transform _cube3;

        Sequence _sequence;

        [Range(0f, 12f)]
        public float time;

        private void Start()
        {
            var tween1 = _cube1.DoPositionX(1f, 1f, Ease.InExpo, 2, LoopType.ReversedYoyo);
            var tween2 = _cube2.DoPositionY(1f, 1f, Ease.InExpo, 2, LoopType.ReversedYoyo);
            var tween3 = _cube3.DoPositionZ(1f, 1f, Ease.InExpo, 2, LoopType.ReversedYoyo);

            _sequence = new Sequence();
            _sequence.Append(tween1);
            _sequence.Append(tween2);
            _sequence.Append(tween3);
        }

        private void Update()
        {
            _sequence.SetTime(time);
        }
    }
}