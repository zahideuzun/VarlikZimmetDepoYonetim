using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.Provider
{
	public class SqlDbService
	{
		private SqlConnection conn;
		private SqlCommand cmd;
		SqlTransaction tran;

		public SqlDbService(string connectionQuery, string connectionString = "server=.\\SQLEXPRESS;database=VarlikZimmetDepo;user id=sa;password=sa;multipleactiveresultsets=true;trustservercertificate=true;")
		{
			conn = new SqlConnection(connectionString);
			cmd = new SqlCommand();
			cmd.CommandText = connectionQuery;
			cmd.Connection = conn;
		}
		public void AddParameter(SqlParameter[] sqlParameters)
		{
			cmd.Parameters.AddRange(sqlParameters);
		}
		public void Open()
		{
			if (conn.State == ConnectionState.Closed) conn.Open();
		}
		public void Close()
		{
			if (conn.State == ConnectionState.Open) conn.Close();
		}

		public SqlDataReader ExReader()
		{
			return cmd.ExecuteReader();
		}
		public int ExecuteNonQuery()
		{
			return cmd.ExecuteNonQuery();
		}

		public int ExcutNon()
		{
			int result = 0;

			try
			{

				Open();
				result = cmd.ExecuteNonQuery();

			}
			catch (Exception ex)
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
			return cmd.ExecuteScalar();
		}

		public void ExecuteTransaction(string queryType, string command, SqlParameter[] parameter)
		{
			Open();
			tran = conn.BeginTransaction();
			cmd.CommandText = command;
			cmd.Transaction = tran;
			int etkilenenSatirSayisi = 0;
			try
			{
				if (parameter != null)
				{
					AddParameter(parameter);
				}

				if (queryType == "insert" || queryType == "update" || queryType == "delete")
				{
					etkilenenSatirSayisi = ExecuteNonQuery();
					if (etkilenenSatirSayisi == 0)
					{
						throw new Exception("hata");
					}
				}
				else
				{
					throw new Exception("hata");
				}

				cmd.Parameters.Clear();
				tran.Commit();

			}
			catch (Exception ex)
			{
				tran.Rollback();

			}
			finally
			{
				Close();
			}
		}

		public void ExecuteTransaction(string[] commands, SqlParameter[] parameter)
		{
			Open();
			tran = conn.BeginTransaction();
			try
			{
				if (parameter != null)
				{
					AddParameter(parameter);
				}
				foreach (string command in commands)
				{
					cmd = new SqlCommand(command, conn, tran);
					int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
					if (etkilenenSatirSayisi == 0)
					{
						throw new Exception("hata");
					}
				}
				tran.Commit();
			}
			catch (Exception ex)
			{
				tran.Rollback();
			}
			finally
			{
				Close();
			}
		}

		public void ExecuteTransaction(string[] commands)
		{
			Open();
			tran = conn.BeginTransaction();
			try
			{
				foreach (string command in commands)
				{
					cmd = new SqlCommand(command, conn, tran);
					int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
					if (etkilenenSatirSayisi == 0)
					{
						throw new Exception("hata");
					}
				}
				tran.Commit();
			}
			catch (Exception ex)
			{
				tran.Rollback();
			}
			finally
			{
				Close();
			}
		}
	}
}
