using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQLconnector
{
    internal class DataBase
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=Reference");

        public bool checkConnect()
        {
            try
            {
                OpenConnection();
                CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            if (checkConnect() == true)
                return Connection;
            else 
                return null;
        }
    }
}
