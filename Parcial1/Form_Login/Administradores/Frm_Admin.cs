using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
            this.ListarTodo();
        }
        /// <summary>
        /// Carga la lista de administradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RestaurarLista_Click(object sender, EventArgs e)
        {
            this.ListarTodo();
        }
        /// <summary>
        /// abre el formulario para agregar un administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_AltaAdm frmAltaAdm = new Frm_AltaAdm();
            frmAltaAdm.ShowDialog();
            this.ListarTodo();
            this.Show();
        }
        /// <summary>
        /// Elimina un admnistrador segun ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Administrador adm = this.BuscarPorId();
            if (adm != null)
            {
                if (MessageBox.Show("¿Esta seguro? No se pueden deshacer los cambios.", "Eliminar administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    adm.Eliminar();
                    this.ListarTodo();
                }
            }
            else
                MessageBox.Show($"El id ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// Busca un adm por ID y lo muestra en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BuscarPorId_Click(object sender, EventArgs e)
        {
            Administrador item = this.BuscarPorId();
            if (item != null)
            {
                this.dtgv_Lista.Rows.Clear();
                this.dtgv_Lista.Rows.Add(item.IdAdmin.ToString(), item.Nombre, item.Apellido, item.Dni, item.User); //Agrego renglon
            }
            else
                MessageBox.Show($"El id ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// Obtiene un administrador segun ID en textbox
        /// </summary>
        /// <returns>null si no existe, el administrador si el id es valido</returns>
        private Administrador BuscarPorId()
        {
            List<Administrador> listaAux = new List<Administrador>(Administrador.ObtenerLista());
            foreach (Administrador item in listaAux)
            {
                if (this.txt_Id.Text == item.IdAdmin.ToString())
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Obtiene un administrador segun ID param
        /// </summary>
        /// <param name="id">id buscado</param>
        /// <returns>null si no existe, el administrador si es un id valido</returns>
        private Administrador BuscarPorId(string id)
        {
            int idAux = 0;
            if (Validaciones.SoloNumeros(id))
            {
                idAux = int.Parse(id);
                List<Administrador> listaAux = new List<Administrador>(Administrador.ObtenerLista());
                foreach (Administrador item in listaAux)
                {
                    if (idAux == item.IdAdmin)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Lista la lista completa de los administradores
        /// </summary>
        private void ListarTodo()
        {
            List<Administrador> listaAux = new List<Administrador>(Administrador.ObtenerLista());
            this.dtgv_Lista.Rows.Clear();
            foreach (Administrador item in listaAux)
            {
                this.dtgv_Lista.Rows.Add(item.IdAdmin.ToString(), item.Nombre, item.Apellido, item.Dni, item.User); //Agrego renglon
            }
        }
        /// <summary>
        /// abre el formulario para modificar un administrador segun id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Administrador adm = BuscarPorId();
            if (adm != null)
            {
                Frm_ModificarAdm form = new Frm_ModificarAdm();
                form.lbl_Usuario.Text = this.BuscarPorId(this.txt_Id.Text).User;
                form.ShowDialog();
                this.ListarTodo();
                this.Show();
            }
            else
                MessageBox.Show($"ID inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
