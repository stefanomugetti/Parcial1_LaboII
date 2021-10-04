using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Pet_Shop
{
    public partial class Frm_Ventas : Form
    {
        public Frm_Ventas()
        {
            InitializeComponent();
            this.CargarListaStock();
        }
        /// <summary>
        /// Realiza la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if (this.nud_Cantidad.Value > 0)
            {
                Cliente cli = BuscarPorDni(this.txt_DniCliente.Text);
                if (cli != null)
                {
                    Console.Beep();
                    this.Comprar();
                    this.CargarListaCompras();
                }
                else
                    MessageBox.Show($"No existe un cliente con el dni ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show($"No se puede comprar 0 cantidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Carga la lista de productos disponibles
        /// </summary>
        private void CargarListaStock()
        {
            string tipoProducto = "x";
            List<Productos> lista = new List<Productos>(Productos.ObtenerLista());
            if (lista != null)
            {
                this.dtgv_Lista.Rows.Clear();
                foreach (Productos item in lista)
                {
                    tipoProducto = Productos.TipoProductoString(item);
                    this.dtgv_Lista.Rows.Add(item.IdProducto.ToString(), item.Nombre, item.Marca, tipoProducto, item.CantidadDisponible.ToString(), item.Precio.ToString()); //Agrego renglon
                }
            }
        }
  
        /// <summary>
        /// Carga la lista de compras del cliente con el dni ingresado
        /// </summary>
        private void CargarListaCompras()
        {
            Cliente cliente = BuscarPorDni(this.txt_DniCliente.Text);
            this.dtgv_ListaCompras.Rows.Clear();
            foreach (Compras item in cliente.Carrito)
            {
                this.dtgv_ListaCompras.Rows.Add(item.IdProd.ToString(), item.NombreProd, item.MarcaProd, item.TipoProd, item.Cantidad.ToString(), item.PrecioProd.ToString()); //Agrego renglon
            }
        }
        /// <summary>
        /// Obtiene el producto elegido en el data griew list del stock
        /// </summary>
        /// <returns>null si no es valido o el producto si es valido</returns>
        private Productos ObtenerProductoElegido()
        {
            string idProdElegidoString = this.dtgv_Lista.CurrentRow.Cells[0].Value.ToString();
            if (int.TryParse(idProdElegidoString, out int idProdElegido))
            {
                Productos prod = this.BuscarProdPorId(idProdElegido);
                if (prod != null)
                {
                    return prod;
                }
            }
            return null;
        }
        /// <summary>
        /// Realiza la compra
        /// </summary>
        private void Comprar()
        {
            Productos prod = this.ObtenerProductoElegido();
            Cliente cliente = BuscarPorDni(this.txt_DniCliente.Text);
            if (prod != null && cliente != null)
            {
                if (prod.CantidadDisponible >= (int)this.nud_Cantidad.Value)
                {
                    if (cliente.Saldo > (prod.Precio * (int)this.nud_Cantidad.Value))
                    {
                        Compras compra = new Compras(prod.Nombre, prod.Marca, prod.Precio.ToString(), Productos.TipoProductoString(prod), (int)this.nud_Cantidad.Value, prod.IdProducto);
                        prod.CantidadDisponible = prod.CantidadDisponible - (int)this.nud_Cantidad.Value;
                        cliente.Saldo = cliente.Saldo - (prod.Precio * (int)this.nud_Cantidad.Value);
                        cliente.Carrito.Push(compra);
                        this.FacturaTxt(compra, cliente);
                        this.CargarListaStock();
                    }
                    else
                        MessageBox.Show($"El saldo del cliente no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show($"No hay tantas unidades disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Busca un cliente segun el DNI
        /// </summary>
        /// <param name="dni">Dni a buscar</param>
        /// <returns>Cliente si existe, o null si el DNI no corresponde</returns>
        public Cliente BuscarPorDni(string dni)
        {
            List<Cliente> lista = Cliente.ObtenerLista();
            foreach (Cliente item in lista)
            {
                if (item.Dni == dni)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Bisca un producto segun el ID
        /// </summary>
        /// <param name="id">Id a buscar</param>
        /// <returns>Producto si existe, o null si el id no corresponde</returns>
        public Productos BuscarProdPorId(int id)
        {
            List<Productos> lista = Productos.ObtenerLista();
            foreach (Productos item in lista)
            {
                if (item.IdProducto == id)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Escribe la factura de la compra en un txt
        /// </summary>
        /// <param name="compra">datos de la compra realizada</param>
        /// <param name="comprador">datos del cliente</param>
        private void FacturaTxt(Compras compra,Cliente comprador)
        {
            string path = "C:\\Users\\stefa\\source\\repos\\Parcial1\\Form_Login\\Productos\\Facturas\\factura.txt";
            double.TryParse(compra.PrecioProd, out double precio);
            TextWriter texto = new StreamWriter(path);
            texto.WriteLine($"ID PRODUCTO:{compra.IdProd}\t NOMBRE PRODUCTO:{compra.NombreProd}\t MARCA:{compra.MarcaProd}\n");
            texto.WriteLine($"PRECIO:{compra.PrecioProd}\n");
            texto.WriteLine($"CANTIDAD:{compra.Cantidad}\n");
            texto.WriteLine($"ID CLIENTE:{comprador.Id}\t DNI:{comprador.Dni}\t TOTAL:{compra.Cantidad * precio}");
            texto.Close();
        }
    }
}
