using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day4_Tests
    {
        [Fact]
        public static void TestDayOne()
        {
            Day4 Four = new Day4();
            Four.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day4/TestInput.txt"), false);
            Assert.Equal(2, Four.PartOne());
            Four.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day4/TestInputLong.txt"), false);
            Assert.Equal(30, Four.PartOne());
        }
        [Fact]
        public static void TestDayTwo()
        {
            Day4 Four = new Day4();
            Four.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day4/TestInput.txt"), false);
            Assert.Equal(4, Four.PartTwo());
        }
    }   
}