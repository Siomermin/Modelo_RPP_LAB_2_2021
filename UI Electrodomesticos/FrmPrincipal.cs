using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Electrodomesticos;

namespace UI_Electrodomesticos
{
    public partial class FrmPrincipal : Form
    {
        public int cantidadProductos = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.lbl_Titulo.Text = Tienda.NombreTienda;
            if (Tienda.AgregarProducto(new Televisor("42mlp", 40000, Tienda.EMarca.LG, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("57rpk", 50000, Tienda.EMarca.LG, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("43sam_lat", 43000, Tienda.EMarca.Samsung, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("42mlp", 40000, Tienda.EMarca.LG, true)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("40ujkp", 35000, Tienda.EMarca.LG, false)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("32ujkp", 30000, Tienda.EMarca.Noblex, false)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Televisor("32ujkp", 30000, Tienda.EMarca.Noblex, false)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("S21", 100000, Tienda.EMarca.Samsung, 20)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("MotoE", 38000, Tienda.EMarca.Samsung, 8)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("S21", 100000, Tienda.EMarca.Samsung, 12)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("K42", 25000, Tienda.EMarca.LG, 12)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("A02", 33000, Tienda.EMarca.Samsung, 16)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("A02", 33000, Tienda.EMarca.Samsung, 16)))
                cantidadProductos++;
            if (Tienda.AgregarProducto(new Celular("N405", 9999, Tienda.EMarca.Noblex, 2)))
                cantidadProductos++;
            this.rtbCatalogo.Text += string.Concat("Cantidad de productos en el catalogo: ", cantidadProductos);
            this.rtbCatalogo.Text += "\n" + Tienda.InfoTienda();
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            rtbOfertas.Text = Tienda.Oferta.ToString();
        }
    }
}
