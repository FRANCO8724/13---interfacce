using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___interfacce
{
    internal class Ala : IComponente
    {

        public double Lunghezza { get; set; }
        public double Apertura { get; set; }


        public Ala(double _Lunghezza, double _Apertura)
        {
            Lunghezza = _Lunghezza;
            Apertura = _Apertura;
        }

        public string Descrizione()
        {
            return "";
        }

        public  double Costo()
        {
            return Lunghezza * Apertura;
        }

    }
}
