using Booster.CodingTest.Library;
using System.Text;

namespace TGT.Exercise.Service
{
    public class ReadStreamService
    {
        public static async IAsyncEnumerable<string> Read()
        {
            using WordStream stream = new();
            StreamReader reader = new(stream, Encoding.UTF8, true, 1024);

            List<string> words = new();
            StringBuilder wordBuilder = new();

            while (!reader.EndOfStream)
            {
                char[] buf = new char[1024];
                int bytesRead = await reader.ReadBlockAsync(buf);

                for (int i = 0; i < bytesRead; i++)
                {
                    char c = buf[i];

                    if (char.IsWhiteSpace(c))
                    {
                        if (wordBuilder.Length > 0)
                        {
                            words.Add(wordBuilder.ToString());
                            wordBuilder.Clear();
                        }
                    }
                    else
                    {
                        wordBuilder.Append(c);
                    }
                }

                yield return wordBuilder.ToString();
            }

            if (wordBuilder.Length > 0)
            {
                yield return wordBuilder.ToString();
            }
        }
    }
}
