using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;
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

        private void Start()
        {
            _cube1.DoPositionX(2f, 1f, Ease.InOutExpo, 2, LoopType.Yoyo).Play();
            _cube1.DoEulerAnglesY(90f, 1f, Ease.InOutExpo).Play();
            //Tween.Create("", "Gusen and Albina, and Omar and Zuhra loves vice versa too", (s) => _text.text = s.ToString(), 2f, Ease.InOutExpo).Play();
            //Tween.Create('G', 'Z', (s) => _text.text = s.ToString(), 1f, Ease.OutQuint).Play();
        }
    }
}