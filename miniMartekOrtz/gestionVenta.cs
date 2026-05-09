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

        int indexEditar = -1;


        public gestionVenta(Form menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
        }

        private void gestionVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet7.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter3.Fill(this.miniMarketOrtzDataSet7.venta);
            // TODO: esta línea de código carga datos en la tabla 'miniMarketOrtzDataSet6.venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter2.Fill(this.miniMarketOrtzDataSet6.venta);
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

            decimal neto = totalVenta / 1.19m;
            decimal iva = totalVenta - neto;


            string queryVenta = "INSERT INTO Venta (Fecha, Total, IVA) VALUES (@Fecha, @Total, @IVA); SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(queryVenta, connection))
                    {
                        cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Total", totalVenta);
                        cmd.Parameters.AddWithValue("@IVA", iva);


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

                    MessageBox.Show("Venta registrada exitosamente.\nNeto: "
                        + neto.ToString("C") + "\nIVA: " + iva.ToString("C") +
                        "\nTotal: " + totalVenta.ToString("C"));

                    carrito.Clear();
                    dgvCarrito.Rows.Clear();

                    this.productoTableAdapter.Fill(this.miniMarketOrtzDataSet1.Producto);
                    this.ventaTableAdapter3.Fill(this.miniMarketOrtzDataSet7.venta);

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

            MessageBox.Show("Venta cancelada.");
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
                return;

            DataRowView row = (DataRowView)cmbProducto.SelectedItem;

            decimal precio = (decimal)row["Precio"];
            int stock = (int)row["Stock"];

            decimal neto = precio / 1.19m;
            decimal iva = precio - neto;

            lblPrecio.Text = "Precio: $" + precio.ToString("0");
            lblStock.Text = "Stock: " + stock;
            lblIVA.Text = "IVA: $" + iva.ToString("0");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indexEditar < 0)
            {
                MessageBox.Show("Seleccione una fila para editar.");
                return;
            }
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            DataRowView row = (DataRowView)cmbProducto.SelectedItem;

            int idProducto = Convert.ToInt32(row["IdProducto"]);
            string nombreProducto = row["Nombre"].ToString();
            decimal precio = Convert.ToDecimal(row["Precio"]);
            int stock = Convert.ToInt32(row["Stock"]);

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


            carrito[indexEditar].IdProducto = idProducto;
            carrito[indexEditar].Cantidad = cantidad;
            carrito[indexEditar].PrecioUnitario = precio;

            dgvCarrito.Rows[indexEditar].SetValues(nombreProducto, cantidad, precio, cantidad * precio);


            MessageBox.Show("Producto editado correctamente.");

            indexEditar = -1;

            cmbProducto.SelectedIndex = -1;
            nudCantidad.Value = 1;

        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            indexEditar = e.RowIndex;

            string nombreProducto = dgvCarrito.Rows[e.RowIndex].Cells["Producto"].Value.ToString();

            foreach (DataRowView item in cmbProducto.Items)
            {
                if (item["Nombre"].ToString() == nombreProducto)
                {
                    cmbProducto.SelectedItem = item;
                    break;
                }
            }
            nudCantidad.Value = Convert.ToInt32(dgvCarrito.Rows[e.RowIndex].Cells[1].Value);
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para eliminar.");
                return;
            }

            int idVenta = Convert.ToInt32(dgvVenta.CurrentRow.Cells[0].Value);


            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            string query = "DELETE FROM Venta WHERE IdVenta = @IdVenta";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                        
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Venta eliminada exitosamente.");

                this.ventaTableAdapter3.Fill(this.miniMarketOrtzDataSet7.venta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la venta: " + ex.Message);
            }
        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta para actualizar.");
                return;
            }

            int idVenta = Convert.ToInt32(dgvVenta.CurrentRow.Cells[0].Value);

            decimal nuevoTotal = decimal.Parse(txtTotalEditar.Text);

            decimal nuevoIVA = nuevoTotal - (nuevoTotal / 1.19m);

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            string query = "UPDATE Venta SET Total = @Total, IVA = @IVA WHERE IdVenta = @IdVenta";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Total", nuevoTotal);
                        cmd.Parameters.AddWithValue("@IVA", nuevoIVA);
                        cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                        
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Venta actualizada exitosamente.");
                this.ventaTableAdapter3.Fill(this.miniMarketOrtzDataSet7.venta);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la venta: " + ex.Message);
            }
        }
        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            txtTotalEditar.Text =
                dgvVenta.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}