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
    public partial class smartPlaning : Form
    {
        int count=0;

        RichTextBox dynamicRichTextBox;
        public smartPlaning()
        {
            InitializeComponent();
        }

        private void smartPlaning_Load(object sender, EventArgs e)
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

        private void smartPlaning_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(450, 200, 40, 40));
            formGraphics.FillEllipse(myBrush, new Rectangle(410, 210, 25, 25));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                createDynamicRichTextBox();
                richTextBox1.Hide();
                Controls.Add(dynamicRichTextBox);
                button1.Text = "Επόμενο";
            }
            else if (count == 2)
            {
                dynamicRichTextBox.Text = "Επέλεξε μέρος και μεταφορικό μέσο.\n\nΜε τον ηλεκτρικό.";
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                label4.Visible = true;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(748, 186, 20, 20));
                formGraphics.FillEllipse(myBrush, new Rectangle(785, 180, 30, 30));
                button1.Text = "Αποστολή";
                myBrush.Dispose();
                formGraphics.Dispose();
            }
            else if (count == 3)
            {
                dynamicRichTextBox.Text = "Πώς θέλετε να πάτε στο Super και σε ποιο super;";
                button1.Text = "Επόμενο";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(BackColor);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(748, 186, 20, 20));
                formGraphics.FillEllipse(myBrush, new Rectangle(785, 180, 30, 30));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
            else if (count == 4)
            {
                dynamicRichTextBox.Text = "Επέλεξε μέρος και μεταφορικό μέσο.\n\nΜε το αυτοκίνητο.";
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                label4.Visible = true;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(748, 186, 20, 20));
                formGraphics.FillEllipse(myBrush, new Rectangle(785, 180, 30, 30));
                button1.Text = "Αποστολή";
                myBrush.Dispose();
                formGraphics.Dispose();

            }
            else if (count==5)
            {
                dynamicRichTextBox.Text = "Πώς θέλετε να πάτε για άθληση και που;";
                button1.Text = "Επόμενο";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(BackColor);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(748, 186, 20, 20));
                formGraphics.FillEllipse(myBrush, new Rectangle(785, 180, 30, 30));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
            else if (count == 6)
            {
                dynamicRichTextBox.Text = "Επέλεξε μέρος και μεταφορικό μέσο.\n\nΜε τα πόδια.";
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                label4.Visible = true;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(748, 186, 20, 20));
                formGraphics.FillEllipse(myBrush, new Rectangle(785, 180, 30, 30));
                button1.Text = "Αποστολή";
                myBrush.Dispose();
                formGraphics.Dispose();
            }
            else if (count == 7)
            {
                dynamicRichTextBox.Text = "Αυτός είναι ο πιο γρήγορος δρόμος για να εκτελέσετε τα παραπάνω.";
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                label5.Visible = true;
                label4.Visible = false;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(748, 186, 20, 20));
                formGraphics.FillEllipse(myBrush, new Rectangle(785, 180, 30, 30));
                myBrush.Dispose();
                formGraphics.Dispose();
                button1.Text = "Επόμενο";
            }
            else
            {
                dynamicRichTextBox.Text = "Θα αποθηκεύσουμε τις πληροφορίες σας για να γίνει πιο γρήγορα την επόμενη φορά\n\nΕυχαριστούμε.";
                button1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(BackColor);
                System.Drawing.Graphics formGraphics;
                formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(myBrush, new Rectangle(748, 186, 20, 20));
                formGraphics.FillEllipse(myBrush, new Rectangle(785, 180, 30, 30));
                myBrush.Dispose();
                formGraphics.Dispose();
            }
     
            
        }

        private void createDynamicRichTextBox()
        {
            dynamicRichTextBox = new RichTextBox();
            dynamicRichTextBox.Location = new Point(509, 129);
            dynamicRichTextBox.Width = 232;
            dynamicRichTextBox.Height = 160;
            dynamicRichTextBox.Text = "Πώς θα γίνει  η μετάβαση στη Δουλειά, με τον ηλεκτρικό, με αυτοκίνητο, με λεωφορεία, με ποδήλατο, με τα πόδια, με συνδυασμό; ";
            dynamicRichTextBox.Name = "DynamicRichTextBox";
            dynamicRichTextBox.Font = new Font("Segoe UI", 12);
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
