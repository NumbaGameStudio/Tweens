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
            //_playable = _cube1.DoPositionX(1f, 2f).OnStart(() => { Debug.Log("Started"); }).SetEase(Ease.InOutExpo).SetLoops(-1, LoopType.Forward);

            //_playable.Play();

            //yield return new WaitForSeconds(1f);

            //_tween.Stop();
            //_tween.Play();

            Sequence moveSequence = new Sequence().SetLoops(-1, LoopType.Yoyo)
                .Append(_cube1.DoPositionX(1.5f, 1f, Ease.InOutExpo))
                .Insert(0f, _cube2.DoPositionX(-1.5f, 1f, Ease.InOutExpo));

            Sequence rotateSequence = new Sequence().SetLoops(-1, LoopType.Yoyo)
                .Append(_cube1.DoEulerAnglesY(90f, 1f, Ease.InOutExpo))
                .Insert(0f, _cube2.DoEulerAnglesY(-90f, 1f, Ease.InOutExpo));

            moveSequence.Append(rotateSequence);

            moveSequence.Play();

            //yield return new WaitForSeconds(1f);

            //_sequence.Stop();
            //_sequence.Play();
        }

        private void Update()
        {
            //_sequence.SetTime(_time);
        }
    }
}