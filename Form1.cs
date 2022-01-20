using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace Scrabble_Project_Assessment
{
    public partial class Form1 : Form
    {
        /*  TODO: */
        // fix the letters in word rack so that double letters are not replaced as a whole

        string[] dictionary = System.IO.File.ReadAllLines("english3.txt");
  
        { "A", "A", "A", "A", "A", "A", "A", "A", "A", "B", "B", "C", "C", "D", "D", "D", "D", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "F", "F", "G", "G", "G", "H", "H", "I", "I", "I", "I", "I", "I", "I", "I", "I", "J", "K", "L", "L", "L", "L", "M", "M", "N", "N", "N", "N", "N", "N", "O", "O", "O", "O", "O", "O", "O", "O", "P", "P", "Q", "R", "R", "R", "R", "R", "R", "S", "S", "S", "S", "T", "T", "T", "T", "T", "U", "U", "U", "U", "V", "V", "W", "W", "X", "Y", "Y", "Z" };

        int totalTally = 0;
        private int totalSeconds;
        string lowercaseUI;              // convert userinput to lowercase to match with the dictionary
        string labelAsAWord;            // Make a word from the individual label entries - for use in function checkUserInputInLabels
        private Bitmap[] healthBar = { Scrabble_Project_Assessment.Properties.Resources.full_heart4, Scrabble_Project_Assessment.Properties.Resources.full_heart3, Scrabble_Project_Assessment.Properties.Resources.full_heart2, Scrabble_Project_Assessment.Properties.Resources.full_heart1, Scrabble_Project_Assessment.Properties.Resources.full_heart };
        int lastLife = 5;
        bool inSurvivalMode = false;

        public Form1()
        {
            InitializeComponent();
        }
        int r = 244;
        int g = 65;
        int b = 65;
        void timer_Tick(object sender, EventArgs e)
        {

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = false;
            pnlStart.Visible = false;
            pnlOption.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pnlGame.Visible = false;
            pnlStart.Visible = true;
            pnlOption.Visible = false;
            lbl1.Text = lbl2.Text = lbl3.Text = lbl4.Text = lbl5.Text = lbl6.Text = lbl7.Text = "";
        }

        Boolean checkDictionary(string word)
        {
            Boolean wordExists = false;
            string userInput = txtUserInput.Text.ToLower();
            lowercaseUI = userInput;
            for (int i = 0; i < dictionary.Length; i++)
            {

                if (userInput == dictionary[i])
                {
                    wordExists = true;
                    break;
                }
            }
            return wordExists;
        }

        private int makeScore(string labelLetter)
        {

            int score = 0;
            /* 
             *  1 Point - A, E, I, L, N, O, R, S, T and U.
                2 Points - D and G.
                3 Points - B, C, M and P.
                4 Points - F, H, V, W and Y.
                5 Points - K.
                8 Points - J and X.
                10 Points - Q and Z.
            */

            if ("AEILNORSTU".Contains(labelLetter))
            {
                score = score + 1;
            }
            else if ("DG".Contains(labelLetter))
            {
                score = score + 2;
            }
            else if ("BCMP".Contains(labelLetter))
            {
                score = score + 3;
            }
            else if ("FHVWY".Contains(labelLetter))
            {
                score = score + 4;
            }
            else if ("K".Contains(labelLetter))
            {
                score = score + 5;
            }
            else if ("JX".Contains(labelLetter))
            {
                score = score + 8;
            }
            else if ("QZ".Contains(labelLetter))
            {
                score = score + 10;
            }

            return score;
        }


        // This function will check to see if the user input (guess) matches all the letters from the wordrack
        // We look at the length of the user guessed word, and match with wordrack letters
        // if the numer of letters in guess word is >= letter in wordrack, then its good to go!

        private bool checkUserInputInLabels()
        {
            string guess = lowercaseUI;
            string rack = labelAsAWord.ToLower();
            string wrongGuessLetters = "";    // to store the wrong guessed letters
            int wrongChar = 0;                // keep count of wrong letters guessed ( which were not in rack)

            for (int i = 0; i < guess.Length; i++)
            {
                if (rack.Contains(guess[i].ToString()))      // check each letter in guess. does the rack contain this letter?
                {
                    int found = rack.IndexOf(guess[i]);
                    Console.WriteLine("rack contains guessed letter " + guess[i] + " at position " + found);
                    rack = rack.Remove(found, 1); // if letter is found, remove it from rack
                    Console.WriteLine("                 new rack is " + rack);
                }
                else
                {
                    wrongChar++;
                    wrongGuessLetters = wrongGuessLetters + guess[i];  // add this letter to wrong guesses string
                    Console.WriteLine("Rack does not contain " + guess[i] + "  wrongchar = " + wrongChar);
                }
            }

            if (wrongChar > 0)
            {
                Console.WriteLine("The guessed letters [" + wrongGuessLetters + "] Were not not in the rack [" + rack + "]");
                return false;
            }
            else
            {
                Console.WriteLine(" OK - matched all characters from rack");
                return true;
            }

            //####################

        }


        private void deductPoints(int num, string stype)
        {

            if (stype == "wordMsg")
            {

                if (totalTally >= 5)                     // does user have enough points?
                {
                    MessageBox.Show(lowercaseUI + " is not in the dictionary\n5 points deducted..."); //shows you how many hearts you have left out of 5 in the message box?
                    totalTally = totalTally - num;         // yes, take away NUM points
                    full_heart5.Visible = false;
                    removeOneHeart();
                }
                else
                {
                    MessageBox.Show(lowercaseUI + " is not in the dictionary " + lblTotalTally.Text + " points deducted...");
                    totalTally = 0;
                    removeOneHeart();
                }
            }
            else
            {//shuffleMsg
                if (totalTally >= 10)                     // does user have enough points?
                {
                    MessageBox.Show("10 points deducted for shuffling...");
                    totalTally = totalTally - num;         // yes, take away NUM points
                }
                else
                {
                    MessageBox.Show(lblTotalTally.Text + " points deducted for shuffling...");
                    totalTally = 0;
                }
            }

            lblTotalTally.Text = totalTally.ToString();
            //if (totalTally >= 150)
            {
                //    pnlLabels.Visible = false;
                //    lblGameOver.Visible = false;
                //
                //    lblYouWin.Visible = true;
                //
                //    string message = ("Congratulations! You won the game. You got to " + lbl1.Text + " points with a time of " + lblTime.Text);
                //    string title = "You Won!";
                //    MessageBoxButtons buttons = MessageBoxButtons.OK;
                //    DialogResult result;
                //
                //    result = MessageBox.Show(message, title, buttons);
                //    if (result == DialogResult.OK)
                {
                    //        this.Close();
                    //    }
                }
            }
        }
        // this function will:
        // 1. Check to see if the word exists in the dictionary
        // 2. check the guessed letters against the word rack letters.
        //    any which match are shuffled

        private void checkAndShuffle()
        {
            Boolean wordExists = false;
            Random rlg = new Random();
            int randomLet;

            wordExists = checkDictionary(lowercaseUI);

            int scoreTally = 0;
            if ((wordExists == true) && (checkUserInputInLabels()))
            {
                // Each block is for each label in the word rack
                // This For each letter in the word rack - the following happen:
                // 1. Determine the score based on the scrabble letter in the word rack
                // 2. Generate a new random letter from the word rack
                // 3. Remove the newly used letter from the word rack array
                // 4. Update the label with new letter


                //doesn't let you win

                if (lowercaseUI.Contains(lbl1.Text.ToLower()))
                {
                    scoreTally = scoreTally + makeScore(lbl1.Text);
                    randomLet = rlg.Next(0, alphabet.Count - 1);
                    alphabet.Remove(alphabet[randomLet]);
                    lbl1.Text = alphabet[randomLet];
                }
                if (lowercaseUI.Contains(lbl2.Text.ToLower()))
                {
                    scoreTally = scoreTally + makeScore(lbl2.Text);
                    randomLet = rlg.Next(0, alphabet.Count - 1);
                    alphabet.Remove(alphabet[randomLet]);
                    lbl2.Text = alphabet[randomLet];

                }
                if (lowercaseUI.Contains(lbl3.Text.ToLower()))
                {
                    scoreTally = scoreTally + makeScore(lbl3.Text);
                    randomLet = rlg.Next(0, alphabet.Count - 1);
                    alphabet.Remove(alphabet[randomLet]);
                    lbl3.Text = alphabet[randomLet];
                }
                if (lowercaseUI.Contains(lbl4.Text.ToLower()))
                {
                    scoreTally = scoreTally + makeScore(lbl4.Text);
                    randomLet = rlg.Next(0, alphabet.Count - 1);
                    alphabet.Remove(alphabet[randomLet]);
                    lbl4.Text = alphabet[randomLet];

                }

                if (lowercaseUI.Contains(lbl5.Text.ToLower()))
                {
                    scoreTally = scoreTally + makeScore(lbl5.Text);
                    randomLet = rlg.Next(0, alphabet.Count - 1);
                    alphabet.Remove(alphabet[randomLet]);
                    lbl5.Text = alphabet[randomLet];
                }
                if (lowercaseUI.Contains(lbl6.Text.ToLower()))
                {
                    scoreTally = scoreTally + makeScore(lbl6.Text);
                    randomLet = rlg.Next(0, alphabet.Count - 1);
                    alphabet.Remove(alphabet[randomLet]);
                    lbl6.Text = alphabet[randomLet];
                }
                if (lowercaseUI.Contains(lbl7.Text.ToLower()))
                {
                    scoreTally = scoreTally + makeScore(lbl7.Text);
                    randomLet = rlg.Next(0, alphabet.Count - 1);
                    alphabet.Remove(alphabet[randomLet]);
                    lbl7.Text = alphabet[randomLet];
                }

                lblPointsScore.Text = scoreTally.ToString();
                totalTally = totalTally + int.Parse(lblPointsScore.Text);
                lblTotalTally.Text = totalTally.ToString();

                label1.Text = alphabet.Count.ToString();
                if (alphabet.Count <= 1)
                {
                    pnlLabels.Visible = false;
                    lblGameOver.Visible = false;

                    lblYouWin.Visible = true;

                    string message = ("Congratulations! You won the game. Your final score was " + lbl1.Text + " with a time of " + lblTime.Text);
                    string title = "You Won!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                    else if (inSurvivalMode)
                    {
                        string massage = ("Congratulations! You won the game. Your final score was " + lbl1.Text);

                        result = MessageBox.Show(massage);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }

                // reshuffle the correctly used letters here

                // recreate the label as word with newly shuffled letters
                labelAsAWord = lbl1.Text + lbl2.Text + lbl3.Text + lbl4.Text + lbl5.Text + lbl6.Text + lbl7.Text;
            }
            else
            {
                if (wordExists == false)
                {

                    // decuct points for bad guesses, but dont take away points if it will cause negative points.
                    // check to see if user has enough points, then deduct in steps of 5, 
                    // if user will go below 0, then set to 0

                    deductPoints(5, "wordMsg");

                    lblTotalTally.Text = totalTally.ToString();
                }
                if (!checkUserInputInLabels())
                {
                    MessageBox.Show("You can only use the letters from the word rack!");
                }
            }
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {


            if (txtUserInput.Text == "")
            {
                MessageBox.Show("You have to type something first...");
            }
            else
            {
                checkAndShuffle();
                txtUserInput.Text = String.Empty;
            }
        }
        private void submit_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmit.PerformClick();
        }

        private void lblScrabble_Click(object sender, EventArgs e)
        {

        }

        private void btnBullet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
            }
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 0;

            int minutes = int.Parse(this.comboBox1.SelectedItem.ToString());
            int seconds = int.Parse(this.comboBox2.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;
            this.timer1.Enabled = true;

            pnlGame.Visible = true;
            pnlStart.Visible = false;
            pnlOption.Visible = false;

            // btnShuffle_Click(sender, e);
            generateWordRack();
        }

        private void btnRapid_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
            }
            this.comboBox1.SelectedIndex = 5;
            this.comboBox2.SelectedIndex = 0;

            int minutes = int.Parse(this.comboBox1.SelectedItem.ToString());
            int seconds = int.Parse(this.comboBox2.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;
            this.timer1.Enabled = true;

            pnlGame.Visible = true;
            pnlStart.Visible = false;
            pnlOption.Visible = false;

            //btnShuffle_Click(sender, e);
            generateWordRack();
        }

        private void btnSurvival_Click(object sender, EventArgs e)
        {
            pnlGame.Visible = true;
            pnlStart.Visible = false;
            pnlOption.Visible = false;
            pnlTimer.Visible = false;

            //btnShuffle_Click(sender, e);
            generateWordRack();
            emp_heart5.Visible = false;
            full_heart5.Visible = false;
            emp_heart1.Visible = false;
            full_heart1.Visible = false;

            lastLife = 3;                                    // for survival mode, there are only 3 lives
            inSurvivalMode = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string message = ("                  Time's Up!\nYou got " + lblTotalTally.Text + " points that round!");
            string title = "Score";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                this.lblTime.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timer1.Stop();
                pnlTimer.Visible = false;
                pnlPoints.Visible = false;
                pnlLabels.Visible = false;

                lblGameOver.Visible = true;


                result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }

        }


        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (r <= 65)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }
            if (b <= 65)
            {
                r += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (r >= 244)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (g >= 244)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r >= 244)
            {
                g -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (g <= 65)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (b >= 244)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }
            if (g >= 244)
            {
                b -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (b <= 64)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void generateWordRack()
        {
            Random rlg = new Random();
            int randomLet;
            for (int i = 0; i <= 7; i++)
            {
                randomLet = rlg.Next(0, alphabet.Count);
                lbl1.Text = alphabet[randomLet];
                randomLet = rlg.Next(0, alphabet.Count);
                lbl2.Text = alphabet[randomLet];
                randomLet = rlg.Next(0, alphabet.Count);
                lbl3.Text = alphabet[randomLet];
                randomLet = rlg.Next(0, alphabet.Count);
                lbl4.Text = alphabet[randomLet];
                randomLet = rlg.Next(0, alphabet.Count);
                lbl5.Text = alphabet[randomLet];
                randomLet = rlg.Next(0, alphabet.Count);
                lbl6.Text = alphabet[randomLet];
                randomLet = rlg.Next(0, alphabet.Count);
                lbl7.Text = alphabet[randomLet];

            }
            labelAsAWord = lbl1.Text + lbl2.Text + lbl3.Text + lbl4.Text + lbl5.Text + lbl6.Text + lbl7.Text;
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (totalTally >= 10)
            {
                string message = "Are you sure you want to shuffle, this will deduct 10 points?";
                string title = "Shuffle";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    deductPoints(10, "shuffleMsg");
                    generateWordRack();

                    if (inSurvivalMode)
                        removeSurvivalHeart();
                    else
                        removeOneHeart();
                }
            }
            else
            {
                string message = "Are you sure you want to shuffle, this will deduct " + lblTotalTally.Text + " points?";
                string title = "Shuffle";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    deductPoints(totalTally, "shuffleMsg");
                    generateWordRack();

                    if (inSurvivalMode)
                        removeSurvivalHeart();
                    else
                        removeOneHeart();
                }
            }
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {

        }


        private void removeOneHeart()
        {

            switch (lastLife)
            {
                case 5: full_heart5.Visible = false; break;
                case 4: full_heart4.Visible = false; break;
                case 3: full_heart3.Visible = false; break;
                case 2: full_heart2.Visible = false; break;

                case 1:
                    full_heart1.Visible = false;
                    pnlTimer.Visible = false;
                    pnlPoints.Visible = false;
                    pnlLabels.Visible = false;
                    lblGameOver.Visible = true;
                    string message = ("You lost all 5 lives.");
                    string title = "Game Over";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    //if user doesn't enter a word then say "enter a word"
                    result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                    break;
            }
            lastLife--;
        }


        // if the gamemode is survival then user only has 3 hearts and gets lives lost for everything
        private void removeSurvivalHeart()
        {
            if (inSurvivalMode)
                switch (lastLife)
                {

                    case 3: full_heart4.Visible = false; break;                 // the heart images are offset because i messed about
                    case 2: full_heart3.Visible = false; break;

                    case 1:
                        full_heart2.Visible = false;
                        pnlTimer.Visible = false;
                        pnlPoints.Visible = false;
                        pnlLabels.Visible = false;
                        lblGameOver.Visible = true;
                        string message = ("You lost all 3 lives.");
                        string title = "Game Over";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, title, buttons);

                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                }
            lastLife--;
        }

    }
}

