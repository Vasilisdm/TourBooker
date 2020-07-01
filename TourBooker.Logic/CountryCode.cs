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
    }
}
