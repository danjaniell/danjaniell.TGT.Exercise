namespace TGT.Exercise.Service
{
    public class TextService
    {
        private static string _longestWord = string.Empty;

        public static string FindTheLongestWord(string input)
        {
            var words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string newLongestWord = words
                .OrderByDescending(word => word.Length)
                .FirstOrDefault();

            if (!string.IsNullOrEmpty(newLongestWord) && newLongestWord.Length > _longestWord.Length)
            {
                _longestWord = newLongestWord;
            }

            return _longestWord;
        }

        public static int CountNonWhitespaceCharacters(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountWords(string input)
        {
            int count = 0;
            bool inWord = false;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (!char.IsWhiteSpace(c))
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            return count;
        }
    }
}
