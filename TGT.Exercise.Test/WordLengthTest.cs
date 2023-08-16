using TGT.Exercise.Service;

namespace TGT.Exercise.Test
{
    public class WordLengthTest
    {

        [Theory]
        [InlineData("This is a test", "This,test,is,a")]
        [InlineData("", "")]
        [InlineData("  ", "")]
        [InlineData("Word", "Word")]
        [InlineData("   word with spaces  ", "spaces,word,with")]
        public void GetLongestWords_ShouldReturnCorrectResult(string input, string expectedWords)
        {
            string result = string.Empty;
            WordLengthService wordLengthService = new();

            foreach (string word in input.Trim().Split(' '))
            {
                result = wordLengthService.GetLongestWords(word);
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
            WordLengthService wordLengthService = new();

            foreach (string word in input.Trim().Split(' '))
            {
                result = wordLengthService.GetShortestWords(word);
            }
            Assert.Equal(expectedWords, result);
        }
    }
}