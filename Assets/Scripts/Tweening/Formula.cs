using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening
{
	public abstract class Formula 
	{
        public abstract float Calculate(float interpolation);
	}
}