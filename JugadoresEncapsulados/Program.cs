namespace JugadoresEncapsulados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear equipo
            Equipo equipo = new Equipo(3, "Barcelona FC");
            // Crear jugadores
            Jugador jugador1 = new Jugador(12345678, "Lionel Messi", 10, 20);
            Jugador jugador2 = new Jugador(87654321, "Cristiano Ronaldo", 15, 30);
            Jugador jugador3 = new Jugador(11111111, "Neymar Jr", 5, 10);
            Jugador jugador4 = new Jugador(22222222, "Kylian Mbappé", 8, 16);

            // Agregar jugadores al equipo
            if (equipo + jugador1)
            {
                Console.WriteLine(jugador1.MostrarDatos());
            }
            if (equipo + jugador2)
            {
                Console.WriteLine(jugador2.MostrarDatos());
            }
            if (equipo + jugador3)
            {
                Console.WriteLine(jugador3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO " + jugador3.MostrarDatos());
            }
            // Intentar agregar un jugador cuando se ha alcanzado el límite
            if (equipo + jugador4)
            {
                Console.WriteLine(jugador4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO " + jugador4.MostrarDatos());            
            }
        }
    }
}