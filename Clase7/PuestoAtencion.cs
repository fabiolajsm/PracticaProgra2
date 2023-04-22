using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Clase PuestoAtencion
El atributo numeroActual es estático y privado. Se inicializará en el constructor de clase (estático) con valor 0.
El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará un tiempo de atención mediante el método Sleep de la clase Thread (perteneciente al espacio de nombre System.Threading)
y retornará true para indicar el final de la atención.
La propiedad estática NumeroActual es la encargada de incrementar en 1 al atributo numeroActual y luego retornarlo.
*/
namespace Clase7
{
    public class PuestoAtencion
    {
        private static int numeroActual;

        static PuestoAtencion() { numeroActual = 0; }
        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }
        public bool Atender(Cliente cliente)
        {
            // Simular tiempo de atención
            Thread.Sleep(1000);
            return true;
        }
    }
}
