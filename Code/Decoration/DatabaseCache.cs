using System;

namespace Decoration
{
	internal class DatabaseCache : IDatabase
	{
		private readonly IDatabase database;

		private int total;
		private DateTime lastUpdate;
		private const int cacheSeconds = 5;

		internal DatabaseCache(IDatabase database) => this.database = database;

		public int GetTotal()
		{
			if (DateTime.UtcNow > lastUpdate.AddSeconds(cacheSeconds))
			{
				total = database.GetTotal();
				lastUpdate = DateTime.UtcNow;
			}
			return total;
		}

		public string GetName(int id) => database.GetName(id);
	}
}
