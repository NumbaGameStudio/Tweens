using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;
using UnityEngine.UI;
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

        [SerializeField]
        private Text _text;

        private void Start()
        {
            
            _text.DoText("Hello Tweens! Hello Tweens! Hello Tweens! Hello Tweens! Hello Tweens!", 1f, Ease.InOutExpo, -1, LoopType.ReversedYoyo).Play();
        }
    }
}