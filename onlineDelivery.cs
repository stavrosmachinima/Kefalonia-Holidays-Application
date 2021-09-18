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

        private void onlineDelivery_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int food = int.Parse(textBox1.Text);
            food++;
            textBox1.Text = food.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text)>0)
            {
                int food = int.Parse(textBox1.Text);
                food--;
                textBox1.Text = food.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int food = int.Parse(textBox2.Text);
            food++;
            textBox2.Text = food.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) > 0)
            {
                int food = int.Parse(textBox2.Text);
                food--;
                textBox2.Text = food.ToString();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int food = int.Parse(textBox3.Text);
            food++;
            textBox3.Text = food.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox3.Text) > 0)
            {
                int food = int.Parse(textBox3.Text);
                food--;
                textBox3.Text = food.ToString();
            }
        }


        private void pictureBox16_Click(object sender, EventArgs e)
        {
            int food = int.Parse(textBox4.Text);
            food++;
            textBox4.Text = food.ToString();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox4.Text) > 0)
            {
                int food = int.Parse(textBox4.Text);
                food--;
                textBox4.Text = food.ToString();
            }
               
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            int food = int.Parse(textBox5.Text);
            food++;
            textBox5.Text = food.ToString();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox5.Text) > 0)
            {
                int food = int.Parse(textBox5.Text);
                food--;
                textBox5.Text = food.ToString();
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {   
                int food = int.Parse(textBox6.Text);
                food++;
                textBox6.Text = food.ToString();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox6.Text) > 0)
            {
                int food = int.Parse(textBox6.Text);
                food--;
                textBox6.Text = food.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int redMeats = int.Parse(textBox1.Text);
            int lettuces = int.Parse(textBox3.Text);
            int apples = int.Parse(textBox2.Text);
            int yoghurt = int.Parse(textBox4.Text);
            int milk = int.Parse(textBox5.Text);
            int iceCream = int.Parse(textBox6.Text);
            double total = redMeats * 2.1 + lettuces * 0.5 + apples * 0.2 + yoghurt * 3 + milk * 1.2 + iceCream * 3.4;
            if (total > 0)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox1.Visible = false;
                pictureBox6.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                button1.Visible = false;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                button2.Visible = true;
                textBox7.Text = total.ToString() + " €";
            }
            else
                MessageBox.Show("You have to order something to move on.");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox7.Text)&& !String.IsNullOrEmpty(textBox8.Text) && !String.IsNullOrEmpty(textBox9.Text)
                 && !String.IsNullOrEmpty(textBox10.Text) && !String.IsNullOrEmpty(textBox11.Text) && !String.IsNullOrEmpty(textBox12.Text))
            {
                MessageBox.Show("You should expect your delivery soon.");
                label14.Visible = true;
                pictureBox19.Visible = true;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false; ;
                label13.Visible = false;
                button2.Visible = false;
            }
            else
            {
                MessageBox.Show("You should fill all information to move on.");
            }
            
        }
    }
}
