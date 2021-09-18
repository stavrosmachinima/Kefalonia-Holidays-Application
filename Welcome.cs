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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            smartPlaning form2 = new smartPlaning();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            smartHome form3 = new smartHome();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            smartTemperature form4 = new smartTemperature();
            form4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            servicesForOldPeople form5 = new servicesForOldPeople();
            form5.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            onlineDelivery form6 = new onlineDelivery();
            form6.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            myDesign form7 = new myDesign();
            form7.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Play();
            soundPlayer.soundVariable.PlayLooping();
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Play();
            soundPlayer.doYouHearMusic = true;
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Stop();
            soundPlayer.doYouHearMusic = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
        }

        private void Welcome_Activated(object sender, EventArgs e)
        {
            // ama akouei kati, ftiaxnei analogws tis eikones gia thn mousikh
            if (soundPlayer.doYouHearMusic)
            {
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }
            else
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
        }
    }
}
