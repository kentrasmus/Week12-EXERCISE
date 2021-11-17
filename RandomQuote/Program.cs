using System;
using System.IO;

namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("49 Wise Quotes That Will Inspire You to Success in Life");
            Console.WriteLine(GetRandomJokje());

        }
        public static string GetRandomJokje()
        {
            string filePath = @"C:\Users\opilane\samples\quotes.txt";
            string[] jokeAboutChuck = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokeAboutChuck.Length);

            return jokeAboutChuck[randomIndex];
        }
    }
}
