using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarketOrtz.Modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdCategoria { get; set; }

        public Producto()
        {
        }

        public Producto(int idProducto, string codigo, string nombre, decimal precio, int stock, int idCategoria)
        {
            this.IdProducto = idProducto;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.IdCategoria = idCategoria;
        }
    }
}