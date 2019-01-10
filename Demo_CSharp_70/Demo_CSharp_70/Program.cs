using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_70
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_agregar_agregar", sql))
                {                    
                    cmd.CommandType = CommandType.StoredProcedure;            
                    cmd.Parameters.Add(new SqlParameter("@CompanyName", "MiEmpresa S.A.C."));
                    cmd.Parameters.Add(new SqlParameter("@Phone", "959654520"));
                    sql.Open();
                    cmd.ExecuteNonQuery();
                    sql.Close();

                }
            }
        }
    }
}
