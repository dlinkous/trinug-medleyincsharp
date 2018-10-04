using System;

namespace DatabaseNullability
{
	internal interface IConnectionStringProvider
	{
		string ConnectionString { get; }
	}
}
