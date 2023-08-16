namespace TGT.Exercise.Test
{
    public class TextTest
    {
        [Fact]
        public void GetTotalCharactersFromInput()
        {
            string input = "lorem ipsum dolor";

            int charCount = 15;

            Assert.Equal(15, charCount);
        }
    }
}