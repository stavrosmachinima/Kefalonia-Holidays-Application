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
    public partial class smartHome : Form
    {
        public smartHome()
        {
            InitializeComponent();
        }

        private void smartHome_Load(object sender, EventArgs e)
        {

        }

        private void smartHome_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(650, 280, 40, 40));
            formGraphics.FillEllipse(myBrush, new Rectangle(620, 290, 25, 25));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
