namespace Biblioteca
{
    public class Documento
    {
        public int Numero { get; }
        public Documento(int numero)
        {
            this.Numero = numero;
        }
    }

    public class Recibo: Documento
    {
        // El constructor sin parámetros de Recibo asignará 0 como número de documento.
        public Recibo(): this(0) { }
        public Recibo(int numero) : base(numero) { }
    }
    public class Factura: Documento
    {
        public Factura(int numero) : base(numero) { }
    }
}