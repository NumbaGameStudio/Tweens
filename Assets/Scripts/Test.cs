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

        //private Tweak _tweak;

        //[SerializeField]
        //[Range(0f, 1f)]
        //private float _interpolation;

        private IEnumerator Start()
        {
            //_tweak = Tweak.Create(0f, 1f, (x) => Debug.Log(x));

            var tween1 = _cube1.DoPositionX(1f, 1f, FormulasUtility.InOutExpo, 2, LoopType.Yoyo);
            var tween2 = _cube2.DoPositionX(1f, 1f, FormulasUtility.Linear, 2, LoopType.Yoyo);

            var sequence = new Sequence().Append(tween1).Insert(0.5f, tween2);
            sequence.Play();

            yield return new WaitForSeconds(1f);

            sequence.Pause();

            yield return new WaitForSeconds(1f);

            sequence.Play();

            //Tween.Create(0f, 1f, (x) => _cube1.position = new Vector3(x, 0f, 0f), 1f).SetEase(FormulasUtility.InOutSine).Play();

            //var tween = _cube1.DoPosition(1f, 2f, 3f, 1f, Ease.Linear, 2, LoopType.Yoyo);
            //tween.Play();

            //yield return new WaitForSeconds(0.75f);

            //tween.Pause();

            //yield return new WaitForSeconds(1f);

            //tween.Stop();
            //tween.Play();
        }

        //private void Update()
        //{
        //    _tweak.SetTo(_interpolation, null);
        //}
    }
}