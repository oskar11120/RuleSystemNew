using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public abstract class Premise
    {
        public abstract bool? Verify(Dictionary<string, List<Rule>> RuleLists);
    }
}
