using System.Collections.Generic;

namespace Entidades
{
    public class Cliente
    {
        private static List<Cliente> listaClientes;

        private string nombre;
        private string apellido;
        private string dni;
        private int edad;
        private double saldo;
        private int idCliente;
        private Stack<Compras> carrito;

        private static int id = 0;

        public Cliente(string nombre, string apellido, string dni, int edad, double saldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.saldo = saldo;
            this.carrito = new Stack<Compras>();
            id = id + 1;
            this.idCliente = id;
        }
        static Cliente()
        {
            listaClientes = new List<Cliente>();
        }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Id { get => idCliente; }
        public Stack<Compras> Carrito { get => carrito; set => carrito = value; }

        public static void AgregarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }
        /// <summary>
        /// Elimina un cliente si este existe en la lista
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>false si no se elimino, true si se eliminos</returns>
        public static bool EliminarCliente(Cliente cliente)
        {
            foreach (Cliente item in listaClientes)
            {
                if (listaClientes.Contains(cliente))
                {
                    listaClientes.Remove(cliente);
                    return true;
                }
            }
            return false;
        }

        public static List<Cliente> ObtenerLista()
        {
            return listaClientes;
        }

        public static bool operator +(Cliente cliente, Compras compra)
        {
            cliente.carrito.Push(compra);

            return true;

        }
    }
}
