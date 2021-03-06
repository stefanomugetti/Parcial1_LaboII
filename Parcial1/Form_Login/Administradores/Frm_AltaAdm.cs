using System;
using System.Windows.Forms;
using Entidades;

namespace Pet_Shop
{
    public partial class Frm_AltaAdm : Form
    {
        public Frm_AltaAdm()
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
        /// Agrega un administrador a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(Validaciones.NombreValido(this.txt_Nombre.Text) && Validaciones.ApellidoValido(this.txt_Apellido.Text) && Validaciones.DniValido(this.txt_Dni.Text))
            {
                if (this.txt_Password.Text == this.txt_ConfirmarPassword.Text)
                {
                    Administrador adm = new Administrador(this.txt_Nombre.Text, this.txt_Apellido.Text, this.txt_Dni.Text, this.txt_Usuario.Text, this.txt_Password.Text);
                    if(adm.Agregar())
                    {
                        Console.Beep();
                        this.Close();
                    }
                    else
                        MessageBox.Show("El usuario ya existe! Pruebe con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Datos invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }      
    }
}
