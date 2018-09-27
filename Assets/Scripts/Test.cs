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

        private void Start()
        {
            //_cube1.DoPositionZ(10f, 1f, Ease.InExpo, 2, LoopType.ReversedYoyo).Play();

            var tween1 = _cube1.DoPositionX(1.5f, 1f, Ease.InOutExpo, 2, LoopType.Yoyo);

            tween1.Started += () => Debug.Log("Started 1");
            tween1.Updated += () => Debug.Log("Updated 1");
            tween1.Completed += () => Debug.Log("Completed 1");

            var tween2 = _cube2.DoPositionX(1.5f, 1f, Ease.InOutExpo, 1);

            tween2.Started += () => Debug.Log("Started 2");
            tween2.Updated += () => Debug.Log("Updated 2");
            tween2.Completed += () => Debug.Log("Completed 2");

            var tween3 = _cube3.DoPositionX(1.5f, 1f, Ease.InOutExpo, 1);

            tween3.Started += () => Debug.Log("Started 3");
            tween3.Updated += () => Debug.Log("Updated 3");
            tween3.Completed += () => Debug.Log("Completed 3");

            ////tween1.Play();

            ////yield return new WaitForSeconds(0.5f);

            ////tween1.Duration = 2f;

            Sequence sequence = new Sequence().SetLoops(2);
            sequence.Append(tween1);
            //sequence.Insert(0f, tween2);
            //sequence.Insert(0f, tween3);
            sequence.Play();
        }
    }
}