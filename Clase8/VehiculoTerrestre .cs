using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected eColores.Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, eColores.Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public void Informar()
        {
            Console.WriteLine($"cantidadRuedas = {this.cantidadRuedas}, cantidadPuertas = {this.cantidadPuertas} y color = {this.color}");
        }
    }
}
