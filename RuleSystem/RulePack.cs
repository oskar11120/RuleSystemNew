﻿using System;
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
            Real wiek2 = new Real("WiekStefana", 11);
            RuleSystem.Boolean czyTomaszStarszy = new RuleSystem.Boolean("czyTomaszJestStarszy");
            RuleSystem.Enum @enum = new RuleSystem.Enum(new List<string> { "a", "b", "c" }, "papa", 1);

            //reguly
            PremiseForVariables<Real, decimal?> premise = new PremiseForVariables<Real, decimal?>(wiek, Sign.biggerThan, wiek2);
            Conclusion<RuleSystem.Boolean, bool?> conclusion = new Conclusion<RuleSystem.Boolean, bool?>(czyTomaszStarszy, new RuleSystem.Boolean("asdas", true));

            Rule<RuleSystem.Boolean, bool?> rule = new Rule<RuleSystem.Boolean, bool?>(premise, conclusion, RuleLists);

            Console.WriteLine(czyTomaszStarszy.GetValue());
            rule.Follow();
            Console.WriteLine(czyTomaszStarszy.GetValue());
        }
        
        private Dictionary<string, List<GeneralRule>> RuleLists = new Dictionary<string, List<GeneralRule>>();

    }
}