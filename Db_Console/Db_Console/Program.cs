using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Db_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connString = @"Server=DESKTOP-1HKAK02;Database=demo_h_sp21;User Id=sa;Password=1234;";
            string connString = @"Server=DESKTOP-1HKAK02;Database=demo_h_sp21;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            /*string query = "insert into users values ('abdur kader','a_kader','23335')";
            SqlCommand cmd = new SqlCommand(query,conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                Console.WriteLine("Added");
            }
            else {
                Console.WriteLine("Not added");
            }*/
            string query = "select * from users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id\tName\t\t\t\tUsername");
            while (reader.Read()) {
                int id = reader.GetInt32(reader.GetOrdinal("Id"));
                string name = reader.GetString(1);
                string username = reader.GetString(2);
                Console.WriteLine("{0}\t{1}\t{2}",id,name,username);
            }
            conn.Close();

        }
    }
}
