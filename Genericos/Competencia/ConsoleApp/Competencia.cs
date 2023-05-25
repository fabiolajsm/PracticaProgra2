using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class VehiculoDeCarrera
    {
    }
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        private List<T> competidores;

    }
}
