using System;

namespace Providers.Solution
{
	internal interface IIdentifierProvider
	{
		Guid Generate();
	}
}
