using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    internal class Division
    {
        public double? Dividir(double N1, double N2)
        {
            if (N2 == 0)
            {
                // Si el divisor es cero, devuelve null
                return null;
            }
            else
            {
                // Si el divisor no es cero, realiza la división
                return N1 / N2;
            }
        }

        public string Validacion(double divisor)
        {
            if (divisor == 0)
            {
                // Devuelve un mensaje si el divisor es cero
                return "Error";
            }
            else
            {
                return ""; // No hay error
            }
        }
    }
}

