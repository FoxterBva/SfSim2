using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.General;
using SfSim.Model;

namespace SfSim.Class.Archer.Talents
{
	/// <summary>
	/// Redusec abilities resource cost by 20
	/// </summary>
	public class ChargingMechanismTalent : Talent
	{
		public ChargingMechanismTalent()
			: base()
		{
			Name = EntityNames.Talents.Archer.ChargingMechanism;
		}

		public override void OnApply(Actor actor)
		{
			actor.Abilities.ForEach(a =>
			{
				if (a.Name.Equals(EntityNames.Abilities.Archer.AimedShot) ||
					a.Name.Equals(EntityNames.Abilities.Archer.ElectricShot) ||
					a.Name.Equals(EntityNames.Abilities.Archer.FireArrow))
				{
					a.ResourceCost = Math.Max(a.ResourceCost - 20, 0);
				}
			});
		}
	}
}
