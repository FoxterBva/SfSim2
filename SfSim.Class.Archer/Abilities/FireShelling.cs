using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.General;
using SfSim.Model;

namespace SfSim.Class.Archer.Abilities
{
	public class FireShelling : PeriodicalHitAbility
	{
		public FireShelling()
			: base()
		{
			Name = EntityNames.Abilities.Archer.FireShelling;
			FirstTickDelayMS = 250;
			TickDelayMS = 250;
			ResourceCost = 100;
			UseImpulse = false;
			AbilityDmgMod = 4.7;
			AbilityImpulseDmgMod = 0;
			TotalUseTimeMS = 4000;
		}
	}
}
