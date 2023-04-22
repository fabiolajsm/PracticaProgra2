namespace Clase8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");
             VehiculoTerrestre camion = new Camion(1, 2, eColores.Colores.Rojo, 13, 4);
             Moto moto = new Moto(2, 3, eColores.Colores.Negro, 5);
             VehiculoTerrestre auto = new VehiculoTerrestre(2, 3, eColores.Colores.Gris);

             VehiculoTerrestre vehiculo = new VehiculoTerrestre(2, 3, eColores.Colores.Azul);
             camion.Informar();
             moto.Informar();
             moto.InformarMoto();
             auto.Informar();
             vehiculo.Informar();*/
            DateTime dateTime = DateTime.ParseExact("17/12/2002", "dd/MM/yyyy", null);
            Persona per = new Persona("Fabiola", dateTime , 96059973);
            per.MostrarDatos();
        }
    }
}