using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.General;

namespace SfSim.Model.Symbols
{
	public abstract class SymbolBase
	{
		public SymbolBase()
		{
			LastActivatedMS = -1;
		}

		public string Name { get; set; }
		public int InternalCdMS { get; set; }
		public int LastActivatedMS { get; set; }
		public int Rank { get; set; }

		/// <summary>
		/// Actions that happens when symbol is applied to the actor
		/// </summary>
		public abstract void OnApply(Actor actor);

		public bool IsOnCD(int timeMS)
		{
			return LastActivatedMS >= 0 && timeMS < LastActivatedMS + InternalCdMS;
		}
	}
}
