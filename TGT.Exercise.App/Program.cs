using TGT.Exercise.Service;

namespace TGT.Exercise.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalCharacters = 0;
            int totalWords = 0;
            IAsyncEnumerable<string> streamData = ReadStreamService.Read();
            WordLengthService wordLengthService = new();
            FrequencyCounterService frequencyCounterService = new();

            foreach (string data in streamData.ToEnumerable())
            {
                Console.WriteLine($"Total Characters(No whitespace): {totalCharacters += WordCountService.CountNonWhitespaceCharacters(data)}");
                Console.WriteLine($"Total Words: {totalWords += WordCountService.CountWords(data)}");
                Console.WriteLine($"Current Longest Words: {wordLengthService.GetLongestWords(data)}");
                Console.WriteLine($"Current Shortest Words: {wordLengthService.GetShortestWords(data)}");
                Console.WriteLine($"Most Frequent Words: {frequencyCounterService.GetMostFrequentWords(data)}");

                Thread.Sleep(300);
                Console.Clear();
            }
        }
    }
}