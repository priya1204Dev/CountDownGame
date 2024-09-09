using Countdown.Interfaces;
using NHunspell;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Countdown
{
    public class ValidateUserInput : IValidateUserInput
    {
        public bool IsUserInputValid(string UserInputText, string letterDisplay)
        {
            List<WordInput> inputCharList = new List<WordInput>();
            List<WordInput> availCharList = new List<WordInput>();

            for (int i = 0; i < UserInputText.Length; i++)
            {
                inputCharList.Add(new WordInput() { alpha = UserInputText.ToUpper()[i], matched = 0 });

            }
            for (int i = 0; i < letterDisplay.Length; i++)
            {
                availCharList.Add(new WordInput() { alpha = letterDisplay[i], matched = 0 });

            }

            AllInpCharsPresentInAvlblChars(inputCharList, availCharList);
         
            return (inputCharList.Where(x => x.matched == 0).Count() == 0 && UserInputText.Length != 0 && isMeaningfullWord(UserInputText)) ? true : false;
        
        }

        public void AllInpCharsPresentInAvlblChars(List<WordInput> inputCharList, List<WordInput> availCharList)
        {

            foreach (var inpChar in inputCharList.ToList())
            {
                foreach (var avlChar in availCharList.ToList())
                {
                    if (inpChar.alpha.Equals(avlChar.alpha) && avlChar.matched == 0)
                    {
                        inpChar.matched = 1;
                        avlChar.matched = 1;
                        break;
                    }
                }
            }

        }
        public bool isMeaningfullWord(string userInput)
        {
            if(userInput.Length>0)
            {
                using (Hunspell hunspell = new Hunspell("en_US.aff", "en_US.dic"))
                {
                    return hunspell.Spell(userInput);

                }

            }
            return false;

        }

    }
}

