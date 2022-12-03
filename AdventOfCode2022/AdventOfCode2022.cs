using AdventOfCode2022.HelperObjects;

namespace AdventOfCode2022
{
    class AdventOfCode2022
    {
        static void Main()
        {
            try
            {
                DailyDownloader.Download();
            }
            catch (Exception e)
            {
                if (e.Message != "Afraid it's not December yet. Please come back later.")
                {
                    throw new Exception(e.Message + " (Forwarded from DailyDownloader.cs, please check it as well.)");
                }
            }
            //var Current = new Day2();
            //Current.DayRun();
        }
    }
}