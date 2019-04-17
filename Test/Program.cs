using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuleSystem;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //zmienne asdasd 
            Real wiek = new Real("WiekTomasza",12);
            Real wiek2 = new Real("WiekStefana",11);
            RuleSystem.Boolean czyTomaszStarszy = new RuleSystem.Boolean("czyTomaszJestStarszy");

            //reguly
            PremiseForVariables<Real> premise = new PremiseForVariables<Real>(wiek as Variable<Real>, Sign.biggerThan, wiek2);

        }
    }
}
