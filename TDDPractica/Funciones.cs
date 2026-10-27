using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractica
{
    public static class Funciones
    {
        private const long ErrorNumeroNegativo = -1;
        private const int LongitudMinima = 8;
        private const char CaracterObligatorio = '#';

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
            if (string.IsNullOrEmpty(contrasenya))
            {
                return false;
            }

            return contrasenya.Length >= LongitudMinima
                && contrasenya.Contains(CaracterObligatorio);
        }
    }
}
