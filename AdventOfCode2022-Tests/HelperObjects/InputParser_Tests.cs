using Xunit;
using System.Collections.Generic;
using System.IO;
namespace AdventOfCode2022.Tests
{
    public class ValidateInputParser
    {
        [Fact]
        public void NoEmptyLines()
        {
            string InputWithEmptyLines = File.ReadAllText(@"HelperObjects/InputParser_Tests_Files/InputWithEmptyLines.txt");
            List<string> ParserResult = AdventOfCode2022.HelperObjects.InputParser.LinesToList(InputWithEmptyLines, true);
            foreach (var line in ParserResult)
            {
                Assert.NotEmpty(line);
            }
        }
        [Fact]
        public void WithEmptyLines()
        {
            string InputWithEmptyLines = File.ReadAllText(@"HelperObjects/InputParser_Tests_Files/InputWithEmptyLines.txt");
            List<string> ParserResult = AdventOfCode2022.HelperObjects.InputParser.LinesToList(InputWithEmptyLines, false);
            foreach (var line in ParserResult)
            {
                Assert.NotNull(line);
            }
        }
    }
}