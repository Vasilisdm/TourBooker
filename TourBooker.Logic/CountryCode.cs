﻿using Pluralsight.AdvCShColls.TourBooker.Logic;
using System;
using System.Collections.Generic;
using System.Data;
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

        public override int GetHashCode() => StringComparer.OrdinalIgnoreCase.GetHashCode(Value);

        public static bool operator ==(CountryCode lhs, CountryCode rhs)
        {
            if (lhs != null)
            {
                return lhs.Equals(rhs);
            }
            else
            {
                return rhs == null;
            }
        }

        public static bool operator !=(CountryCode lhs, CountryCode rhs)
        {
            return !(lhs == rhs);
        }
    }
}
