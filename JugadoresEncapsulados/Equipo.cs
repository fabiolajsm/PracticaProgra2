using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadoresEncapsulados
{
    public class Equipo
    {
        public short cantidadDeJugadores;
        public string nombre;
        public List<Jugador> jugadores;

        private Equipo() {         
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre): this() { 
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cantidad jugadores : {this.cantidadDeJugadores}, Nombre del equipo: {this.nombre}, ");
            sb.Append($"Partidos Jugados: ");
            for ( int i = 0; i < jugadores.Count; i++ )
            {
                sb.Append($"{jugadores[i].MostrarDatos()}");
            }
            return sb.ToString();
        }

        // Sobrecarga: el operador + agregará jugadores a la lista siempre y cuando no exista aún en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores.
        public static bool operator +(Equipo equipo, Jugador jugador) { 
            if(equipo.jugadores.Count == 0 ||  equipo.jugadores.Count < equipo.cantidadDeJugadores)
            {
                foreach (Jugador item in equipo.jugadores)
                {
                    if(item == jugador) // esta es la sobrecarga que esta en jugador
                    {
                        return false;
                    }
                }
                equipo.jugadores.Add(jugador);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
