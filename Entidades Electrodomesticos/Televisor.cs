using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Electrodomesticos
{
    public class Televisor : Producto
    {
        private bool esSmart;

        public Televisor(string modelo, float precio, bool esSmart) :this(modelo, precio, Tienda.EMarca.MarcaNoInformada, esSmart)
        {

        }

        public Televisor(string modelo, float precio, Tienda.EMarca marca, bool esSmart) : base(modelo, precio, marca)
        {
            this.esSmart = esSmart;
        }

        public override string Garantia
        {
            get
            {
                if (this.esSmart)
                {
                    return "Garantía de 48 meses.";

                }
                
                return "Garantía de 36 meses.";
            }
        }

        protected override int PorcentajeDescuento
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}es Smart: {this.esSmart}\n";
        }
    }
}
