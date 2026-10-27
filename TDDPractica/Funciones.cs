using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractica
{
    public static class Funciones
    {
        private const long ErrorNumeroNegativo = -1;

        public static long CalcularFactorial(int n)
        {
            if (n < 0)
            {
                return ErrorNumeroNegativo;
            }

            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public static bool EsContrasenyaValida(string? contrasenya)
        {
            if (contrasenya == null)
            {
                return false;
            }
            if (contrasenya == "")
            {
                return false;
            }
            if (contrasenya.Length < 8)
            {
                return false;
            }
            if (!contrasenya.Contains("#"))
            {
                return false;
            }
            return true;
        }
    }
}
