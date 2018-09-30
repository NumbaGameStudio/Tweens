using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
	internal abstract class InternalFormula : Formula 
	{
        public abstract new Ease Ease { get; }
	}
}