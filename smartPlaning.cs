using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class smartPlaning : Form
    {
        Random random;
        int count=0;

        RichTextBox dynamicRichTextBox;
        bool didHeOrSheClick = false;

        int place1x=0;
        int place1y=0;
        int place2x=0;
        int place2y=0;
        int place3x=0;
        int place3y=0;

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
            random = new Random();
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
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Δεν έχετε συμπληρώσει κάτι.");
                return;
            }
                

            if (!richTextBox1.Text.Contains("στις"))
            {
                MessageBox.Show("Δεν αναγνωρίζουμε το σωστό φορμάτ.");
                return;
            }


            // to parakatw snippet pairnei ta merh pou exeis valei kai ta spaei mexri na sylle3ei 
            // to katallhlo string pou einai to meros pou 8elei na paei o xrhsths.
            List<string> places = new List<string>();
            try
            {
                String[] temp = richTextBox1.Text.Trim().Split("\n");
                // τσεκαρει αν εχει βαλει πανω απο τρία.
                if (temp.Length>3)
                {
                    MessageBox.Show("Το μάξιμουμ που μπορούμε να υποστηρίξουμε μέχρι στιγμής είναι 3 μέρη στο πλάνο");
                    return;
                }

                foreach (String placeHour in temp)
                {
                    String[] temp2=placeHour.Split("στις");
                    places.Add(temp2[0]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (comboBox1.Visible==true&&comboBox1.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Πρέπει να διαλέξεις μεταφορικό μέσο.");
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
                dynamicRichTextBox.Text = "Πώς θα γίνει η μετάβαση για "+places[0].Trim()+";";
                richTextBox1.Hide();
                Controls.Add(dynamicRichTextBox);
                button1.Text = "Επόμενο";
            }
            else if (count == 2)
            {                
                comboBox1.Visible = false;
                dynamicRichTextBox.Text = "Επέλεξε τοποθεσία.";
                pictureBox3.Visible = true;
                button1.Text = "Αποστολή";
                // ama einai mono ena meros pros8ese gia na paei sto proteleftaio vhma
                if (places.Count==1)
                    count +=4;
            }
            else if (count == 3)
            {
                // ama den exei epile3ei topo8esia gyrna sthn arxh
                if (!didHeOrSheClick)
                {
                    MessageBox.Show("Δεν επέλεξες τοποθεσία.");
                    count = 2;
                    return;
                }
                didHeOrSheClick = false;
                comboBox1.Visible = true;
                dynamicRichTextBox.Text = "Πώς θα γίνει η μετάβαση για " + places[1].Trim() + ";";
                button1.Text = "Επόμενο";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                paintInBackColor();
            }
            else if (count == 4)
            {
                comboBox1.Visible = false;
                dynamicRichTextBox.Text = "Επέλεξε τοποθεσία.";
                pictureBox3.Visible = true;
                button1.Text = "Αποστολή";
                //// ama einai mono dyo merh pros8ese gia na paei sto proteleftaio vhma
                if (places.Count == 2)
                    count += 2;
            }
            else if (count==5)
            {
                // ama den exei epile3ei topo8esia gyrna sthn arxh
                if (!didHeOrSheClick)
                {
                    MessageBox.Show("Δεν επέλεξες τοποθεσία.");
                    count = 4;
                    return;
                }
                didHeOrSheClick = false;
                comboBox1.Visible = true;
                dynamicRichTextBox.Text = "Πώς θέλετε να πάτε για " + places[2].Trim() + ";";
                button1.Text = "Επόμενο";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                paintInBackColor();
            }
            else if (count == 6)
            {
                comboBox1.Visible = false;
                dynamicRichTextBox.Text = "Επέλεξε τοποθεσία.";
                button1.Text = "Αποστολή";
                pictureBox3.Visible = true;
            }else if (count==7)
            {
                // ama den exei epile3ei topo8esia gyrna sthn arxh
                if (!didHeOrSheClick)
                {
                    MessageBox.Show("Δεν επέλεξες τοποθεσία.");
                    count = 6;
                    return;
                }
                pictureBox3.Visible = false;
                dynamicRichTextBox.Text = "Παρακαλώ, δώστε μας σημειώσεις ή οποιοδήποτε περιορισμούς έχετε στο ταξίδι σας.\n\n" +
                    "πχ αν χρειαστείτε καφέ και τι ώρα, τι ώρα θα πρέπει να επιστρέψετε απο τα διάφορα μέρη.";
                button1.Text = "Επομένο";
                paintInBackColor();
            }else if (count==8)
            {
                dynamicRichTextBox.Text = "Πχ. Θέλω καφέ στις 4 και θέλω να επιστρέψω όσο τον δυνατόν γρηγορότερα από το Χ μέρος.";
                dynamicRichTextBox.ReadOnly = false;
                dynamicRichTextBox.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                dynamicRichTextBox.GotFocus += RemoveText;
                dynamicRichTextBox.LostFocus += AddText;
                button1.Text = "Αποστολή";
            }
            else if (count == 9)
            {
                dynamicRichTextBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                dynamicRichTextBox.ReadOnly = true;
                dynamicRichTextBox.Text = "Αυτός είναι ο πιο γρήγορος δρόμος για να εκτελέσετε τα παραπάνω.";
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                //label5.Visible = false;
              //  label4.Visible = false;
                button1.Text = "Επόμενο";
                pictureBox8.Visible = true;
                label4.Visible = false;
                label5.Visible = true;
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                showDynamicCloud(myBrush);
                myBrush.Dispose();
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
            if (count == 9)
            {
                return;
            }
            label4.Visible = true;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            showDynamicCloud(myBrush);
            myBrush.Dispose();
            pictureBox2.Visible = true;
        }

        private void paintInBackColor()
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(BackColor);
            showDynamicCloud(myBrush);
            myBrush.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // metavlhth gia na dei an klikarei.
            didHeOrSheClick = true;

            paintInBackColor();
            pictureBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            // edw apo8hkevei ta merh gia na t dei3ei ston xarth.
            //Den einai functional afou an epile3ei mono 1 meros o xrhsths den 8a exei xrhsimopoih8ei h 2h metavlhth pixi 
            if (count == 2)
            {
                place1x = e.X;
                place1y = e.Y;
            }
            else if (count==4)
            {
                place2x = e.X;
                place2y = e.Y;
            }
            else if (count==6)
            {
                place3x = e.X;
                place3y = e.Y;
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics gf = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);
            GraphicsPath capPath = new GraphicsPath();
            
            // ama epile3ei mono 1 meros, 2 merh, 3 merh ktl.
            if (place2x==0&&place3x==0)
                gf.DrawLine(pen, random.Next(1,268), random.Next(1,138), place1x, place1y);
            else if (place3x==0)
            {
                gf.DrawLine(pen, random.Next(1, 268), random.Next(1, 138), place1x, place1y);
                gf.DrawLine(pen, place1x, place1y, place2x, place2y);
            }
            else 
            {
                gf.DrawLine(pen, random.Next(1, 268), random.Next(1, 138), place1x, place1y);
                gf.DrawLine(pen, place1x, place1y, place2x, place2y);
                gf.DrawLine(pen, place2x, place2y, place3x, place3y);
            }
            /*
              // h diadromh allazei ka8e fora.
            int secondPointX = random.Next(204, 254);
            int secondPointY = random.Next(89, 127);
            gf.DrawLine(pen, random.Next(98, 153), random.Next(87, 123), secondPointX, secondPointY);
            gf.DrawLine(pen, secondPointX, secondPointY, random.Next(193, 251), random.Next(7, 47));
            */
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            /*
            pictureBox8.Visible = false;
            paintInBackColor();
            label5.Visible = false;
            */
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        public void RemoveText(object sender,EventArgs e)
        {
            if (dynamicRichTextBox.Text == "Πχ. Θέλω καφέ στις 4 και θέλω να επιστρέψω όσο τον δυνατόν γρηγορότερα από το Χ μέρος.")
            {
                dynamicRichTextBox.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                dynamicRichTextBox.Text = "";
            }
 
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dynamicRichTextBox.Text))
                dynamicRichTextBox.Text= "Πχ. Θέλω καφέ στις 4 και θέλω να επιστρέψω όσο τον δυνατόν γρηγορότερα από το Χ μέρος.";
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
