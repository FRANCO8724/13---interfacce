using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___interfacce
{
    internal class Ruota : IComponente
    {

        public double Pollici { get; set; }
        public double Altezza { get; set; }
        public double Larghezza { get; set; }
        public double Raggio { get; set; }

        public Ruota(double _Pollici, double _Altezza, double _Larghezza, double _Raggio)
        {
            Pollici = _Pollici;
            Altezza = _Altezza;
            Larghezza = _Larghezza;
            Raggio = _Raggio;
        }

        public string Descrizione()
        {
            return "";
        }

        public double Costo()
        {
            return Pollici * Altezza * Larghezza * Raggio;
        }
    }
}
