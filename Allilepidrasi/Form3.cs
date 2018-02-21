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
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {

        }

        private void picturebox1_Click(object sender, EventArgs e)
        {
            if (!Global.IsBathroomDark)
            {
                Global.IsBathroomDark = true;
                pictureBox1.Image = Properties.Resources.bathroomDark;
            }
            else if (Global.IsBathroomDark)
            {
                Global.IsBathroomDark = false;
                pictureBox1.Image = Properties.Resources.bathroom;
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void picturebox2_Click(object sender, EventArgs e)
        {
            if (!Global.IsBedroomDark)
            {
                Global.IsBedroomDark = true;
                pictureBox2.Image = Properties.Resources.bedroomDark;
            }
                
            else if (Global.IsBedroomDark)
            {
                pictureBox2.Image = Properties.Resources.bedroom;
                Global.IsBedroomDark = false;
            }
        }

        private void picturebox3_Click(object sender, EventArgs e)
        {
            if (!Global.IsKitchenDark)
            {
                pictureBox3.Image = Properties.Resources.kitchenDark;
                Global.IsKitchenDark = true;
            }
            else if (Global.IsKitchenDark)
            {
                pictureBox3.Image = Properties.Resources.kitchen;
                Global.IsKitchenDark = false;
            }
        }

        private void picturebox4_Click(object sender, EventArgs e)
        {
            if (!Global.IsLivingRoomDark)
            {
                pictureBox4.Image = Properties.Resources.livingroomDark;
                Global.IsLivingRoomDark = true;
            }

            else if (Global.IsLivingRoomDark)
            {
                pictureBox4.Image = Properties.Resources.livingroom;
                Global.IsLivingRoomDark = false;
            }
        }
    }
}
