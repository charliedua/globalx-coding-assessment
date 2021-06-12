using System;
using System.Collections.Generic;

namespace globalx_coding_assessment
{
    public class Name : IComparable<Name>
    {
        List<string> FirstNames;

        string LastName;

        public Name(List<string> firstNames, string lastName)
        {
            FirstNames = firstNames;
            LastName = lastName;
        }

        public int CompareTo(Name other)
        {
            return LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            return string.Join(" ", FirstNames) + " " + LastName;
        }

    }
}
