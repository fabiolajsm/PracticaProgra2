using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        public Cliente Cliente { get; set; }
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        // Sobrecarga
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c) return false;
            else {           
                n.clientes.Enqueue(c);         
                return true;           
            }
        }
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (c == item) return true;
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c) {
            foreach (Cliente item in n.clientes)
            {
                if (c != item) return true;
            }
            return false;
        }
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }
    }
}
