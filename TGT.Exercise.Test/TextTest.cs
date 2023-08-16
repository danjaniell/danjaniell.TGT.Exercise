using TGT.Exercise.Service;

namespace TGT.Exercise.Test
{
    public class TextTest
    {
        public class TextServiceTests
        {
            [Theory]
            [InlineData("This is a test", 11)]
            [InlineData("", 0)]
            [InlineData("  ", 0)]
            [InlineData("Word", 4)]
            public void CountNonWhitespaceCharacters_ShouldReturnCorrectCount(string input, int expectedCount)
            {
                int count = TextService.CountNonWhitespaceCharacters(input);
                Assert.Equal(expectedCount, count);
            }

            [Theory]
            [InlineData("This is a test", 4)]
            [InlineData("", 0)]
            [InlineData("  ", 0)]
            [InlineData("Word", 1)]
            [InlineData("   word with spaces  ", 3)]
            public void CountWords_ShouldReturnCorrectCount(string input, int expectedCount)
            {
                int count = TextService.CountWords(input);
                Assert.Equal(expectedCount, count);
            }

            [Theory]
            [InlineData("This is a test", "This,test,is,a")]
            [InlineData("", "")]
            [InlineData("  ", "")]
            [InlineData("Word", "Word")]
            [InlineData("   word with spaces  ", "spaces,word,with")]
            public void GetLongestWords_ShouldReturnCorrectResult(string input, string expectedWords)
            {
                string result = string.Empty;
                TextService textService = new();

                foreach (string word in input.Trim().Split(' '))
                {
                    result = textService.GetLongestWords(word);
                }
                Assert.Equal(expectedWords, result);
            }

            [Theory]
            [InlineData("This is a test", "a,is,This,test")]
            [InlineData("", "")]
            [InlineData("  ", "")]
            [InlineData("Word", "Word")]
            [InlineData("   word with spaces  ", "word,with,spaces")]
            public void GetShortestWords_ShouldReturnCorrectResult(string input, string expectedWords)
            {
                string result = string.Empty;
                TextService textService = new();

                foreach (string word in input.Trim().Split(' '))
                {
                    result = textService.GetShortestWords(word);
                }
                Assert.Equal(expectedWords, result);
            }
        }
    }
}