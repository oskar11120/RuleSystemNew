using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public abstract class Variable<T>
    {
        protected Variable(string name)
        {
            this.Name = name;
        }
       
        public string Name;
        protected T Value;

        public abstract T GetValue();
        public abstract void SetValue(T Value);        
    }
}
