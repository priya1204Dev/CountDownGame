namespace Countdown
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabGames = new System.Windows.Forms.TabControl();
            this.tabLetters = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.vowelBut = new System.Windows.Forms.Button();
            this.constanantBut = new System.Windows.Forms.Button();
            this.letresetBut = new System.Windows.Forms.Button();
            this.letterDisplay = new System.Windows.Forms.TextBox();
            this.TimerButton = new System.Windows.Forms.Button();
            this.EnterWord = new System.Windows.Forms.Button();
            this.UserInputlabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ScoreBoardButton = new System.Windows.Forms.Button();
            this.LongestWord = new System.Windows.Forms.Button();
            this.RuleList = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabGames.SuspendLayout();
            this.tabLetters.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabGames, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.9537F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1922, 1050);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabGames
            // 
            this.tabGames.Controls.Add(this.tabLetters);
            this.tabGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGames.Location = new System.Drawing.Point(4, 5);
            this.tabGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGames.Name = "tabGames";
            this.tabGames.SelectedIndex = 0;
            this.tabGames.Size = new System.Drawing.Size(1914, 1040);
            this.tabGames.TabIndex = 0;
            // 
            // tabLetters
            // 
            this.tabLetters.Controls.Add(this.tableLayoutPanel2);
            this.tabLetters.Location = new System.Drawing.Point(4, 29);
            this.tabLetters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabLetters.Name = "tabLetters";
            this.tabLetters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabLetters.Size = new System.Drawing.Size(1906, 1007);
            this.tabLetters.TabIndex = 1;
            this.tabLetters.Text = "Letters";
            this.tabLetters.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.UserInputTextBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.vowelBut, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.constanantBut, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.letresetBut, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.letterDisplay, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TimerButton, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.EnterWord, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.UserInputlabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ResetButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ScoreBoardButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.LongestWord, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.RuleList, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.93225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.14015F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.682975F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.61714F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.94396F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1898, 997);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // UserInputTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.UserInputTextBox, 2);
            this.UserInputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputTextBox.Location = new System.Drawing.Point(4, 454);
            this.UserInputTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(940, 143);
            this.UserInputTextBox.TabIndex = 5;
            this.UserInputTextBox.TextChanged += new System.EventHandler(this.UserInputTextBox_TextChanged);
            // 
            // vowelBut
            // 
            this.vowelBut.BackColor = System.Drawing.Color.Teal;
            this.vowelBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vowelBut.Font = new System.Drawing.Font("Algerian", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vowelBut.ForeColor = System.Drawing.Color.AliceBlue;
            this.vowelBut.Location = new System.Drawing.Point(4, 5);
            this.vowelBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vowelBut.Name = "vowelBut";
            this.vowelBut.Size = new System.Drawing.Size(466, 238);
            this.vowelBut.TabIndex = 0;
            this.vowelBut.Text = "Vowel";
            this.vowelBut.UseVisualStyleBackColor = false;
            this.vowelBut.Click += new System.EventHandler(this.vowelBut_Click);
            // 
            // constanantBut
            // 
            this.constanantBut.BackColor = System.Drawing.Color.Teal;
            this.constanantBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constanantBut.Font = new System.Drawing.Font("Algerian", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constanantBut.ForeColor = System.Drawing.Color.AliceBlue;
            this.constanantBut.Location = new System.Drawing.Point(478, 5);
            this.constanantBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.constanantBut.Name = "constanantBut";
            this.constanantBut.Size = new System.Drawing.Size(466, 238);
            this.constanantBut.TabIndex = 1;
            this.constanantBut.Text = "Consonant";
            this.constanantBut.UseVisualStyleBackColor = false;
            this.constanantBut.Click += new System.EventHandler(this.constanantBut_Click);
            // 
            // letresetBut
            // 
            this.letresetBut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.letresetBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letresetBut.Enabled = false;
            this.letresetBut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.letresetBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.letresetBut.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letresetBut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.letresetBut.Location = new System.Drawing.Point(1426, 5);
            this.letresetBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letresetBut.Name = "letresetBut";
            this.letresetBut.Size = new System.Drawing.Size(468, 238);
            this.letresetBut.TabIndex = 11;
            this.letresetBut.Text = "ROUND - 1";
            this.letresetBut.UseVisualStyleBackColor = false;
            this.letresetBut.Click += new System.EventHandler(this.letresetBut_Click);
            // 
            // letterDisplay
            // 
            this.letterDisplay.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanel2.SetColumnSpan(this.letterDisplay, 4);
            this.letterDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letterDisplay.Font = new System.Drawing.Font("Book Antiqua", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterDisplay.Location = new System.Drawing.Point(4, 253);
            this.letterDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterDisplay.Name = "letterDisplay";
            this.letterDisplay.Size = new System.Drawing.Size(1890, 152);
            this.letterDisplay.TabIndex = 3;
            this.letterDisplay.TextChanged += new System.EventHandler(this.letterDisplay_TextChanged);
            // 
            // TimerButton
            // 
            this.TimerButton.BackColor = System.Drawing.Color.Black;
            this.TimerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimerButton.Font = new System.Drawing.Font("Algerian", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerButton.ForeColor = System.Drawing.Color.White;
            this.TimerButton.Location = new System.Drawing.Point(1426, 454);
            this.TimerButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(468, 151);
            this.TimerButton.TabIndex = 4;
            this.TimerButton.Text = "TIMER";
            this.TimerButton.UseVisualStyleBackColor = false;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // EnterWord
            // 
            this.EnterWord.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.EnterWord.BackColor = System.Drawing.Color.Gray;
            this.EnterWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnterWord.Enabled = false;
            this.EnterWord.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterWord.ForeColor = System.Drawing.Color.Black;
            this.EnterWord.Location = new System.Drawing.Point(952, 454);
            this.EnterWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.EnterWord.Name = "EnterWord";
            this.EnterWord.Size = new System.Drawing.Size(466, 151);
            this.EnterWord.TabIndex = 6;
            this.EnterWord.Text = "ENTER";
            this.EnterWord.UseVisualStyleBackColor = false;
            this.EnterWord.Click += new System.EventHandler(this.EnterWord_Click);
            // 
            // UserInputlabel
            // 
            this.UserInputlabel.AutoSize = true;
            this.UserInputlabel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputlabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UserInputlabel.Location = new System.Drawing.Point(4, 418);
            this.UserInputlabel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.UserInputlabel.Name = "UserInputlabel";
            this.UserInputlabel.Size = new System.Drawing.Size(398, 29);
            this.UserInputlabel.TabIndex = 10;
            this.UserInputlabel.Text = "Enter a word using above alphabets: ";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Crimson;
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetButton.Font = new System.Drawing.Font("Algerian", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResetButton.Location = new System.Drawing.Point(952, 5);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(466, 238);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ScoreBoardButton
            // 
            this.ScoreBoardButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.ScoreBoardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreBoardButton.FlatAppearance.BorderSize = 2;
            this.ScoreBoardButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBoardButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ScoreBoardButton.Location = new System.Drawing.Point(478, 634);
            this.ScoreBoardButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoreBoardButton.Name = "ScoreBoardButton";
            this.tableLayoutPanel2.SetRowSpan(this.ScoreBoardButton, 2);
            this.ScoreBoardButton.Size = new System.Drawing.Size(466, 358);
            this.ScoreBoardButton.TabIndex = 12;
            this.ScoreBoardButton.Text = "Score Board";
            this.ScoreBoardButton.UseVisualStyleBackColor = false;
            // 
            // LongestWord
            // 
            this.LongestWord.BackColor = System.Drawing.Color.LightCyan;
            this.LongestWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LongestWord.FlatAppearance.BorderSize = 2;
            this.LongestWord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongestWord.ForeColor = System.Drawing.Color.Green;
            this.LongestWord.Location = new System.Drawing.Point(4, 634);
            this.LongestWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LongestWord.Name = "LongestWord";
            this.tableLayoutPanel2.SetRowSpan(this.LongestWord, 2);
            this.LongestWord.Size = new System.Drawing.Size(466, 358);
            this.LongestWord.TabIndex = 9;
            this.LongestWord.Text = "Want to see the longest possible word ??";
            this.LongestWord.UseVisualStyleBackColor = false;
            this.LongestWord.Click += new System.EventHandler(this.LongestWord_Click);
            // 
            // RuleList
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.RuleList, 2);
            this.RuleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuleList.Enabled = false;
            this.RuleList.FlatAppearance.BorderSize = 2;
            this.RuleList.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleList.Location = new System.Drawing.Point(952, 634);
            this.RuleList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RuleList.Name = "RuleList";
            this.tableLayoutPanel2.SetRowSpan(this.RuleList, 2);
            this.RuleList.Size = new System.Drawing.Size(942, 358);
            this.RuleList.TabIndex = 13;
            this.RuleList.Text = resources.GetString("RuleList.Text");
            this.RuleList.UseVisualStyleBackColor = true;
            this.RuleList.Click += new System.EventHandler(this.RuleList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1050);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabGames.ResumeLayout(false);
            this.tabLetters.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabGames;
        private System.Windows.Forms.TabPage tabLetters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button vowelBut;
        private System.Windows.Forms.Button constanantBut;
        private System.Windows.Forms.Button letresetBut;
        private System.Windows.Forms.TextBox letterDisplay;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.TextBox UserInputTextBox;
        private System.Windows.Forms.Button EnterWord;
        private System.Windows.Forms.Button LongestWord;
        private System.Windows.Forms.Label UserInputlabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ScoreBoardButton;
        private System.Windows.Forms.Button RuleList;
    }
}

