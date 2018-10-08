using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweens;
using UnityEngine.UI;

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

        private IEnumerator Start()
        {
            yield return _cube1.DoPositionX(1f, 1f, Ease.InOutExpo, 2, LoopType.Yoyo).Play();
            _text.DoText("Hello Tweens! Hello Tweens! Hello Tweens! Hello Tweens! Hello Tweens!", 1f, Ease.InOutExpo, -1, LoopType.ReversedYoyo).Play();
        }
    }
}