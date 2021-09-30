using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Frm_AltaCliente : Form
    {
        public Frm_AltaCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Agrega un cliente a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            double saldo = 0;
            int edad = 0;
            if (Validaciones.NombreValido(this.txt_Nombre.Text) &&
                 Validaciones.ApellidoValido(this.txt_Apellido.Text) &&
                 Validaciones.DniValido(this.txt_Dni.Text) &&
                 Validaciones.SaldoValido(this.txt_Saldo.Text) &&
                 Validaciones.EdadValida(this.txt_Edad.Text))
            {
                if (VerificarDni(this.txt_Dni.Text))
                {
                    edad = int.Parse(this.txt_Edad.Text);
                    saldo = double.Parse(this.txt_Saldo.Text);
                    Cliente cli = new Cliente(this.txt_Nombre.Text, this.txt_Apellido.Text, this.txt_Dni.Text, edad, saldo);
                    Cliente.AgregarCliente(cli);
                    Console.Beep();
                    this.Close();
                }
                else
                    MessageBox.Show($"El cliente con dni {this.txt_Dni.Text} ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Datos invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Verifica que el dni no se repita
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>false si se repite, true si no existe</returns>
        private bool VerificarDni(string dni)
        {
            List<Cliente> lista = new List<Cliente>(Cliente.ObtenerLista());
            foreach (Cliente item in lista)
            {
                if (item.Dni == dni)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
