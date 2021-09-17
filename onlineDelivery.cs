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
    public partial class onlineDelivery : Form
    {
        public onlineDelivery()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            label3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label4.Visible = true;
        }
    }
}
