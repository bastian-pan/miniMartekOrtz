using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menuPrincipal.Show(); 
            this.Close(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreCategoria = txtNombre.Text;
            string descripcionCategoria = txtDescripcion.Text;

            if (string.IsNullOrWhiteSpace(nombreCategoria) || string.IsNullOrWhiteSpace(descripcionCategoria)) 
            {
                MessageBox.Show("Los campos son obligatorios.");
                return;
            }

            
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
    
            
            string query = "INSERT INTO Categoria (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";

            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Nombre", nombreCategoria);
                        command.Parameters.AddWithValue("@Descripcion", descripcionCategoria);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro insertado exitosamente.");
                            this.categoriaTableAdapter.Fill(this.miniMarketOrtzDataSet.Categoria);
                            txtNombre.Clear();
                            txtDescripcion.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el registro.");
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}");
            }
        }

        private void gestionCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.miniMarketOrtzDataSet.Categoria);



        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.menuPrincipal.Show();
            this.Close();
        }
    }
}