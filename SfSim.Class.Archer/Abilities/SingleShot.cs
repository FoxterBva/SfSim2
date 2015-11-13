using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.General;
using SfSim.Model;

namespace SfSim.Class.Archer.Abilities
{
	class SingleShot : Ability
	{
		public SingleShot()
			: base()
		{
			Name = EntityNames.Abilities.Archer.SingleShot;

			this.AdditionalCastActions.Add((context, dmgDetails) => { });
		}

		public override void OnCast(EnvironmentContext context)
		{
			base.OnCast(context);

			// Possible additional actions
			// 1. If bow -> apply debuff
			// 2. If спазмы + импульс -> apply debuff
			// 3. Restores energy
			// 4. If рана + крит -> apply debuff
			// 5. If симв. кинетика и импульс -> apply buff

			context.ScheduleApplyBuff(context.Source, new Buff(), null);
		}

		public override void OnHit(EnvironmentContext context, DmgDetails dmgDetails)
		{
			base.OnHit(context, dmgDetails);

			// Possible additional actions
			// 1. If bow -> apply debuff
			// 2. If спазмы + импульс -> apply debuff
			// 3. Restores energy
			// 4. If рана + крит -> apply debuff
			// 5. If симв. кинетика и импульс -> apply buff

			context.ScheduleApplyBuff(context.Source, new Buff(), null);
		}
	}
}
