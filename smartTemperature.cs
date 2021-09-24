using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class smartTemperature : Form
    {
        public smartTemperature()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Play();
            soundPlayer.doYouHearMusic = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Stop();
            soundPlayer.doYouHearMusic = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
        }

        private void smartTemperature_Load(object sender, EventArgs e)
        {
            if (soundPlayer.doYouHearMusic)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\..\..\bestHelpInTown.chm");
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.X >= 115 && e.X <= 124) && (e.Y >= 169) && e.Y <= 179)
            {
                // ypologismos 8ermokrasias
                Random random = new Random();
                double x = random.NextDouble()*(38.6-36.0)+36.0;
                x = Math.Round(x,1);
                label3.Text = x.ToString() + " °C";
                label3.Visible = true;
                pictureBox1.Image = Properties.Resources.whatIsTemperature;

                //emfanish o8onhs
                richTextBox1.Visible = true;
                pictureBox7.Visible = true;
                pictureBox2.Visible = true;
               

                if (x <= 36.6)
                    richTextBox1.Text = "Μπορείτε να περάσετε.";
                else if (x<=37.2)
                    richTextBox1.Text = "Ξαναδοκιμάστε σε 5'.";
                else if (x<=38)
                    richTextBox1.Text = "Έχετε δέκατα.\nΠροτείνουμε προσοχή.";
                else
                    richTextBox1.Text = "Προτείνουμε να κάνετε τεστ κορονοϊού.";
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X >= 115 && e.X <= 124) && (e.Y >= 169) && e.Y <= 179)
                pictureBox1.Cursor = Cursors.Hand;
            else
                pictureBox1.Cursor = Cursors.Default;
        }
    }
}
