using System;

namespace CompositionVsInheritance.Before
{
	internal class Player : Character
	{
		internal Player(int maximumMana) => base.SetMaximumMana(maximumMana);

		internal void Tick() => base.IncrementMana();
	}
}
