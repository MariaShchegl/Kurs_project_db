using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ARMLibrary3_2
{
    class QueryDB
    {
        static MySqlConnection conn = new MySqlConnection("Data source=localhost;UserId=root;Password=;database=library;");

        public static void connectionClose()
        {
            conn.Close();
        }

        public static void noQueryDB(string sql)
        {
            conn.Open();

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;
            command.CommandText = sql;

            command.ExecuteNonQuery();

            conn.Close();
        }

        public static MySqlCommand QueryResult(string sql)
        {
            conn.Open();

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;
            command.CommandText = sql;

            return command;
        }
    }
}
