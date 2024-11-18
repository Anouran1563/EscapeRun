using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRun2
{
    public partial class FormGame : Form
    {
        bool left = false;
        bool right = false;
        bool jump = false;
        bool hasKey = false;

        int PlayerX = 80;
        int PlayerY = 396;
        int Playerforce = 8;
        int Playerjumpump = 0;
        int Playerscore = 0;
        int Playerspeed = 5;

        private Form1 parentForm;
        public FormGame(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = " " + Playerscore;

            if (left == true && pbPlayer.Left > 60)
            {
                pbPlayer.Left -= Playerspeed;
            }
            if (right == true && pbPlayer.Left + (pbPlayer.Width + 60) < this.ClientSize.Width)
            {
                pbPlayer.Left += Playerspeed;
            }
            if (jump == true)
            {
                Playerjumpump = 12;
                Playerforce -= 1;
                pbPlayer.Top -= Playerjumpump;
            }
            else
            {
                Playerjumpump = 12;
                pbPlayer.Top += Playerjumpump;
            }
            if (jump == true && Playerforce < 0)
            {
                jump = false;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag as string == "platform")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && jump == false)
                    {
                        Playerforce = 8;
                        pbPlayer.Top = x.Top - pbPlayer.Height;
                        Playerjumpump = 0;
                    }
                }

                if (x is PictureBox picturebox 
                    && picturebox.Tag is string tag 
                    && tag == "Coin")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        Playerscore += 1;
                    }

                }
            }

            if (pbPlayer.Bounds.IntersectsWith(pbKey.Bounds))
            {
                pbKey.Visible = false;
                hasKey = true;
            }

            if (pbPlayer.Bounds.IntersectsWith(pbDoor.Bounds) && hasKey == true)
            {
                pbDoor.Image = Properties.Resources.open;
                MainTimer.Stop();
                MessageBox.Show("You completed this stage" + Environment.NewLine + "Click to play again");
                Restart();

            }
            if (pbPlayer.Bounds.IntersectsWith(pbGround.Bounds))
            {
                dead();
            }
        }

        private void MoveGameElements(string direction)
        {
            //foreach (Control x in this.Controls)
            //{
            //    if (x is PictureBox && (string)x.Tag == "platform" ||
            //        x is PictureBox && (string)x.Tag == "coin" ||
            //        x is PictureBox && (string)x.Tag == "key" ||
            //        x is PictureBox && (string)x.Tag == "pbDoor")
            //    {
            //        if (direction == "back")
            //        {
            //            x.Left -= bgspeed;
            //        }
            //        if (direction == "forward")
            //        {
            //            x.Left += bgspeed;
            //        }
            //    }
            //}
        }
        private void Restart()
        {
            Form1 newWindow = new Form1();
            this.Close();
            newWindow.Show();
            //int a = Int32.Parse(lblValue.Text);
            //if (Playerscore > a)
            //{
            //    lblValue.Text = Playerscore.ToString();
            //}
        }

        private void CloseForm(object sender, FormClosedEventArgs eventArgs)
        {
            Application.Exit();


        }

        private void dead()
        {
            DialogResult result = MessageBox.Show("You died", "Do you wanna try again", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Restart();
            }
            else
            {
                this.Close();
                parentForm.Show();
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = true;
                PlayerX--;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
                PlayerX++;
            }
            if (e.KeyCode == Keys.W)
            {
                jump = true;
                PlayerY--;
            }
            if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Confirmation", "Are you sure you want to exit the Game?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                parentForm.Enabled = true;
                parentForm.Show();
                this.Close();
            }
            else
            {
                
            }
            
        }
    }
}
