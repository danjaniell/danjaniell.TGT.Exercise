namespace TGT.Exercise.Service
{
    public class FrequencyCounterService
    {
        private readonly Dictionary<string, int> _wordFrequency = new();

        private void ProcessNewString(string input)
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
            ProcessNewString(input);
            return string.Join(',', GetMostFrequentWords());
        }
    }
}
