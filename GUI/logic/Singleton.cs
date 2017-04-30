using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace logic
{
   public class Singleton
    {
        string servername = "dtsl.ehb.be";
        string username = "JAVA051";
        string password = "73496512";
        string dbname = "JAVA051";
        string connectionString =null;
        MySqlConnection conn=null;

        public Singleton()
        {
            connectionString = "SERVER=" + servername + ";" + "DATABASE=" + dbname + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new FieldAccessException("geen connectie met database: " + ex);
            }
        }
        public MySqlConnection getConn(){
            conn.Open();
            return conn;

        }
        public void closeConn()
        {
            conn.Close();

        }
    }
}
