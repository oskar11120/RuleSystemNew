using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Conclusion<TVariable,T> where TVariable: Variable<T>
    {
        public Conclusion(TVariable variable, TVariable value)
        {
            this.variable = variable;
            this.value = value;
        }

        //pola
        private TVariable variable;
        private TVariable value;
        
        //metody
        public void Follow()
        {
            variable.SetValue(value.GetValue());
        }
        public override string ToString()
        {
            return variable.Name;
        }
    }
}
