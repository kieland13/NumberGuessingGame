namespace RandomNumberGuessingGame
{
   partial class NumberGuess
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtGuess = new System.Windows.Forms.TextBox();
         this.guessButton = new System.Windows.Forms.Button();
         this.playAgainButton = new System.Windows.Forms.Button();
         this.lblLowHigh = new System.Windows.Forms.Label();
         this.textBoxGuesses = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(320, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "I have a number between 1 and 1000--can you guess my number?";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 59);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(142, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Please enter your first guess.";
         // 
         // txtGuess
         // 
         this.txtGuess.Location = new System.Drawing.Point(162, 59);
         this.txtGuess.Name = "txtGuess";
         this.txtGuess.Size = new System.Drawing.Size(170, 20);
         this.txtGuess.TabIndex = 2;
         // 
         // guessButton
         // 
         this.guessButton.Location = new System.Drawing.Point(15, 193);
         this.guessButton.Name = "guessButton";
         this.guessButton.Size = new System.Drawing.Size(75, 23);
         this.guessButton.TabIndex = 3;
         this.guessButton.Text = "Guess";
         this.guessButton.UseVisualStyleBackColor = true;
         this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
         // 
         // playAgainButton
         // 
         this.playAgainButton.Location = new System.Drawing.Point(249, 193);
         this.playAgainButton.Name = "playAgainButton";
         this.playAgainButton.Size = new System.Drawing.Size(75, 23);
         this.playAgainButton.TabIndex = 4;
         this.playAgainButton.Text = "Play Again";
         this.playAgainButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.playAgainButton.UseVisualStyleBackColor = true;
         this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
         // 
         // lblLowHigh
         // 
         this.lblLowHigh.AutoSize = true;
         this.lblLowHigh.Location = new System.Drawing.Point(154, 94);
         this.lblLowHigh.Name = "lblLowHigh";
         this.lblLowHigh.Size = new System.Drawing.Size(0, 13);
         this.lblLowHigh.TabIndex = 5;
         // 
         // textBoxGuesses
         // 
         this.textBoxGuesses.Location = new System.Drawing.Point(15, 151);
         this.textBoxGuesses.Name = "textBoxGuesses";
         this.textBoxGuesses.Size = new System.Drawing.Size(309, 20);
         this.textBoxGuesses.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(23, 135);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(80, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Guesses so far:";
         // 
         // NumberGuess
         // 
         this.AcceptButton = this.guessButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(352, 241);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.textBoxGuesses);
         this.Controls.Add(this.lblLowHigh);
         this.Controls.Add(this.playAgainButton);
         this.Controls.Add(this.guessButton);
         this.Controls.Add(this.txtGuess);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.KeyPreview = true;
         this.Name = "NumberGuess";
         this.Text = "Guess A Number";
         this.Load += new System.EventHandler(this.NumberGuess_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button guessButton;
      private System.Windows.Forms.Button playAgainButton;
      private System.Windows.Forms.Label lblLowHigh;
      private System.Windows.Forms.TextBox textBoxGuesses;
      private System.Windows.Forms.Label label3;
   }
}

