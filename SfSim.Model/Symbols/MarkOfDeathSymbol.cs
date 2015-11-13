using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.General;
using SfSim.Model.Buffs;

namespace SfSim.Model.Symbols
{
	public class MarkOfDeathSymbol : SymbolBase
	{
		public MarkOfDeathSymbol() : base()
		{
			Name = EntityNames.Symbols.MarkOfDeath;
			InternalCdMS = 40000;
		}

		public override void OnApply(Actor actor)
		{
			// все атакующие способности на OnHit получает дополнительную способность наложить дебафф
			actor.Abilities.ForEach(a =>
				{
					a.AdditionalHitActions.Add((context, dmg) =>
						{
							var symb = context.Source.Symbols.FirstOrDefault(s => s.Name.Equals(this.Name));
							if (symb != null && !symb.IsOnCD(context.CurrentTimeMS))
							{
								// TODO: 1. there is a chance to apply;
								context.ScheduleApplyDeBuff(context.Target, new MarkOfDeathBuff() { Stack = symb.Rank }, null);
								symb.LastActivatedMS = context.CurrentTimeMS;
							}
						});
				});
		}
	}
}
