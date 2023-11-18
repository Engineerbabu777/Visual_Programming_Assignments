using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // default pipe speed defined with an integer
        int gravity = 15; // default gravity speed defined with an integer
        int score = 0; // default score integer set to 0
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimeEvents(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            PipBottom.Left -= pipeSpeed; // link the bottom pipes left position to the pipe speed integer, it will reduce the pipe speed value from the left position of the pipe picture box so it will move left with each tick
            PipTop.Left -= pipeSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign
            ScoreText.Text = "Score: " + score.ToString(); // show the current score on the score text label

            // below we are checking if any of the pipes have left the screen
            if (PipBottom.Left < -100)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                PipBottom.Left = 700;
                score++;
            }
            if (PipTop.Left < -100)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                PipTop.Left = 870;
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(PipBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(PipTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }
            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 5) 
            {
                pipeSpeed = 15;
            }

        }

        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            // this is the game key is down event thats linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -15;
            }

        }

        private void gameKeyisUp(object sender, KeyEventArgs e)
        {
            // this is the game key is up event thats linked to the main form
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released then gravity is set back to 15
                gravity = 15;
            }
        }

        private void PipTop_Click(object sender, EventArgs e)
        {

        }
        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            gameTime.Stop(); // stop the main timer
            ScoreText.Text += " Game over!!!"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it
        }
    }
}
