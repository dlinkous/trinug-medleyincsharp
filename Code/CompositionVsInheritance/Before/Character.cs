using System;

namespace CompositionVsInheritance.Before
{
	internal abstract class Character
	{
		protected int CurrentMana { get; private set; }
		protected int MaximumMana { get; private set; }
		protected int ManaRegenerationRate { get; set; }

		protected void SetMaximumMana(int maximum)
		{
			MaximumMana = maximum;
			if (CurrentMana > MaximumMana) CurrentMana = MaximumMana;
		}

		protected void DecrementMana(int amount)
		{
			CurrentMana -= amount;
			if (CurrentMana < 0) CurrentMana = 0;
		}

		protected void IncrementMana()
		{
			CurrentMana += ManaRegenerationRate;
			if (CurrentMana > MaximumMana) CurrentMana = MaximumMana;
		}
	}
}
