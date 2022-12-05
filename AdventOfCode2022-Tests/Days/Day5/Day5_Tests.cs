using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day5_Tests
    {
        [Fact]
        public static void TestPartOne()
        {
            Day5 Five = new Day5();
            Five.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day5/TestInput.txt"), false);
            Assert.Equal(2, Five.PartOne());
        }
        [Fact]
        public static void TestPartTwo()
        {
            Day5 Five = new Day5();
            Five.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day5/TestInput.txt"), false);
            Assert.Equal(4, Five.PartTwo());
        }
    }
}