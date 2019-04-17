using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Integer : Variable<int?>
    {
        public Integer(string name, int? value = null) : base(value, name)
        {

        }

        public override string ToString()
        {
            return this.Value.HasValue ? Value.ToString() : "<<unnknown>>";
        }
    }
}
