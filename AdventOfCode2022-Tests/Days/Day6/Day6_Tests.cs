using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day6_Tests
    {
        [Fact]
        public static void TestPartOne()
        {
            Day6 Six = new Day6();
            Six.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day6/TestInput.txt"), false);
            Assert.Equal(7, Six.PartOne());
        }
        [Fact]
        public static void TestPartTwo()
        {
            Day6 Six = new Day6();
            Six.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day6/TestInput2.txt"), false);
            Assert.Equal(19, Six.PartTwo());
        }
        [Fact]
        public static void RunBothTests()
        {
            TestPartOne();
            TestPartTwo();
        }
    }   
}