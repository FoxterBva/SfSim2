using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.General;
using SfSim.Model.Buffs;

namespace SfSim.Model.Symbols
{
	public class LacerationSymbol : SymbolBase
	{
		public LacerationSymbol() : base()
		{
			Name = EntityNames.Symbols.Laceration;
			InternalCdMS = 0;
		}

		public override void OnApply(Actor actor)
		{
			// все способности на критический OnHit получает дополнительную способность наложить дебафф Рваная рана
			actor.Abilities.ForEach(a =>
			{
				a.AdditionalHitActions.Add((context, dmg) =>
				{
					if (dmg != null && dmg.IsCritical)
					{
						var symb = context.Source.Symbols.FirstOrDefault(s => s.Name.Equals(this.Name));
						if (symb != null && !symb.IsOnCD(context.CurrentTimeMS))
						{
							context.ScheduleApplyDeBuff(context.Target, new LacerationBuff() { Stack = symb.Rank }, null);
							symb.LastActivatedMS = context.CurrentTimeMS;
						}
					}
				});
			});
		}
	}
}
