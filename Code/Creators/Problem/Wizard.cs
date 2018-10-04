using System;

namespace Creators.Problem
{
	internal class Wizard
	{
		internal int Mana { get; private set; }
		internal int Gold { get; private set; }

		private const int DefaultMana = 100;
		private const int DefaultGold = 20;

		internal Wizard(int mana)
		{
			Mana = mana;
			Gold = DefaultGold;
		}

		//internal Wizard(int gold)
		//{
		//	Mana = DefaultMana;
		//	Gold = gold;
		//}
	}
}
