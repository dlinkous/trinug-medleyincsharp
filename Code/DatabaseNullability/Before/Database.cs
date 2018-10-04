using System;
using System.Data.SqlClient;

namespace DatabaseNullability.Before
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
							LastName = rdr.IsDBNull(1) ? default(string) : rdr.GetString(1),
							FirstName = rdr.IsDBNull(2) ? default(string) : rdr.GetString(2),
							MiddleName = rdr.IsDBNull(3) ? default(string) : rdr.GetString(3),
							Age = rdr.IsDBNull(4) ? default(short?) : rdr.GetInt16(4),
							LastLogin = rdr.IsDBNull(5) ? default(DateTime?) : rdr.GetDateTime(5),
						};
					}
				}
			}
		}
	}
}
