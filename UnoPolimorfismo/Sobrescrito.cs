using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoPolimorfismo
{
        /* Parte II
         * Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.
         * Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
         * Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
         * Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
         * Agregar una clase llamada SobreSobrescrito que herede de Sobrescrito. Implementar el código necesario para que todo funcione correctamente.
         */
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
        /* Parte I
         * Sobrescribir el método ToString para que retorne "¡Este es mi método ToString sobrescrito!".
         * Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la misma clase), false caso contrario.
         * Sobrescribir el método GetHashCode para que retorne el número 1142510181.
         */
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object? obj)
        {            
            return obj?.GetType() == typeof(Sobrescrito);
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }

    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad
        {
            get { return miAtributo; }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
