using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Usuarios
    {
        private static List<Administrador> listaAdministradores;
        private static int idAdministrador=0;
        private int idAdmin;
        static Administrador()
        {
            listaAdministradores = new List<Administrador>();
        }

        public Administrador(string nombre, string apellido, string dni, string user, string password) : base(nombre, apellido, dni, user, password)
        {
            idAdministrador = idAdministrador + 1;
            this.idAdmin = idAdministrador;
        }

        public int IdAdmin { get => idAdmin; }

        /// <summary>
        /// Agrega un administrador a la lista si el usuario no se repite
        /// </summary>
        /// <returns>false si se repite, true si se agrego</returns>
        public override bool Agregar()
        {
            foreach (Administrador item in listaAdministradores)
            {
                if(item.User == this.User)
                {
                    return false;
                }
            }
            listaAdministradores.Add(this);
            return true;
        }

        /// <summary>
        /// Elimina la instancia si el administrtador esta en la lista
        /// </summary>
        /// <returns>true si fue eliminado,false si no</returns>
        public override bool Eliminar()
        {
            foreach (Administrador item in listaAdministradores)
            {
                if (listaAdministradores.Contains(this))
                {
                    listaAdministradores.Remove(this);
                    return true;
                }
            }
            return false;
        }
        public static List<Administrador> ObtenerLista()
        {
            return listaAdministradores;
        }



    }
}
