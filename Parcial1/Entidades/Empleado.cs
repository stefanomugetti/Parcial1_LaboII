using System.Collections.Generic;

namespace Entidades
{
    public class Empleado : Usuarios
    {
        private static List<Empleado> listaEmpleados;

        private static int id=0;
        private int idEmpleado;

        public int IdEmpleado { get => idEmpleado;  }

        public Empleado(string nombre, string apellido, string dni, string user, string password) : base(nombre, apellido, dni, user, password)
        {
            id = id + 1;
            this.idEmpleado = id;
        }

        static Empleado()
        {
            listaEmpleados = new List<Empleado>();
        }
       /// <summary>
       /// agrega un empleado a la lista sin repetir un usuario existente
       /// </summary>
       /// <returns>true si se agrego, false si no se agrego</returns>
        public override bool Agregar()
        {
            foreach (Empleado item in listaEmpleados)
            {
                if (item.User == this.User)
                {
                    return false;
                }
            }
            listaEmpleados.Add(this);
            return true;
        }
        /// <summary>
        /// Elimina un empleado si este existe en la lista
        /// </summary>
        /// <returns>true si se elimino, false si no</returns>
        public override bool Eliminar()
        {
            foreach (Empleado item in listaEmpleados)
            {
                if (listaEmpleados.Contains(this))
                {
                    listaEmpleados.Remove(this);
                    return true;
                }
            }
            return false;
        }

        public static List<Empleado> ObtenerLista()
        {
            return listaEmpleados;
        }
    }
}
