using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Cliente
    {
        public int Numero { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Cliente other = (Cliente)obj;
            return Numero == other.Numero;
        }

        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (ReferenceEquals(c1, c2))
            {
                return true;
            }

            if (c1 is null || c2 is null)
            {
                return false;
            }

            return c1.Equals(c2);
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
