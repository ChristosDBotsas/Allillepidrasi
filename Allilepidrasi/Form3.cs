using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allilepidrasi
{
    public partial class Form3 : Form
    {
        private bool IsDark1 = false, IsDark2 = false, IsDark3 = false, IsDark4 = false;
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {

        }

        private void picturebox1_Click(object sender, EventArgs e)
        {
            if (!IsDark1)
            {
                IsDark1 = true;
                pictureBox1.Image = Properties.Resources.bathroomDark;
            }
            else if (IsDark1)
            {
                IsDark1 = false;
                pictureBox1.Image = Properties.Resources.bathroom;
            }
        }

        private void picturebox2_Click(object sender, EventArgs e)
        {
            if (!IsDark2)
            {
                IsDark2 = true;
                pictureBox2.Image = Properties.Resources.bedroomDark;
            }
                
            else if (IsDark2)
            {
                pictureBox2.Image = Properties.Resources.bedroom;
                IsDark2 = false;
            }
        }

        private void picturebox3_Click(object sender, EventArgs e)
        {
            if (!IsDark3)
            {
                pictureBox3.Image = Properties.Resources.kitchenDark;
                IsDark3 = true;
            }
            else if (IsDark3)
            {
                pictureBox3.Image = Properties.Resources.kitchen;
                IsDark3 = false;
            }
        }

        private void picturebox4_Click(object sender, EventArgs e)
        {
            if (!IsDark4)
            {
                pictureBox4.Image = Properties.Resources.livingroomDark;
                IsDark4 = true;
            }

            else if (IsDark4)
            {
                pictureBox4.Image = Properties.Resources.livingroom;
                IsDark4 = false;
            }
        }
    }
}
