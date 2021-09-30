using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Frm_Empleado : Form
    {
        public Frm_Empleado()
        {
            InitializeComponent();
            this.ListarTodo();
        }
        /// <summary>
        /// lista a todos los empleados en el data griew list
        /// </summary>
        private void ListarTodo()
        {
            List<Empleado> listaAux = new List<Empleado>(Empleado.ObtenerLista());
            this.dtgv_Lista.Rows.Clear();

            if (listaAux != null)
            {
                foreach (Empleado item in listaAux)
                {
                    this.dtgv_Lista.Rows.Add(item.IdEmpleado.ToString(), item.Nombre, item.Apellido, item.Dni, item.User);
                }
            }
        }
        /// <summary>
        /// abre el formulario apra agregar un empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            Frm_AltaEmp frmAltaEmp = new Frm_AltaEmp();
            frmAltaEmp.ShowDialog();
            this.ListarTodo();
            this.Show();
        }
        /// <summary>
        /// Carga la lista completa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RestaurarLista_Click_1(object sender, EventArgs e)
        {
            this.ListarTodo();
        }
        /// <summary>
        /// Muestra un empleado buscado por ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_BuscarPorId_Click_1(object sender, EventArgs e)
        {
            Empleado item = this.BuscarPorId();
            if (item != null)
            {
                this.dtgv_Lista.Rows.Clear();
                this.dtgv_Lista.Rows.Add(item.IdEmpleado.ToString(), item.Nombre, item.Apellido, item.Dni, item.User); //Agrego renglon
            }
            else
                MessageBox.Show($"El id ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// Elimina un empleado segun ID en text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            Empleado emp = this.BuscarPorId();
            if (emp != null)
            {
                if (MessageBox.Show("¿Esta seguro? No se pueden deshacer los cambios.", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    emp.Eliminar();
                    this.ListarTodo();
                }
            }
            else
                MessageBox.Show($"El id ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// abre formulario para modificar un empleado segun id en texbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Empleado emp = this.BuscarPorId();
            if (emp != null)
            {
                Frm_ModificarEmp form = new Frm_ModificarEmp();
                form.lbl_Usuario.Text = this.BuscarPorId(this.txt_Id.Text).User;
                form.ShowDialog();
                this.ListarTodo();
                this.Show();
            }
            else
                MessageBox.Show($"ID inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// busca un empleado segun id en text box
        /// </summary>
        /// <returns>null si no existe un empleado con el id, o el empleado si existe</returns>
        private Empleado BuscarPorId()
        {
            List<Empleado> listaAux = new List<Empleado>(Empleado.ObtenerLista());
            if (listaAux != null)
            {
                foreach (Empleado item in listaAux)
                {
                    if (this.txt_Id.Text == item.IdEmpleado.ToString())
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// busca un empleado por id en param
        /// </summary>
        /// <param name="id">id a buscar en lista de empleados</param>
        /// <returns>null si no existe, el empleado si el id es valido</returns>
        private Empleado BuscarPorId(string id)
        {
            int idAux = 0;
            if (Validaciones.SoloNumeros(id))
            {
                idAux = int.Parse(id);
                List<Empleado> listaAux = new List<Empleado>(Empleado.ObtenerLista());
                foreach (Empleado item in listaAux)
                {
                    if (idAux == item.IdEmpleado)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
