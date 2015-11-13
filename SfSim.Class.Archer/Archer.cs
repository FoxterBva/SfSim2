using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.General;

namespace SfSim.Class.Archer
{
	public class Archer : Actor
	{
		public Archer()
			: base()
		{
			MaxResource = 300;
			CurrentResource = MaxResource;
			ResourceGainValue = 5;
			ResourceGainTickMS = 1000;
		}
	}
}
