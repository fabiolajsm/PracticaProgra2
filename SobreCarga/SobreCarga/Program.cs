using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SobreCarga;
// se tiene que hacer el using para tener la dependencia y vincular
namespace SobreCarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumadorDos = new Sumador();
            //sumador.Mostrar();
            Console.WriteLine(sumador.Sumar(1,2));          
            Console.WriteLine(sumador.Sumar("20", "23"));          
            sumador.Mostrar();
            sumadorDos.Mostrar();            
            Console.WriteLine("Ahora si los convertidores");
            Console.WriteLine(sumador + sumadorDos);          
            Console.WriteLine(sumador | sumadorDos);
        }
    }
}