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

            runTime = Stopwatch.StartNew();
            textBoxPhrase.Enabled = false;
            buttonStart.Enabled = false;

            string validatePhrase = textBoxPhrase.Text.ToUpper();
            for (int i = 0; i < validatePhrase.Length; i++)
            {
                if (validatePhrase[i] != 32 && ((validatePhrase[i] < 65) || (validatePhrase[i] > 90)))
                {
                    _ = MessageBox.Show("The phrase can only contain characters A - Z. Please remove any special characters and try again.");
                    _ = textBoxPhrase.Focus();
                    runTime.Reset();
                    return;
                }
            }

            listBoxResults.Items.Clear();
            FindPhrase(validatePhrase);
            runTime.Stop();
            labelRunTime.Text = runTime.Elapsed.ToString();
        }

        private void FindPhrase(string weaselPhrase)
        {
            string nextGuess;
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
                listBoxResults.Items.Add(nextGuess);

                attemptPhrases.Clear();

                // New list of 100 strings
                for (int i = 0; i < 100; i++)
                {
                    attemptPhrases.Add(new Phrase(nextGuess));
                }

            } while (nextGuess != weaselPhrase);

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
                    int newChar = random.Next(64, 91);
                    if (newChar == 64) { newChar = 32; }
                    newString[currentLetter] = (char)newChar;
                }

                newList.Add(new Phrase(new String(newString)));
            }

            return newList;
        }

        private string FuzzyMatch(List<Phrase> attemptPhrases, string weaselPhrase)
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

            return bestMatch.PhraseString;
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
                        int newChar = random.Next(64, 91);
                        if (newChar == 64) { newChar = 32; }
                        currentPhrase.CharArray[currentLetter] = (char)newChar;
                    }
                }
            }
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
    }
}
