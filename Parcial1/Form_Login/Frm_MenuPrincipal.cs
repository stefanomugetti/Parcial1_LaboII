using System;
using System.Windows.Forms;



namespace Pet_Shop
{
    public partial class Frm_Administrador : Form
    {
        
        public Frm_Administrador()
        {           
            InitializeComponent();                  
        }
        private void Frm_Administrador_Load(object sender, EventArgs e)
        {
            Frm_Inicio formInicio = new Frm_Inicio();
            string rango = this.lbl_Rango.Text;
            formInicio.lbl_Rangos.Text = rango;     
            this.AbrirForm(formInicio);
        }

        /// <summary>
        /// Cierra el menu y vuelve al login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Esta seguro?", "Cerrar sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Muestra el formulario con todas las ventas y el total facturado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VerFacturacionTotal_Click(object sender, EventArgs e)
        {          
            if (this.esAdmin())
            {
                Frm_FacturacionTotal form = new Frm_FacturacionTotal();
                this.AbrirForm(form);
            }
            else
                MessageBox.Show("Acceso denegado. Solo administradores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// muestra  la seccion de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VerEmpleados_Click(object sender, EventArgs e)
        {
            if (this.esAdmin())
            {
                Frm_Empleado formEmpleado = new Frm_Empleado();
                this.AbrirForm(formEmpleado);
            }
            else
                MessageBox.Show("Acceso denegado. Solo administradores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// abre la seccion de los administradores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Administradores_Click(object sender, EventArgs e)
        {
            if (this.esAdmin())
            {
                Frm_Admin formAdmin = new Frm_Admin();
                this.AbrirForm(formAdmin);
                //this.Show();

            }
            else
                MessageBox.Show("Acceso denegado. Solo administradores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        /// <summary>
        /// abre la seccion de los clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VerClientes_Click(object sender, EventArgs e)
        {
            Frm_Cliente formCliente = new Frm_Cliente();
            this.AbrirForm(formCliente);
        }

        /// <summary>
        /// Abre la seccion que muestra el stock de todos los productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Form_Stock form = new Form_Stock();
            this.AbrirForm(form);
        }
        /// <summary>
        /// Abre la seccion para realizar las ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            Frm_Ventas form = new Frm_Ventas();
            this.AbrirForm(form);
        }
     
        /// <summary>
        /// Metodo para abrir formularios dentro del panel
        /// </summary>
        /// <param name="formulario">formulario a abrir</param>
        private void AbrirForm(object formulario)
        {
            if (this.pnl_Formularios.Controls.Count > 0)
                this.pnl_Formularios.Controls.RemoveAt(0);

            Form form = formulario as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnl_Formularios.Controls.Add(form);
            this.pnl_Formularios.Tag = form;
            form.Show();
        }
        /// <summary>
        /// Verifica si la instancia es admin
        /// </summary>
        /// <returns>False si no es admin, true si lo es</returns>
        private bool esAdmin()
        {
            if (this.lbl_Rango.Text != "Administrador")
                return false;

            return true;
        }      
    }
}
