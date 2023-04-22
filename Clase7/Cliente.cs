using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Cliente
    {
        private string Nombre { get; set; }
        private int Numero { get; set; }

        public Cliente(int numero)
        {
            this.Numero = numero;
        }
        public Cliente(int numero, string nombre) {
            this.Numero = numero;
            this.Nombre = nombre;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1.Numero == c2.Numero);
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }
    }
}
