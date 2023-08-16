using TGT.Exercise.Service.Interface;
using TGT.Exercise.Service.Strategy;

namespace TGT.Exercise.Service
{
    public class WordLengthService
    {
        private List<string> _longestWords = new();
        private List<string> _shortestWords = new();

        private IWordFindingStrategy _longestWordStrategy = new LongestWordFindingStrategy();
        private IWordFindingStrategy _shortestWordStrategy = new ShortestWordFindingStrategy();

        public string GetLongestWords(string input)
        {
            _longestWords = _longestWordStrategy.FindWords(_longestWords, input.Trim());
            return string.Join(',', _longestWords);
        }

        public string GetShortestWords(string input)
        {
            _shortestWords = _shortestWordStrategy.FindWords(_shortestWords, input.Trim());
            return string.Join(',', _shortestWords);
        }
    }
}
