using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Data;
using System.Data.OleDb;

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
        OleDbConnection objConexion;
        public void ConectarAccess(Label lbl) 
        {
           
            try
            {
                objConexion = new OleDbConnection();
                string Ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\InventarioNegocio.accdb";
                objConexion.ConnectionString = Ruta;
                objConexion.Open();
                lbl.Text = "Conectado";

                
            }
            catch ( Exception ex ) 
            {
                lbl.Text = ex.Message;
                MessageBox.Show("Error al Conectar : " + ex.Message);
            }
        }
        public void CargarProducto(String Nombre,String Descripcion,int Precio,int Stock,int Categoria )
        {
            try
            {
                String connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\InventarioNegocio.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString)) 
                {
                    string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, Categoria)" +
                        " VALUES (?,?,?,?,?)";
                    using (OleDbCommand comando = new OleDbCommand(query, connection)) 
                    {
                        comando.Parameters.AddWithValue("?", Nombre);
                        comando.Parameters.AddWithValue("?", Descripcion);
                        comando.Parameters.AddWithValue("?", Precio);
                        comando.Parameters.AddWithValue("?", Stock);
                        comando.Parameters.AddWithValue("?", Categoria);

                        connection.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Producto Cargado Correctamente");

                    }
                }
                

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Cargar Datos : " + ex.Message);
            }



        }
    }

}

