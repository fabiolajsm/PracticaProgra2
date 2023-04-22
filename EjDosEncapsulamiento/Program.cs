namespace EjDosEncapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "fcku";
            libro[2] = "undos";
            libro[3] = "untres";
            libro[4] = "uncuatro";
            libro[2] = "undosdoss";

            Console.WriteLine(libro[0]);
            Console.WriteLine(libro[2]);
            Console.WriteLine(libro[3]);
            Console.WriteLine(libro[2]);
            Console.WriteLine(libro[5]);
        }
    }
}