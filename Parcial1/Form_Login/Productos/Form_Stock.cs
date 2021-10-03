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
    public partial class Form_Stock : Form
    {
        public Form_Stock()
        {
            InitializeComponent();
            this.CargarLista();
        }
        /// <summary>
        /// Carga el data griew view con los datos de la lista del producto
        /// </summary>
        private void CargarLista()
        {
            string tipoProducto = "x";
            List<Productos> lista = new List<Productos>(Productos.ObtenerLista());
            if(lista != null)
            {
                this.dtgv_Lista.Rows.Clear();
                foreach (Productos item in lista)
                {
                    tipoProducto = Productos.TipoProductoString(item);
                   // this.dtgv_Lista.DataSource = lista;                              no muestra como quiero
                    this.dtgv_Lista.Rows.Add(item.IdProducto.ToString(),item.Nombre,item.Marca,tipoProducto,item.CantidadDisponible.ToString(),item.Precio.ToString()); //Agrego renglon
                }
            }
        }
        /// <summary>
        /// Segun los tipos de productos, devolvera una cadena string con el tipo
        /// </summary>
        /// <param name="item">producto a analizar</param>
        /// <returns>Retorna ""(Error)||o el tipo de producto string (Exito)</returns>

        private void FiltrarPorTipo()
        {
            string tipoProducto = "x";            
            string tipoProductoElegido = this.cmb_TipoProducto.Text;            
            List<Productos> lista = new List<Productos>(Productos.ObtenerLista());
            if (lista != null)
            {
                this.dtgv_Lista.Rows.Clear();
                foreach (Productos item in lista)
                {
                    tipoProducto = Productos.TipoProductoString(item);
                    if(tipoProducto == tipoProductoElegido)
                    {
                        this.dtgv_Lista.Rows.Add(item.IdProducto.ToString(), item.Nombre, item.Marca, tipoProducto, item.CantidadDisponible.ToString(), item.Precio.ToString()); //Agrego renglon
                    }
                }
            }
        }

        private void cmb_TipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltrarPorTipo();
        }
        /// <summary>
        /// Carga la lista entera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RestaurarLista_Click(object sender, EventArgs e)
        {
            this.CargarLista();
        }
        /// <summary>
        /// Abre formulario para agregar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_AgregarProducto frm = new Frm_AgregarProducto();
            frm.ShowDialog();
            
            this.CargarLista();
            this.Show();
        }        
    }
}
