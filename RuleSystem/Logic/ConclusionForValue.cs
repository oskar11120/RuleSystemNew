using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    class ConclusionForValue<T> : Conclusion
    {
        public ConclusionForValue(Variable variable, T value)
        {
            this.variable = variable;
            this.value = value;
        }

        //pola
        private Variable variable;
        private T value;

        //metody
        public override void Follow()
        {
           ( variable as Variable<T>).SetValue(value);
        }
        public override string ToString()
        {
            return variable.Name;
        }
    }
}
