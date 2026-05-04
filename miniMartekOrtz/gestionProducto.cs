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
    public partial class gestionProducto : Form
    {
        
        private Form menuPrincipal;

        
        public gestionProducto(Form menu)
        {
            InitializeComponent();
            
            this.menuPrincipal = menu;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menuPrincipal.Show();
            this.Close();
        }

        private void gestionProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet3.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.miniMarketOrtzDataSet3.Categoria);

        }
    }
}