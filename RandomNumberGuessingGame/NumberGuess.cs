using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGuessingGame
{
   public partial class NumberGuess : Form
   {
      int numberGuessed = 0;
      static int numberDifference = 0;
      static int numberGenerated = 0;
      List<int> guessesList = new List<int>();

      public NumberGuess()
      {
         InitializeComponent();
      }
      private void initialize()
      {
         var randomNumber = new Random();
         numberGenerated = randomNumber.Next(1, 1001);
         guessButton.Enabled = true;
         txtGuess.Clear();
         txtGuess.BackColor = Color.White;
         txtGuess.ForeColor = Color.Black;
         lblLowHigh.Text = "";
         guessesList.Clear();
         textBoxGuesses.Text = "";
      }

      private void NumberGuess_Load(object sender, EventArgs e)
      {
         initialize();
      }

      private void guessButton_Click(object sender, EventArgs e)
      {
         

         try {

            numberGuessed = Convert.ToInt32(txtGuess.Text);

            if (numberGuessed < 1 || numberGuessed > 1000)
            {
               MessageBox.Show("Must guess a number between 1 and 1000");
               numberGuessed = Convert.ToInt32(txtGuess.Text);
            }

            if (txtGuess.Text == "")
            {
               MessageBox.Show("Must guess a valid number.");
            }

            if (Math.Abs(numberGenerated - numberGuessed) < numberDifference)
            {
               txtGuess.BackColor = Color.Blue;
            }

            else
            {
               txtGuess.BackColor = Color.Red;
            }

            if (numberGuessed > numberGenerated)
            {
               lblLowHigh.Text = "Guess is Too High.";
               txtGuess.ForeColor = Color.White;
               guessesList.Add(numberGuessed);
               txtGuess.Focus();
            }

            else if (numberGuessed < numberGenerated)
            {
               lblLowHigh.Text = "Guess is Too Low.";
               txtGuess.ForeColor = Color.White;
               guessesList.Add(numberGuessed);
               txtGuess.Focus();
            }

            else
            {
               lblLowHigh.Text = "Correct.";
               txtGuess.BackColor = Color.Green;
               txtGuess.ForeColor = Color.White;
               guessButton.Enabled = false;
            }

            textBoxGuesses.Text = string.Join(", ", guessesList);

            numberDifference = Math.Abs(numberGenerated - numberGuessed);
         }
         catch (Exception ex)
         {
            MessageBox.Show("Entry error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
         }
         }
      private void playAgainButton_Click(object sender, EventArgs e)
      {
         initialize();
      }

     
     
   }
}
