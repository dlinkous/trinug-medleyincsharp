using System;

namespace Providers.Solution
{
	internal class ShieldForge
	{
		private const int expirationDays = 30;
		private const int armorMinimum = 5;
		private const int armorMaximum = 15;
		private const int enchantmentDenominator = 50;

		private readonly IIdentifierProvider identifierProvider;
		private readonly IDateTimeProvider dateTimeProvider;
		private readonly IRandomProvider randomProvider;

		internal ShieldForge(IIdentifierProvider identifierProvider, IDateTimeProvider dateTimeProvider, IRandomProvider randomProvider)
		{
			this.identifierProvider = identifierProvider;
			this.dateTimeProvider = dateTimeProvider;
			this.randomProvider = randomProvider;
		}

		internal Shield Forge()
		{
			var id = identifierProvider.Generate();
			var expiration = dateTimeProvider.Now.AddDays(expirationDays);
			var armor = randomProvider.Generate(armorMinimum, armorMaximum + 1);
			var enchanted = (randomProvider.Generate(enchantmentDenominator + 1) == 0);
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
