using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    internal static class Utiles
    {
        public static void CargarArray(int[] array, int cantidadItems)
        {
            Random rnd = new Random();
            if (cantidadItems > 0)
            {
                for (int i = 0; i < cantidadItems; i++)            
                {                
                    array[i] = rnd.Next(-100, 100);           
                }            
            };
        } 
        public static void MostrarNumeros(int[] numeros)
        {
            if (numeros.Length == 0) Console.WriteLine("El array de números está vacío");
            else for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        public static int OrdenarDecreciente(int numeroUno, int numeroDos)
        {
            return numeroDos - numeroUno;
        }
        // Lista:
        public static void CargarLista(List<int> lista, int cantidadItems)
        {
            Random rnd = new Random();

            if (cantidadItems > 0)
            {
                for (int i = 0; i < cantidadItems; i++)
                {
                    lista.Add(rnd.Next(-100, 100));
                }
            }
        }
        public static void MostrarLista(List<int> numeros)
        {
            if (numeros.Count == 0) Console.WriteLine("El array de números está vacío");
            else for (int i = 0; i < numeros.Count; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
        }
        public static void OrdenarListaDecreciente(List<int> lista)
        {
            if(lista.Count > 0)
            {
                lista.Sort(CompararListaDecreciente);
            }
        }
        private static int CompararListaDecreciente(int numUno, int numDos) {
        
            if(numUno > numDos) return -1;
            if (numUno < numDos) return 1;
            else return 0;
        }
        public static void OrdenarListaCreciente(List<int> lista)
        {
            if (lista.Count > 0)
            {
                // lista.OrderBy(x => x) esta devuelve una nueva lista y sort si modifica a la actual
                lista.Sort();
            }
        }
        // Stack:
        public static void CargarStack(Stack<int> stack, int cantidadItems)
        {
            Random rnd = new Random();

            if (cantidadItems > 0)
            {
                for (int i = 0; i < cantidadItems; i++)
                {
                    stack.Push(rnd.Next(-100, 100));
                }
            }
        }
        public static void MostrarStack(Stack<int> numeros)
        {
            if (numeros.Count == 0) Console.WriteLine("El stack de números está vacío");
            else
            {
                foreach (int numero in numeros)
                {
                    Console.WriteLine($"{numero}");
                }
            }                
        }
        public static Stack<int> OrdenarStackCreciente(Stack<int> numeros)
        {
            if (numeros.Count == 0) return numeros;
            List<int> listaCreciente = numeros.ToList();
            listaCreciente.Sort();
            listaCreciente.Reverse();
            Stack<int> stackCreciente = new Stack<int>(listaCreciente);
            return stackCreciente;
        }
        public static Stack<int> OrdenarStackDecreciente(Stack<int> numeros)
        {
            if (numeros.Count == 0) return numeros;
            List<int> listaDecreciente = numeros.ToList();
            listaDecreciente.Sort();
            Stack<int> stackDecreciente = new Stack<int>(listaDecreciente);
            return stackDecreciente;
        }
        // Queue
        public static void CargarQueue(Queue<int> queue, int cantidadItems)
        {
            Random rnd = new Random();

            if (cantidadItems > 0)
            {
                for (int i = 0; i < cantidadItems; i++)
                {
                    queue.Enqueue(rnd.Next(-100, 100));
                }
            }
        }
        public static void MostrarQueue(Queue<int> numeros)
        {
            if (numeros.Count == 0) Console.WriteLine("El array de números está vacío");
            else
            {
                foreach (int numero in numeros)
                {
                    Console.WriteLine($"{numero}");
                }
            }
        }
        public static Queue<int> OrdenarQueueCreciente(Queue<int> numeros)
        {
            if (numeros.Count == 0) return numeros;
            List<int> listaCreciente = numeros.ToList();
            listaCreciente.Sort();
            Queue<int> stackCreciente = new Queue<int>(listaCreciente);
            return stackCreciente;
        }
        public static Queue<int> OrdenarQueueDecreciente(Queue<int> numeros)
        {
            if (numeros.Count == 0) return numeros;
            List<int> listaDecreciente = numeros.ToList();
            listaDecreciente.Sort();
            listaDecreciente.Reverse();
            Queue<int> stackDecreciente = new Queue<int>(listaDecreciente);
            return stackDecreciente;
        }
        // Diccionario:
        public static void CargarDiccionario(Dictionary<int, int> diccionario, int cantidadItems)
        {
            /*Ej:
             Dictionary<string, int> miDiccionario = new Dictionary<string, int>();
             miDiccionario.Add("uno", 1);
             miDiccionario.Add("dos", 2);
             miDiccionario.Add("tres", 3);
             Cada item tiene que tener un key unico
             */
            Random rnd = new Random();

            if (cantidadItems > 0)
            {
                for (int i = 0; i < cantidadItems; i++)
                {
                    diccionario.Add(i, rnd.Next(-100, 100));
                }
            }
        }
        public static void MostrarDiccionario(Dictionary<int, int> numeros)
        {
            if (numeros.Count == 0) Console.WriteLine("El array de números está vacío");
            else
            {
                foreach(KeyValuePair<int, int> numero in numeros)
                {
                    Console.WriteLine($"Key: {numero.Key}, Value: {numero.Value}");
                }
            }
        }
        public static Dictionary<int, int> OrdenarDiccionarioDecreciente(Dictionary<int, int> numeros, string valor)
        {
            var ordenadosPorKey = numeros.OrderByDescending(kvp => kvp.Key);
            var ordenadosPorValor = numeros.OrderByDescending(kvp => kvp.Value);
            Dictionary<int, int> diccionarioOrdenadoKey = new Dictionary<int, int>(ordenadosPorKey);
            Dictionary<int, int> diccionarioOrdenadoValor = new Dictionary<int, int>(ordenadosPorValor);
            return valor == "key" ? diccionarioOrdenadoKey : diccionarioOrdenadoValor;
        }
        public static Dictionary<int, int> OrdenarDiccionarioCreciente(Dictionary<int, int> numeros, string valor)
        {
            var ordenadosPorKey = numeros.OrderBy(kvp => kvp.Key);
            var ordenadosPorValor = numeros.OrderBy(kvp => kvp.Value);
            Dictionary<int, int> diccionarioOrdenadoKey = new Dictionary<int, int>(ordenadosPorKey);
            Dictionary<int, int> diccionarioOrdenadoValor = new Dictionary<int, int>(ordenadosPorValor);
            return valor == "key" ? diccionarioOrdenadoKey : diccionarioOrdenadoValor;
        }
    }
}
