using System;

namespace CloningTests.Domain
{
	internal class Customer
	{
		internal string LastName { get; set; }
		internal string FirstName { get; set; }
		private int Hits { get; set; }

		internal void Hit() => Hits++;

		internal int GetHits() => Hits;

		internal Customer ShallowCopy() =>
			(Customer)MemberwiseClone();
	}
}
