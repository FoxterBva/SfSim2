using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model.General
{
	public abstract class Talent
	{
		public string Name { get; set; }

		/// <summary>
		/// Actions that happens when talent is applied to the actor
		/// </summary>
		public abstract void OnApply(Actor actor);
	}
}
