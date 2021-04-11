using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MultiFormApplication
{
    class Database
    {
        public static SqlConnection COnnectDB() {
            string connString = @"Server=DESKTOP-1HKAK02;Database=demo_h_sp21;Integrated Security=true;";
            return new SqlConnection(connString);
        }
    }
}
