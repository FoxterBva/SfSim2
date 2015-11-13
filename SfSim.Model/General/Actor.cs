using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SfSim.Model.Symbols;

namespace SfSim.Model.General
{
	public class Actor
	{
		public Actor()
		{
			BaseStats = new ActorStats();
			CurrentStats = new ActorStats();
			Abilities = new List<Ability>();
			Buffs = new List<Buff>();
			DeBuffs = new List<Buff>();
			Symbols = new List<SymbolBase>();
		}

		public int MaxHp { get; set; }
		public int CurrentHp { get; set; }
		public double HpRatio { get { return MaxHp == 0 ? 0 : (double)CurrentHp / MaxHp; } }

		public int MaxResource { get; set; }
		public int CurrentResource { get; set; }
		public int ResourceGainValue { get; set; }
		public int ResourceGainTickMS { get; set; }

		public ActorStats BaseStats { get; set; }
		public ActorStats CurrentStats { get; set; }
		public List<Ability> Abilities { get; set; }
		public List<Buff> Buffs { get; set; }
		public List<Buff> DeBuffs { get; set; }
		public List<SymbolBase> Symbols { get; set; }

		public void SelectSymbol(SymbolBase symbol)
		{
			symbol.OnApply(this);
			Symbols.Add(symbol);
		}
	}
}
