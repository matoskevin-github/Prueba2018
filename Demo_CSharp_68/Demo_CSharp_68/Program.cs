using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_68
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            string codCliente = "'BLONP'";

            string query = @"select * from Customers
                             where CustomerID ="+codCliente ;

            DataTable dt = new DataTable();

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    sql.Open();
                    da.Fill(dt);
                    sql.Close();
                }
            }
            Console.Read();
        }
    }
}
