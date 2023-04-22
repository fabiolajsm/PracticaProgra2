using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Automovil: VehiculoTerrestre
    {
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, eColores.Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
