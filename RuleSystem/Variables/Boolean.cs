using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Boolean : Variable<bool?> 
    {
        public Boolean(string name, bool? value = null) : base(name)
        {
            SetValue(value);
        }

        public override bool? GetValue()
        {
            return this.Value;
        }
        public override void SetValue(bool? Value)
        {
            this.Value = Value;
            IsNull = this.Value is null;
        }

        public override void SetValue(Variable variable)
        {
            this.Value = (variable as Boolean).Value;
            if(this.Value is null) this.IsNull = true;
            IsNull = this.Value is null;
        }
    }
}
