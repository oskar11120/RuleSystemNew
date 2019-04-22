using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Enum : Variable<string>
    {
        public Enum(List<string> possibleValues, string name, int? index = null) : base(name)
        {
            this.PossibleValues = possibleValues;
            this.index = index;
        }

        private readonly List<string> PossibleValues;
        public int? index;

        public override void SetValue(string Value)
        {
            // do zmiany
            for (int i = 0; i < PossibleValues.Count(); i++)
            {
                if (this.Value == Value) this.index = i;
            }
        }
        public override string GetValue()
        {
            return this.index is null ? null : PossibleValues[(int)index];
        }
        public override string ToString()
        {
            return this.GetValue().ToString();
        }
    }
}
