using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Real : Variable<decimal?>
    {
        public Real(string name, decimal? value = null) : base(value, name)
        {

        }

        public override string ToString()
        {
            return this.Value.HasValue ? Value.ToString() : "<<unnknown>>";
        }
    }
}
