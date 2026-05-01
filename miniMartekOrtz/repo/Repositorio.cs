using MiniMarketOrtz.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMarketOrtz.Repo
{
    public static class Repositorio
    {
        public static List<Categoria> Categorias = new List<Categoria>();
        public static List<Producto> Productos = new List<Producto>();
        public static List<Venta> Ventas = new List<Venta>();
        public static List<DetalleVenta> DetallesVentas = new List<DetalleVenta>();

        // Constructor estático: se ejecuta una sola vez al iniciar el programa
        static Repositorio()
        {
            CargarDatosInciales();
        }

        private static void CargarDatosInciales()
        {
            
            Categorias.Add(new Categoria(1, "Abarrotes", "Productos básicos y despensa"));
            Categorias.Add(new Categoria(2, "Lácteos", "Leches, quesos y derivados"));
            Categorias.Add(new Categoria(3, "Bebidas y Jugos", "Líquidos y refrescos"));
            Categorias.Add(new Categoria(4, "Snacks", "Papas fritas, galletas y colaciones"));
            Categorias.Add(new Categoria(5, "Aseo", "Artículos de limpieza de hogar"));

            
            // Abarrotes 
            Productos.Add(new Producto(1, "P001", "Arroz Tucapel G1 (1kg)", 1450m, 40, 1));
            Productos.Add(new Producto(2, "P002", "Fideos Lucchetti Espiral", 950m, 50, 1));
            Productos.Add(new Producto(3, "P003", "Aceite Natura (900ml)", 2890m, 15, 1));

            // Lacteos 
            Productos.Add(new Producto(4, "P004", "Leche Colun Entera (1L)", 1100m, 30, 2));
            Productos.Add(new Producto(5, "P005", "Manjar Colun Bolsa (400g)", 1990m, 20, 2));
            Productos.Add(new Producto(6, "P006", "Queso Gauda Soprole (250g)", 3200m, 12, 2));

            // Bebidas 
            Productos.Add(new Producto(7, "P007", "Bilz 2L", 1850m, 24, 3));
            Productos.Add(new Producto(8, "P008", "Pap 2L", 1850m, 24, 3));
            Productos.Add(new Producto(9, "P009", "Mote con Huesillo Vaso", 1500m, 10, 3));

            // Snacks 
            Productos.Add(new Producto(10, "P010", "Papas Fritas Marco Polo", 1750m, 18, 4));
            Productos.Add(new Producto(11, "P011", "Ramitas de Queso Evercrisp", 1200m, 22, 4));
            Productos.Add(new Producto(12, "P012", "Galletas Tritón (126g)", 850m, 45, 4));

            // Aseo 
            Productos.Add(new Producto(13, "P013", "Detergente Omo (1kg)", 4500m, 10, 5));
            Productos.Add(new Producto(14, "P014", "Quix Limón (750ml)", 2100m, 15, 5));
        }

        
        public static decimal CalcularSoloIVA(decimal montoTotal)
        {
            return montoTotal - (montoTotal / 1.19m);
        }

        public static decimal CalcularNeto(decimal montoTotal)
        {
            return montoTotal / 1.19m;
        }

        public static decimal CalcularTotalConIVA(decimal montoNeto)
        {
            return montoNeto * 1.19m;
        }
    }
}