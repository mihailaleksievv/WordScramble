using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WordScramble
{
    public partial class IndexForm : Form
    {
        private const string wordsTextFile = @"words.txt";
        private readonly List<string> failedAttempts = new List<string>();
        private readonly List<string> wordList = new List<string>();
        private int attempts = 0;
        private int guessedWords = 0;
        private string currentWord;
        private Random random = new Random();

        public IndexForm()
        {
            InitializeComponent();
            this.Load += IndexForm_Load;
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            GetAllWords();
            GenerateNewWord();
        }

        private void GetAllWords()
        {
            try
            {
                if (File.Exists(wordsTextFile))
                {
                    string[] lines = File.ReadAllLines(wordsTextFile);
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            wordList.Add(line.Trim().ToLower());
                        }
                    }
                }

                if (wordList.Count == 0)
                {
                    wordList.AddRange(new[] { "apple", "banana", "cherry", "dog", "cat", "house" });
                }
            }
            catch
            {
                wordList.AddRange(new[] { "apple", "banana", "cherry", "dog", "cat", "house" });
            }
        }

        private void GenerateNewWord()
        {
            if (wordList.Count == 0) return;

            int randomIndex = random.Next(wordList.Count);
            currentWord = wordList[randomIndex];
            ResetGameInfo();
        }

        private void ResetGameInfo()
        {
            attempts = 0;
            failedAttempts.Clear();
            UpdateLabels();
            labelScrambledWord.Text = ScrambleWord(currentWord);
        }

        private string ScrambleWord(string word)
        {
            if (string.IsNullOrEmpty(word)) return word;

            char[] chars = word.ToCharArray();
            Random rng = new Random();
            int n = chars.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char temp = chars[n];
                chars[n] = chars[k];
                chars[k] = temp;
            }

            return new string(chars);
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentWord))
            {
                GenerateNewWord();
            }

            string input = textBoxInput.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a word to check.");
                return;
            }

            if (currentWord == input)
            {
                guessedWords++;
                labelGuessedWordsValue.Text = guessedWords.ToString();
                wordList.Remove(currentWord);

                if (wordList.Count > 0)
                {
                    GenerateNewWord();
                }
                else
                {
                    MessageBox.Show($"Congratulations! You've guessed all {guessedWords} words!");
                    ResetGame();
                }

                textBoxInput.Clear();
            }
            else
            {
                attempts++;

                if (!failedAttempts.Contains(input))
                {
                    failedAttempts.Add(input);
                }

                if (attempts >= 10)
                {
                    MessageBox.Show("10 unsuccessful attempts! Moving to next word.");
                    GenerateNewWord();
                    textBoxInput.Clear();
                }
            }

            UpdateLabels();
        }

        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            GenerateNewWord();
            textBoxInput.Clear();
        }

        private void UpdateLabels()
        {
            textBoxFailedAttempts.Text = string.Join(", ", failedAttempts);
            labelAttemptsCount.Text = attempts.ToString();
        }

        private void ResetGame()
        {
            attempts = 0;
            guessedWords = 0;
            failedAttempts.Clear();
            labelGuessedWordsValue.Text = "0";
            labelAttemptsCount.Text = "0";
            textBoxFailedAttempts.Text = string.Empty;
            textBoxInput.Clear();

            if (wordList.Count == 0)
            {
                GetAllWords();
            }
            GenerateNewWord();
        }
    }
}