using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public enum TipoProductos
    {
        alimentos = 1,
        juguetes = 2,
        camas = 3,
        medicamento = 4,
        limpieza = 5
    }
    public class Productos
    {
        private static List<Productos> listaProductos;
        private int idProducto;
        private string nombre;
        private string marca;
        private int tipoProducto;
        private int cantidadDisponible;
        private double precio;
        private static int id = 0;

        public Productos(string nombre, string marca, double precio, int tipoProducto, int cantidadDisponible)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.tipoProducto = tipoProducto;
            this.cantidadDisponible = cantidadDisponible;
            id = id + 1;
            this.idProducto = id;
        }
        static Productos()
        {
            listaProductos = new List<Productos>();
        }

        public int IdProducto { get => idProducto;}
        public double Precio { get => precio; set => precio = value; }
        public int TipoProducto { get => tipoProducto; set => tipoProducto = value; }
        public int CantidadDisponible { get => cantidadDisponible; set => cantidadDisponible = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }

        public static List<Productos> ObtenerLista()
        {
            return listaProductos;         
        }

        public static void AgregarProducto(Productos prod)
        {
            listaProductos.Add(prod);
        }
    }
}
