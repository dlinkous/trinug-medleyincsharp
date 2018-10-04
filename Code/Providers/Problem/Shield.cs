using System;

namespace Providers.Problem
{
	internal class Shield
	{
		internal Guid Id { get; set; }
		internal DateTime Expiration { get; set; }
		internal int Armor { get; set; }
		internal bool Enchanted { get; set; }
	}
}
