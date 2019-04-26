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
        public void FindValue(Dictionary<string, List<GeneralRule>> RuleLists)
        {
            if (!(this.Value as object is null)) return;
            foreach (GeneralRule rule in RuleLists[this.Name])
            {
                //nie wiem co sie dzieje jesli RuleLists jest pusta
                rule.Follow();
                if (!(this.Value as object is null)) return;
            }
        }
        public override string ToString()
        {
            if ((this.Value as object) is null) return this.Name + ": <<unnknown>>";
            else return this.Name +": "+ this.Value.ToString();
        }
    }
}
