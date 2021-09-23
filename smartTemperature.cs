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
        bool pictureChanged = false;
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
            if ((e.X >= 113 && e.X <= 120) && (e.Y >= 136) && e.Y <= 143)
            {
                pictureBox1.Image = Properties.Resources.whatIsTemperature;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X >= 113 && e.X <= 120) && (e.Y >= 136) && e.Y <= 143)
                pictureBox1.Cursor = Cursors.Hand;
            else
                pictureBox1.Cursor = Cursors.Default;
        }
    }
}
