using System.Linq;

namespace TGT.Exercise.Service
{
    public class FrequencyCounterService
    {
        private readonly Dictionary<string, int> _wordFrequency = new();
        private readonly Dictionary<char, int> _characterFrequency = new Dictionary<char, int>();

        private void CountWordFrequency(string input)
        {
            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (!_wordFrequency.ContainsKey(word))
                {
                    _wordFrequency[word] = 0;
                }
                _wordFrequency[word]++;
            }
        }

        private void CountCharacterFrequency(string input)
        {
            foreach (char c in input)
            {
                if (_characterFrequency.ContainsKey(c))
                {
                    _characterFrequency[c]++;
                }
                else
                {
                    _characterFrequency[c] = 1;
                }
            }
        }

        private List<string> GetMostFrequentWords(int count = 10)
        {
            return _wordFrequency
                .OrderByDescending(kv => kv.Value)
                .Take(count)
                .Select(kv => kv.Key)
                .ToList();
        }

        public string GetMostFrequentWords(string input)
        {
            CountWordFrequency(input);
            return string.Join(',', GetMostFrequentWords());
        }

        private List<KeyValuePair<char, int>> GetCharacterFrequencies()
        {
            return _characterFrequency
                .OrderByDescending(kv => kv.Value)
                .ToList();
        }

        public string GetCharacterFrequencies(string input)
        {
            CountCharacterFrequency(input);
            return string.Join(',', GetCharacterFrequencies());
        }
    }
}
