using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Moto: VehiculoTerrestre
    {
        short cilindrada;
  
        public Moto(short cantidadRuedas, short cantidadPuertas, eColores.Colores color, short cilindrada): base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;    
        } 
        public void InformarMoto()
        {
            Console.WriteLine($"cilindrada = {this.cilindrada}");
        }
    }
}
