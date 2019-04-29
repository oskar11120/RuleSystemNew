using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class PremiseForVariables : Premise
    {
        public PremiseForVariables(Variable var1, Sign sign, Variable var2)
        {
            this.var1 = var1;
            this.var2 = var2;
            this.sign = sign;
        }

        private Variable var1;
        private Variable var2;
        private readonly Sign sign;

        public override bool? Verify(Dictionary<string,List<Rule>> RuleLists)
        {
            if (var1.IsNull) var1.FindValue(RuleLists);
            if (var2.IsNull) var2.FindValue(RuleLists);

            if (var1.IsNull || var2.IsNull) throw new CouldNotFindValueException();
            else
            {
                switch (sign)
                {
                    case Sign.eqal:
                        return var1.isEqal(var2);
                    case Sign.notEqal:
                        return var1.isNotEqal(var2);
                    case Sign.biggerThan:
                        return var1.isBigger(var2);
                    case Sign.smallerThan:
                        return var1.isSmaller(var2);
                    case Sign.biggerOrEven:
                        return var1.isBiggerOrEven(var2);
                    case Sign.smallerOrEven:
                        return var1.isSmallerOrEven(var2);
                }
            }
            throw new NotImplementedException();
        }
       
    }
}
