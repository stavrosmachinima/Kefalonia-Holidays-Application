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
        int count = 0;
        bool changeDirection=false;
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
            if (soundPlayer.doYouHearMusic)
            {
                pictureBox21.Visible = true;
                pictureBox20.Visible = false;
            }
            else
            {
                pictureBox21.Visible = false;
                pictureBox20.Visible = true;
            }
            timer1.Enabled = true;
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
            
            if (count==0)
            {
                timer1.Enabled = false;
                pictureBox24.Visible = false;
                pictureBox19.Image = Properties.Resources.delivery;
                pictureBox19.Visible = false;
                count++;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox6.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                label2.Visible = true;
            }
            else if (count == 1)
            {
                label1.Text = "Safe Online Delivery";
                int redMeats = int.Parse(textBox1.Text);
                int lettuces = int.Parse(textBox3.Text);
                int apples = int.Parse(textBox2.Text);
                int yoghurt = int.Parse(textBox4.Text);
                int milk = int.Parse(textBox5.Text);
                int iceCream = int.Parse(textBox6.Text);
                double total = redMeats * 2.1 + lettuces * 0.5 + apples * 0.2 + yoghurt * 3 + milk * 1.2 + iceCream * 3.4;
                if (total <= 0)
                {
                    MessageBox.Show("You have to order something to move on.");
                    return;
                }
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox1.Visible = false;
                pictureBox6.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
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
              //  button1.Visible = false;
               // button2.Visible = true;
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
                label2.Text = "Card Details";
                button1.Text = "Submit";
                textBox7.Text = total.ToString() + " €";
                count++;
            }
            else
            {
                if (!String.IsNullOrEmpty(textBox7.Text) && !String.IsNullOrEmpty(textBox8.Text) && !String.IsNullOrEmpty(textBox9.Text)
                 && !String.IsNullOrEmpty(textBox10.Text) && !String.IsNullOrEmpty(textBox11.Text) && !String.IsNullOrEmpty(textBox12.Text))
                {
                    if (textBox8.Text.Length != 19||textBox9.Text.Length!=3||textBox11.Text.Length!=2||textBox12.Text.Length!=2)
                    {
                        MessageBox.Show("You didn't enter your information correctly.");
                        return;
                    }
                        
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
                    label2.Visible = false;
                    button1.Visible = false;
                }
                else
                {
                    MessageBox.Show("You should fill all information to move on.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Play();
            soundPlayer.doYouHearMusic = true;
            pictureBox20.Visible = false;
            pictureBox21.Visible = true;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            soundPlayer.soundVariable.Stop();
            soundPlayer.doYouHearMusic = false;
            pictureBox21.Visible = false;
            pictureBox20.Visible = true;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\..\..\bestHelpInTown.chm", HelpNavigator.TopicId, "50");
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed.");
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed.");
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only two digits are allowed.");
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only text is allowed.");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed.");
            }

            // oxi backspace

            if (e.KeyChar == (char)Keys.Back)
            {
                textBox8.Text = "";
                return;
            }

            // ka8e 4 pros8etei keno
            String cardNumber = textBox8.Text;
            if (cardNumber.Length > 0 && cardNumber.Length <19)
            {
                String temp = cardNumber.Replace(" ", "");

                if (temp.Length % 4 == 0)
                {
                    cardNumber = cardNumber + " ";
                    textBox8.Text = cardNumber;
                    textBox8.Focus();
                    textBox8.SelectionStart = textBox8.Text.Length;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int new_x;
            // o kwdikas animation einai edw.

            if (!changeDirection)
            {
                pictureBox24.Image = Properties.Resources.cartIcon;
                new_x = pictureBox24.Location.X + 1;
                pictureBox24.Location = new Point(new_x, pictureBox24.Location.Y);
                if (pictureBox24.Location.X >= 106)
                    changeDirection = true;
            }
            else
            {
                pictureBox24.Image = Properties.Resources.cartInverted;
                new_x = pictureBox24.Location.X-1;
                pictureBox24.Location = new Point(new_x, pictureBox24.Location.Y);
                if (pictureBox24.Location.X<= 1)
                    changeDirection = false;
            }
                

        }
    }
}
