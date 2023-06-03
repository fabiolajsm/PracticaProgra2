namespace FuncionesPrueba
{
    public static class Calculadora
    {
        public static int Sumar(int a, int b)
        {
            return a + b;
        }
        public static int Restar(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static double Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }

            return (double)a / b;
        }
    }
}