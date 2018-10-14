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
            Sequence sequence = new Sequence();
            sequence.Append(_cube1.DoPositionX(1f, 1f));
            sequence.Append(_cube1.DoEulerAnglesY(90f, 1f));
            sequence.Insert(0f, _cube1.DoLocalScaleX(2f, 1f));
            sequence.Insert(0f, () => Debug.Log("cb1"), 1);
            sequence.Insert(0f, () => Debug.Log("cb2"), 0);
            sequence.Insert(0f, () => Debug.Log("cb3"));

            sequence.Play();
        }
    }
}