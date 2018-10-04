using System;
using System.Data.SqlClient;

namespace DatabaseNullability.After
{
	public static class DatabaseExtensions
	{
		public static string GetStringOrDefault(this SqlDataReader rdr, int index) =>
			rdr.IsDBNull(index) ? default(string) : rdr.GetString(index);

		public static short? GetInt16OrDefault(this SqlDataReader rdr, int index) =>
			rdr.IsDBNull(index) ? default(short?) : rdr.GetInt16(index);

		public static DateTime? GetDateTimeOrDefault(this SqlDataReader rdr, int index) =>
			rdr.IsDBNull(index) ? default(DateTime?) : rdr.GetDateTime(index);
	}
}
