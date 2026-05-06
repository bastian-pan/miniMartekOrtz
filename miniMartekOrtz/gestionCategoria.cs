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
            // Leer datos
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor ingrese un nombre y una descripción válidos.");
                return;
            }

            
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Categoria (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);

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
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(dataGridView1.CurrentRow.Cells["idCategoriaDataGridViewTextBoxColumn"].Value.ToString(), out id))
            {
                MessageBox.Show("Ingrese un ID valido para eliminar.");
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    string query = "DELETE FROM Categoria WHERE IdCategoria = @Id";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Categoria Eliminada Exitosamente");
                            this.categoriaTableAdapter.Fill(this.miniMarketOrtzDataSet.Categoria);
                        }

                        else
                        {
                            MessageBox.Show("No se encontro un registro con ese ID.");
                        }

                    }


                }

                catch(Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}