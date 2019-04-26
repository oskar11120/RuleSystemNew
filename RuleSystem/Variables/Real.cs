using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Real : Variable<decimal?>
    {
        public Real(string name, decimal? value = null) : base(name)
        {
            this.Value = value;
        }

        public override decimal? GetValue()
        {
            return this.Value;
        }
        public override void SetValue(decimal? Value)
        {
            this.Value = Value;
        }
    }
}
