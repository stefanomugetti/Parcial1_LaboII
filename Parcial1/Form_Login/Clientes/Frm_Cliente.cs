using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Frm_Cliente : Form
    {
        public Frm_Cliente()
        {
            InitializeComponent();
            this.CargarLista();
        }
        /// <summary>
        /// cierra el formulario actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// carga la lista de todos los clientes
        /// </summary>
        private void CargarLista()
        {
            List<Cliente> listaAux = new List<Cliente>(Cliente.ObtenerLista());
            if (listaAux != null)
            {
                this.dtgv_Lista.Rows.Clear();
                foreach (Cliente item in listaAux)
                {
                    this.dtgv_Lista.Rows.Add(item.Id.ToString(), item.Nombre, item.Apellido, item.Dni, item.Edad.ToString(), item.Saldo.ToString()); //Agrego renglon
                }
                this.txt_Id.Text = "";
            }
        }
        /// <summary>
        /// Muestra un cliente en la lista segun el id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BuscarPorId_Click(object sender, EventArgs e)
        {
            Cliente cli = this.BuscarPorId();
            if (cli != null)
            {
                this.dtgv_Lista.Rows.Clear();
                this.dtgv_Lista.Rows.Add(cli.Id.ToString(), cli.Nombre, cli.Apellido, cli.Dni, cli.Edad.ToString(), cli.Saldo.ToString()); //Agrego renglon
            }
            else
                MessageBox.Show($"El id ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Carga la lista completa de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RestaurarLista_Click(object sender, EventArgs e)
        {
            this.CargarLista();
        }
        /// <summary>
        /// abre formulario para agregar un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_AltaCliente frm = new Frm_AltaCliente();
            frm.ShowDialog();
            this.CargarLista();
            this.Show();
        }
        /// <summary>
        /// Elimina un cliente segun el id ingresado en textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = this.BuscarPorId();
            if (cliente != null)
            {
                if (MessageBox.Show("¿Esta seguro? No se pueden deshacer los cambios.", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Cliente.EliminarCliente(cliente);
                    this.CargarLista();
                }
            }
            else
                MessageBox.Show($"El id ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Busca un cliente segun el id en textbox
        /// </summary>
        /// <returns>null si no existe, o el cliente si es un id valido</returns>
        private Cliente BuscarPorId()
        {
            List<Cliente> listaAux = new List<Cliente>(Cliente.ObtenerLista());
            if (listaAux != null)
            {
                foreach (Cliente item in listaAux)
                {
                    if (this.txt_Id.Text == item.Id.ToString())
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// abre el formulario para modificar un cliente segun id en text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = this.BuscarPorId();
            if (cliente != null)
            {
                Frm_ModificarCli form = new Frm_ModificarCli();
                form.lbl_IdCli.Text = txt_Id.Text;
                form.ShowDialog();
                this.CargarLista();
                this.Show();
            }
            else
                MessageBox.Show($"ID inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

