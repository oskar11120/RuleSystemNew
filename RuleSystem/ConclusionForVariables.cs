using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    class ConclusionForVariables<T> : Conclusion
    {
        public ConclusionForVariables(Variable<T> variable, T value)
        {
            this.variable = variable;
            this.value = value;
        }

        //pola
        private Variable<T> variable;
        private T value;
        
        //metody
        public override void Follow()
        {
            this.variable.Value = this.value;
        }
    }
}
