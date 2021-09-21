﻿using System;
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
            formGraphics.FillEllipse(myBrush, new Rectangle(380, 217, 15, 15));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] temp = richTextBox1.Text.Trim().Split("\n");
            /*
            String[temp.Length] array;
            foreach (String kappa in temp)
            {
                String[] array[0]=kappa.Split(" ")[0];
                MessageBox.Show(kappa);
            }*/

            if (comboBox1.Visible==true&&comboBox1.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Πρέπει να διαλέξεις μεταφορικό μέσο");
                return;
            }

            pictureBox7.Visible = false;
            richTextBox2.Visible = false;
            count++;
            if (count == 1)
            {
                button1.Location = new Point(639, 313);
                comboBox1.Visible = true;
                createDynamicRichTextBox();
                richTextBox1.Hide();
                Controls.Add(dynamicRichTextBox);
                button1.Text = "Επόμενο";
            }
            else if (count == 2)
            {                
                comboBox1.Visible = false;
                dynamicRichTextBox.Text = "Επέλεξε τοποθεσία. Έχουμε σημειώσει στον χάρτη τα κοντινότερα σημεία.";
                pictureBox3.Visible = true;
                button1.Text = "Αποστολή";
            }
            else if (count == 3)
            {
                comboBox1.Visible = true;
                dynamicRichTextBox.Text = "Πώς θέλετε να πάτε στο Super;";
                button1.Text = "Επόμενο";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                paintInBackColor();
            }
            else if (count == 4)
            {
                comboBox1.Visible = false;
                dynamicRichTextBox.Text = "Επέλεξε τοποθεσία. Έχουμε σημειώσει στον χάρτη τα κοντινότερα σημεία.";
                pictureBox3.Visible = true;
                button1.Text = "Αποστολή";
            }
            else if (count==5)
            {
                comboBox1.Visible = true;
                dynamicRichTextBox.Text = "Πώς θέλετε να πάτε για άθληση;";
                button1.Text = "Επόμενο";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                paintInBackColor();
            }
            else if (count == 6)
            {
                comboBox1.Visible = false;
                dynamicRichTextBox.Text = "Επέλεξε τοποθεσία. Έχουμε σημειώσει στον χάρτη τα κοντινότερα σημεία.";
                pictureBox3.Visible = true;
                button1.Text = "Αποστολή";
            }
            else if (count == 7)
            {
                dynamicRichTextBox.Text = "Αυτός είναι ο πιο γρήγορος δρόμος για να εκτελέσετε τα παραπάνω.";
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label5.Visible = false;
                label4.Visible = false;
                paintInBackColor();
                button1.Text = "Επόμενο";
            }
            else
            {
                dynamicRichTextBox.Text = "Θα αποθηκεύσουμε τις πληροφορίες σας για να γίνει πιο γρήγορα την επόμενη φορά\n\nΕυχαριστούμε.";
                button1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label5.Visible = false;
                paintInBackColor();
            }
        }

        private void createDynamicRichTextBox()
        {
            dynamicRichTextBox = new RichTextBox();
            dynamicRichTextBox.Location = new Point(509, 129);
            dynamicRichTextBox.ReadOnly = true;
            dynamicRichTextBox.Width = 251;
            dynamicRichTextBox.Height = 230;
            dynamicRichTextBox.Text = "Πώς θα γίνει η μετάβαση στη Δουλειά;";
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\..\..\bestHelpInTown.chm");
        }

       private void showDynamicCloud(System.Drawing.SolidBrush myBrush)
        {
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(767, 217, 20, 20));
            formGraphics.FillEllipse(myBrush, new Rectangle(795, 210, 30, 30));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //minimize
            if (pictureBox7.Location != new Point(512, 253))
            {
                richTextBox2.Visible = false;
                pictureBox7.Location = new Point(512, 253);
            }
            else
            {
                richTextBox2.Visible = true;
                pictureBox7.Location = new Point(648, 253);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            if (count==7)
            {
                label4.Visible = false;
                label5.Visible = true;
            }
            pictureBox2.Visible = true;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            showDynamicCloud(myBrush);
            myBrush.Dispose();

            /*
            pen = new Pen(Color.Black, 3);
            graphics = pictureBox2.CreateGraphics();
            graphics.DrawEllipse(pen, 849, 158, 20, 20);
            graphics.DrawEllipse(pen, 116, 35, 20, 20);
            graphics.DrawEllipse(pen, 65, 65, 20, 20);
            */
            pictureBox2.Invalidate();
        }

        private void paintInBackColor()
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(BackColor);
            showDynamicCloud(myBrush);
            myBrush.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            paintInBackColor();
            pictureBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString() + "," + e.Y.ToString());
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gf = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);
            gf.DrawEllipse(pen, 23, 13, 20, 20);
            gf.DrawEllipse(pen, 116, 35, 20, 20);
            gf.DrawEllipse(pen, 65, 65, 20, 20);
        }
    }
}
