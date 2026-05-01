using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarketOrtz.Modelos
{
    public class Categoria
    {


        public int idCategoria { get; set; }
        public String Nombre { get; set; }

        public String Descripcion { get; set; }

        public Categoria()
        {

        }

        public Categoria(int idCategoria, string nombre, string descripcion)
        {
            this.idCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
