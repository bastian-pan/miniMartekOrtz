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
    public partial class gestionCategoria : Form
    {
        
        private Form menuPrincipal;

        
        public gestionCategoria(Form menu)
        {
            InitializeComponent();
            
            this.menuPrincipal = menu;
        }

        // Ejemplo de cómo usarlo para volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menuPrincipal.Show(); 
            this.Close(); 
        }
    }
}