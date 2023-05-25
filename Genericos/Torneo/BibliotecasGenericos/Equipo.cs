using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecasGenericos
{
    public abstract class Equipo
    {
        public string nombre;
        private DateTime fechaCreacion;
        public Equipo(string nombre, DateTime fechaCreacion) {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        /* El método Ficha retornará el nombre del equipo y su fecha de creación con el siguiente formato: [EQUIPO] fundado el [FECHA]  */
        public string Ficha()
        {
            return $"{nombre} fundado el {fechaCreacion.ToString("dd/MM/yyyy")}";
        }
        // Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
        // Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.nombre == equipoB.nombre && equipoA.fechaCreacion == equipoB.fechaCreacion;
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.nombre != equipoB.nombre && equipoA.fechaCreacion != equipoB.fechaCreacion;
        }
    }
    // Generar la clase EquipoFutbol que herede de Equipo.
    public class EquipoFutbol: Equipo
    {
        public EquipoFutbol(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion) { 
        }
    }
    // Generar la clase EquipoBasquet que herede de Equipo.
    public class EquipoBasquet : Equipo
    {
        public EquipoBasquet(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }
    }
}
