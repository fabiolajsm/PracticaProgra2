// el namespace es una agrupación lógica de clases y otros elementos del código fuente.
// todo lo que declaremos deberá estar contenido en un espacio de nombres.
// Los identificadores de espacios de nombres pueden ser distintos al nombre del proyecto del que forman parte. También puede haber más de un namespace por proyecto.
namespace Entidades
{
    // Las clases estaticas son agrupadoras de atributos y métodos estáticos (datos y funciones) 
    public static class Calculadora // el static es opcional
    {
        // buenas practicas de programación es que los atributos de las clases sean privados
        private static int contador;
        private static int numero;
        private static int maximo;
        private static int minimo;
        private static int suma;

        static Calculadora() // esta es la manera de inicializar datos en una clase
            // la mala practica es hacer x = 1, NO HACER ESO.
        {
            contador = 0;
            numero = 0;
            maximo = 0;
            minimo = 0;
            suma = 0;
        }
        /// <summary>
        /// Acá va el resumen de lo que hace el método
        /// </summary>
        /// <param name="nombredelparametro">Descripción del parámetro</param> => este sólo va si se tiene
        /// <returns>Acá va que se retorna</returns>
        public static int Dos()
        {
            return 2;
        }
        // este de ingresar numeros es de la clase 1 de intro, despues lo cambio de espacio.
        public static void IngresarNumeros()
        {
            int promedio;
            while (contador < 5)
            {
                Console.WriteLine("Ingrese un número:");
                int.TryParse(Console.ReadLine(), out numero);

                if (numero > 0)
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    suma += numero;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Error. numero inválido.");
                }
            }

            promedio = suma / contador;
            Console.WriteLine("El Contadorrr {0}", contador);
            Console.WriteLine("El valor máximo es: {0} . El valor mínimo es: {1} . El valor promedio es: {2}", maximo, minimo, promedio);
        }
    }
}