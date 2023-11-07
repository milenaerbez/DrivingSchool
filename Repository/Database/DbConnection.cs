using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{
    public class DbConnection
    {
        SqlConnection connection;
        SqlTransaction transaction;

        public bool IsReady()
        {
            return connection!=null && connection.State!=System.Data.ConnectionState.Closed;
        }

        public void OpenConnection()
        {
            if (!IsReady())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
        }




        public void Close()
        {

            connection?.Close();
           
            transaction.Dispose();
            transaction = null;
        }

        public SqlCommand CreateCommand(string text="")
        {
            if (transaction == null) transaction = connection.BeginTransaction();


            return new SqlCommand(text, connection, transaction);
            
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction?.Rollback();
        }
    }
}
