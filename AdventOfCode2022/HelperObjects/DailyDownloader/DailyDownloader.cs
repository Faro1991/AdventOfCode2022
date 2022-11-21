using System;
using System.Collections.Generic;
using System.Net;

namespace AdventOfCode2022.HelperObjects
{
    static class DailyDownloader
    {
        public static async void Download()
        {

            var Today = DateTime.Today;
            var December1st = new DateTime(2022, 12, 1);
            TimeSpan DifferenceToDecember1st = Today - December1st;
            var FileDirectory = "../Day" + DifferenceToDecember1st;
            var FileName = "InputDay" + DifferenceToDecember1st + ".txt";
            var FilePath = FileDirectory + "/" + FileName;

            if (!System.IO.Directory.Exists(FileDirectory))
            {
                System.IO.Directory.CreateDirectory(FileDirectory);
            }

            if (!System.IO.File.Exists(FilePath))
            {
                var AoCDomain = @".adventofcode.com";
                var URL = @"https://adventofcode.com/2022/day/" + DifferenceToDecember1st + @"/input";
                var AutCVal = System.IO.File.ReadAllText("../AuthCookie.autc");

                try
                {
                    using (HttpClientHandler Handler = new HttpClientHandler() {CookieContainer = new CookieContainer()})
                    using (HttpClient Download = new HttpClient())
                    {
                        Cookie AuthCookie = new Cookie("session", AutCVal) { Domain = AoCDomain};
                        Handler.CookieContainer.Add(AuthCookie);
                        var Result = await Download.GetAsync(URL);
                        Result.EnsureSuccessStatusCode();

                        System.IO.File.WriteAllText(FilePath, Result.Content.ToString());
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