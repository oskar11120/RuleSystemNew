using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Rule
    {
        private Rule(Conclusion conclusion, Dictionary<string, List<Rule>> RuleLists)
        {
            this.conclusion = conclusion;
            if (this.RuleList is null)
            {
                RuleList = new List<Rule>();
                RuleLists.Add(conclusion.ToString(), RuleList);
            }
            RuleList.Add(this);
            this.RuleLists = RuleLists;
        }
        public Rule(List<Premise> premises, Conclusion conclusion, Dictionary<string, List<Rule>> RuleLists) : this(conclusion, RuleLists)
        {
            this.premises = premises;         
        }
        public Rule(Premise premise, Conclusion conclusion, Dictionary<string, List<Rule>> RuleLists) : this(conclusion, RuleLists)
        {
            this.premises.Add(premise);           
        }

        private List<Premise> premises = new List<Premise>();
        private Conclusion conclusion;
        private bool IsInspected = false;
        private List<Rule> RuleList;
        Dictionary<string, List<Rule>> RuleLists;

        public void Follow()
        {
            if (this.IsInspected) return;
            if(IsTrue()) conclusion.Follow();
            this.IsInspected = true;
        }
        public bool IsTrue()
        {
            return premises.All(premise => premise.Verify(RuleLists) == true);
        }
    }
}
