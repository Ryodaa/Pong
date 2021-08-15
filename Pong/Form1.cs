using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Poeng : Form
    {
        bool goUpP1;
        bool goDownP1;
        bool goUpP2;
        bool goDownP2;
        bool ballGoesLeft;
        int ballMovesUp;
        int ballVerticalSpeed;
        int ballRallyCount = 0;
        int scorePOne = 0;
        int scorePTwo = 0;
        int paddleOneSpeed = 20;
        int paddleTwoSpeed = 20;
        int ballSpeed = 10;
        Random random = new Random(); //randoms with only 2 act as bool

        public Poeng()
        {
            ballMovesUp = random.Next(2);
            ballVerticalSpeed = random.Next(6);
            InitializeComponent();
            BallTimer.Enabled = false;
        }

        private void BallSpeedIncrease()
        {
            if (Ball.Bounds.IntersectsWith(PaddleOne.Bounds))
            {
                ballRallyCount++;
            }
            else if (Ball.Bounds.IntersectsWith(PaddleTwo.Bounds))
            {
                ballRallyCount++;
            }

            switch (ballRallyCount)
            {
                case 5:
                    ballSpeed = 12;
                    break;
                case 10:
                    ballSpeed = 14;
                    break;
                case 15:
                    ballSpeed = 16;
                    break;
                case 20:
                    ballSpeed = 18;
                    break;
                case 25:
                    ballSpeed = 20;
                    break;
                case 30:
                    ballSpeed = 22;
                    break;
                case 35:
                    ballSpeed = 25;
                    break;
                case 40:
                    ballSpeed = 30;
                    break;
            }
        }

        // Start Game

        private void StartGame()
        {
            BallTimer.Enabled = true;
            ballRallyCount = 0;
            BallRandomizer();
        }

        private void PressSpace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                StartGame();
            }
        }

        // Paddle Movement

        private void PaddleMove(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUpP1 = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                goDownP1 = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUpP2 = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDownP2 = true;
            }
        }

        private void PaddleStop(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goUpP1 = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                goDownP1 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUpP2 = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDownP2 = false;
            }
        }

        // Ingame Timers

        private void IngameTimer_P1(object sender, EventArgs e)
        {
            if (goUpP1)
            {
                PaddleOne.Top -= paddleOneSpeed;
                if (PaddleOne.Top < -1)
                {
                    PaddleOne.Top += paddleOneSpeed;
                }
            }
            else if (goDownP1)
            {
                PaddleOne.Top += paddleOneSpeed;
                if (PaddleOne.Top > 517)
                {
                    PaddleOne.Top -= paddleOneSpeed;
                }
            }

        }

        private void InGameTimer_P2(object sender, EventArgs e)
        {
            if (goUpP2)
            {
                PaddleTwo.Top -= paddleTwoSpeed;
                if (PaddleTwo.Top < -1)
                {
                    PaddleTwo.Top += paddleTwoSpeed;
                }
            }
            else if (goDownP2)
            {
                PaddleTwo.Top += paddleTwoSpeed;
                if (PaddleTwo.Top > 517)
                {
                    PaddleTwo.Top -= paddleTwoSpeed;
                }
            }
        }

        private void BallMovementTimer(object sender, EventArgs e)
        {
            if (ballGoesLeft)
            {
                BallMovementLeft();
            }
            else if (!ballGoesLeft)
            {
                BallMovementRight();
            }

            if (ballMovesUp == 1)
            {
                BallMovesUpwards();
            }
            else if (ballMovesUp == 0)
            {
                BallMovesDown();
            }

            BallSpeedIncrease();
            ResetBall();
            ScoreP1();
            ScoreP2();
        }


        //Ball Movement

        private void BallRandomizer()
        {
            if (random.Next(4) == 0)
            {
                ballGoesLeft = false;
                ballMovesUp = 0;
            }
            else if (random.Next(4) == 1)
            {
                ballGoesLeft = true;
                ballMovesUp = 1;
            }
            else if (random.Next(4) == 2)
            {
                ballGoesLeft = false;
                ballMovesUp = 1;
            }
            else if (random.Next(4) == 3)
            {
                ballGoesLeft = true;
                ballMovesUp = 0;
            }

            ballVerticalSpeed = random.Next(6);
        }

        private void BallMovesUpwards()
        {
            Ball.Top -= ballVerticalSpeed;
            if (Ball.Top < 1)
            {
                Ball.Top += ballVerticalSpeed;
            }
        }

        private void BallMovesDown()
        {
            Ball.Top += ballVerticalSpeed;
            if (Ball.Top > 630)
            {
                Ball.Top -= ballVerticalSpeed;
            }
        }

        private void BallMovementLeft()
        {
            Ball.Left -= ballSpeed;
            if (Ball.Bounds.IntersectsWith(PaddleOne.Bounds))
            {
                ballVerticalSpeed = random.Next(6);
                ballGoesLeft = false;
                ballMovesUp = random.Next(2);
            }
        }

        private void BallMovementRight()
        {
            Ball.Left += ballSpeed;
            if (Ball.Bounds.IntersectsWith(PaddleTwo.Bounds))
            {
                ballVerticalSpeed = random.Next(6);
                ballGoesLeft = true;
                ballMovesUp = random.Next(2);
            }
        }

        private void ResetBall()
        {
            if (Ball.Left > 1050 || Ball.Left < -20)
            {
                BallTimer.Enabled = false;
                Ball.Left = 483;
                Ball.Top = 304;
            }
        }

        // Score

        private void ScoreP1()
        {
            ScorePlayerOne.Text = scorePOne.ToString();
            if (Ball.Left >= 1050)
            {
                scorePOne++;
            }
        }

        private void ScoreP2()
        {
            ScorePlayerTwo.Text = scorePTwo.ToString();
            if (Ball.Left <= -20)
            {
                scorePTwo++;
            }
        }
    }
}
