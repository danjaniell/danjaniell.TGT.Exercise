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

            foreach (string data in streamData.ToEnumerable())
            {
                Console.WriteLine($"Total Characters(No whitespace): {totalCharacters += TextService.CountNonWhitespaceCharacters(data)}");
                Console.WriteLine($"Total Words: {totalWords += TextService.CountWords(data)}");

                Thread.Sleep(300);
                Console.Clear();
            }
        }
    }
}