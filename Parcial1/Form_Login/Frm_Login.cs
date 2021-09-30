using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Frm_Login : Form
    {
        #region Instancio objetods


        Administrador adm = new Administrador("Stefano", "Mugetti", "44320339", "stefano", "123");
        Administrador adm2 = new Administrador("Pepe", "Sand", "24567942", "pepito", "pepe123");
        Administrador adm3 = new Administrador("Heber", "Luduena", "12363412", "locura", "heber123");
        Administrador adm4 = new Administrador("Oscar", "Smarke", "5124456", "mate", "oscar123");
        Administrador adm5 = new Administrador("Martina", "Boscovich", "42657549", "martina", "bosco123");
        Administrador adm6 = new Administrador("Lucas", "Rodriguez", "34564982", "lucas10", "123");
        Administrador adm7 = new Administrador("Ezequiel", "Oggioni", "33263112", "eze121", "123");
        Administrador adm8 = new Administrador("Mateo", "Martinez", "2124456", "mate0", "mate123");

        Empleado emp = new Empleado("Franco", "Martinez", "42416964", "franquito", "12345");
        Empleado emp2 = new Empleado("Alejandro", "Ledesma", "26457985", "alejandro", "12345");
        Empleado emp3 = new Empleado("Francisco", "Martinez", "41256789", "opaaa", "12345");
        Empleado emp4 = new Empleado("Juan", "Blatter", "43852697", "juancito5csp", "12345");
        Empleado emp5 = new Empleado("Franco", "Martinez", "42416964", "franqui1to", "12345");
        Empleado emp6 = new Empleado("Alejandro", "Ledesma", "26457985", "aleja2ndro", "12345");
        Empleado emp7 = new Empleado("Francisco", "Martinez", "41256789", "opaa3a", "12345");
        Empleado emp8 = new Empleado("Juan", "Blatter", "43852697", "juanci89tocsp", "12345");

        Cliente cliente = new Cliente("natalia", "fornari", "4141414", 40, 52000);
        Cliente cliente2 = new Cliente("mateo", "luchetti", "15975332", 40, 100000);
        Cliente cliente3 = new Cliente("mariano", "mugetti", "24155678", 42, 155000);
        Cliente cliente4 = new Cliente("pirulo", "lucci", "65479832", 19, 56000);
        Cliente cliente5 = new Cliente("lola", "luceai", "37479832", 19, 56000);
        Cliente cliente6 = new Cliente("mento", "luxas", "42479831", 19, 56000);
        Cliente cliente7 = new Cliente("pero", "lucciernaga", "60798321", 19, 56000);
        Cliente cliente8 = new Cliente("nee", "luchiquetk", "35498321", 19, 56000);
        Cliente cliente9 = new Cliente("helou", "ciome", "15479321", 19, 56000);

        Productos prod = new Productos("Peluche", "Noga", 650, 2, 20);
        Productos prod1 = new Productos("Hueso", "Terry", 250, 1, 25);
        Productos prod2 = new Productos("Shampoo X", "Akme", 1350, 5, 12);
        Productos prod3 = new Productos("Pipeta", "Guaugau", 2100, 4, 20);
        Productos prod4 = new Productos("Camita", "Doggy", 6200, 3, 7);
        Productos prod5 = new Productos("Alimento", "Sabrositos", 1650, 1, 10);
        Productos prod6 = new Productos("Alimento", "Carnix", 400, 1, 20);
        Productos prod7 = new Productos("Alimento", "Gatix", 650, 1, 30);
        Productos prod8 = new Productos("Maiz", "Torke", 60, 1, 14);
        Productos prod9 = new Productos("Antirrabica", "SpaceX", 499, 4, 4);
        Productos prod10 = new Productos("Sonajero", "Beldent", 150, 2, 20);
        Productos prod11 = new Productos("Gotas", "Gotix", 350, 4, 4);


        Compras compra = new Compras("Peluche", "Noga", "650", "Juguetes", 3, 1);
        Compras compra2 = new Compras("Hueso", "Terry", "250", "Alimentos", 2, 2);
        Compras compra3= new Compras("Shampoo X", "Akme", "1350", "Limpieza", 5, 3);
        Compras compra4 = new Compras("Pipeta", "Guaugau", "2100", "Medicamento", 2, 4);
        Compras compra5 = new Compras("Camita", "Doggy", "6200", "Camas", 3, 5);
        Compras compra6 = new Compras("Alimento", "Sabrositos", "1650", "Alimentos", 5, 6);
        Compras compra7 = new Compras("Alimento", "Carnix", "400", "Alimentos", 2, 7);
        Compras compra8 = new Compras("Alimento", "Gatix", "650", "Alimentos", 5, 8);
        Compras compra9 = new Compras("Antirrabica", "SpaceX", "499", "Medicamento", 1, 10);
        Compras compra10 = new Compras("Sonajero", "Beldent", "150", "Juguete", 9, 11);
        Compras compra11 = new Compras("Peluche", "Noga", "350", "Juguetes", 3,1);

        
        #endregion
        public Frm_Login()
        {
            InitializeComponent();
            #region Cargo listas y compras

            emp.Agregar();
            emp2.Agregar();
            emp3.Agregar();
            emp4.Agregar();
            emp5.Agregar();
            emp6.Agregar();
            emp7.Agregar();
            emp8.Agregar();
            
         

            adm.Agregar();
            adm2.Agregar();
            adm3.Agregar();
            adm4.Agregar();
            adm5.Agregar();
            adm6.Agregar();
            adm7.Agregar();
            adm8.Agregar();

            
            Cliente.AgregarCliente(cliente);
            Cliente.AgregarCliente(cliente2);
            Cliente.AgregarCliente(cliente3);
            Cliente.AgregarCliente(cliente4);
            Cliente.AgregarCliente(cliente5);
            Cliente.AgregarCliente(cliente6);
            Cliente.AgregarCliente(cliente7);
            Cliente.AgregarCliente(cliente8);
            Cliente.AgregarCliente(cliente9);

            Productos.AgregarProducto(prod);
            Productos.AgregarProducto(prod1);
            Productos.AgregarProducto(prod2);
            Productos.AgregarProducto(prod3);
            Productos.AgregarProducto(prod4);
            Productos.AgregarProducto(prod5);
            Productos.AgregarProducto(prod6);
            Productos.AgregarProducto(prod7);
            Productos.AgregarProducto(prod8);
            Productos.AgregarProducto(prod9);
            Productos.AgregarProducto(prod10);
            Productos.AgregarProducto(prod11);

            

            bool x = cliente + compra;
            x = cliente + compra2;
            x = cliente + compra3;
        
            x = cliente2 + compra4;

            x = cliente3 + compra5;
            x = cliente3 + compra6;
            x = cliente3 + compra7;
            x = cliente3 + compra8;

            x = cliente4 + compra9;
            x = cliente4 + compra10;

            x = cliente7 + compra11;

            #endregion
        }

        /// <summary>
        /// Logea al usuario ingresado si esta en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (this.cmb_TipoLogin.Text == "Empleado")
            {
                Empleado emp = this.CuentaEmpleadoValida();
                if (emp != null)
                {
                    Frm_Administrador formMenu = new Frm_Administrador();
                    formMenu.lbl_Usuario.Text = this.txt_Usuario.Text.ToUpper();
                    formMenu.lbl_Rango.Text = this.cmb_TipoLogin.Text;
                    this.Hide();
                    formMenu.ShowDialog();
                    this.Limpiar();
                    this.Show();
                }
                else
                    MessageBox.Show("Los datos ingresados no corresponden a un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cmb_TipoLogin.Text == "Administrador")
            {
                if (this.CuentaAdministradorValida() != null)
                {
                    Frm_Administrador formMenu= new Frm_Administrador();
                    this.Hide();
                    formMenu.lbl_Rango.Text = this.cmb_TipoLogin.Text;
                    formMenu.lbl_Usuario.Text = this.txt_Usuario.Text.ToUpper();
                    formMenu.ShowDialog();
                    this.Limpiar();
                    this.Show();
                }
                else
                    MessageBox.Show("Los datos ingresados no corresponden a un administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese el tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Autocompleta los datos en los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Autocompletar_Click(object sender, EventArgs e)
        {
            if(this.cmb_TipoLogin.Text == "Administrador")
            {
                this.txt_Password.Text = "123";
                this.txt_Usuario.Text = "stefano";
            }
            else if(this.cmb_TipoLogin.Text == "Empleado")
            {
                this.txt_Password.Text = "12345";
                this.txt_Usuario.Text = "franquito";
            }
            else
            {
                this.txt_Password.Text = "123";
                this.txt_Usuario.Text = "stefano";
                this.cmb_TipoLogin.Text = "Administrador";
            }
            #region ValidacionesBienHechasDeAutocompletado
            //VALIDACIONES BIEN HECHAS
            //if (this.cmb_TipoLogin.Text == "Empleado")
            //{
            //    if (UsuarioEmpleadoValido() != null)
            //        this.txt_Password.Text = UsuarioEmpleadoValido().Password;
            //    else
            //        MessageBox.Show("El usuario ingresado no corresponde a un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (this.cmb_TipoLogin.Text == "Administrador")
            //{
            //    if (UsuarioAdministradorValido() != null)
            //        this.txt_Password.Text = UsuarioAdministradorValido().Password;
            //    else
            //        MessageBox.Show("El usuario ingresado no corresponde a un administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //    MessageBox.Show("Ingrese el tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion
        }

        /// <summary>
        /// Verifica que la cuenta ingresada como empleado exista
        /// </summary>
        /// <returns>Null si no existe, el empleado si existe</returns>
        private Empleado CuentaEmpleadoValida()
        {
            List<Empleado> listaAux = new List<Empleado>(Empleado.ObtenerLista());
            foreach (Empleado item in listaAux)
            {
                if (item.User == this.txt_Usuario.Text && item.Password == this.txt_Password.Text)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Verifica que la cuenta ingresada como administrador exista
        /// </summary>
        /// <returns>Null si no existe, el administrador si existe</returns>
        private Administrador CuentaAdministradorValida()
        {
            List<Administrador> listaAux = new List<Administrador>(Administrador.ObtenerLista());
            foreach (Administrador item in listaAux)
            {
                if (item.User == this.txt_Usuario.Text && item.Password == this.txt_Password.Text)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Limpia los textbox
        /// </summary>
        private void Limpiar()
        {
            this.txt_Password.Text = "";
            this.txt_Usuario.Text = "";
        }
    }
}
