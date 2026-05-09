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
            int id;
            if (dataGridView1.CurrentRow == null || !int.TryParse(dataGridView1.CurrentRow.Cells["idProductoDataGridViewTextBoxColumn"].Value.ToString(), out id))
            {
                MessageBox.Show("Seleccione un registro válido para eliminar.");
                return;
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
                            MessageBox.Show("Producto Eliminado Exitosamente");
                            this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet.Producto);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un registro con ese ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precioDataGridViewTextBoxColumn"].Value.ToString();

                // Cambio clave: Usamos "Stock" porque así sale en tu ventana de Propiedades
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();

                cmbCategorias.SelectedValue = dataGridView1.CurrentRow.Cells["idCategoriaDataGridViewTextBoxColumn"].Value;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id, stock;
            decimal precio;
            string nombre = txtNombre.Text;

            if (dataGridView1.CurrentRow == null ||
                !int.TryParse(dataGridView1.CurrentRow.Cells["idProductoDataGridViewTextBoxColumn"].Value.ToString(), out id) ||
                string.IsNullOrWhiteSpace(nombre) ||
                !decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtStock.Text, out stock) ||
                cmbCategorias.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un registro y complete todos los campos correctamente.");
                return;
            }

            int idCategoria = (int)cmbCategorias.SelectedValue;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Producto SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock, IdCategoria = @IdCategoria WHERE IdProducto = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        command.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro actualizado exitosamente.");
                            this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet.Producto);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para actualizar.");
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