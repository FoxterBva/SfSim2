using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model.General
{
	/// <summary>
	/// Represents abilities do multiple periodical hits
	/// </summary>
	public class PeriodicalHitAbility : Ability
	{
		public PeriodicalHitAbility()
			: base()
		{ }

		public int FirstTickDelayMS { get; set; }		// delay before use and first dmg tick
		public int TickDelayMS { get; set; }				// delay between ticks
	}
}
