using System;

namespace CompositionVsInheritance.After
{
	internal class ManaPool
	{
		internal int Current { get; private set; }
		internal int Maximum { get; private set; }
		internal int RegenerationRate { get; set; }

		internal void SetMaximum(int maximum)
		{
			Maximum = maximum;
			if (Current > Maximum) Current = Maximum;
		}

		internal void Decrement(int amount)
		{
			Current -= amount;
			if (Current < 0) Current = 0;
		}

		internal void Increment()
		{
			Current += RegenerationRate;
			if (Current > Maximum) Current = Maximum;
		}
	}
}
