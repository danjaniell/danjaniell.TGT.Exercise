using TGT.Exercise.Service.Interface;

namespace TGT.Exercise.Service.Strategy
{
    public class LongestWordFindingStrategy : IWordFindingStrategy
    {
        public List<string> FindWords(List<string> words, string input)
        {
            if (string.IsNullOrWhiteSpace(input)) { return words; }
            if (words.Contains(input)) { return words; }

            words.Add(input);
            words = words.OrderByDescending(x => x.Length).ToList();

            if (words.Count > 5)
            {
                words.RemoveRange(5, words.Count - 5);
            }

            return words;
        }
    }
}