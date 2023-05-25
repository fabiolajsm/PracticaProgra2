using System.Text;

namespace BibliotecasGenericos
{
    /* Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
     * Tendrá un atributo equipos de tipo List<T> y otro que se llame nombre de tipo string. */
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Torneo()
        {
            equipos = new List<T>();
            nombre = string.Empty;
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        // Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        // Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando este no se encuentre ya en el torneo.
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if ((torneo is not null && equipo is not null) && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }
        // El método Mostrar retornará los datos del torneo y de los equipos participantes.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {nombre}");
            foreach (T item in equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        /* El método privado CalcularPartido recibirá dos elementos del tipo T, que deberán ser del tipo Equipo o sus herencias, 
         * y calculará utilizando la clase Random un resultado del partido. Retornará el resultado como un string con el siguiente formato donde 
         * EQUIPOX es el nombre del equipo y RESULTADOX la cantidad de goles/puntos: [EQUIPO1][RESULTADO1] – [RESULTADO2][EQUIPO2]*/
        private string CalcularPartido(T e1, T e2)
        {
            Random rd = new Random();
            return $"{e1.nombre}{rd.Next(0, 10)} - {e2.nombre}{rd.Next(0, 10)}";
        }
        // La propiedad pública JugarPartido tomará dos equipos de la lista al azar y calculará el resultado del partido a través del método CalcularPartido.
        public string JugarPartido
        {
            get
            {
                Random rd = new Random();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[rd.Next(0, equipos.Count)];
                    equipo2 = equipos[rd.Next(0, equipos.Count)];
                } while (equipo1 == equipo2);
                return CalcularPartido(equipo1, equipo2);
            }
        }
    }
}