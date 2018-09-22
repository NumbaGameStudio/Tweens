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

        private void Start()
        {
            var cube1Tween = _cube1.DoPositionX(1.5f, 0f, Ease.InOutExpo, 1);
            cube1Tween.Play();
        }
    }
}