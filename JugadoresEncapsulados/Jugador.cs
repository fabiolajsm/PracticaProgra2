using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadoresEncapsulados
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador() {
            // Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public float GetPromedioGoles() {
            return (float)this.partidosJugados / this.totalGoles;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre : {this.nombre}, DNI: {this.dni.ToString()}, ");
            sb.Append($"Partidos Jugados: {this.partidosJugados.ToString()}, Promedio Goles: {GetPromedioGoles().ToString()}, ");
            sb.Append($"Total goles: {this.totalGoles.ToString()}");
            return sb.ToString();
        }

        // Sobrecarga: Dos jugadores seran iguales si tienen el mismo DNI
        public static bool operator == (Jugador uno, Jugador dos){
            return uno.dni == dos.dni;
        }
        public static bool operator !=(Jugador uno, Jugador dos)
        {
            return uno.dni != dos.dni;
        }
    }
}
