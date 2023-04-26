namespace WindowsFormsApp1
{
    partial class Form1
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop4 = new System.Windows.Forms.PictureBox();
            this.pipeBottom4 = new System.Windows.Forms.PictureBox();
            this.restartGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom4)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.scoreText.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(524, 756);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(183, 46);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "SCORE: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Aqua;
            this.flappyBird.Image = global::WindowsFormsApp1.Properties.Resources.birdfly3;
            this.flappyBird.Location = new System.Drawing.Point(19, 377);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(0);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(53, 39);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::WindowsFormsApp1.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-6, 723);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(2010, 109);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::WindowsFormsApp1.Properties.Resources.pipe_down1;
            this.pipeTop.Location = new System.Drawing.Point(387, -4);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 310);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::WindowsFormsApp1.Properties.Resources.pipe1;
            this.pipeBottom.Location = new System.Drawing.Point(387, 499);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 226);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.Image = global::WindowsFormsApp1.Properties.Resources.pipe_down1;
            this.pipeTop2.Location = new System.Drawing.Point(784, -4);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(100, 264);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 7;
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.Image = global::WindowsFormsApp1.Properties.Resources.pipe1;
            this.pipeBottom2.Location = new System.Drawing.Point(784, 454);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(100, 271);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 8;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop4
            // 
            this.pipeTop4.Image = global::WindowsFormsApp1.Properties.Resources.pipe_down1;
            this.pipeTop4.Location = new System.Drawing.Point(1125, -4);
            this.pipeTop4.Name = "pipeTop4";
            this.pipeTop4.Size = new System.Drawing.Size(100, 363);
            this.pipeTop4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop4.TabIndex = 11;
            this.pipeTop4.TabStop = false;
            // 
            // pipeBottom4
            // 
            this.pipeBottom4.Image = global::WindowsFormsApp1.Properties.Resources.pipe1;
            this.pipeBottom4.Location = new System.Drawing.Point(1125, 555);
            this.pipeBottom4.Name = "pipeBottom4";
            this.pipeBottom4.Size = new System.Drawing.Size(100, 170);
            this.pipeBottom4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom4.TabIndex = 12;
            this.pipeBottom4.TabStop = false;
            // 
            // restartGame
            // 
            this.restartGame.AutoSize = true;
            this.restartGame.BackColor = System.Drawing.Color.Goldenrod;
            this.restartGame.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGame.Location = new System.Drawing.Point(377, 345);
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(512, 60);
            this.restartGame.TabIndex = 13;
            this.restartGame.Text = "Try Again? Press R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1261, 828);
            this.Controls.Add(this.restartGame);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeBottom4);
            this.Controls.Add(this.pipeTop4);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "       ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop4;
        private System.Windows.Forms.PictureBox pipeBottom4;
        private System.Windows.Forms.Label restartGame;
    }
}

