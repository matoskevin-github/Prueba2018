using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_69
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            string codCliente = "BLONP";

          

            DataTable dt = new DataTable();

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_buscar_cliente_por_pais", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idPais", SqlDbType.NVarChar, 5).Value = codCliente;
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
