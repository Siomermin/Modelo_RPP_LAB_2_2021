using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Electrodomesticos
{
    public abstract class Producto
    {
        protected Tienda.EMarca marca;
        protected string modelo;
        protected float precio;

        private Producto() 
        {
            this.marca = Tienda.EMarca.MarcaNoInformada;
        }

        public Producto(string modelo, float precio) :this()
        {
            this.modelo = modelo;
            this.precio = precio;
        }

        public Producto(string modelo, float precio, Tienda.EMarca marca) :this(modelo, precio)
        {
            this.marca = marca;
        }

        public abstract string Garantia
        {
            get;
        }

        protected abstract int PorcentajeDescuento
        {
            get;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Garantia: {this.Garantia}");

            return sb.ToString();

        }

        public void AplicarDescuento()
        {
            float descuento = this.precio * this.PorcentajeDescuento / 100;
            this.precio -= descuento;
        }

        public static bool operator ==(List<Producto> listaProd, Producto p1)
        {
            foreach (Producto item in listaProd)
            {
                if (item == p1)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(List<Producto> listaProd, Producto p1)
        {
            return !(listaProd == p1);
        }

        public static bool operator +(List<Producto> listaProd, Producto p1)
        {
            if (listaProd != p1)
            {
                listaProd.Add(p1);
                return true;
            }

            return false;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.marca == p2.marca & p1.modelo == p2.modelo && p1.GetType() == p2.GetType();
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
