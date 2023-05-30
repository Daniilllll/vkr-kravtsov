using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkr_kravtsov
{
    class DB
    {
        //port=3306;
        public MySqlConnection connection;
        private const string connStr = "server=localhost;user=root;password=root;database=stroisila";

        public static string SqlConnection
        {   get
            {
                return connStr;
            }
        }

        public object getConnection { get; internal set; }

        public DB ()
        {
            connection = new MySqlConnection(connStr);
            //openConnection(connection);
            //connection.Open();
        }

      
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        //{
        //    return connection;
        //}

    }
}
