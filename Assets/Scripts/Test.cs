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

        private void Start()
        {
            //_tweak = Tweak.Create(0f, 1f, (x) => Debug.Log(x));

            //var tween1 = _cube1.DoPositionX(1f, 1f, FormulasUtility.InOutExpo, 2, LoopType.Yoyo);
            //var tween2 = _cube2.DoPositionX(1f, 1f, FormulasUtility.Linear, 2, LoopType.Yoyo);

            //new Sequence().Append(tween1).Insert(0.5f, tween2).Play();

            Tween.Create(0f, 1f, (x) => _cube1.position = new Vector3(x, 0f, 0f), 1f).SetEase(FormulasUtility.InOutSine).Play();
        }

        //private void Update()
        //{
        //    _tweak.SetTo(_interpolation, null);
        //}
    }
}