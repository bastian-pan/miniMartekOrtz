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
    }
}