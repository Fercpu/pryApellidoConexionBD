using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pryApellidoConexionBD
{
    internal class clsConexionBD
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=Producto;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    ______________("✅ Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    ______________("❌ Error al conectar: " + ex.Message);
                }
            }
        }
    }

}

