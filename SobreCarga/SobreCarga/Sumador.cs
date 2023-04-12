using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    internal class Sumador
    {
        public int cantidadSumas;
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0) { }
        //Métodos
        public void Mostrar()
        {
            Console.WriteLine("{0}", this.cantidadSumas);
        }
        public long Sumar(long numeroUno, long numeroDos) {
            this.cantidadSumas += 1;
            return numeroUno + numeroDos;
        }
        public string Sumar(string strUno, string strDos)
        {
            this.cantidadSumas += 1;
            return string.Format($"{strUno}{strDos}");
        }

        // Conversión explícita que retorne CantidadSumas
        public static explicit operator int(Sumador cant)
        {
            return cant.cantidadSumas;
        }
        public static long operator +(Sumador sumUno, Sumador sumDos)
        {
            return sumUno.cantidadSumas + sumDos.cantidadSumas;
        }
        public static bool operator |(Sumador pipeUno, Sumador pipeDos)
        {
            return pipeUno.cantidadSumas == pipeDos.cantidadSumas;
        }
    }
}
