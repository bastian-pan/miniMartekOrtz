using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarketOrtz.Modelos
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public Venta()
        {
        }

        public Venta(int idVenta, DateTime fecha, decimal total)
        {
            this.IdVenta = idVenta;
            this.Fecha = fecha;
            this.Total = total;
        }
    }

    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public DetalleVenta()
        {
        }

        public DetalleVenta(int idDetalle, int idVenta, int idProducto, int cantidad, decimal precioUnitario)
        {
            this.IdDetalle = idDetalle;
            this.IdVenta = idVenta;
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.PrecioUnitario = precioUnitario;
        }
    }
}