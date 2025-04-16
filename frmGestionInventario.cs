using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryApellidoConexionBD
{
    public partial class frmGestionInventario : Form
    {
        public frmGestionInventario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Descripcion = txtDescripcion.Text;
            int Precio = Convert.ToInt32(txtPrecio.Text);
            int Stock = Convert.ToInt32(txtStock.Text);
            int Categoria = Convert.ToInt32(txtCategoria.Text);
            clsConexionBD  clase = new clsConexionBD();
            clase.CargarProducto(Nombre,Descripcion,Precio,Stock,Categoria);
        }
    }
}
