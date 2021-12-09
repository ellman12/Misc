namespace Guesser_and_Checker
{
    internal static class Program
    {
        public static void Main()
        {
            //Configuration
            const long min = 0;
            const long max = 100000;
            const long number = 6977;
            const long runs = 1;
            const bool printGuesses = true;

            for (int i = 0; i < runs; i++)
            {
                if (printGuesses)
                    Guessing.RunGuessWithOutput(min, max, number);
                else
                    Guessing.RunGuessNoOutput(min, max, number);
            }
        }
    }
}