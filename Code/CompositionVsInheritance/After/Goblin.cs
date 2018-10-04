using System;

namespace CompositionVsInheritance.After
{
	internal class Goblin
	{
		private readonly ManaPool manaPool = new ManaPool();

		internal Goblin() => manaPool.SetMaximum(int.MaxValue);
	}
}
