using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Electrodomesticos
{
    public class Celular : Producto
    {
        private int megaPixelesCamara;

        public Celular(string modelo, float precio, Tienda.EMarca marca, int megaPixelesCamara) : base(modelo, precio, marca)
        {
            this.megaPixelesCamara = megaPixelesCamara;
        }

        public override string Garantia
        {
            get
            {
                if (this.marca == Tienda.EMarca.MarcaNoInformada || this.marca == Tienda.EMarca.Noblex)
                {
                    return "Garantía de 12 meses.";

                }
                else
                {
                    if (this.megaPixelesCamara > 12)
                    {
                        return "Garantía de 36 meses.";
                    }

                    return "Garantía de 24 meses.";
                }
            }
        }

        protected override int PorcentajeDescuento
        {
            get
            {
                return 5;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}MegaPx: {this.megaPixelesCamara}\n";
        }
    }
}
