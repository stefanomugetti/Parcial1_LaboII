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
    public partial class Frm_AgregarProducto : Form
    {
        public Frm_AgregarProducto()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cierra el formulario actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Crea y Agrega un producto a la lista de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            double precio = 0;
            int tipo = 0;
            if(Validaciones.NombreValido(this.txt_Nombre.Text) &&
                Validaciones.SoloString(this.txt_Marca.Text) &&
                Validaciones.SoloNumeros(this.txt_Precio.Text) &&
                Validaciones.SoloNumeros(this.txt_Cantidad.Text))
            {
                precio = double.Parse(this.txt_Precio.Text);
                cantidad = int.Parse(this.txt_Cantidad.Text);
                tipo = this.ObtenerTipoProductoInt();
                Productos prod = new Productos(this.txt_Nombre.Text, this.txt_Marca.Text,precio,tipo,cantidad);
                Productos.AgregarProducto(prod);
                Console.Beep();
                this.Close();
            }
        }
        /// <summary>
        /// Obtiene el tipo de producto en int
        /// </summary>
        /// <returns>tipo producto seleccionado</returns>
        private int ObtenerTipoProductoInt()
        {
            return this.cmb_TipoProducto.SelectedIndex+1;//Arranca de 0, sumo 1 para ser el primero del Enum
        }
    }
}
