using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

// Add a switch to disregard phrase length
// Add capability to include all ASCII characters

namespace WeaselProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Stopwatch runTime;

            if (string.IsNullOrEmpty(textBoxPhrase.Text))
            {
                _ = MessageBox.Show("The phrase is blank. There is nothing to compute.\r\nPlease enter a phrase and start again.");
                _ = textBoxPhrase.Focus();
                return;
            }

            listBoxResults.Items.Clear();

            runTime = Stopwatch.StartNew();
            textBoxPhrase.Enabled = false;
            buttonStart.Enabled = false;

            string validatePhrase = textBoxPhrase.Text;
            for (int i = 0; i < validatePhrase.Length; i++)
            {
                if (validatePhrase[i] != 32)

                {
                    if ((validatePhrase[i] < 65) || (validatePhrase[i] > 90))
                    {
                        if ((validatePhrase[i] < 97) || (validatePhrase[i] > 122))
                        {
                            _ = MessageBox.Show("The phrase can only contain characters A - Z, a - z, and <space>. Please remove any special characters and try again.");
                            _ = textBoxPhrase.Focus();
                            runTime.Reset();
                            return;
                        }
                    }
                }
            }

            FindPhrase(validatePhrase);
            runTime.Stop();
            labelRunTime.Text = runTime.Elapsed.ToString();
            textBoxPhrase.Enabled = true;
            buttonStart.Enabled = true;
        }

        private void FindPhrase(string weaselPhrase)
        {
            Phrase nextGuess;
            List<Phrase> attemptPhrases = new();

            // Initialize 100 random strings
            attemptPhrases = NewPhrasePopulation(weaselPhrase);

            do
            {
                // Mutate the list of strings
                MutatePhraseList(attemptPhrases);

                // Get the closest match
                nextGuess = FuzzyMatch(attemptPhrases, weaselPhrase);

                // Add the match to the listBox
                listBoxResults.Items.Add(nextGuess.ToString());

                attemptPhrases.Clear();

                // New list of 100 strings
                for (int i = 0; i < 100; i++)
                {
                    attemptPhrases.Add(new Phrase(nextGuess.PhraseString));
                }

            } while (nextGuess.PhraseString != weaselPhrase);

        }

        private List<Phrase> NewPhrasePopulation(string weaselPhrase)
        {
            Random random = new Random();
            List<Phrase> newList = new List<Phrase>();

            for (int count = 0; count < 100; count++)
            {
                char[] newString = new char[weaselPhrase.Length];
                for (int currentLetter = 0; currentLetter < weaselPhrase.Length; currentLetter++)
                {
                    char newChar = GetValidChar();
                    newString[currentLetter] = (char)newChar;
                }

                newList.Add(new Phrase(new String(newString)));
            }

            return newList;
        }

        private Phrase FuzzyMatch(List<Phrase> attemptPhrases, string weaselPhrase)
        {
            Phrase bestMatch;

            foreach (var currentPhrase in attemptPhrases)
            {
                for (int currentLetter = 0; currentLetter < currentPhrase.PhraseString.Length; currentLetter++)
                {
                    if (currentPhrase.PhraseString[currentLetter] == weaselPhrase[currentLetter])
                    {
                        currentPhrase.Score += 1;
                    }
                }
            }

            bestMatch = attemptPhrases[0];

            foreach (var currentPhrase in attemptPhrases)
            {
                if (currentPhrase.Score > bestMatch.Score)
                { bestMatch = currentPhrase; }
            }

            return bestMatch;
        }

        private void MutatePhraseList(List<Phrase> attemptPhrases)
        {
            Random random = new();

            foreach (var currentPhrase in attemptPhrases)
            {
                //Reset the score
                currentPhrase.Score = 0;

                for (int currentLetter = 0; currentLetter < currentPhrase.PhraseString.Length; currentLetter++)
                {
                    if (random.Next(100) < 5)
                    {
                        char newChar = GetValidChar();
                        currentPhrase.CharArray[currentLetter] = newChar;
                    }
                }
            }
        }

        private char GetValidChar()
        {
            bool done;
            int newChar;

            Random random = new();

            do
            {
                newChar = random.Next(64, 122);
                if (newChar == 64)
                {
                    newChar = 32;
                    done = true;
                }

                done = newChar <= 90 || newChar >= 97;

            } while (!done);

            return (char)newChar;
        }
    }

    internal class Phrase
    {
        private char[] charArray;

        public string PhraseString
        {
            get
            {
                return new string(charArray);
            }
        }

        public char[] CharArray
        {
            get { return charArray; }
        }

        public int Score { get; set; } = 0;

        public Phrase(string phrase)
        {
            charArray = phrase.ToCharArray();
        }

        public override string ToString()
        {
            return new string((new string(charArray)) + " | " + Score);
        }
    }
}
