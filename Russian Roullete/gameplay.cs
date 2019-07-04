using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Reflection;


namespace Russian_Roullete
{
    public partial class gameplay : Form
    {
        public gameplay()
        {
            InitializeComponent();
        }
        shootaway away = new shootaway();
        Random spinrand = new Random();
        private void bulleteloadbtn_Click(object sender, EventArgs e)
        {
           
            //this shows the image


            bulleteloadbtn.Enabled = false;
            bulletespinbt.Enabled = true;
            // Assembly myasses = Assembly.GetExecutingAssembly();
            // Stream myst = myasses.GetManifestResourceStream("Russian.roullete.rources.load.gif");
            // Bitmap bmp = new Bitmap(myst);
            pictureBox1.Image = Russian_Roullete.Properties.Resources.load;
           // System.Media.SoundPlayer player = new System.Media.SoundPlayer(Russian_Roullete.Properties.Resources.load1);
            SoundPlayer player = new SoundPlayer(Russian_Roullete.Properties.Resources.load1);
           
            player.Play();
        }

        private void bulletespinbt_Click(object sender, EventArgs e)
        {
            
            //this shows the image

            away.Spinbullete = spinrand.Next(1, 6);//choose random number from 1 to 6

            Bulleteshotbt.Enabled = true;
            bulletespinbt.Enabled = false;
            // Assembly myasses = Assembly.GetExecutingAssembly();
            // Stream myst = myasses.GetManifestResourceStream("Russian.roullete.rources.load.gif");
            // Bitmap bmp = new Bitmap(myst);
            pictureBox1.Image = Russian_Roullete.Properties.Resources.spin;
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(Russian_Roullete.Properties.Resources.spin1);
            SoundPlayer player = new SoundPlayer(Russian_Roullete.Properties.Resources.spin1);
            player.Play();
        }

        private void Bulleteshotbt_Click(object sender, EventArgs e)
        {
           
            // Assembly myasses = Assembly.GetExecutingAssembly();
            // Stream myst = myasses.GetManifestResourceStream("Russian.roullete.rources.load.gif");
            // Bitmap bmp = new Bitmap(myst);
            pictureBox1.Image = Russian_Roullete.Properties.Resources.shoot;
           // System.Media.SoundPlayer player = new System.Media.SoundPlayer(Russian_Roullete.Properties.Resources.shoot1);
            SoundPlayer player = new SoundPlayer(Russian_Roullete.Properties.Resources.shoot1);
            player.Play();
           

            if (away.Totalshots > 0 && away.Spinbullete == 1)
            {

                MessageBox.Show("You Loose");

                shootawaybt.Enabled = false;
                bulletespinbt.Enabled = false;
                Bulleteshotbt.Enabled = false;
                bulleteloadbtn.Enabled = false;
                //this disable the buttons


            }
            else if (away.Totalshots > 0 && away.Spinbullete != 1)
            {
                away.Totalshots = away.Totalshots - 1;
                away.Spinbullete = away.BulleteChange(away.Spinbullete);
                MessageBox.Show("No bullete Fired");
                //this shows the meesage box
            }
        }

        private void shootawaybt_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(Russian_Roullete.Properties.Resources.shot1);
            SoundPlayer player = new SoundPlayer(Russian_Roullete.Properties.Resources.shot);
            player.Play();
            int score = away.Awaymiss();
            if (score == 10)
            {
                MessageBox.Show("You Win your score is 100");
                shootawaybt.Enabled = false;
                bulletespinbt.Enabled = true;
                Bulleteshotbt.Enabled = false;
                bulleteloadbtn.Enabled = false;

            }
            if (score == 5)
            {
                MessageBox.Show("You Win your score is 50");
                shootawaybt.Enabled = false;
                bulletespinbt.Enabled = true;
                Bulleteshotbt.Enabled = false;
                bulleteloadbtn.Enabled = false;
            }
            if (score == 0)
            {

                MessageBox.Show("No bullete Fired");
                if (away.Totalshots == 0)
                {

                    MessageBox.Show("you lost");
                    shootawaybt.Enabled = false;


                }

            }

           
        }

        private void retrybt_Click(object sender, EventArgs e)
        {
            (new gameplay()).Show();
            this.Hide();
        }
    }
}

