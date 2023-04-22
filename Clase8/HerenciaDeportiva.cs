using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Persona
    {
        // Propiedades de Persona
        public string Nombre { get; set; }
        public long Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Constructor de Persona
        public Persona(string nombre, DateTime fechaNacimiento, long dni)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Dni = dni;
        }

        // Método para exponer los datos de Persona
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}, DNI: {Dni}");
        }
    }
    // aja la otra clase 
    public class DirectorTecnico : Persona
    {
        // Constructor de DirectorTecnico
        public DirectorTecnico(string nombre, DateTime fechaNacimiento, long dni)
            : base(nombre, fechaNacimiento, dni)
        {
        }

        // Sobrescribir el método Equals para que dos DirectorTecnico sean iguales si tienen el mismo nombre y fecha de nacimiento
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            DirectorTecnico dt = (DirectorTecnico)obj;
            return (Nombre == dt.Nombre) && (FechaNacimiento == dt.FechaNacimiento);
        }

        // Sobrescribir el método GetHashCode para asegurar que dos objetos iguales tengan el mismo código hash
        public override int GetHashCode()
        {
            return Nombre.GetHashCode() ^ FechaNacimiento.GetHashCode();
        }

        // Método para exponer los datos de DirectorTecnico
        public void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Director Técnico");
        }
    }
}
