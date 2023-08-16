using TGT.Exercise.Service;

namespace TGT.Exercise.Test
{
    public class WordCountTest
    {
        [Theory]
        [InlineData("This is a test", 11)]
        [InlineData("", 0)]
        [InlineData("  ", 0)]
        [InlineData("Word", 4)]
        public void CountNonWhitespaceCharacters_ShouldReturnCorrectCount(string input, int expectedCount)
        {
            int count = WordCountService.CountNonWhitespaceCharacters(input);
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
            int count = WordCountService.CountWords(input);
            Assert.Equal(expectedCount, count);
        }
    }
}