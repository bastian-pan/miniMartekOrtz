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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Leer datos 
            string nombre = txtNombre.Text;
            decimal precio;
            int stock;

            if (string.IsNullOrWhiteSpace(nombre) || !decimal.TryParse(txtPrecio.Text, out precio) || !int.TryParse(txtStock.Text, out stock) || cmbCategorias.SelectedValue == null)
            {
                MessageBox.Show("Por favor ingrese datos válidos en todos los campos.");
                return;
            }

            int idCategoria = (int)cmbCategorias.SelectedValue;

            
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Producto (Nombre, Precio, Stock, IdCategoria) VALUES (@Nombre, @Precio, @Stock, @IdCategoria)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@IdCategoria", idCategoria);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro insertado exitosamente.");
                            this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet.Producto);

                            txtNombre.Clear();
                            txtPrecio.Clear();
                            txtStock.Clear();
                            cmbCategorias.SelectedIndex = -1;
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



        private void gestionProducto_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet.Producto);
            this.categoriaTableAdapter.Fill(this.miniMarketOrtzDataSet.Categoria);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menuPrincipal.Show();
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            {
                int id;
                if (!int.TryParse(dataGridView1.CurrentRow.Cells["idProductoDataGridViewTextBoxColumn"].Value.ToString(), out id))
                {
                    MessageBox.Show("Ingrese un ID valido para eliminar.");
                }

                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        string query = "DELETE FROM Producto WHERE IdProducto = @Id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Categoria Eliminada Exitosamente");
                                this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet.Producto);
                            }

                            else
                            {
                                MessageBox.Show("No se encontro un registro con ese ID.");
                            }

                        }


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}