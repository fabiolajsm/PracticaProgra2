using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Validador
    {
        public Validador() { }
        /// <summary>
        ///  Valida que los numeros ingresados estén dentro del rango del min y max
        /// </summary>
        /// <param name="valor">dato a validar</param>
        /// <param name="min">mínimo del valor incluido</param>
        /// <param name="max">máximo del valor incluido</param>
        /// <returns>true si el valor está dentro del ramgo y false si no lo esta</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
        // El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
        /// <summary>
        /// Devuelve un valor de tipo booleano TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
        /// </summary>
        /// <param name="respuesta">valor ingresado</param>
        /// <returns>true si la respuesta es S/s y false si no lo es</returns>
        public static bool ValidarRespuesta(string respuesta)
        {         
            return !string.IsNullOrEmpty(respuesta) && (respuesta == "S" || respuesta == "s");
        }
        /// <summary>
        /// Pregunta si desea continuar con las opciones S/N
        /// </summary>
        /// <returns>retorna true si la respuesta es S/s y false si no lo es.</returns>
        public static bool DeseaContinuar() {
            string respuesta = "";

            Console.WriteLine("¿Desea continuar? (S/N)");
            respuesta = Console.ReadLine();
            return ValidarRespuesta(respuesta);
        }
    }
}

