using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mart_Management_System
{
    public class DB
    {
        public static SqlConnection con = null;
        
        const string db_name = "database = MMS;";
        const string host = "server = Coder;";
        const string security = "integrated security = true;";

        public static void Connection()
        {
            con = new SqlConnection(host+db_name+security);
        }
    }
}
