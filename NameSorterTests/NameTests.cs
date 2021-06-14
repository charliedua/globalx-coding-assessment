using System.Collections.Generic;
using Xunit;
using NameSorter;

namespace NameSorterTests
{
    public class NameTests
    {
        [Fact]
        public void LastNameComesBeforeTest()
        {
            List<string> firstNames = new List<string>() { "a", "b" };
            string lastName = "k";

            Name name1 = new Name(firstNames, lastName);

            firstNames = new List<string>() { "c", "d", "e" };
            lastName = "l";
            
            Name name2 = new Name(firstNames, lastName);

            Assert.Equal(-1, name1.CompareTo(name2));
        }

        [Fact]
        public void LastNameIsSameTest()
        {
            List<string> firstNames = new List<string>() { "a", "b" };
            string lastName = "k";

            Name name1 = new Name(firstNames, lastName);

            firstNames = new List<string>() { "c", "d", "e" };
            
            Name name2 = new Name(firstNames, lastName);

            Assert.Equal(0, name1.CompareTo(name2));
        }

        [Fact]
        public void LastNameComesAfterTest()
        {
            List<string> firstNames = new List<string>() { "a", "b" };
            string lastName = "k";

            Name name1 = new Name(firstNames, lastName);

            firstNames = new List<string>() { "c", "d", "e" };
            lastName = "a";
            
            Name name2 = new Name(firstNames, lastName);

            Assert.Equal(1, name1.CompareTo(name2));
        }

        [Fact]
        public void StringRepresentationTest()
        {
            List<string> firstNames = new List<string>() { "a", "b" };
            string lastName = "k";

            Name name1 = new Name(firstNames, lastName);

            Assert.Equal("a b k", name1.ToString());
        }
    }
}
