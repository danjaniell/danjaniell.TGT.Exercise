namespace TGT.Exercise.Service
{
    public class WordLengthService
    {
        public List<string> LongestWords { get; set; } = new List<string>();
        public List<string> ShortestWords { get; set; } = new List<string>();

        private void FindTheLongestWords(string input, int size = 5)
        {
            if (string.IsNullOrWhiteSpace(input)) { return; }
            if (LongestWords.Contains(input)) { return; }

            LongestWords.Add(input);
            LongestWords = LongestWords.OrderByDescending(x => x.Length).ToList();
            if (LongestWords.Count > size)
            {
                LongestWords.RemoveAt(5);
            }
        }

        public string GetLongestWords(string input)
        {
            FindTheLongestWords(input.Trim());
            return string.Join(',', LongestWords);
        }

        private void FindTheShortestWords(string input, int size = 5)
        {
            if (string.IsNullOrWhiteSpace(input)) { return; }
            if (ShortestWords.Contains(input)) { return; }

            ShortestWords.Add(input);
            ShortestWords = ShortestWords.OrderBy(x => x.Length).ToList();
            if (ShortestWords.Count > size)
            {
                ShortestWords.RemoveAt(5);
            }
        }

        public string GetShortestWords(string input)
        {
            FindTheShortestWords(input.Trim());
            return string.Join(',', ShortestWords);
        }

    }
}
