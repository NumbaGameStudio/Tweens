using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweens
{
    /// <summary>
    /// Represent base class for internal (built-in) formulas.
    /// </summary>
	internal abstract class InternalFormula : Formula 
	{
        /// <summary>
        /// Formula's associated ease type.
        /// </summary>
        public abstract new Ease Ease { get; }
	}
}