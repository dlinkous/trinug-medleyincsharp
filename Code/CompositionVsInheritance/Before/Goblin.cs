using System;

namespace CompositionVsInheritance.Before
{
	internal class Goblin : Character
	{
		internal Goblin() => base.SetMaximumMana(int.MaxValue);
	}
}
