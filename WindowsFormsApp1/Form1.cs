using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int gravity = 12;
        int score = 0;
        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            movePipe(4);
            scoreText.Text = score.ToString();
            restartGame.Visible = false;

            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
                restartGame.Visible = true;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
                restartGame.Visible = true;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeTop4.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom4.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
                restartGame.Visible = true;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -12;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 12;
            }
            
            if (e.KeyCode == Keys.R && gameOver) 
            {
                RestartGame(4);
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game over...";
            gameOver = true;
        }

        Random r = new Random();
        private void movePipe(int speed)
        {
            
            if (pipeBottom.Left >= 0 && pipeTop.Left >= 0)
            {
                pipeBottom.Left += -speed;
                pipeTop.Left += -speed;
            }
            else
            {
                pipeBottom.Left = 1120;
                pipeTop.Left = 1120;
                score++;
            }
            
            if (pipeBottom2.Left >= 0 && pipeTop2.Left >= 0)
            {
                pipeBottom2.Left += -speed;
                pipeTop2.Left += -speed;
            }
            else
            {
                pipeBottom2.Left = 1120;
                pipeTop2.Left = 1120;
                score++;
            }
            /*pipeTop2.Height = r.Next(236, 264);
            pipeBottom2.Height = r.Next(270, 272);*/

            if (pipeBottom4.Left >= 0 && pipeTop4.Left >= 0)
            {
                pipeBottom4.Left += -speed;
                pipeTop4.Left += -speed;
            }
            else
            {
                pipeBottom4.Left = 1120;
                pipeTop4.Left = 1120;
                score++;
            }
            /*pipeTop.Height = r.Next(363, 370);
            pipeBottom.Height = r.Next(170, 175);*/
        }
        
        private void RestartGame(int speed) 
        {
            score = 0;
            flappyBird.Top += gravity;
            gameOver = false;

            flappyBird.Location = new Point(19, 377);
            scoreText.Text = "Score: 0";

            pipeBottom.Location = new Point(387, 499);
            pipeTop.Location = new Point(387, -4);

            pipeBottom2.Location = new Point(784, 454);
            pipeTop2.Location = new Point(784, -4);

            pipeBottom4.Location = new Point(1125, 555);
            pipeTop4.Location = new Point(1125, -4);


            if (pipeBottom.Left >= 0 && pipeTop.Left >= 0)
            {
                pipeBottom.Left += -speed;
                pipeTop.Left += -speed;
            }
            else
            {
                pipeBottom.Left = 1120;
                pipeTop.Left = 1120;
                score++;
            }

            if (pipeBottom2.Left >= 0 && pipeTop2.Left >= 0)
            {
                pipeBottom2.Left += -speed;
                pipeTop2.Left += -speed;
            }
            else
            {
                pipeBottom2.Left = 1120;
                pipeTop2.Left = 1120;
                score++;
            }
            /*pipeTop2.Height = r.Next(236, 264);
            pipeBottom2.Height = r.Next(270, 272);*/

            if (pipeBottom4.Left >= 0 && pipeTop4.Left >= 0)
            {
                pipeBottom4.Left += -speed;
                pipeTop4.Left += -speed;
            }
            else
            {
                pipeBottom4.Left = 1120;
                pipeTop4.Left = 1120;
                score++;
            }
            gameTimer.Start();
            restartGame.Visible = true;

        }
    }
}
