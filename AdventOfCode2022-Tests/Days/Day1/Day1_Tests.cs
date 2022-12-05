using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day1_Tests
    {
        [Fact]
        public static void TestPartOne()
        {
            Day1 One = new Day1();
            One.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day1/TestInput.txt"), false);
            Assert.Equal(24000, One.PartOne());
        }
        [Fact]
        public static void TestPartTwo()
        {
            Day1 One = new Day1();
            One.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day1/TestInput.txt"), false);
            Assert.Equal(45000, One.PartTwo());
        }
    }
}