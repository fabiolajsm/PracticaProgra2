using BibliotecasGenericos;

/* Generar dos torneos, uno de Futbol y otro de Basquet.
 * Crear 3 equipos de cada tipo.
 * Agregar los equipos en tantos torneos como se pueda.
 * Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
 * Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su respuesta por pantalla.
*/
namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("tBasquet");
            EquipoBasquet e1 = new EquipoBasquet("e1", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("e2", DateTime.Now);

            _ = torneoBasquet + e1;
            _ = torneoBasquet + e2;

            Console.WriteLine(torneoBasquet.Mostrar());
        }
    }
}