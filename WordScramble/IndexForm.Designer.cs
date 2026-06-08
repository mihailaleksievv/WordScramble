namespace WordScramble
{
    partial class IndexForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitle;
        private Label labelAttempts;
        private Label labelAttemptsCount;
        private Label labelGuessedWords;
        private Label labelGuessedWordsValue;
        private Label labelScrambledWord;
        private Label labelFailedAttemptsTitle;
        private TextBox textBoxInput;
        private TextBox textBoxFailedAttempts;
        private Button buttonCheck;
        private Button buttonSkip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new Label();
            this.labelAttempts = new Label();
            this.labelAttemptsCount = new Label();
            this.labelGuessedWords = new Label();
            this.labelGuessedWordsValue = new Label();
            this.labelScrambledWord = new Label();
            this.labelFailedAttemptsTitle = new Label();
            this.textBoxInput = new TextBox();
            this.textBoxFailedAttempts = new TextBox();
            this.buttonCheck = new Button();
            this.buttonSkip = new Button();
            this.SuspendLayout();

            this.labelTitle.Text = "Word Scramble";
            this.labelTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(150, 20);
            this.labelTitle.Size = new System.Drawing.Size(300, 50);
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Anchor = AnchorStyles.Top;

            this.labelAttempts.Text = "Attempts:";
            this.labelAttempts.Font = new Font("Segoe UI", 12);
            this.labelAttempts.Location = new System.Drawing.Point(50, 100);
            this.labelAttempts.Size = new System.Drawing.Size(80, 30);

            this.labelAttemptsCount.Text = "0";
            this.labelAttemptsCount.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.labelAttemptsCount.Location = new System.Drawing.Point(130, 100);
            this.labelAttemptsCount.Size = new System.Drawing.Size(50, 30);

            this.labelGuessedWords.Text = "Guessed words:";
            this.labelGuessedWords.Font = new Font("Segoe UI", 12);
            this.labelGuessedWords.Location = new System.Drawing.Point(250, 100);
            this.labelGuessedWords.Size = new System.Drawing.Size(130, 30);

            this.labelGuessedWordsValue.Text = "0";
            this.labelGuessedWordsValue.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.labelGuessedWordsValue.Location = new System.Drawing.Point(380, 100);
            this.labelGuessedWordsValue.Size = new System.Drawing.Size(50, 30);

            this.labelScrambledWord.Text = "?????";
            this.labelScrambledWord.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            this.labelScrambledWord.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelScrambledWord.Location = new System.Drawing.Point(150, 180);
            this.labelScrambledWord.Size = new System.Drawing.Size(300, 60);
            this.labelScrambledWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.textBoxInput.Location = new System.Drawing.Point(120, 270);
            this.textBoxInput.Size = new System.Drawing.Size(200, 27);
            this.textBoxInput.Font = new Font("Segoe UI", 12);

            this.buttonCheck.Text = "Check";
            this.buttonCheck.Font = new Font("Segoe UI", 12);
            this.buttonCheck.Location = new System.Drawing.Point(340, 265);
            this.buttonCheck.Size = new System.Drawing.Size(100, 40);
            this.buttonCheck.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new EventHandler(this.ButtonCheck_Click);

            this.buttonSkip.Text = "Skip";
            this.buttonSkip.Font = new Font("Segoe UI", 12);
            this.buttonSkip.Location = new System.Drawing.Point(340, 315);
            this.buttonSkip.Size = new System.Drawing.Size(100, 40);
            this.buttonSkip.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new EventHandler(this.ButtonSkip_Click);

            this.labelFailedAttemptsTitle.Text = "Failed attempts:";
            this.labelFailedAttemptsTitle.Font = new Font("Segoe UI", 12);
            this.labelFailedAttemptsTitle.Location = new System.Drawing.Point(50, 380);
            this.labelFailedAttemptsTitle.Size = new System.Drawing.Size(130, 30);

            this.textBoxFailedAttempts.Location = new System.Drawing.Point(190, 380);
            this.textBoxFailedAttempts.Size = new System.Drawing.Size(350, 27);
            this.textBoxFailedAttempts.Font = new Font("Segoe UI", 12);
            this.textBoxFailedAttempts.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAttempts);
            this.Controls.Add(this.labelAttemptsCount);
            this.Controls.Add(this.labelGuessedWords);
            this.Controls.Add(this.labelGuessedWordsValue);
            this.Controls.Add(this.labelScrambledWord);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.labelFailedAttemptsTitle);
            this.Controls.Add(this.textBoxFailedAttempts);
            this.Text = "Word Scramble";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}