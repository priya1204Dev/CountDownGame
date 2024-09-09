using System.Windows.Forms;

namespace Countdown.Interfaces
{
    public interface IValidateUserInput
    {
        bool IsUserInputValid(string UserInputText, string letterDisplay);
    }
}
