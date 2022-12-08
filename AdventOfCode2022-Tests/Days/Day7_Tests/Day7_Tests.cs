using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day7_Tests
    {
        [Fact]
        public static void TestPartOne()
        {
            Day7 Seven = new Day7();
            Seven.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day7/TestInput.txt"), false);
            Assert.Equal(95437, Seven.PartOne());
        }
        [Fact]
        public static void TestPartTwo()
        {
            Day7 Seven = new Day7();
            Seven.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day7/TestInput.txt"), false);
            Assert.Equal(24933642, Seven.PartTwo());
        }
        [Fact]
        public static void RunBothTests()
        {
            TestPartOne();
            TestPartTwo();
        }
    }   
}