using System;
using System.Diagnostics;

namespace Guesser_and_Checker
{
    public static class Guessing
    {
        /// <summary>
        /// Output stats and stuff. Also append to csv file.
        /// </summary>
        private static void Output(long min, long max, long number, long ms, long attempts, bool output)
        {
            decimal s = ms / (decimal) 1000;
            decimal m = ms / (decimal) 60000;
            decimal h = ms / (decimal) 3600000;

            Console.WriteLine($"The number {number} was guessed after {attempts} attempts");
            Console.WriteLine($"It took...\n{ms} milliseconds");
            Console.WriteLine($"{s} seconds");
            Console.WriteLine($"{m} minutes");
            Console.WriteLine($"{h} hours\n");

            CSV_IO.AddRow(@"C:\Users\Elliott\Documents\GitHub\Guesser-and-Checker\data.csv", min, max, number, attempts, ms, output);
        }
        
        /// <summary>
        /// Run a guess with Console output of guesses (slower)
        /// </summary>
        public static void RunGuessWithOutput(long min, long max, long number)
        {
            long guess, attempts = 0;
            Random rand = new();
            Stopwatch t = new();
            t.Start();
            do
            {
                guess = rand.NextInt64(min, max);
                Console.WriteLine(guess);
                attempts++;
            } while (guess != number);

            t.Stop();

            long ms = t.ElapsedMilliseconds;
            Output(min, max, number, ms, attempts, true);
        }

        /// <summary>
        /// Same as the other but no output for each guess (much faster)
        /// </summary>
        public static void RunGuessNoOutput(long min, long max, long number)
        {
            long guess, attempts = 0;
            Random rand = new();
            Stopwatch t = new();
            t.Start();
            do
            {
                guess = rand.NextInt64(min, max);
                attempts++;
            } while (guess != number);

            t.Stop();

            long ms = t.ElapsedMilliseconds;
            Output(min, max, number, ms, attempts, false);
        }
    }
}