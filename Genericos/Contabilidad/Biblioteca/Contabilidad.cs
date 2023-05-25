using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    // Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
    // El tipo U deberá tener una restricción que indique que deberá tener un constructor público y sin parámetros.
    public class Contabilidad<T, U> where T : Documento where U : Documento, new()
    {
        public List<T> egresos;
        public List<U> ingresos;

        // Crear en Contabilidad un constructor que no reciba parámetros e inicialice las listas.
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        // El operador + entre Contabilidad y T agrega un elemento a la lista egresos.
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, T egreso)
        {
            if(contabilidad is null || egreso is null) return null;

            contabilidad.egresos.Add(egreso);
            return contabilidad;
        }
        // El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            if (contabilidad is null || ingreso is null) return null;

            contabilidad.ingresos.Add(ingreso);
            return contabilidad;
        }
    }
}
