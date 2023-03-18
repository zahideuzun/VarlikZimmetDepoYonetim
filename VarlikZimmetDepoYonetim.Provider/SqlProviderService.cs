using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.Provider
{
	public class SqlProviderService
	{
		private SqlConnection conn;
		private SqlCommand cmd;

			public SqlProviderService(string connectionQuery, string Address= "server=.\\SQLEXPRESS;database=ETrade8438;user id=sa;password=sa;multipleactiveresultsets=true;trustservercertificate=true;")
			{
				conn = new SqlConnection(Address);
				cmd = new SqlCommand();
				cmd.CommandText = connectionQuery;

				cmd.Connection = conn;
			}

			void Close()
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}

			}
			void Open()
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}

			}


			public int ExecuteNonQuery()
			{
				int result = 0;

				try
				{

					Open();
					result = cmd.ExecuteNonQuery();

				}
				catch (Exception)
				{

					result = 0;
				}
				finally
				{
					Close();
				}

				return result;



			}

			public object ExecuteScalar()
			{
				object result = null;

				try
				{
					Open();
					result = cmd.ExecuteScalar();
				}
				catch (Exception)
				{


				}
				finally
				{
					Close();
				}

				return result;
			}

			
			public SqlDataReader ExcuteRedaer() 
			{
				SqlDataReader rdr = null;
				try
				{
					Open();
					rdr = cmd.ExecuteReader();
				}
				catch (Exception)
				{


				}
				finally
				{
					Close();
				}

				return rdr;

			}

			public void ParametreEkle(SqlParameter[] sqlParameters)
			{
				cmd.Parameters.AddRange(sqlParameters);

			}

	}
}
