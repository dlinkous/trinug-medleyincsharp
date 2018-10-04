using System;

namespace Providers.Problem
{
	internal class ShieldForge
	{
		private const int expirationDays = 30;
		private const int armorMinimum = 5;
		private const int armorMaximum = 15;
		private const int enchantmentDenominator = 50;

		internal Shield Forge()
		{
			var id = Guid.NewGuid();
			var expiration = DateTime.UtcNow.AddDays(expirationDays);
			var random = new Random();
			var armor = random.Next(armorMinimum, armorMaximum + 1);
			var enchanted = (random.Next(enchantmentDenominator + 1) == 0);
			return new Shield()
			{
				Id = id,
				Expiration = expiration,
				Armor = armor,
				Enchanted = enchanted
			};
		}
	}
}
