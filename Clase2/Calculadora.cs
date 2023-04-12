using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public static class Calculadora
    {
        private static bool Validar(int segundoNumero)
        {
            return segundoNumero != 0;
        }
        public static int Calcular(int primerNumero, int segundoNumero, char operando)
        {
            int resultado = 0;
            int numeroDivision;
            switch (operando)
            {
                case '-':
                    resultado = primerNumero - segundoNumero; 
                    break;
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero  * segundoNumero;
                    break;
                case '/':
                    if (Validar(segundoNumero)) {                     
                        resultado = primerNumero / segundoNumero;
                    } else
                    {
                        Console.WriteLine("El segundo número ingresado tiene que ser distinto de 0. Ingrese otro número:");
                        int.TryParse(Console.ReadLine(), out numeroDivision);
                        resultado = Calcular(primerNumero, numeroDivision, operando);
                    }
                    break;
                default:
                    return resultado;
            }
            return resultado;
        }

        public static void MostrarTablaDeMultiplicar(int numero)
        {
            StringBuilder multiplicaciones = new StringBuilder();
            if (numero < 1) Console.WriteLine("Se muestran tablas con numeros mayores a 0.");
            else
            {
                Console.WriteLine("Tabla de multiplicar del número {0}:", numero);
                for (int i = 1; i < 10; i++) {
                    multiplicaciones.Append($"{numero} x {i} = {numero*i}{Environment.NewLine}");
                }
            }
            Console.WriteLine(multiplicaciones);
        }

    }
}
