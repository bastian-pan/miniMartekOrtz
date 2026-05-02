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
    public partial class gestionVenta : Form
    {
        private Form menuPrincipal;

        public gestionVenta(Form menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
        }
    }
}