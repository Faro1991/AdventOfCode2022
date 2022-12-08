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
                string[] allowedMessages = {
                    "Challenge not online yet, wait for midnight EST.",
                    "Afraid it's not December yet. Please come back later."
                };
                if (!allowedMessages.Contains(e.Message))
                {
                    throw new Exception(e.Message + " (Forwarded from DailyDownloader.cs, please check it as well.)");
                }
            }
            var Current = new Day7();
            Current.DayRun();
        }
    }
}