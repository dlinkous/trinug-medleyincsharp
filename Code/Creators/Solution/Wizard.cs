using System;

namespace Creators.Solution
{
	internal class Wizard
	{
		internal int Mana { get; private set; }
		internal int Gold { get; private set; }

		private const int DefaultMana = 100;
		private const int DefaultGold = 20;

		private Wizard() { }

		internal static Wizard CreateWithMana(int mana) =>
			new Wizard()
			{
				Mana = mana,
				Gold = DefaultGold
			};

		internal static Wizard CreateWithGold(int gold) =>
			new Wizard()
			{
				Mana = DefaultMana,
				Gold = gold
			};
	}
}
