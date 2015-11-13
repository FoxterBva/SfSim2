using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model.General
{
	public class EnvironmentContext
	{
		public EnvironmentContext()
		{
			AbilityNames = new Dictionary<int, string>();
		}

		public Actor Source { get; set; }
		public Actor Target { get; set; }

		public int CurrentTimeMS { get; private set; }
		public Dictionary<int, string> AbilityNames { get; set; }				// Dictionary to store int<->ability mapping for damage events to remove necessity to store ability names multiple times


		public void ScheduleApplyBuff(Actor actor, Buff buff, int? time)
		{ }

		public void ScheduleApplyDeBuff(Actor actor, Buff buff, int? time)
		{ }

		public void ScheduleResourceTick(int resource, int? time)
		{ }
	}

	public delegate void AbilityAction(EnvironmentContext context, DmgDetails dmgDetails);
}
