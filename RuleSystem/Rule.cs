using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Rule<TVariable,T> : GeneralRule where TVariable: Variable<T> 
    {
        private Rule(Conclusion<TVariable, T> conclusion, Dictionary<string, List<GeneralRule>> RuleLists)
        {
            this.conclusion = conclusion;
            if (this.RuleList is null)
            {
                RuleList = new List<GeneralRule>();
                RuleLists.Add(conclusion.ToString(), RuleList);
            }
            RuleList.Add(this);
        }
        public Rule(List<Premise> premises, Conclusion<TVariable,T> conclusion, Dictionary<string, List<GeneralRule>> RuleLists) : this(conclusion, RuleLists)
        {
            this.premises = premises;         
        }
        public Rule(Premise premise, Conclusion<TVariable, T> conclusion, Dictionary<string, List<GeneralRule>> RuleLists) : this(conclusion, RuleLists)
        {
            this.premises.Add(premise);           
        }

        private List<Premise> premises = new List<Premise>();
        private Conclusion<TVariable,T> conclusion;
        private bool IsInspected = false;
        private bool isTrue;
        private List<GeneralRule> RuleList;

        public override void Follow()
        {
            isTrue = true;
            foreach (Premise premise in premises)
            {
                if(premise.Verify() == false)
                {
                    isTrue = false;
                    break;
                }
            }
            if (isTrue) conclusion.Follow();
            this.IsInspected = true;
        }
    }
}
