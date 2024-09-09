using Countdown.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    static class Program
    {
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {  
            IValidateUserInput _validUserInput = new ValidateUserInput();
            IGetLongestWord _getLongestWord = new GetLongestWord() ;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(_validUserInput, _getLongestWord));
        }
    }
}
