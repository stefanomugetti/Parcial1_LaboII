namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Valida que la cadena pasada por parametro sea un nombre valido
        /// </summary>
        /// <param name="nombre">Cadena a validar</param>
        /// <returns>False si no es valido, true si es valido</returns>
        public static bool NombreValido(string nombre)
        {
            char letra = 'x';
            for (int i = 0; i < nombre.Length; i++)
            {
                letra = nombre[i];
                if (!char.IsLetter(letra))
                    return false;
            }
            return true;

        }/// <summary>
         /// Valida que la cadena pasada por parametro sea un solo letras
         /// </summary>
         /// <param name="cadena">Cadena a validar</param>
         /// <returns>False si no es valido, true si es solo letras</returns>
        public static bool SoloString(string cadena)
        {
            char letra = 'x';
            for (int i = 0; i < cadena.Length; i++)
            {
                letra = cadena[i];
                if (!char.IsLetter(letra))
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametro sea un apellido valido
        /// </summary>
        /// <param name="apellido">Cadena a validar</param>
        /// <returns>False si no es valido, true si es valido</returns>
        public static bool ApellidoValido(string apellido)
        {
            char letra = 'x';
            for (int i = 0; i < apellido.Length; i++)
            {
                letra = apellido[i];
                if (!char.IsLetter(letra))
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametro sea un dni valido
        /// </summary>
        /// <param name="dni">Cadena a validar</param>
        /// <returns>False si no es valido, true si es valido</returns>
        public static bool DniValido(string dni)
        {
            char aux = 'x';
            if (dni.Length > 6 && dni.Length < 9)
            {
                for (int i = 0; i < dni.Length; i++)
                {
                    aux = dni[i];
                    if (!char.IsNumber(aux))
                        return false;
                }
            }
            else
                return false;

            return true;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametro sea solo numeros
        /// </summary>
        /// <param name="numeros">Cadena a validar</param>
        /// <returns>False si no es valido, true si son solo numeros</returns>
        public static bool SoloNumeros(string numeros)
        {
            char aux = 'x';
            for (int i = 0; i < numeros.Length; i++)
            {
                aux = numeros[i];
                if (!char.IsNumber(aux))
                    return false;
            }

            return true;
        }
        /// <summary>
        /// Valida que la edad sea valida
        /// </summary>
        /// <param name="edad">Numero a validar</param>
        /// <returns>False si no es valido, true si es valido</returns>
        public static bool EdadValida(int edad)
        {
            if (edad > 0 && edad < 100)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que la edad string sea valida
        /// </summary>
        /// <param name="edad">cadena a validar</param>
        /// <returns>False si no es valido, true si es valido</returns>
        public static bool EdadValida(string edad)
        {
            if (int.TryParse(edad, out int edadAux))
            {
                if (edadAux > 0 && edadAux < 100)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que el saldo string sea valida
        /// </summary>
        /// <param name="saldo">cadena a validar</param>
        /// <returns>False si no es valido, true si es valido</returns>
        public static bool SaldoValido(string saldo)
        {
            if (double.TryParse(saldo, out double saldoAux))
            {
                if (saldoAux > 0)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que el saldo double sea valida
        /// </summary>
        /// <param name="saldo">cadena a validar</param>
        /// <returns>False si no es valido, true si es valido</returns>
        public static bool SaldoValido(double saldo)
        {
            if (saldo > 0)
            {
                return true;
            }
            return false;
        }
    }
}
