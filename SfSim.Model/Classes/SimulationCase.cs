using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model.Classes
{
	/// <summary>
	/// Contains parameters for specific simulation
	/// </summary>
	public class SimulationCase
	{
		public string Name { get; set; }
		public int IterationCount { get; set; }
		public int TargetMaxHp { get; set; }

		public ActorStats SourceStats { get; set; }

		// TODO: symbols

		// TODO: talents

		// TODO: wpns

		// TODO: amulets

		// TODO: class/rotation
	}
}
