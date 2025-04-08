using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace pryApellidoConexionBD
{
    internal class clsConexionBD
    {
        public void Main(Label lbl)
        {
            string connectionString = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    lbl.Text = "Conectado";

                }
                catch (Exception ex)
                {
                    lbl.Text = ex.Message;
                    MessageBox.Show("Error al Conectar : " + ex.Message);
                }

            }
        }
        public void BuscarProducto() 
        {
            try
            {
                string query = "SELECT Nombre FROM Categorias ";
                String connectionString = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            MessageBox.Show($"{reader["Nombre"]} ");
                        }
                    }
                }
            }
            catch ( Exception ex ) 
            {
            
                MessageBox.Show("Error al Conectar : " + ex.Message);
            }

           

        }
    }

}

