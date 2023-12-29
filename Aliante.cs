using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___interfacce
{
    internal class Aliante : IComponente
    {
        public string deala { get; set; }
        public string deFusoliera { get; set; }
        public string deCoda { get; set; }

        public Aliante(string _deala, string _deFusoliera, string _deCoda)
        {
            deala = _deala;
            deFusoliera = _deFusoliera;
            deCoda = _deCoda;
        }

        public string Descrizione()
        {
            return "Ala: " + deala + ", Fusoliera : " + deFusoliera + ", Coda : " + deCoda;
        }

        public double Costo()
        {
            return 0;
        }
    }
}
