using System.IO;

namespace Guesser_and_Checker
{
    public static class CSV_IO
    {
        private static void GenerateFile(string path) => File.WriteAllText(path, "Min_Guess,Max_Guess,Number,Attempts,Milli_Taken,Output\n");

        public static void AddRow(string path, long min, long max, long number, long attempts, long ms, bool output)
        {
            if (!File.Exists(path)) GenerateFile(path);
            File.AppendAllText(path, $"{min},{max},{number},{attempts},{ms},{output}\n");
        }
    }
}