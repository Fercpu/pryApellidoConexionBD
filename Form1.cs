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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            clsConexionBD BD = new clsConexionBD();
            BD.Main(lblConexion);
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            clsConexionBD BD = new clsConexionBD();
            BD.BuscarProducto();
        }

       
    }
}
