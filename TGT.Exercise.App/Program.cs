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
            TextService textService = new();

            foreach (string data in streamData.ToEnumerable())
            {
                Console.WriteLine($"Total Characters(No whitespace): {totalCharacters += TextService.CountNonWhitespaceCharacters(data)}");
                Console.WriteLine($"Total Words: {totalWords += TextService.CountWords(data)}");
                Console.WriteLine($"Current Longest Words: {textService.GetLongestWords(data)}");
                Console.WriteLine($"Current Shortest Words: {textService.GetShortestWords(data)}");

                Thread.Sleep(300);
                Console.Clear();
            }
        }
    }
}