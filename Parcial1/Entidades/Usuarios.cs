using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuarios
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string user;
        private string password;       

        protected Usuarios(string nombre, string apellido, string dni, string user, string password)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.User = user;
            this.Password = password;           
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }


        public abstract bool Agregar();
        public abstract bool Eliminar();
        
        public virtual string ObtenerDatos()
        {
            return ($"NOMBRE:{this.Nombre}\nAPELLIDO:{this.Apellido}\nDNI:{this.Dni}\nUSUARIO:{this.User}");
        }

        
    }
}
