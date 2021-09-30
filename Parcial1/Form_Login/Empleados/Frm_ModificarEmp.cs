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
    public partial class Frm_ModificarEmp : Form
    {
        public Frm_ModificarEmp()
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
        /// modifica un empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Empleado emp = this.BuscarPorUsuario();

            if (txt_Nombre.Text != "")
            {
                if (Validaciones.SoloString(txt_Nombre.Text))
                {
                    emp.Nombre = txt_Nombre.Text;
                }
                else
                    MessageBox.Show($"Nombre invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_Apellido.Text != "")
            {
                if (Validaciones.SoloString(txt_Apellido.Text))
                {
                    emp.Apellido = txt_Apellido.Text;
                }
                else
                    MessageBox.Show($"Apellido invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_Dni.Text != "")
            {
                if (Validaciones.DniValido(txt_Dni.Text))
                {
                    emp.Dni = txt_Dni.Text;
                }
                else
                    MessageBox.Show($"Dni invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_Password.Text != "")
            {
                if (txt_Password.Text == txt_ConfirmarPassword.Text)
                {
                    emp.Password = txt_Password.Text;
                }
                else
                    MessageBox.Show($"Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// busca un empleado segun el usuario en textbox
        /// </summary>
        /// <returns>null si no existe, empleado si existe</returns>
        private Empleado BuscarPorUsuario()
        {
            List<Empleado> listaAux = new List<Empleado>(Empleado.ObtenerLista());
            foreach (Empleado item in listaAux)
            {
                if (this.lbl_Usuario.Text == item.User)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
