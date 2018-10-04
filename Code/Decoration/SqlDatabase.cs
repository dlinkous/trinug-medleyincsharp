using System;
using System.Threading;

namespace Decoration
{
	internal class SqlDatabase : IDatabase
	{
		public int GetTotal()
		{
			// Complex/Slow SQL database access here
			Thread.Sleep(2000);
			return int.MaxValue;
		}

		public string GetName(int id)
		{
			// Simple/Fast SQL database access here
			return string.Empty;
		}
	}
}
