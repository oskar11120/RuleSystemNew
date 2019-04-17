using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Enum : Variable<int?>
    {
        public Enum(List<string> possibleValues, string name, int? index = null) : base(index, name)
        {
            this.PossibleValues = possibleValues;
        }

        private readonly List<string> PossibleValues;

        public override string ToString()
        {
            return this.Value.HasValue ? PossibleValues[this.Value.Value] : "<<unnknown>>";
        }
    }
}
