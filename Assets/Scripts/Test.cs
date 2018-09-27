using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;
using Numba.Tweening.Engine;
using Numba.Tweening.Tweaks;

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

        private IEnumerator Start()
        {
            var tween1 = _cube1.DoLocalPositionX(1f, 1f);
            var tween2 = _cube2.DoLocalPositionX(1f, 1f);
            var tween3 = _cube3.DoLocalPositionX(1f, 1f);

            Sequence sequence = new Sequence();
            sequence.Append(tween1);
            var player = sequence.Play();

            sequence.Append(tween2);

            yield return new WaitForSeconds(0.5f);

            sequence.Insert(0.5f, tween3);

            yield return player;

            sequence.Play();
        }
    }
}