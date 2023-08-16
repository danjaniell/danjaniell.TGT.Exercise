using TGT.Exercise.Service;

namespace TGT.Exercise.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            IAsyncEnumerable<string> streamData = ReadStreamService.Read();
            foreach (string data in streamData.ToEnumerable())
            {
                Console.WriteLine($"{i++} - {data}");
            }
        }
    }
}