using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSystem
{
    public class Enum : Variable<string>
    {
        public Enum(List<string> possibleValues, string name, string value) : base(name)
        {
            this.possibleValues = possibleValues;
            SetValue(value);
        }

        private readonly List<string> possibleValues;

        public override void SetValue(string value)
        {
            if (possibleValues.Any(allowed => allowed.Equals(value)))
            {
                this.Value = value;
                IsNull = this.Value is null;
            }
            else throw new NotAllowedValueForEnumException();
        }
        public override void SetValue(Variable variable)
        {
            this.SetValue((variable as Enum).Value);
            IsNull = this.Value is null;
        }
        public override string GetValue()
        {
            return this.Value;
        }
    }
}
