
namespace Pong
{
    partial class Poeng
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poeng));
            this.ScorePlayerOne = new System.Windows.Forms.Label();
            this.GameTimerP1 = new System.Windows.Forms.Timer(this.components);
            this.GameTimerP2 = new System.Windows.Forms.Timer(this.components);
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.ScorePlayerTwo = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.PaddleTwo = new System.Windows.Forms.PictureBox();
            this.PaddleOne = new System.Windows.Forms.PictureBox();
            this.madeBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleOne)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorePlayerOne
            // 
            this.ScorePlayerOne.AutoSize = true;
            this.ScorePlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePlayerOne.Location = new System.Drawing.Point(238, 9);
            this.ScorePlayerOne.Name = "ScorePlayerOne";
            this.ScorePlayerOne.Size = new System.Drawing.Size(27, 29);
            this.ScorePlayerOne.TabIndex = 0;
            this.ScorePlayerOne.Text = "0";
            // 
            // GameTimerP1
            // 
            this.GameTimerP1.Enabled = true;
            this.GameTimerP1.Interval = 10;
            this.GameTimerP1.Tick += new System.EventHandler(this.IngameTimer_P1);
            // 
            // GameTimerP2
            // 
            this.GameTimerP2.Enabled = true;
            this.GameTimerP2.Interval = 10;
            this.GameTimerP2.Tick += new System.EventHandler(this.InGameTimer_P2);
            // 
            // BallTimer
            // 
            this.BallTimer.Enabled = true;
            this.BallTimer.Interval = 10;
            this.BallTimer.Tick += new System.EventHandler(this.BallMovementTimer);
            // 
            // ScorePlayerTwo
            // 
            this.ScorePlayerTwo.AutoSize = true;
            this.ScorePlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePlayerTwo.Location = new System.Drawing.Point(704, 9);
            this.ScorePlayerTwo.Name = "ScorePlayerTwo";
            this.ScorePlayerTwo.Size = new System.Drawing.Size(27, 29);
            this.ScorePlayerTwo.TabIndex = 4;
            this.ScorePlayerTwo.Text = "0";
            // 
            // Ball
            // 
            this.Ball.Image = global::Pong.Properties.Resources.ball;
            this.Ball.Location = new System.Drawing.Point(483, 304);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 3;
            this.Ball.TabStop = false;
            // 
            // PaddleTwo
            // 
            this.PaddleTwo.Image = global::Pong.Properties.Resources.Paddle;
            this.PaddleTwo.Location = new System.Drawing.Point(950, 245);
            this.PaddleTwo.Name = "PaddleTwo";
            this.PaddleTwo.Size = new System.Drawing.Size(22, 139);
            this.PaddleTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaddleTwo.TabIndex = 2;
            this.PaddleTwo.TabStop = false;
            // 
            // PaddleOne
            // 
            this.PaddleOne.Image = global::Pong.Properties.Resources.Paddle;
            this.PaddleOne.Location = new System.Drawing.Point(12, 245);
            this.PaddleOne.Name = "PaddleOne";
            this.PaddleOne.Size = new System.Drawing.Size(22, 139);
            this.PaddleOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PaddleOne.TabIndex = 1;
            this.PaddleOne.TabStop = false;
            // 
            // madeBy
            // 
            this.madeBy.AutoSize = true;
            this.madeBy.ForeColor = System.Drawing.Color.Azure;
            this.madeBy.Location = new System.Drawing.Point(890, 632);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(82, 13);
            this.madeBy.TabIndex = 5;
            this.madeBy.Text = "Made by Ryoda";
            // 
            // Poeng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 654);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.ScorePlayerTwo);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.PaddleTwo);
            this.Controls.Add(this.PaddleOne);
            this.Controls.Add(this.ScorePlayerOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Poeng";
            this.Text = "Poeng";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaddleMove);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressSpace);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaddleStop);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddleOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScorePlayerOne;
        private System.Windows.Forms.PictureBox PaddleOne;
        private System.Windows.Forms.PictureBox PaddleTwo;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer GameTimerP1;
        private System.Windows.Forms.Timer GameTimerP2;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.Label ScorePlayerTwo;
        private System.Windows.Forms.Label madeBy;
    }
}

