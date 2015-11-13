using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model.General
{
	public abstract class Ability
	{
		public Ability()
		{
			AdditionalCastActions = new List<AbilityAction>();
			AdditionalHitActions = new List<AbilityAction>();
		}

		public string Name { get; set; }

		// Parameters
		public int ResourceCost { get; set; }
		public double AbilityDmgMod { get; set; }
		public double AbilityImpulseDmgMod { get; set; }
		public bool UseImpulse { get; set; }
		public int CastTimeMS { get; set; }
		public int TravelTimeMS { get; set; }
		public int TotalUseTimeMS { get; set; }

		public List<AbilityAction> AdditionalCastActions { get; set; }
		public List<AbilityAction> AdditionalHitActions { get; set; }

		/// <summary>
		/// Fired when user starts ability (keypress)
		/// </summary>
		public virtual void OnCastStart()
		{ 

		}

		/// <summary>
		/// Fired after abilitie's cast time
		/// </summary>
		public virtual void OnCast(EnvironmentContext context)
		{
			foreach (var action in AdditionalHitActions)
			{
				action(context, null);
			}
		}

		/// <summary>
		/// Fired when ability hits target
		/// </summary>
		public virtual void OnHit(EnvironmentContext context, DmgDetails dmgDetails)
		{
			foreach (var action in AdditionalHitActions)
			{
				action(context, dmgDetails);
			}
		}
	}
}
