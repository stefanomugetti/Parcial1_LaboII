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
    public partial class Frm_ModificarAdm : Form
    {
        public Frm_ModificarAdm()
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
        /// Modifica un administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Administrador adm = this.BuscarPorUsuario();
            Console.Beep();
            if (txt_Nombre.Text != "")
            {
                if(Validaciones.SoloString(txt_Nombre.Text))
                {
                    adm.Nombre = txt_Nombre.Text;
                }
                else
                    MessageBox.Show($"Nombre invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txt_Apellido.Text != "")
            {
                if (Validaciones.SoloString(txt_Apellido.Text))
                {
                    adm.Apellido = txt_Apellido.Text;
                }
                else
                    MessageBox.Show($"Apellido invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            if(txt_Dni.Text != "")
            {
                if(Validaciones.DniValido(txt_Dni.Text))
                {
                    adm.Dni = txt_Dni.Text;
                }
                else
                    MessageBox.Show($"Dni invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            if(txt_Password.Text != "")
            {
                if(txt_Password.Text == txt_ConfirmarPassword.Text)
                {
                    adm.Password = txt_Password.Text;
                }
                else
                    MessageBox.Show($"Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// busca un administrador segun el usuario
        /// </summary>
        /// <returns>null si no existe, el administrador si existe</returns>
        private Administrador BuscarPorUsuario()
        {
            List<Administrador> listaAux = new List<Administrador>(Administrador.ObtenerLista());
            foreach (Administrador item in listaAux)
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
