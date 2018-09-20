using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;
using Numba.Tweening.Engine;

namespace Namespace
{
    public class Test : MonoBehaviour
    {
        [SerializeField]
        private Transform _cube1;

        [SerializeField]
        private Transform _cube2;

        private IPlayable _playable;

        [SerializeField]
        [Range(0f, 10f)]
        private float _time;

        private void Start()
        {
            var cube1Tween = _cube1.DoPositionX(1.5f, 1f, Ease.InOutExpo, 1, LoopType.Forward)
                .OnStart(() => { Debug.Log("OnStart cube1."); })
                .OnUpdate(() => { Debug.Log("OnUpdate cube1."); })
                .OnComplete(() => { Debug.Log("OnComplete cube1."); });

            var cube2Tween = _cube2.DoPositionX(-1.5f, 1f, Ease.InOutExpo, 1, LoopType.Forward)
                .OnStart(() => { Debug.Log("OnStart cube2."); })
                .OnUpdate(() => { Debug.Log("OnUpdate cube2."); })
                .OnComplete(() => { Debug.Log("OnComplete cube2."); });

            Sequence sequence = new Sequence(cube1Tween);
            sequence.Insert(0f, cube2Tween, 0);
            sequence.Play();
        }

        private void Update()
        {
            //_sequence.SetTime(_time);
        }
    }
}