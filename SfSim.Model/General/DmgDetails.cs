using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model.General
{
	public class DmgDetails
	{
		public int AbilityIndex { get; set; }

		public double MightDmg { get; set; }
		public double StrDmg { get; set; }
		public double BraveDmg { get; set; }
		public double LuckDmg { get; set; }
		public double SpiritDmg { get; set; }
		public double AmuletDmg { get; set; }

		public double TotalDmg { get; }

		public bool IsCritical { get; set; }
		public bool IsImpulse { get; set; }
		public bool IsCrushing { get; set; }
		public bool IsTestiness { get; set; }
	}
}
