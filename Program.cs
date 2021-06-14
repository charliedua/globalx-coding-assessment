using System;
using System.Collections.Generic;

namespace globalx_coding_assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // If no arguments provided
            if (args.Length < 1)
            {
                // Throws error and shuts the program down (can also throw exception)
                Console.Error.WriteLine("Please Provide Filename");
                Environment.Exit(1);
            }

            // List of all the names found in the file
            List<Name> Names = new List<Name>();

            using (System.IO.StreamReader file = new System.IO.StreamReader(args[0]))
            // will throw FileNotFoundException if file is not present
            {
                // The current line being read from file
                string line;

                // Read the file line by line
                while ((line = file.ReadLine()) != null)
                {
                    // stores all the names a person has in a List
                    List<string> name_words = new List<string>(line.Split(" "));

                    // Last in the list is the last name
                    string lastname = name_words[name_words.Count - 1];

                    // All others are first name
                    List<string> firstNames = name_words.GetRange(0, name_words.Count - 1);

                    Name name = new Name(firstNames, lastname);
                    Names.Add(name);
                }
            }

            NameSorter sorter = new NameSorter(Names);

            // sort by last name
            sorter.sort();

            // Write to console
            sorter.print();

            // Write to file
            sorter.writeToFile("sorted-names-list.txt");

        }
    }
}