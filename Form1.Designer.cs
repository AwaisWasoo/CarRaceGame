namespace CAR_RACING_GAME
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.roadtrack1 = new System.Windows.Forms.PictureBox();
            this.roadtrack2 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.roadtrack2);
            this.panel1.Controls.Add(this.roadtrack1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 519);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(188, 569);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(180, 536);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 18);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score : 0";
            // 
            // roadtrack1
            // 
            this.roadtrack1.Image = global::CAR_RACING_GAME.Properties.Resources.roadTrack;
            this.roadtrack1.Location = new System.Drawing.Point(0, -519);
            this.roadtrack1.Name = "roadtrack1";
            this.roadtrack1.Size = new System.Drawing.Size(475, 519);
            this.roadtrack1.TabIndex = 0;
            this.roadtrack1.TabStop = false;
            // 
            // roadtrack2
            // 
            this.roadtrack2.Image = global::CAR_RACING_GAME.Properties.Resources.roadTrack;
            this.roadtrack2.Location = new System.Drawing.Point(0, 0);
            this.roadtrack2.Name = "roadtrack2";
            this.roadtrack2.Size = new System.Drawing.Size(474, 632);
            this.roadtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roadtrack2.TabIndex = 1;
            this.roadtrack2.TabStop = false;
            // 
            // A1
            // 
            this.A1.Image = global::CAR_RACING_GAME.Properties.Resources.carGreen;
            this.A1.Location = new System.Drawing.Point(93, 26);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(50, 101);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A1.TabIndex = 2;
            this.A1.TabStop = false;
            this.A1.Tag = "carLeft";
            // 
            // award
            // 
            this.award.Image = global::CAR_RACING_GAME.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(127, 205);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 3;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::CAR_RACING_GAME.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(199, 399);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 4;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::CAR_RACING_GAME.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(204, 410);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // A2
            // 
            this.A2.Image = global::CAR_RACING_GAME.Properties.Resources.CarRed;
            this.A2.Location = new System.Drawing.Point(249, 85);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(50, 100);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A2.TabIndex = 6;
            this.A2.TabStop = false;
            this.A2.Tag = "carRight";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(476, 657);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox roadtrack2;
        private System.Windows.Forms.PictureBox roadtrack1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

