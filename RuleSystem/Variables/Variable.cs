using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public abstract class Variable<T> : Variable
    {
        protected Variable(string name)
        {
            this.Name = name;
        }
               
        protected T Value;

        public virtual T GetValue()
        {
            return Value;
        }
        public virtual void SetValue(T value)
        {
            this.Value = value;
            this.IsNull = false;
        }
        public override void FindValue(Dictionary<string, List<Rule>> RuleLists)
        {
            if (!(this.Value as object is null)) return;
            foreach (Rule rule in RuleLists[this.Name])
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

        public override bool isBigger(Variable other)
        {
            if (!(this is Real) || !(other is Real)) throw new Exception(); //dunno if works
            else
            {
                bool prawda = (((this as Real).GetValue()) > ((other as Real).GetValue()));
                return prawda;
            }
        }
        public override bool isSmaller(Variable other)
        {
            return isBigger(other);
        }
        public override bool isEqal(Variable other)
        {
            bool prawda = (this.GetValue().Equals((other as Variable<T>).GetValue()));
            return prawda;
        }
        public override bool isBiggerOrEven(Variable other)
        {
            return (isEqal(other) || isBigger(other));
        }
        public override bool isSmallerOrEven(Variable other)
        {
            return (isEqal(other) || isSmaller(other));
        }
        public override bool isNotEqal(Variable other)
        {
            return !isEqal(other);
        }

        public bool isBigger(T other)
        {
            if (!(this is Real) || !(other is decimal?)) throw new Exception(); //dunno if works
            else
            {
                bool prawda = (((this as Real).GetValue()) > (other as decimal?));
                return prawda;
            }
        }
        public bool isSmaller(T other)
        {
            return isBigger(other);
        }
        public bool isEqal(T other)
        {
            bool prawda = (this.GetValue().Equals(other));
            return prawda;
        }
        public bool isBiggerOrEven(T other)
        {
            return (isEqal(other) || isBigger(other));
        }
        public bool isSmallerOrEven(T other)
        {
            return (isEqal(other) || isSmaller(other));
        }
        public bool isNotEqal(T other)
        {
            return !isEqal(other);
        }


    }
    public abstract class Variable
    {
        public string Name;
        public bool IsNull = true;

        public abstract bool isBigger(Variable other);
        public abstract bool isSmaller(Variable other);
        public abstract bool isBiggerOrEven(Variable other);
        public abstract bool isSmallerOrEven(Variable other);
        public abstract bool isNotEqal(Variable other);
        public abstract bool isEqal(Variable other);
        public abstract void FindValue(Dictionary<string, List<Rule>> RuleLists);
        public abstract void SetValue(Variable variable);

    }
}
