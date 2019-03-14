using Numba.Tweens;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNamespace
{
    public class Script : MonoBehaviour
    {
        public Transform cube;

        private void Start()
        {
            cube.DoPositionX(2f, 1f, Ease.ExpoOut).Play();
        }
    }
}