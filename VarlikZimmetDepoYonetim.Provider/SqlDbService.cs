
using System.Data.SqlClient;
using System.Data;


namespace VarlikZimmetDepoYonetim.Provider
{
	public class SqlDbService
	{
		private SqlConnection conn;
		private SqlCommand cmd;
		
		/// <summary>
		/// Database baglantisini yapan parametreli constructor. 
		/// </summary>
		/// <param name="connectionQuery"></param>
		/// <param name="connectionString"></param>
		public SqlDbService(string connectionQuery, string connectionString = "server=.\\SQLEXPRESS;database=VarlikZimmetDepo;user id=sa;password=sa;multipleactiveresultsets=true;trustservercertificate=true;")
		{
			conn = new SqlConnection(connectionString);
			cmd = new SqlCommand();
			cmd.CommandText = connectionQuery;
			cmd.Connection = conn;
		}

		/// <summary>
		/// SqlParameter tipinde sorgulara parametre eklemeyi saglayan özellestirilmis metot.
		/// </summary>
		/// <param name="sqlParameters"></param>
		public void AddParameters(SqlParameter[] sqlParameters)
		{
			cmd.Parameters.AddRange(sqlParameters);
		}

		/// <summary>
		/// Database baglantisini acan özellestirilmis metot.
		/// </summary>
		public void Open()
		{
			if (conn.State == ConnectionState.Closed) conn.Open();
		}

		/// <summary>
		/// Database bağlantısını kapatan özellestirilmis metot.
		/// </summary>
		public void Close()
		{
			if (conn.State == ConnectionState.Open) conn.Close();
		}

		/// <summary>
		/// SqlDataReader tipindeki, select sorgularinda kullanilan veri okuma metodu.
		/// </summary>
		/// <returns></returns>
		public SqlDataReader ExecuteReader()
		{
			return cmd.ExecuteReader();
		}

		/// <summary>
		/// Insert, update, delete (DDL) sorgularindan etkilenen satır sayisini int tipinde dönen metot.
		/// </summary>
		/// <returns></returns>
		public int ExecuteNonQuery()
		{
			return cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Tek satır, tek sütun veri dönmek istedigimde kullanilan object dönen özellestirilmis metot.
		/// </summary>
		/// <returns></returns>
		public object ExecuteScalar()
		{
			return cmd.ExecuteScalar();
		}

	}
}
