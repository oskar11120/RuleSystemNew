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
            this.Value = value;
        }

        public override int? GetValue()
        {
            return this.Value;
        }
        public override void SetValue(int? Value)
        {
            this.Value = Value;
        }
    }
}
