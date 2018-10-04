using System;

namespace DatabaseNullability
{
	internal class Customer
	{
		internal int Id { get; set; }
		internal string LastName { get; set; }
		internal string FirstName { get; set; }
		internal string MiddleName { get; set; }
		internal short? Age { get; set; }
		internal DateTime? LastLogin { get; set; }
	}
}
