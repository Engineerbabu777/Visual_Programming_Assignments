namespace Flappy_Bird_Game
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
            this.PipBottom = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipTop = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PipBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipTop)).BeginInit();
            this.SuspendLayout();
            // 
            // PipBottom
            // 
            this.PipBottom.Image = global::Flappy_Bird_Game.Properties.Resources.pipe;
            this.PipBottom.Location = new System.Drawing.Point(688, 239);
            this.PipBottom.Name = "PipBottom";
            this.PipBottom.Size = new System.Drawing.Size(100, 163);
            this.PipBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipBottom.TabIndex = 0;
            this.PipBottom.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::Flappy_Bird_Game.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(71, 191);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(48, 49);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 1;
            this.FlappyBird.TabStop = false;
            this.FlappyBird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappy_Bird_Game.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(1, 397);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(802, 116);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // PipTop
            // 
            this.PipTop.Image = global::Flappy_Bird_Game.Properties.Resources.pipedown;
            this.PipTop.Location = new System.Drawing.Point(197, 5);
            this.PipTop.Name = "PipTop";
            this.PipTop.Size = new System.Drawing.Size(100, 132);
            this.PipTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipTop.TabIndex = 3;
            this.PipTop.TabStop = false;
            this.PipTop.Click += new System.EventHandler(this.PipTop_Click);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(2, 5);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(169, 57);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score:1";
            this.ScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.gameTimeEvents);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.PipTop);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.PipBottom);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.PipBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipBottom;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipTop;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTime;
    }
}

