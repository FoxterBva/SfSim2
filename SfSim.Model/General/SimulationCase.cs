using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model.General
{
	/// <summary>
	/// Contains parameters for specific simulation
	/// </summary>
	public class SimulationCase
	{
		public SimulationCase()
		{
			SourceStats = new ActorStats();
		}

		public string Name { get; set; }
		public int IterationCount { get; set; }
		public int TargetMaxHp { get; set; }

		public ActorStats SourceStats { get; set; }

		public string SymbolsStr { get; set; }

		public string TalentsStr { get; set; }

		// TODO: wpns

		// TODO: amulets

		// TODO: class/rotation
	}
}
