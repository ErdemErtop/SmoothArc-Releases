using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothArc.tools
{
    class DBconnection
    {
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();


        public DBconnection()
        {
            connection.ConnectionString = "Server='185.12.108.76';Database='mimarcrm_wo'; Uid='mimarcrm_wo';Pwd='mimari.crm12354';Charset=utf8";
            command.Connection = connection;

        }

        public DataTable query(string query)
        {
            DataTable results = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                connection.Open();
                command.CommandText = query;
                adapter.Fill(results);
                connection.Close();
            }
            catch (Exception ConnectionEx)
            {
                Console.WriteLine(ConnectionEx.Message);
            }
            return results;
        }


        public void NonQuery(string query)
        {
            connection.Open();
            command.CommandText = query;
            Console.WriteLine(query);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
