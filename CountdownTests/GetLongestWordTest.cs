using Countdown;
using Countdown.Interfaces;

namespace CountdownTests
{
    public class GetLongestWordTest
    {
        public GetLongestWord getLongestWord;

        [SetUp]
        public void Setup()
        {
            getLongestWord = new GetLongestWord();
        }

        [Test]
        public void getLongestWord_Test()
        {
            string word = "";
            string actualOutput = getLongestWord.getLongestMeaningfullWord(word);
            string expectedOutput = "No Word found";
            Assert.Equals(expectedOutput, actualOutput);
        }
    }
}