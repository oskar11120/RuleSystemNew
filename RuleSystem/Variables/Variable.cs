using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public abstract class Variable<T>
    {
        protected Variable(T value, string name)
        {
            this.Value = value;
            this.Name = name;
        }


        public T Value;
        public string Name;

        public abstract override string ToString();
    }
}
