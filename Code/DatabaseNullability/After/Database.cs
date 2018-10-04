using System;
using System.Data.SqlClient;

namespace DatabaseNullability.After
{
	internal class Database
	{
		private readonly IConnectionStringProvider connectionStringProvider;

		internal Database(IConnectionStringProvider connectionStringProvider) =>
			this.connectionStringProvider = connectionStringProvider;

		internal Customer GetCustomer(int id)
		{
			using (var con = new SqlConnection(connectionStringProvider.ConnectionString))
			{
				con.Open();
				using (var com = new SqlCommand("SELECT * FROM Customers WHERE Id = @Id", con))
				{
					com.Parameters.AddWithValue("@Id", id);
					using (var rdr = com.ExecuteReader())
					{
						rdr.Read();
						return new Customer()
						{
							Id = rdr.GetInt32(0),
							LastName = rdr.GetStringOrDefault(1),
							FirstName = rdr.GetStringOrDefault(2),
							MiddleName = rdr.GetStringOrDefault(3),
							Age = rdr.GetInt16OrDefault(4),
							LastLogin = rdr.GetDateTimeOrDefault(5)
						};
					}
				}
			}
		}
	}
}
