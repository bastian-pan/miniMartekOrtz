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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "admin" && contraseña == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso");
                menuPrincipal menu = new menuPrincipal();
                menu.Show(this);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
