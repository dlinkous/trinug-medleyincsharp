using System;

namespace Decoration
{
	internal class Consumer
	{
		private readonly IDatabase database;

		internal Consumer(IDatabase database) => this.database = database;

		internal Report GetReport(int id) =>
			new Report()
			{
				Total = database.GetTotal(),
				Name = database.GetName(id)
			};
	}
}
