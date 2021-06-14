using System.Collections.Generic;
using Xunit;
using NameSorter;

namespace NameSorterTests
{
    public class NameSorterTests
    {
        NameSorter.NameSorter sorter;
        public NameSorterTests()
        {
            List<string> firstNames = new List<string>() { "a" };
            string lastName = "l";

            Name name1 = new Name(firstNames, lastName);

            firstNames = new List<string>() { "c", "d", "e" };
            lastName = "k";
            
            Name name2 = new Name(firstNames, lastName);

            firstNames = new List<string>() { "a", "c"};
            lastName = "j";

            Name name3 = new Name(firstNames, lastName);

            sorter = new NameSorter.NameSorter(new List<Name>() {name1, name2, name3});
        }

        [Fact]
        public void NameSorterSortTest()
        {
            sorter.sort();

            Assert.Equal("j", sorter.Names[0].LastName);
            Assert.Equal("k", sorter.Names[1].LastName);
            Assert.Equal("l", sorter.Names[2].LastName);
        }

        [Fact]
        public void NameSorterWriteToFileTest()
        {
            sorter.writeToFile("Test.txt");

            List<Name> NameList = new List<Name>();

            Assert.True(System.IO.File.Exists("Test.txt"), "File Doesn't Exist!");

            using (System.IO.StreamReader file = new System.IO.StreamReader("Test.txt"))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    List<string> name_words = new List<string>(line.Split(" "));

                    string lastname = name_words[name_words.Count - 1];

                    List<string> firstNames = name_words.GetRange(0, name_words.Count - 1);

                    Name name = new Name(firstNames, lastname);

                    NameList.Add(name);
                }

                Assert.Equal(3, NameList.Count);

                Assert.Equal("l", sorter.Names[0].LastName);
                Assert.Equal("k", sorter.Names[1].LastName);
                Assert.Equal("j", sorter.Names[2].LastName);
            }
        }
    }
}