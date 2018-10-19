using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Taxi : CocheSimple
    {
        private string CodLicencia;

        public Taxi()
        {
        }
        public Taxi(string marca, string mod, int velMax, string lic) : base(marca, mod, velMax)
        {
            CodLicencia = lic;
        }


    }
}