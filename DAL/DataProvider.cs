using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class DataProvider
    {
        #region propers:
        public static SqlConnection sqlConnection;
        
        #endregion
        //Connect to database:
        public static bool Connect(string strConnect)
        {
            try
            {
                sqlConnection = new SqlConnection(strConnect);
                sqlConnection.Open();
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }
        }

        //Query data:
        public static DataTable Query(string sqlQuery)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable tbl = new DataTable();
                sqlDataAdapter.Fill(tbl);
                return tbl;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //Execute sql command:
        public static bool ExeSql(string strCommand)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(strCommand, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
