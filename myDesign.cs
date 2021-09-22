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
        String temperatureKitchen ="27 °C";
        String temperatureLivingRoom= "33 °C";
        String temperatureChildrenRoom = "34 °C";
        String temperatureDiningRoom= "26 °C";
        String temperatureParentsRoom = "32 °C";
        String temperatureBathroom = "28 °C";

        bool lightKitchen = false;
        bool lightBathroom = false;
        bool lightLivingRoom = false;
        bool lightParentsRoom = true;
        bool lightChildrenRoom = true;
        bool lightDiningRoom = true;

        String whatAmIwatching="";

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
            showRoom();
            whatAmIwatching = "kitchen";
            temperature.Text = temperatureKitchen;
            if (lightKitchen)
                pictureRoom.Image = Properties.Resources.kitchenOn;
            else
                pictureRoom.Image = Properties.Resources.kitchenOff;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showRoom();
            whatAmIwatching = "livingRoom";
            temperature.Text = temperatureLivingRoom;
            if (lightLivingRoom)
                pictureRoom.Image = Properties.Resources.livingRoom;
            else
                pictureRoom.Image = Properties.Resources.darkenedLivingRoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (whatAmIwatching.Equals("kitchen"))
            {
                if (lightKitchen)
                {
                    lightKitchen = false;
                    pictureRoom.Image = Properties.Resources.kitchenOff;
                    iconKitchen.Image = Properties.Resources.lightOff;
                }
                else
                {
                    lightKitchen = true;
                    pictureRoom.Image = Properties.Resources.kitchenOn;
                    iconKitchen.Image = Properties.Resources.lightOn;
                }
            }
            else if (whatAmIwatching.Equals("diningRoom"))
            {
                if (lightDiningRoom)
                {
                    lightDiningRoom = false;
                    pictureRoom.Image = Properties.Resources.diningRoomOff;
                    iconDining.Image = Properties.Resources.lightOff;
                }
                else
                {
                    lightDiningRoom = true;
                    pictureRoom.Image = Properties.Resources.diningRoomOn;
                    iconDining.Image = Properties.Resources.lightOn;
                }
            }
            else if (whatAmIwatching.Equals("livingRoom"))
            {
                if (lightLivingRoom)
                {
                    lightLivingRoom = false;
                    pictureRoom.Image = Properties.Resources.darkenedLivingRoom;
                    iconLiving.Image = Properties.Resources.lightOff;
                }
                else
                {
                    lightLivingRoom = true;
                    pictureRoom.Image = Properties.Resources.livingRoom;
                    iconLiving.Image = Properties.Resources.lightOn;
                }
            }
            else if (whatAmIwatching.Equals("parentsRoom"))
            {
                if (lightParentsRoom)
                {
                    lightParentsRoom = false;
                    pictureRoom.Image = Properties.Resources.parentsRoomOff;
                    iconParents.Image = Properties.Resources.lightOff;
                }
                else
                {
                    lightParentsRoom = true;
                    pictureRoom.Image = Properties.Resources.parentsRoomOn;
                    iconParents.Image = Properties.Resources.lightOn;
                }
            }
            else if (whatAmIwatching.Equals("childrenRoom"))
            {
                if (lightChildrenRoom)
                {
                    lightChildrenRoom = false;
                    pictureRoom.Image = Properties.Resources.childrenRoomOff;
                    iconChildren.Image = Properties.Resources.lightOff;
                }
                else
                {
                    lightChildrenRoom = true;
                    pictureRoom.Image = Properties.Resources.childrenRoomOn;
                    iconChildren.Image = Properties.Resources.lightOn;
                }
            }
            else if (whatAmIwatching.Equals("bathroom"))
            {
                if (lightBathroom)
                {
                    lightBathroom = false;
                    pictureRoom.Image = Properties.Resources.bathroomOff;
                    iconBathroom.Image = Properties.Resources.lightOff;
                }
                else
                {
                    lightBathroom = true;
                    pictureRoom.Image = Properties.Resources.bathroomOn;
                    iconBathroom.Image = Properties.Resources.lightOn;
                }
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

            if (whatAmIwatching.Equals("kitchen"))
                temperatureKitchen = s1;
            else if (whatAmIwatching.Equals("diningRoom"))
                temperatureDiningRoom = s1;
            else if (whatAmIwatching.Equals("livingRoom"))
                temperatureLivingRoom = s1;
            else if (whatAmIwatching.Equals("parentsRoom"))
                temperatureParentsRoom = s1;
            else if (whatAmIwatching.Equals("childrenRoom"))
                temperatureChildrenRoom = s1;
            else if (whatAmIwatching.Equals("bathroom"))
                temperatureBathroom = s1;
            temperature.Text = s1;

        }

        private void decrease_Click(object sender, EventArgs e)
        {
            String s1 = temperature.Text;
            s1 = s1.Substring(0, 2);
            int add = int.Parse(s1);
            add = add - 1;
            s1 = add.ToString() + " °C";

            if (whatAmIwatching.Equals("kitchen"))
                temperatureKitchen = s1;
            else if (whatAmIwatching.Equals("diningRoom"))
                temperatureDiningRoom = s1;
            else if (whatAmIwatching.Equals("livingRoom"))
                temperatureLivingRoom = s1;
            else if (whatAmIwatching.Equals("parentsRoom"))
                temperatureParentsRoom = s1;
            else if (whatAmIwatching.Equals("childrenRoom"))
                temperatureChildrenRoom = s1;
            else if (whatAmIwatching.Equals("bathroom"))
                temperatureBathroom = s1;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\..\..\bestHelpInTown.chm");
        }

        private void childrenButton_Click(object sender, EventArgs e)
        {
            showRoom();
            whatAmIwatching = "childrenRoom";
            temperature.Text = temperatureChildrenRoom;
            if (lightChildrenRoom)
                pictureRoom.Image = Properties.Resources.childrenRoomOn;
            else
                pictureRoom.Image = Properties.Resources.childrenRoomOff;
        }

        private void bathroomButton_Click(object sender, EventArgs e)
        {
            showRoom();
            whatAmIwatching = "bathroom";
            temperature.Text = temperatureBathroom;
            if (lightBathroom)
                pictureRoom.Image = Properties.Resources.bathroomOn;
            else
                pictureRoom.Image = Properties.Resources.bathroomOff;
        }

        private void parentsButton_Click(object sender, EventArgs e)
        {
            showRoom();
            whatAmIwatching = "parentsRoom";
            temperature.Text = temperatureParentsRoom;
            if (lightParentsRoom)
                pictureRoom.Image = Properties.Resources.parentsRoomOn;
            else
                pictureRoom.Image = Properties.Resources.parentsRoomOff;
        }

        private void diningRoomButton_Click(object sender, EventArgs e)
        {
            showRoom();
            whatAmIwatching = "diningRoom";
            temperature.Text = temperatureDiningRoom;
            if (lightDiningRoom)
                pictureRoom.Image = Properties.Resources.diningRoomOn;
            else
                pictureRoom.Image = Properties.Resources.diningRoomOff;
        }

        private void iconChildren_Click(object sender, EventArgs e)
        {
            if (lightChildrenRoom == true)
            {
                lightChildrenRoom = false;
                iconChildren.Image = Properties.Resources.lightOff;
                if (whatAmIwatching.Equals("childrenRoom"))
                    pictureRoom.Image = Properties.Resources.childrenRoomOff;
            }
            else
            {
                lightChildrenRoom = true;
                iconChildren.Image = Properties.Resources.lightOn;
                if (whatAmIwatching.Equals("childrenRoom"))
                    pictureRoom.Image = Properties.Resources.childrenRoomOn;
            }
        }

        private void iconBathroom_Click(object sender, EventArgs e)
        {
            if (lightBathroom == true)
            {
                lightBathroom = false;
                iconBathroom.Image = Properties.Resources.lightOff;
                if (whatAmIwatching.Equals("bathroom"))
                    pictureRoom.Image = Properties.Resources.bathroomOff;
            }
            else
            {
                lightBathroom = true;
                iconBathroom.Image = Properties.Resources.lightOn;
                if (whatAmIwatching.Equals("bathroom"))
                    pictureRoom.Image = Properties.Resources.bathroomOn;
            }
        }

        private void iconParents_Click(object sender, EventArgs e)
        {
            if (lightParentsRoom == true)
            {
                lightParentsRoom = false;
                iconParents.Image = Properties.Resources.lightOff;
                if (whatAmIwatching.Equals("parentsRoom"))
                    pictureRoom.Image = Properties.Resources.parentsRoomOff;
            }
            else
            {
                lightParentsRoom = true;
                iconParents.Image = Properties.Resources.lightOn;
                if (whatAmIwatching.Equals("parentsRoom"))
                    pictureRoom.Image = Properties.Resources.parentsRoomOn;
            }
        }

        private void iconLiving_Click(object sender, EventArgs e)
        {
            if (lightLivingRoom == true)
            {
                lightLivingRoom = false;
                iconLiving.Image = Properties.Resources.lightOff;
                if (whatAmIwatching.Equals("livingRoom"))
                {
                    pictureRoom.Image = Properties.Resources.darkenedLivingRoom;
                }
            }
            else
            {
                lightLivingRoom = true;
                iconLiving.Image = Properties.Resources.lightOn;
                if (whatAmIwatching.Equals("livingRoom"))
                {
                    pictureRoom.Image = Properties.Resources.livingRoom;
                }
            }
        }

        private void iconDining_Click(object sender, EventArgs e)
        {
            if (lightDiningRoom == true)
            {
                lightDiningRoom = false;
                iconDining.Image = Properties.Resources.lightOff;
                if (whatAmIwatching.Equals("diningRoom"))
                {
                    pictureRoom.Image = Properties.Resources.diningRoomOff;
                }
            }
            else
            {
                lightDiningRoom = true;
                iconDining.Image = Properties.Resources.lightOn;
                if (whatAmIwatching.Equals("diningRoom"))
                {
                    pictureRoom.Image = Properties.Resources.diningRoomOn;
                }
            }
        }

        private void iconKitchen_Click(object sender, EventArgs e)
        {
            if (lightKitchen==true)
            {
                lightKitchen = false;
                iconKitchen.Image = Properties.Resources.lightOff;
                if (whatAmIwatching.Equals("kitchen"))
                {
                    pictureRoom.Image = Properties.Resources.kitchenOff;
                }
            }
            else
            {
                lightKitchen = true;
                iconKitchen.Image = Properties.Resources.lightOn;

                if (whatAmIwatching.Equals("kitchen"))
                {
                    pictureRoom.Image = Properties.Resources.kitchenOn;
                }
            }

            
        }

        private void pictureRoom_Click(object sender, EventArgs e)
        {

        }
        private void showRoom()
        {
            button4.Visible = true;
            increase.Visible = true;
            decrease.Visible = true;
            temperature.Visible = true;
            pictureRoom.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showRoom();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random=new Random();
            int randomInteger=random.Next(1, 6);
            switch (randomInteger)
            {
                case 1:
                    if (lightKitchen)
                        pictureRoom.Image = Properties.Resources.kitchenOn;
                    else
                        pictureRoom.Image = Properties.Resources.kitchenOff;
                    break;
                case 2:
                    if (lightDiningRoom)
                        pictureRoom.Image = Properties.Resources.diningRoomOn;
                    else
                        pictureRoom.Image = Properties.Resources.diningRoomOff;
                    break;
                case 3:
                    if (lightLivingRoom)
                        pictureRoom.Image = Properties.Resources.livingRoom;
                    else
                        pictureRoom.Image = Properties.Resources.darkenedLivingRoom;
                    break;
                case 4:
                    if (lightParentsRoom)
                        pictureRoom.Image = Properties.Resources.parentsRoomOn;
                    else
                        pictureRoom.Image = Properties.Resources.parentsRoomOff;
                    break;
                case 5:
                    if (lightChildrenRoom)
                        pictureRoom.Image = Properties.Resources.childrenRoomOn;
                    else
                        pictureRoom.Image = Properties.Resources.childrenRoomOff;
                    break;
                case 6:
                    if (lightBathroom)
                        pictureRoom.Image = Properties.Resources.bathroomOn;
                    else
                        pictureRoom.Image = Properties.Resources.bathroomOn;
                    break;
            }
                

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
