using System;
namespace AdventOfCode2022.HelperObjects
{
    public abstract class DayBase
    {
        public abstract long PartOne();
        public abstract long PartTwo();

        public virtual void DayRun()
        {
            try
            {
                long ResultPartOne = PartOne();
                long ResultPartTwo = PartTwo();
            }
            catch (NotImplementedException NotDoneYet)
            {
                Console.WriteLine($"Not done yet, you still need to implement {NotDoneYet.Source}");
            }
        }
    }
}