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
            if (count==1)
            {
                createDynamicRichTextBox();
                richTextBox1.Hide();
                Controls.Add(dynamicRichTextBox);
                button1.Text = "Next";
            }
            else if (count==2)
            {
                dynamicRichTextBox.Text = "Με τον ηλεκτρικό.";
                button1.Text = "Αποστολή";
            }
            else if (count==3)
            {
                dynamicRichTextBox.Text = "Πώς θέλετε να πάτε στο Super?";
                
            }
            
        }

        private void createDynamicRichTextBox()
        {
            dynamicRichTextBox = new RichTextBox();
            dynamicRichTextBox.Location = new Point(509, 129);
            dynamicRichTextBox.Width = 204;
            dynamicRichTextBox.Height = 160;
            dynamicRichTextBox.Text = "Πώς θα γίνει  η μετάβαση στη Δουλειά, με τον ηλεκτρικό, με αυτοκίνητο, με λεωφορεία, με ποδήλατο, με τα πόδια, με συνδυασμό; ";
            dynamicRichTextBox.Name = "DynamicRichTextBox";
            dynamicRichTextBox.Font = new Font("Segoe UI", 12);
        }
       
    }
}
