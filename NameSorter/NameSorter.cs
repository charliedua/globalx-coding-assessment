using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class NameSorter
    // Main class for sorting names
    {
        public List<Name> Names { get; private set; }

        public NameSorter(List<Name> names)
        {
            Names = names;
        }

        public void sort()
        // Sorts the List by last name
        {
            Names.Sort();
        }

        public void print()
        // Writes the names onto the Console
        {
            foreach (var name in Names)
            {
                Console.WriteLine(name.ToString());
            }
        }
        
        public void writeToFile(string filename)
        // Writes the names to file given filename
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                foreach (var name in Names)
                {
                    sw.WriteLine(name.ToString());
                }
            }
        }

    }
}
