using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjDosEncapsulamiento
{
    public class Libro
    {
        List<string> paginas = new List<string>();
        // public List<string> Paginas {  get; set; }
        public string this[int index] { 
            get {
                if(index > 0 && index <= paginas.Count)
                {
                    return paginas.ElementAt(index - 1);
                } 
                else
                {
                    return "";
                }
            }
            set {
                if (index < paginas.Count)
                {
                    paginas[index] = value;
                }
                else {
                    paginas.Add(value);
                }                
            }
        }
    }
}
