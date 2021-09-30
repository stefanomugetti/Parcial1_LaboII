using System;
using Entidades;

namespace PruebaValidaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Validaciones.NombreValido("stef/ano"))
                Console.WriteLine("1 Nombre valido");

            Console.WriteLine(".");

            if(Validaciones.NombreValido("stefano"))
                Console.WriteLine("2 Nombre valido");

            if(Validaciones.ApellidoValido("mugetti"))
                Console.WriteLine("3 Nombre valido");
            
            if(Validaciones.ApellidoValido("muge2tti"))
                Console.WriteLine("4 Nombre valido");

            if(Validaciones.DniValido("44320339"))
                Console.WriteLine("5 dni valido");

            if(Validaciones.DniValido("4.567891"))
                Console.WriteLine("6 dni valido");

            if(Validaciones.DniValido("4.567892222221"))
                Console.WriteLine("7dni valido");

        }
    }
}
