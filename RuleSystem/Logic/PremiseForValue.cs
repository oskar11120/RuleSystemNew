using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    class PremiseForValue<T> : Premise
    {
        public PremiseForValue(Variable var1, Sign sign, T val2)
        {
            //if (!(var1 is Variable<T>)) throw new UnexpectedValueException(); nie wiem co z tym zrobic

            this.var1 = var1;
            this.val2 = val2;
            this.sign = sign;
        }

        private Variable var1;
        private Sign sign;
        private T val2;

        public override bool? Verify(Dictionary<string, List<Rule>> RuleLists)
        {
            
            if(var1.IsNull) var1.FindValue(RuleLists);

            if (var1.IsNull) throw new CouldNotFindValueException();
            else
            {
                switch (sign)
                {
                    case Sign.eqal:
                        return (var1 as Variable<T>).isEqal(val2);
                    case Sign.notEqal:
                        return (var1 as Variable<T>).isNotEqal(val2);
                    case Sign.biggerThan:
                        return (var1 as Variable<T>).isBigger(val2);
                    case Sign.smallerThan:
                        return (var1 as Variable<T>).isSmaller(val2);
                    case Sign.biggerOrEven:
                        return (var1 as Variable<T>).isBiggerOrEven(val2);
                    case Sign.smallerOrEven:
                        return (var1 as Variable<T>).isSmallerOrEven(val2);
                }
            }
            throw new NotImplementedException();
        }
    }
}
