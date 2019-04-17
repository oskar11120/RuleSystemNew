using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    class Rule
    {
        public Rule(List<Premise> premises, Conclusion conclusion)
        {
            this.premises = premises;
            this.conclusion = conclusion;
        }
        public Rule(Premise premise, Conclusion conclusion)
        {
            this.premises.Add(premise);
            this.conclusion = conclusion;
        }

        private List<Premise> premises;
        private Conclusion conclusion;
        private bool IsInspected = false;
        private bool isTrue;

        public void Follow()
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
