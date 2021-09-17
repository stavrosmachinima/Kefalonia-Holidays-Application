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
    }
}
