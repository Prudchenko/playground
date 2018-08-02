using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace playgnd.Models.DataBase
{
    public class DbConnection : IDisposable
    {
        public MySqlConnection Connection;

        public DbConnection()
        {
            Connection = new MySqlConnection("server=195.123.8.52;User ID=********;Password=************;Database=testDB;SslMode=none;CHARSET=utf8;");
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
