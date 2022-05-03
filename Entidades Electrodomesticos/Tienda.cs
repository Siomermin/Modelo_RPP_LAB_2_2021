using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_Electrodomesticos
{
    public static class Tienda
    {
        private const int capacidadTienda = 10;
        private static Random rnd;
        private static List<Producto> stockTienda;

        static Tienda()
        {
            stockTienda = new List<Producto>();
            rnd = new Random();
        }

        public enum EMarca
        {
            MarcaNoInformada,
            Samsung,
            LG,
            Sony,
            BGH,
            Noblex
        }

        public static string NombreTienda
        {
            get
            {
                return "Electrodomesticos Pepe Peposo";
            }
        }

        public static Producto Oferta
        {
            get
            {
                int elementoLista = rnd.Next(stockTienda.Count);
                stockTienda[elementoLista].AplicarDescuento();

                return stockTienda[elementoLista];


            }
        }

        public static bool AgregarProducto(Producto prod)
        {
            if (stockTienda.Count < capacidadTienda && stockTienda != prod)
            {
                stockTienda.Add(prod);
                return true;
            }

            return false;
        }

        public static string InfoTienda()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {NombreTienda}");
            sb.AppendLine($"Capacidad: {capacidadTienda}");
            foreach(Producto item in stockTienda)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

    }
}
