using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShelfUI
{
    class ProjectConnection
    {
        //Class for connectiong SQL between Forms
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = BookStoreDB; Integrated Security = True;";
            return con;
        }

         
    }
}
