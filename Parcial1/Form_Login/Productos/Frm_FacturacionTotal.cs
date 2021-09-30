using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Pet_Shop
{
    public partial class Frm_FacturacionTotal : Form
    {
        public Frm_FacturacionTotal()
        {
            InitializeComponent();
            CargarListaCompras();
            this.lbl_Total.Text = Compras.ObtenerTotalFacturado().ToString();
        }
        /// <summary>
        /// Carga la lista de todas las ventas de todos los clientes
        /// </summary>
        private void CargarListaCompras()
        {
            List<Cliente> lista = Cliente.ObtenerLista();
            this.dtgv_Lista.Rows.Clear();
            foreach (Cliente cliente in lista)
            {
                foreach (Compras item in cliente.Carrito)
                {
                    this.dtgv_Lista.Rows.Add(cliente.Id.ToString(),item.IdProd.ToString(), item.NombreProd, item.MarcaProd, item.TipoProd, item.Cantidad.ToString(), item.PrecioProd.ToString()); //Agrego renglon
                }
            }
        }
    }
}
