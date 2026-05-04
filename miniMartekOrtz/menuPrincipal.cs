using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniMartekOrtz
{
    public partial class menuPrincipal : Form
    {

        

        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            gestionCategoria gestionCategoria = new gestionCategoria(this);
            gestionCategoria.Show(this);
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            gestionProducto gestionProductos = new gestionProducto(this);
            gestionProductos.Show(this);
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            gestionVenta gestionVentas = new gestionVenta(this);
            gestionVentas.Show(this);
            this.Hide();
        }
    }
}
