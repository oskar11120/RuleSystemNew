using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class RulePack
    {

        public RulePack()
        {
            //zmienne asdasd 
            Real wiek = new Real("WiekTomasza", 12);
            Real wiek2 = new Real("WiekStefana", 10);
            Boolean czyTomaszStarszy = new Boolean("czyTomaszJestStarszy");
            Enum @enum = new Enum(new List<string> { "a", "b", "c" }, "papa", "a");

            var czyStefanMlodszy = new Boolean("czyStefanMlodszy");

            //reguly
            PremiseForVariables premise = new PremiseForVariables(wiek, Sign.biggerThan, wiek2);
            var premiseForValue = new PremiseForValue<string>(@enum, Sign.eqal, "a");


            var conclusion = new ConclusionForVariables(czyTomaszStarszy, new Boolean("asdas", true));
            
            Rule rule = new Rule(new List<Premise> { premise, premiseForValue }, conclusion, RuleLists);
            Rule rule2 = new Rule(new PremiseForVariables(czyTomaszStarszy, Sign.eqal, new Boolean("asdas", true)), new ConclusionForValue<bool?>(czyStefanMlodszy, true), RuleLists);
            //Console.WriteLine(rule.IsTrue());
            //Console.WriteLine(czyTomaszStarszy);
            //czyTomaszStarszy.FindValue(RuleLists);
            //Console.WriteLine(czyTomaszStarszy);
            czyStefanMlodszy.FindValue(RuleLists);
            Console.WriteLine(czyStefanMlodszy);
            
        }
        
        private Dictionary<string, List<Rule>> RuleLists = new Dictionary<string, List<Rule>>();

    }
}
