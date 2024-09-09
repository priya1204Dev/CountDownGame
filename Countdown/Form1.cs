using Countdown.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Form1 : Form
    {
        private int round = 1;
        private int totalScore = 0;
        private int timer = 30; //in seconds

        private string scoreBoard = "SCORE BOARD" + '\n';
        private TimeSpan _remaining;
        private bool _timerIsRunning;
        private string revealedText = "Want to see the longest possible word ??";
        private Timer _timer;

        private IValidateUserInput _validUserInput;
        private IGetLongestWord _getLongestWord;

        public Form1(IValidateUserInput validUserInput, IGetLongestWord getLongestWord)
        {
            this._validUserInput = validUserInput;
            this._getLongestWord = getLongestWord;

            InitializeComponent();
        
        }

        private void vowelBut_Click(object sender, EventArgs e)
        {
            const string vowels = "AEIOU";
            Random rand = new Random();
            if (letterDisplay.Text.Length < 9)
            {
                letterDisplay.Text += vowels[rand.Next(vowels.Length)];
            }
        }

        private void constanantBut_Click(object sender, EventArgs e)
        {
            const string consonants = "BCDFGHJKLMNPQRSTVWXYZ";
            Random rand = new Random();
            if (letterDisplay.Text.Length < 9)
            {
                letterDisplay.Text += consonants[rand.Next(consonants.Length)];
            }
        }

        private void letresetBut_Click(object sender, EventArgs e)
        {
            letresetBut.Enabled = false;
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            TimerButton.Enabled = false;
        }

        private void AssignTimer()
        {
            _remaining = TimeSpan.FromSeconds((double)0 + (double)0 + (double)timer);
            _timer = new Timer(this, TimerTick, 100);
        }

        private void TimerStop()
        {
            if (_timerIsRunning)
            {
                _timer.Stop();
            }
        }

        private void GameOver()
        {
            scoreBoard = scoreBoard + '\n' + "\n Total Score" + " - " + totalScore;
            ScoreBoardButton.Text = scoreBoard;
            GetLongestWord();
            MessageBox.Show($"GameOver!! \n Your Total Score is : {totalScore}", "Countdown Timer", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void NewRound(bool _isRevealed)
        {
            if (_isRevealed)
            {
                GetLongestWord();
                MessageBox.Show($"ROUND : {round + 1}", "NEW ROUND", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            LongestWord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LongestWord.Text = revealedText;
            letterDisplay.Clear();
            UserInputTextBox.Clear();
            EnterWord.BackColor = Color.Gray;
            letresetBut.Text = "ROUND - " + ++round;
            TimerButton.Text = "TIMER";
            LongestWord_Style();
        }

        private void MaintainScoreBoard(int score)
        {
            scoreBoard = scoreBoard + '\n' + "Round - " + round + "   =>   " + "Score  - " + score;
            ScoreBoardButton.Text = scoreBoard;
            totalScore = totalScore + score;
        }

        private void NextRound()
        {
            if (round + 1 == 5)
                GameOver();
            NewRound(true);
        }

        private void TimerTick()
        {
            if (_remaining.TotalMilliseconds > 0)
            {
                _remaining = _remaining.Subtract(TimeSpan.FromSeconds(0.1));
                TimerButton.Text = $"TIMER : {_remaining.Seconds:D2}.{_remaining.Milliseconds / 100}";
            }
            else
            {
                TimerStop();
                MaintainScoreBoard(0);
                MessageBox.Show($"Round : {round}  ,  Score : 0  \n Oops !! The time is up ", "Countdown Timer", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                NextRound();
            }
        }

        private void letterDisplay_TextChanged(object sender, EventArgs e)
        {
            if (letterDisplay.Text.Length == 9)
            {
                EnterWord.Enabled = true;
                EnterWord.BackColor = Color.LawnGreen;

                UserInputTextBox.Clear();
                AssignTimer();
                _timer.Start();
                _timerIsRunning = true;
            }
            else
            {
                EnterWord.Enabled = false;
            }
        }

        private void UserInputTextBox_TextChanged(object sender, EventArgs e)
        {
            UserInputTextBox.MaxLength = 9;
        }

        private void EnterWord_Click(object sender, EventArgs e)
        {
            TimerStop();
            bool isUserInputValid = _validUserInput.IsUserInputValid(UserInputTextBox.Text, letterDisplay.Text);

            if (isUserInputValid)
            {
                MessageBox.Show($" Round : {round} ,  Score : {UserInputTextBox.Text.Length} \n Hurray !! A valid word ", "Valid  word", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                MaintainScoreBoard(UserInputTextBox.Text.Length);
                NextRound();
            }
            else

            {
                MessageBox.Show($" Round : {round} ,  Score : 0  \n Alas !! Please Form a meaningfull word using available letters in order to score ", "Invalid  word", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                MaintainScoreBoard(0);
                NextRound();
            }
            TimerButton.Text = "TIMER";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            round = 0;
            totalScore = 0;
            scoreBoard = "SCORE BOARD" + '\n';
            TimerStop();
            TimerButton.Text = "TIMER";
            LongestWord_Style();
            ScoreBoardButton.Text = scoreBoard;
            EnterWord.BackColor = Color.Gray;
            NewRound(false);
        }

        private void LongestWord_Style()
        {
            LongestWord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LongestWord.Text = revealedText;
        }

        private void LongestWord_Click(object sender, EventArgs e)
        {
        }

        private void GetLongestWord()
        {
            TimerStop();
            LongestWord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            string longestWord = _getLongestWord.getLongestMeaningfullWord(letterDisplay.Text);
            LongestWord.Text = longestWord + "\n Length : " + longestWord.Length;
        }

        private void RuleList_Click(object sender, EventArgs e)
        {
        }
    }
}