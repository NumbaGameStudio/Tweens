﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Numba.Tweening;

namespace Namespace
{
	public class Test : MonoBehaviour 
	{
        [SerializeField]
        private Transform _cube1;

        [SerializeField]
        private Transform _cube2;

        private Sequence _sequence;

        private Tween _tween;

        [SerializeField]
        [Range(0f, 10f)]
        private float _time;

		private void Start()
		{
            _tween = _cube1.DoPositionX(1f, 2f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Forward);

            _tween.Play();

            //yield return new WaitForSeconds(1f);

            //_tween.Stop();
            //_tween.Play();

            //_sequence = new Sequence().SetLoops(-1, LoopType.Forward);
            //_sequence.Append(_cube1.DoPositionX(1.5f, 2f).SetEase(Ease.Linear).SetLoops(1, LoopType.Forward));
            //_sequence.Insert(0f, _cube2.DoPositionX(1.5f, 2f).SetEase(Ease.InOutExpo));

            //_sequence.Play();

            //yield return new WaitForSeconds(1f);

            //_sequence.Stop();
            //_sequence.Play();
        }

        private void Update()
        {
            //_sequence.SetTime(_time);
        }
    }
}