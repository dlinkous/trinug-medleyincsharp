using System;

namespace Providers.Solution
{
	internal interface IDateTimeProvider
	{
		DateTime Now { get; }
	}
}
