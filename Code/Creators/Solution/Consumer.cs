using System;

namespace Creators.Solution
{
	internal class Consumer
	{
		internal void Execute()
		{
			//var wizard1 = new Wizard();
			var wizard2 = Wizard.CreateWithMana(34);
			var wizard3 = Wizard.CreateWithGold(61);
		}
	}
}
