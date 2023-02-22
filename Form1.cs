using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RACING_GAME
{
    public partial class Form1 : Form
    {

        int roadspeed = 15;
        int traficspeed = 15;
        int playerspeed = 12;
        int score;
        int carimage;

        Random rand = new Random();
        Random carpostion = new Random();
        bool Goleft, Goright;

        public Form1()
        {
            InitializeComponent();
        }

        private void restartGame(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            Goleft = false;
            Goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;
            roadspeed = 12;
            traficspeed = 15;
            A1.Top = carpostion.Next(200, 500) * -1;
            A1.Left = carpostion.Next(5, 200);
            A2.Top = carpostion.Next(200, 500) * -1;
            A2.Left = carpostion.Next(245, 422);
            gameTimer.Start();
                     
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            score++;

            if (Goleft == true && player.Left > 10)
            {
                player.Left -= playerspeed;
            }
            if (Goright == true && player.Left < 415)
            {
                player.Left += playerspeed;
            }
            roadtrack1.Top = roadspeed;
            roadtrack2.Top = roadspeed;

            if (roadtrack2.Top > 519)
            {
                roadtrack2.Top = -519;
            }
            if (roadtrack1.Top > 519)
            {
                roadtrack1.Top = -519;
            }

            A1.Top += traficspeed;
            A2.Top += traficspeed;

            if (A1.Top > 530)
            {
                ChangeACars(A1);
            }
            if (A2.Top > 530)
            {
                ChangeACars(A2);
            }
            if (player.Bounds.IntersectsWith(A1.Bounds) ||
                player.Bounds.IntersectsWith(A2.Bounds))
            {
                gameOver();
            }
            if (score >40 && score < 500)
            {
                award.Image=Properties.Resources.bronze;
            }
            if (score >500 && score < 2000)
            {
                award.Image=Properties.Resources.silver;
                roadspeed = 20;
                traficspeed = 22;
            }
            if (score >2000)
            {
                award.Image = Properties.Resources.gold;
                roadspeed = 27;
                traficspeed = 25;
            }
        }
        private void gameOver()
        {
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;
        }
        private void ChangeACars(PictureBox tempCar)
        {
            carimage = rand.Next(1, 7);
            switch (carimage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }
            tempCar.Top = carpostion.Next(100, 400) * -1;
            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carpostion.Next(5, 200);
            }
            if((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carpostion.Next(245, 422);
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Goright = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Goright = false;
            }
        }
    }
}
