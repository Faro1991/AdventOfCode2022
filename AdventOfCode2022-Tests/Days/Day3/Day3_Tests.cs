using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day3_Tests
    {
        [Fact]
        public static void TestDayOne()
        {
            Day3 Three = new Day3();
            Three.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day3/TestInput.txt"), false);
            Assert.Equal(157, Three.PartOne());
        }
        [Fact]
        public static void TestDayTwo()
        {
            Day3 Three = new Day3();
            Three.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day3/TestInput.txt"), false);
            Assert.Equal(70, Three.PartTwo());
        }
    }   
}