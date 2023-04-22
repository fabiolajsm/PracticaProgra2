using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Camion: VehiculoTerrestre
    {
        short cantidadMarchas;
        int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, eColores.Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
