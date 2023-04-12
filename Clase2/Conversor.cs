using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public static class Conversor
    {
        /// <summary>
        /// Convierte un número entero del sistema decimal al sistema binario
        /// </summary>
        /// <param name="numeroEntero">numero entero a convertir</param>
        /// <returns>numero entero convertido en binario</returns>
        public static string ConvertirDecimalABinario(int numeroEntero) {
            /* 10 % 2 = 0 => 10/2 = 5 => 5 % 2 = 1 y así sucesivamente*/
            string binario = "";

            while (numeroEntero > 0)
            {
                // Acá se estaría concatenando al binario y le sumamaos el binario para que lo ordene (como un .Reverse())
                binario = (numeroEntero % 2).ToString() + binario;
                numeroEntero /= 2;
            }
            return binario;
        }
        /// <summary>
        /// Convierte un número entero del sistema binario al sistema decimal
        /// </summary>
        /// <param name="numeroEntero">numero binario a convertir</param>
        /// <returns>numero binario convertido en entero</returns>
        public static int ConvertirBinarioADecimal(string binario) {
            // 1 0 1 0
            // 8 4 2 1   multiplicamos 0*1 = 1, 1*2= 2, 2*2= 4 y asi
            // cuando me encuentre en la línea de arriba con un 1, lo que haré es sumarlo con el que tambien esté en 1
            // Acá sería= 8 + 2 = 10 (Recordamos que aplica la ley de la potencia tambien)
            // asi lo explicaron en clase y bueno no da igual a la conversion de arriba:/
            double numeroDecimal = 0;
            int indiceInicial = binario.Length - 1;

            for(int i = indiceInicial; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    numeroDecimal += Math.Pow(2, indiceInicial - 1);
                }
            }
            return (int)numeroDecimal;                
        }
    }
}
