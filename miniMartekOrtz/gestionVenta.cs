using MiniMarketOrtz.Modelos;
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
    public partial class gestionVenta : Form
    {
        private Form menuPrincipal;

        List<DetalleVenta> carrito = new List<DetalleVenta>();

        public gestionVenta(Form menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
        }

        private void gestionVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter1.Fill(this.miniMarketOrtzDataSet.venta);
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet5.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.miniMarketOrtzDataSet5.venta);
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet4.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter2.Fill(this.miniMarketOrtzDataSet4.Producto);
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet2.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.miniMarketOrtzDataSet2.Producto);
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet1.Producto);

            dgvCarrito.Columns.Clear();
            dgvCarrito.Columns.Add("Producto", "Producto");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("Precio", "Precio");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");

            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.menuPrincipal.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            decimal totalVenta = carrito.Sum(item => item.Cantidad * item.PrecioUnitario);

            string queryVenta = "INSERT INTO Venta (Fecha, Total) VALUES (@Fecha, @Total); SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(queryVenta, connection))
                    {
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Total", totalVenta);
                        cmd.ExecuteNonQuery();
                    }

                    foreach (var item in carrito)
                    {
                        string update = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE IdProducto = @IdProducto";

                        using (SqlCommand cmd = new SqlCommand(update, connection))
                        {
                            cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                            cmd.Parameters.AddWithValue("@IdProducto", item.IdProducto);
                            cmd.ExecuteNonQuery();
                        }


                    }

                    decimal neto = totalVenta / 1.19m;
                    decimal iva = totalVenta - neto;



                    MessageBox.Show("Venta registrada exitosamente.\nNeto: " 
                        + neto.ToString("C") + "\nIVA: " + iva.ToString("C") +
                        "\nTotal: " + totalVenta.ToString("C"));

                    carrito.Clear();
                    dgvCarrito.Rows.Clear();

                    this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet1.Producto);

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            DataRowView row = (DataRowView)cmbProducto.SelectedItem;

            int idProducto = (int)row["IdProducto"];
            string nombre = row["Nombre"].ToString();
            decimal precio = (decimal)row["Precio"];
            int stock = (int)row["Stock"];

            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            if (cantidad > stock)
            {
                MessageBox.Show("Stock insuficiente.");
                return;
            }

            carrito.Add(new DetalleVenta
            {
                IdProducto = idProducto,
                Cantidad = cantidad,
                PrecioUnitario = precio
            });

            dgvCarrito.Rows.Add(nombre, cantidad, precio, cantidad * precio);

            // reset
            cmbProducto.SelectedIndex = -1;
            nudCantidad.Value = 1;
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            int fila = dgvCarrito.CurrentRow.Index;

            if (fila < 0 || fila >= carrito.Count)
            {
                MessageBox.Show("Error al eliminar: índice inválido.");
                return;
            }

            carrito.RemoveAt(fila);
            dgvCarrito.Rows.RemoveAt(fila);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            dgvCarrito.Rows.Clear();
        }
    }
}