using System;
using System.Collections.Generic;

namespace globalx_coding_assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.Error.WriteLine("Please Provide Filename");
                Environment.Exit(1);
            }

            string line;
            List<Name> Names = new List<Name>();  

            System.IO.StreamReader file = new System.IO.StreamReader(args[0]);
            while ((line = file.ReadLine()) != null)
            {
                // System.Console.WriteLine(line);
                List<string> name_words = new List<string>(line.Split(" "));
                Name name = new Name(name_words.GetRange(0, name_words.Count-1), name_words[name_words.Count - 1]);
                Names.Add(name);
            }

            file.Close();

            NameSorter sorter = new NameSorter(Names);

            sorter.sort();
            
            sorter.print();

            sorter.writeToFile("sorted-names-list.txt");

        }
    }
}