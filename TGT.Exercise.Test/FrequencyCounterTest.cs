using TGT.Exercise.Service;


namespace TGT.Exercise.Test
{
    public class FrequencyCounterTest
    {
        [Fact]
        public void GetMostFrequentWords_ShouldReturnMostFrequentWords()
        {
            var frequencyCounterService = new FrequencyCounterService();

            string result = frequencyCounterService.GetMostFrequentWords("apple apple banana banana cherry");

            Assert.Equal("apple,banana,cherry", result);
        }

        [Fact]
        public void GetMostFrequentWords_ShouldReturnTopNWords()
        {
            var frequencyCounterService = new FrequencyCounterService();

            string result = frequencyCounterService.GetMostFrequentWords("apple banana cherry apple cherry banana apple");

            Assert.Equal("apple,banana,cherry", result);
        }

        [Fact]
        public void GetMostFrequentWords_ShouldHandleEmptyInput()
        {
            var frequencyCounterService = new FrequencyCounterService();

            string result = frequencyCounterService.GetMostFrequentWords("");

            Assert.Equal("", result);
        }

        [Fact]
        public void GetMostFrequentWords_ShouldHandleWhiteSpaceInput()
        {
            var frequencyCounterService = new FrequencyCounterService();

            string result = frequencyCounterService.GetMostFrequentWords("  ");

            Assert.Equal("", result);
        }

        [Fact]
        public void GetMostFrequentWords_ShouldHandleSingleWord()
        {
            var frequencyCounterService = new FrequencyCounterService();

            string result = frequencyCounterService.GetMostFrequentWords("apple");

            Assert.Equal("apple", result);
        }

        [Fact]
        public void GetCharacterFrequencies_ShouldReturnCharacterFrequencies()
        {
            var characterFrequencyAnalyzer = new FrequencyCounterService();

            string result = characterFrequencyAnalyzer.GetCharacterFrequencies("hello world");

            Assert.Equal("[l, 3],[o, 2],[h, 1],[e, 1],[ , 1],[w, 1],[r, 1],[d, 1]", result);
        }
    }
}
