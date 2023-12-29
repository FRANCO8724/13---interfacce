using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___interfacce
{
    internal class Fusoliera : IComponente
    {
        public string Materiale { get; set; }
        public double Lunghezza { get; set; }

        public Fusoliera(double _Lunghezza, string _Materiale)
        {
            Lunghezza = _Lunghezza;
            Materiale = _Materiale;
        }
        public  string Descrizione()
        {
            return "Materiale: " + Materiale;
        }

        public  double Costo()
        {
            return Lunghezza;
        }
    }
}
