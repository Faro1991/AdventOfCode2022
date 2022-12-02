using System.Net;

namespace AdventOfCode2022.HelperObjects
{
    static class DailyDownloader
    {
        public static void Download()
        {

            long CurrentAoCDay = DayCalculator.AoCDay();
            if (CurrentAoCDay < 0)
            {
                throw new Exception("Afraid it's not December yet. Please come back later.");
            }
            var FileDirectory = "Days/Day" + CurrentAoCDay;
            var FileName = "InputDay" + CurrentAoCDay + ".txt";
            var FilePath = FileDirectory + "/" + FileName;

            if (!System.IO.Directory.Exists(FileDirectory))
            {
                System.IO.Directory.CreateDirectory(FileDirectory);
            }

            if (!System.IO.File.Exists(FilePath))
            {
                var AoCDomain = @".adventofcode.com";
                var URL = @"https://adventofcode.com/2022/day/" + CurrentAoCDay + @"/input";
                var AutCVal = System.IO.File.ReadAllText("../AuthCookie.autc");

                try
                {
                    using (HttpClientHandler Handler = new HttpClientHandler() {CookieContainer = new CookieContainer()})
                    using (HttpClient Download = new HttpClient(Handler))
                    {
                        Cookie AuthCookie = new Cookie("session", AutCVal) { Domain = AoCDomain};
                        Handler.CookieContainer.Add(AuthCookie);
                        var Result = Task.Run(() => Download.GetAsync(URL)).Result;
                        Result.EnsureSuccessStatusCode();
                        var Content = Task.Run(() => Result.Content.ReadAsStringAsync());
                        Content.Wait();

                        System.IO.File.WriteAllText(FilePath, Content.Result);
                    }
                }
                catch (HttpRequestException RequestError)
                {
                    Console.WriteLine("File not found on server");
                    Console.WriteLine(RequestError);
                }
                catch (Exception GeneralException)
                {
                    Console.WriteLine("Something went wrong, here's the exception: ");
                    Console.WriteLine(GeneralException);
                }
            }
        }
    }
}