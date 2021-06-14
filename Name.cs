using System;
using System.Collections.Generic;

namespace globalx_coding_assessment
{
    public class Name : IComparable<Name>
    // Stores the name
    {
        public List<string> FirstNames { get; private set; }
        // List of first names in order
        // This order must not be changed

        public string LastName { get; private set; }

        public Name(List<string> firstNames, string lastName)
        {
            FirstNames = firstNames;
            LastName = lastName;
        }

        public int CompareTo(Name other)
        // Provides sorting functionality
        {
            return LastName.CompareTo(other.LastName);
            // Using string CompareTo on last name so sort by last name 
        }

        public override string ToString()
        // String representation of a name
        {
            return string.Join(" ", FirstNames) + " " + LastName;
        }

    }
}
