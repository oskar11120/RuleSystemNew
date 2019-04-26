using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class PremiseForVariables<TVariable,T> : Premise where TVariable: Variable<T>
    {
        public PremiseForVariables(TVariable var1, Sign sign, TVariable var2)
        {
            this.var1 = var1;
            this.var2 = var2;
            this.sign = sign;
        }

        private TVariable var1;
        private TVariable var2;
        private readonly Sign sign;

        public override bool? Verify(Dictionary<string,List<GeneralRule>> RuleLists)
        {
            if (var1 is null) var1.FindValue(RuleLists);
            if (var2 is null) var2.FindValue(RuleLists);

            if (var1 is null || var2 is null) throw new CouldNotFindValueException();
            else
            {
                switch (sign)
                {
                    case Sign.even:
                        return isEven(var1, var2);
                    case Sign.notEven:
                        return isNotEven(var1, var2);
                    case Sign.biggerThan:
                        return isBigger(var1, var2);
                    case Sign.smallerThan:
                        return isSmaller(var1, var2);
                    case Sign.biggerOrEven:
                        return isBiggerOrEven(var1, var2);
                    case Sign.smallerOrEven:
                        return isSmallerOrEven(var1, var2);
                }
            }
            throw new NotImplementedException();
        }
       
    }
}
