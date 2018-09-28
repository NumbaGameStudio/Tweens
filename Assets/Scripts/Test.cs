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
            Tween.Create(0f, 1f, (i) =>
            {
                float x = Easing.Ease(0f, 4f, i, new QuadraticInOutFormula());
                _cube1.position = new Vector3(x, 0f, 0f);
            }, 1f).Play();

            //_cube1.DoPositionX(1f, 1f, Ease.InQuad).Play();
        }
    }
}