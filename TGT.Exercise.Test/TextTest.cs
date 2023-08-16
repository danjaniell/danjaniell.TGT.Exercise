namespace TGT.Exercise.Test
{
    public class TextTest
    {
        [Fact]
        public void TotalCharacterCountFromInputIsCorrect()
        {
            string input = "lorem ipsum dolor";

            int charCount = CountNonWhitespaceCharacters(input);

            Assert.Equal(15, charCount);
        }

        public int CountNonWhitespaceCharacters(string input)
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

        [Fact]
        public void TotalWordCountFromInputIsCorrect()
        {
            string input = "lorem ipsum dolor";

            int wordCount = CountWords(input);

            Assert.Equal(3, wordCount);
        }

        public int CountWords(string input)
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