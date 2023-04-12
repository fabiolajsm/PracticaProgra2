using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    internal class Cuenta
    {
        private string titular;
        private int cantidad;
        public Cuenta() {        
            titular = string.Empty;
            cantidad = 0;
        }

        public string GetTitular() {         
            return this.titular;
        }
        public int GetCantidad()
        {
            return this.cantidad;
        }
        public int SetCantidad(int monto)
        {
            return this.cantidad+=monto;
        }

        public void Mostrar() {
            Console.WriteLine($"Titular:{titular} y cantidad: {cantidad}.");
        }
        public void Ingresar(int monto) {
            if (monto > 0) {
                SetCantidad(monto);
            }
        }
        public void Retirar()
        {
            Console.WriteLine();
        }
    }
}
