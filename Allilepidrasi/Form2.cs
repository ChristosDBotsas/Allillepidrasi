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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = $"{trackBar2.Value}°C";
            Global.TempratureDegrees = trackBar2.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Form1_Load(sender, e);
            form1.Show();
            Hide();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.TempratureSetting = comboBox2.SelectedIndex;
            switch (comboBox2.Items[comboBox2.SelectedIndex].ToString())
            {
                case "Θέρμανση":
                    pictureBox1.Image = Properties.Resources.Heating;
                    Global.TempratureImage = Properties.Resources.Heating;
                    break;
                case "Ψύξη":
                    pictureBox1.Image = Properties.Resources.Cooling;
                    Global.TempratureImage = Properties.Resources.Cooling;
                    break;
                default:
                    break;
            }
        }
    }
}
