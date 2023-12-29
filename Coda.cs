using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___interfacce
{
    internal class Coda : IComponente
    {
        public double Lunghezza { get; set; }

        public Coda(double _Lunghezza)
        {
            Lunghezza = _Lunghezza;
        }
        public string Descrizione()
        {
            return "";
        }

        public double Costo()
        {
            return Lunghezza;
        }
    }
}
