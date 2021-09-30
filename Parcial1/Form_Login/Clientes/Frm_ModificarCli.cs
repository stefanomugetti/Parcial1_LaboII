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
    public partial class Frm_ModificarCli : Form
    {
        public Frm_ModificarCli()
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
       /// modifica un cliente
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Cliente cliente = this.BuscarPorId();
            if (txt_Nombre.Text != "")
            {
                if (Validaciones.SoloString(txt_Nombre.Text))
                {
                    cliente.Nombre = txt_Nombre.Text;
                }
                else
                    MessageBox.Show($"Nombre invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_Apellido.Text != "")
            {
                if (Validaciones.SoloString(txt_Apellido.Text))
                {
                    cliente.Apellido = txt_Apellido.Text;
                }
                else
                    MessageBox.Show($"Apellido invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_Dni.Text != "")
            {
                if (Validaciones.DniValido(txt_Dni.Text))
                {
                    cliente.Dni = txt_Dni.Text;
                }
                else
                    MessageBox.Show($"Dni invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txt_Edad.Text != "")
            {
                if(Validaciones.EdadValida(txt_Edad.Text))
                {
                    if(int.TryParse(txt_Edad.Text,out int edad))
                    {
                        cliente.Edad = edad;
                    }
                }
                else
                    MessageBox.Show($"Edad invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txt_Saldo.Text != "")
            {
                if(Validaciones.SaldoValido(this.txt_Saldo.Text))
                {
                    if(double.TryParse(this.txt_Saldo.Text,out double saldo))
                    {
                        cliente.Saldo = saldo;
                    }
                }
            }
        }
        /// <summary>
        /// Busca un cliente segun el id en textbox
        /// </summary>
        /// <returns>null si no existe, el cliente si existe</returns>
        private Cliente BuscarPorId()
        {
            List<Cliente> listaAux = new List<Cliente>(Cliente.ObtenerLista());
            if (listaAux != null)
            {
                foreach (Cliente item in listaAux)
                {
                    if (this.lbl_IdCli.Text == item.Id.ToString())
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
