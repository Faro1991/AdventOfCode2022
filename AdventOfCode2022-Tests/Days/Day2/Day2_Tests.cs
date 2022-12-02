using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day2_Tests
    {
        [Fact]
        public static void TestDayOne()
        {
            Day2 Two = new Day2();
            Two.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day2/TestInput.txt"), false);
            Assert.Equal(15, Two.PartOne());

            Two.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day2/TestInputLong.txt"), false);
            Assert.Equal(51, Two.PartOne());
        }
        [Fact]
        public static void TestDayTwo()
        {
            Day2 Two = new Day2();
            Two.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day2/TestInput.txt"), false);
            Assert.Equal(12, Two.PartTwo());
            Two.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day2/TestInputLong.txt"), false);
            Assert.Equal(40, Two.PartTwo());
        }
    }   
}