using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{
    internal class DbConnectionFactory
    {

        private static DbConnectionFactory instance;
        public static DbConnectionFactory Instance
        {
            get
            {
                if (instance == null) instance = new DbConnectionFactory();
                return instance;
            }
        }

        private DbConnectionFactory(){}


        private DbConnection connection = new DbConnection();
        public DbConnection GetDbConnection()
        {
            if (!connection.IsReady())
            {
                //connection = new DbConnection();
                connection.OpenConnection();
            }
            return connection;
        }
    }
}
