using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweens;
using UnityEngine.UI;
using Numba.Tweens.Tweaks;
using System;

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

        [SerializeField]
        private Text _text;

        private void Start()
        {
            Tween tween = _cube1.DoPositionX(1f, 1f, Ease.InExpo, 2, LoopType.ReversedYoyo);
            Sequence seq1 = new Sequence(tween.Settings);
        }
    }
}