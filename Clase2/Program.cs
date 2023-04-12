using Entidades;

// Clase 2: Clases y métodos estáticos
namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine($"{Calculadora.Dos()}");
            //Calculadora.IngresarNumeros();
            // Ejercicio I01 - Validador de rangos
            // Pedir al usuario que ingrese 10 números enteros.
            // Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
            // Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
            // Utilizar variables escalares, NO utilizar vectores/arrays.
            //int contador;
            //int numero;
            //int minimo = 0;
            //bool banderaMin = false;
            //int maximo = 0;
            //bool banderaMax = false;
            //int promedio = 0;
            //int suma = 0;
            // Ejercicio I02 - ¿Desea continuar?
            //while (Validador.DeseaContinuar())            
            //{
            //    contador = 0;
            //    while (contador < 10)
            //    {
            //        Console.WriteLine("Ingrese un número:");
            //        int.TryParse(Console.ReadLine(), out numero);

            //        if (Validador.Validar(numero, -100, 100))
            //        {
            //            if (!banderaMin || numero < minimo)
            //            {
            //                minimo = numero;
            //                banderaMin = true;
            //            }
            //            if (!banderaMax || numero > maximo)
            //            {
            //                maximo = numero;
            //                banderaMax = true;
            //            }
            //            suma += numero;
            //            contador++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error. Número fuera del rango -100 y 100.");
            //        }
            //        promedio = suma / contador;
            //    }
            //    Console.WriteLine("El Contadorrr {0}", contador);
            //    Console.WriteLine("Suma {0}", suma);
            //    Console.WriteLine("El valor máximo es: {0} . El valor mínimo es: {1} . El valor promedio es: {2}", maximo, minimo, promedio);

            //-----------------------------
            // Ejercicio I03 - Conversor binario: NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
            // Console.WriteLine("El número 12 en binario es: {0} y el binario 1100 en decimal es: {1}", Conversor.ConvertirDecimalABinario(12), Conversor.ConvertirBinarioADecimal("1100"));
            // -------------------------------------
            // Ejercicio I04 - La calculadora: Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /). El usuario decidirá cuándo finalizar el programa.
            //do
            //{
            //    int primerNum;
            //    int segundoNum;
            //    char operando;
            //    Console.WriteLine("Ingrese un número:");
            //    int.TryParse(Console.ReadLine(), out primerNum);
            //    Console.WriteLine("Ingrese otro número:");
            //    int.TryParse(Console.ReadLine(), out segundoNum);
            //    Console.WriteLine("Ingrese operación (ingresando el caracter +, -, * o /):");
            //    Char.TryParse(Console.ReadLine(), out operando);
            //    Console.WriteLine("El resultado es: {0}", Calculadora.Calcular(primerNum, segundoNum, operando));
            //} while (Validador.DeseaContinuar());
            // ----------------------------------------------
            //Ejercicio I05 - Aprendete las tablas: Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
            //Console.WriteLine($"{0} x {1} = {2}{Environment.NewLine}");
            Calculadora.MostrarTablaDeMultiplicar(2);
        }

    }
}
