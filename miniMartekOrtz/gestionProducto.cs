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
            string precioTexto = txtPrecio.Text;
            string stockTexto = txtStock.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(precioTexto) || string.IsNullOrWhiteSpace(stockTexto) || cmbCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            decimal precio = decimal.Parse(precioTexto);
            int stock = int.Parse(stockTexto);
            int idCategoria = Convert.ToInt32(cmbCategorias.SelectedValue);

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            string query = "INSERT INTO Producto (Nombre, Precio, Stock, IdCategoria) VALUES (@Nombre, @Precio, @Stock, @IdCategoria)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@IdCategoria", idCategoria);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto registrado con éxito.");
                            this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet.Producto);

                            txtNombre.Clear();
                            txtPrecio.Clear();
                            txtStock.Clear();
                            cmbCategorias.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el producto.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void gestionProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.miniMarketOrtzDataSet.Categoria);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menuPrincipal.Show();
            this.Close();
        }
    }
}