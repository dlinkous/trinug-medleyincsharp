using System;

namespace Providers.Solution
{
	internal interface IRandomProvider
	{
		int Generate(int min, int max);
		int Generate(int max);
	}
}
