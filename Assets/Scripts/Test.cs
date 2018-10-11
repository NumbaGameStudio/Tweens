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
            float easedValue = Easing.Ease(0f, 15f, 0.75f, Ease.Linear);
            Debug.Log(easedValue);
        }

        // This method just write person info to UI text.
        private void WritePersonInfo(PersonInfo info)
        {
            _text.text = string.Format("{0} {1}", info.Age, info.Name);
        }

        public struct PersonInfo
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public PersonInfo(int age, string name)
            {
                Age = age;
                Name = name;
            }
        }

        public class TweakPersonInfo : Tweak<PersonInfo>
        {
            public TweakPersonInfo(PersonInfo from, PersonInfo to, Action<PersonInfo> setter) 
                : base(from, to, setter) { }

            public override PersonInfo Evaluate(float interpolation, Formula formula, bool useSwap = false)
            {
                return Evaluate(useSwap, (from, to) =>
                {
                    PersonInfo info = new PersonInfo
                    {
                        Age = Easing.Ease(from.Age, to.Age, interpolation, formula),
                        Name = Easing.Ease(from.Name, to.Name, interpolation, formula)
                    };

                    return info;
                });
            }
        }
    }
}