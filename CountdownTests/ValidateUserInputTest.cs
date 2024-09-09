using Countdown;
using Countdown.Interfaces;

namespace CountdownTests
{
    public class ValidateUserInputTest
    {
        public ValidateUserInput validateUserInput;

        [SetUp]
        public void Setup()
        {
            validateUserInput = new ValidateUserInput();
        }

        [Test]
        public void getLongestWord_Test()
        {
            string userWord = "";
            string displayWord = "book";
            bool actualOutput = validateUserInput.IsUserInputValid(userWord,displayWord);
            Assert.Equals(false, actualOutput);
        }
    }
}