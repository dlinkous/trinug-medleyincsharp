using System;
using Xunit;
using CloningTests.Domain;

namespace CloningTests.Tests
{
	public class CustomerTests
	{
		[Fact]
		public void ShallowCopyClonesCorrectly()
		{
			var customer1 = new Customer
			{
				LastName = "Last",
				FirstName = "First"
			};
			customer1.Hit();
			customer1.Hit();
			customer1.Hit();
			var customer2 = customer1.ShallowCopy();
			Assert.Equal(customer1.LastName, customer2.LastName);
			Assert.Equal(customer1.FirstName, customer2.FirstName);
			Assert.Equal(customer1.GetHits(), customer2.GetHits());
		}
	}
}
