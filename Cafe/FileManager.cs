using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class FileManager
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leech\Desktop\Cafe256\Cafe\TestDB.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlCommand query(string query)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            return cmd;
        }

        public void close()
        {
            con.Close();
        }
    }

   
}
