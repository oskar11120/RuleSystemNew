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
            this.Value = value;
        }

        public override bool? GetValue()
        {
            return this.Value;
        }
        public override void SetValue(bool? Value)
        {
            this.Value = Value;
        }
        public override string ToString()
        {
            return this.GetValue().ToString();
        }
    }
}
