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
        public myDesign()
        {
            InitializeComponent();
        }

        private void myDesign_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (onlyKitchen)
            {
                if (IconKitchenOn.Visible == true)
                {
                    onlyLivingRoom = true;
                    onlyKitchen = false;
                    LivingRoomOff.Visible = false;
                    LivingRoomOn.Visible = false;
                    kitchenOn.Visible = true;
                    kitchenOff.Visible = false;
                    button4.Visible = true;
                }
                else if (IconKitchenOff.Visible==true)
                {
                    onlyLivingRoom = true;
                    onlyKitchen = false;
                    LivingRoomOff.Visible = false;
                    LivingRoomOn.Visible = false;
                    kitchenOff.Visible = true;
                    kitchenOn.Visible = false;
                    button4.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IconKitchenOn.Visible = false;
            IconKitchenOff.Visible = true;
            kitchenOn.Visible = false;
            kitchenOff.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            IconKitchenOn.Visible = true;
            kitchenOff.Visible = false;
            kitchenOn.Visible = true;
            IconKitchenOff.Visible =false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onlyLivingRoom)
            {
                onlyLivingRoom = false;
                onlyKitchen = true;
                kitchenOff.Visible = false;
                kitchenOn.Visible = false;
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = true;
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
            else if (LivingRoomOff.Visible == true)
            {
                IconKitchenOff.Visible = false;
                IconKitchenOn.Visible = false;
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = true;

            }
            else if (LivingRoomOff.Visible == true)
            {
                IconKitchenOff.Visible = false;
                IconKitchenOn.Visible = false;
                LivingRoomOn.Visible = false;
                LivingRoomOff.Visible = true;

            }
        }
    }
}
