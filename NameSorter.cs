using System;
using System.Collections.Generic;
using System.IO;

namespace globalx_coding_assessment
{
    public class NameSorter
    {
        public List<Name> Names { get; private set; }

        public NameSorter(List<Name> names)
        {
            Names = names;
        }

        public void sort()
        {
            Names.Sort();
        }

        public void print()
        {
            foreach (var name in Names)
            {
                Console.WriteLine(name.ToString());
            }
        }
        
        public void writeToFile(string filename)
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
