using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Boolean : Variable<bool?>
    {
        public Boolean(string name, bool? value = null) : base(value, name)
        {

        }

        public override string ToString()
        {
            return this.Value.HasValue ? Value.ToString() : "<<unnknown>>";
        }
    }
}
