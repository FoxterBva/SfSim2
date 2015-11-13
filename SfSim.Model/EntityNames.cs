using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SfSim.Model
{
	public static class EntityNames
	{
		public static class Symbols
		{
			public static readonly string MarkOfDeath = "Метка смерти";
			public static readonly string Laceration = "Рваная рана";
		}

		public static class Abilities
		{
			public static class Archer
			{
				public static readonly string SingleShot = "Одиночный выстрел";
				public static readonly string PiercingShot = "Пронзающий выстрел";
				public static readonly string AimedShot = "Прицельный выстрел";
				public static readonly string ElectricShot = "Электрический выстрел";
				public static readonly string FireArrow = "Горящая стрела";
				public static readonly string FireShelling = "Огненный обстрел";
			}
		}

		public static class Talents
		{
			public static class Archer
			{
				public static readonly string ChargingMechanism = "Зарядный механизм";
			}
		}
	}
}
