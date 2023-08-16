using TGT.Exercise.Service;

namespace TGT.Exercise.Test
{
    public class TextTest
    {
        [Fact]
        public void TotalCharacterCountFromInputIsCorrect()
        {
            string input = "lorem ipsum dolor";

            int charCount = TextService.CountNonWhitespaceCharacters(input);

            Assert.Equal(15, charCount);
        }

        [Fact]
        public void TotalWordCountFromInputIsCorrect()
        {
            string input = "lorem ipsum dolor";

            int wordCount = TextService.CountWords(input);

            Assert.Equal(3, wordCount);
        }
    }
}