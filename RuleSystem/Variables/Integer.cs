using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Integer : Variable<int?>
    {
        public Integer(string name, int? value = null) : base(name)
        {
            SetValue(value);
        }

        public override int? GetValue()
        {
            return this.Value;
        }
        public override void SetValue(int? Value)
        {
            this.Value = Value;
            IsNull = this.Value is null;
        }
        public override void SetValue(Variable variable)
        {
            this.Value = (variable as Integer).Value;
            IsNull = this.Value is null;
        }
    }
}
