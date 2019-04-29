using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class ConclusionForVariables : Conclusion
    {
        public ConclusionForVariables(Variable variable, Variable value)
        {
            this.variable = variable;
            this.value = value;
        }

        //pola
        private Variable variable;
        private Variable value;
        
        //metody
        public override void Follow()
        {
            variable.SetValue(value);
        }
        public override string ToString()
        {
            return variable.Name;
        }
    }
}
