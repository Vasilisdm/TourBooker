using Pluralsight.AdvCShColls.TourBooker.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourBooker.Logic
{
    public class CountryCode
    {
        public string Value { get; }

        public CountryCode(string value)
        {
            Value = value;
        }

        public override string ToString() => Value;

        public override bool Equals(object obj)
        {
            if (obj is CountryCode other)
            {
                return StringComparer.OrdinalIgnoreCase.Equals(Value, other.Value);
            }
            else
            {
                return false;
            }
        }
    }
}
