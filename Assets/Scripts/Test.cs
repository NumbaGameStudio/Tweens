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

        private IEnumerator Start()
        {
            var tween1 = _cube1.DoPositionX(1.5f, 1f, Ease.Linear, 2);
            
            tween1.Started += () => Debug.Log("Started");
            tween1.Updated += () => Debug.Log("Updated");
            tween1.Completed += () => Debug.Log("Completed");

            tween1.Play();

            yield return new WaitForSeconds(0.5f);

            tween1.Duration = 2f;
        }
    }
}