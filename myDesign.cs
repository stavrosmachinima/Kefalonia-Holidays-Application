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
    public partial class myDesign : Form
    {
        bool onlyKitchen=true;
        bool onlyLivingRoom = true;
        String temperatureKitchen ="27 °C";
        String temperatureLivingRoom= "33 °C";
        public myDesign()
        {
            InitializeComponent();
        }

        private void myDesign_Load(object sender, EventArgs e)
        {
            if (soundPlayer.doYouHearMusic)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (onlyKitchen)
            {
                if (IconKitchenOn.Visible == true)
                {
                    kitchenOn.Visible = true;
                    kitchenOff.Visible = false;
                }
                else if (IconKitchenOff.Visible==true)
                {
                    kitchenOff.Visible = true;
                    kitchenOn.Visible = false;
                }
                onlyLivingRoom = true;
                onlyKitchen = false;
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = false;
                button4.Visible = true;
                temperature.Text =temperatureKitchen;
                temperature.Visible = true;
                increase.Visible = true;
                decrease.Visible = true;
                label3.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IconKitchenOn.Visible = false;
            IconKitchenOff.Visible = true;
            if (kitchenOff.Visible == true || kitchenOn.Visible == true)
            {
                kitchenOn.Visible = false;
                kitchenOff.Visible = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            IconKitchenOn.Visible = true;
            IconKitchenOff.Visible = false;
            if (kitchenOff.Visible == true || kitchenOn.Visible == true)
            {
                kitchenOff.Visible = false;
                kitchenOn.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onlyLivingRoom)
            {
                if (IconLivingRoomOn.Visible == true)
                {
                    LivingRoomOff.Visible = false;
                    LivingRoomOn.Visible = true;
                }
                else if(IconLivingRoomOff.Visible==true)
                {
                    LivingRoomOn.Visible = false;
                    LivingRoomOff.Visible = true;
                }
                temperature.Text = temperatureLivingRoom;
                temperature.Visible = true;
                increase.Visible = true;
                decrease.Visible = true;
                label3.Visible = true;
                onlyLivingRoom = false;
                onlyKitchen = true;
                kitchenOff.Visible = false;
                kitchenOn.Visible = false;
                button4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kitchenOn.Visible == true)
            {
                IconKitchenOff.Visible = true;
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = false;
                IconKitchenOn.Visible = false;
                kitchenOff.Visible = true;
                kitchenOn.Visible = false;
            }
            else if (kitchenOff.Visible == true)
            {
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = false;
                IconKitchenOff.Visible = false;
                IconKitchenOn.Visible = true;
                kitchenOn.Visible = true;
                kitchenOff.Visible = false;
            }
            else if (LivingRoomOn.Visible == true)
            {
                kitchenOff.Visible = false;
                kitchenOn.Visible = false;
                LivingRoomOn.Visible = false;
                LivingRoomOff.Visible = true;

            }
            else if (LivingRoomOff.Visible == true)
            {
                kitchenOff.Visible = false;
                kitchenOn.Visible = false;
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = true;
            }
        }

        private void IconLivingRoomOff_Click(object sender, EventArgs e)
        {
                IconLivingRoomOff.Visible = false;
                IconLivingRoomOn.Visible = true;
            if (LivingRoomOff.Visible == true || LivingRoomOn.Visible == true)
            {
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = true;
            }
        }

        private void IconLivingRoomOn_Click(object sender, EventArgs e)
        {
                IconLivingRoomOn.Visible = false;
                IconLivingRoomOff.Visible = true;
            if (LivingRoomOff.Visible == true || LivingRoomOn.Visible == true)
            {
                LivingRoomOn.Visible = false;
                LivingRoomOff.Visible = true;

            }
        }

        // afto einai to increase
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String s1 = temperature.Text;
            s1 = s1.Substring(0, 2);
            int add = int.Parse(s1);
            add = add + 1;
            s1 = add.ToString()+ " °C";
            temperatureKitchen = s1;
            temperature.Text = s1;
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            String s1 = temperature.Text;
            s1 = s1.Substring(0, 2);
            int add = int.Parse(s1);
            add = add - 1;
            s1 = add.ToString() + " °C";
            temperatureLivingRoom = s1;
            temperature.Text = s1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Play();
            soundPlayer.doYouHearMusic = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Stop();
            soundPlayer.doYouHearMusic = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\..\..\bestHelpInTown.chm");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
