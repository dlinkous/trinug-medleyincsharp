using System;

namespace CompositionVsInheritance.After
{
	internal class Player
	{
		private readonly ManaPool manaPool = new ManaPool();

		internal Player(int maximumMana) => manaPool.SetMaximum(maximumMana);

		internal void Tick() => manaPool.Increment();
	}
}
