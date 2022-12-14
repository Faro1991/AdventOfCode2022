using Xunit;
using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022.Tests
{
    public static class Day4_Tests
    {
        [Fact]
        public static void TestPartOne()
        {
            Day4 Four = new Day4();
            Four.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day4/TestInput.txt"), false);
            Assert.Equal(2, Four.PartOne());
            Four.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day4/TestInputLong.txt"), false);
            Assert.Equal(30, Four.PartOne());
        }
        [Fact]
        public static void TestPartTwo()
        {
            Day4 Four = new Day4();
            Four.input = InputParser.LinesToList(System.IO.File.ReadAllText("Days/Day4/TestInput.txt"), false);
            Assert.Equal(4, Four.PartTwo());
        }
        [Fact]
        public static void RunBothTests()
        {
            TestPartOne();
            TestPartTwo();
        }
    }   
}