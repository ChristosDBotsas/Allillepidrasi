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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Items[comboBox1.SelectedIndex])
            {
                case "Καθημερινό":
                    pictureBox2.Image = Properties.Resources.hoodie;
                    pictureBox3.Image = Properties.Resources.jeans;
                    pictureBox4.Image = Properties.Resources.sneakers;
                    break;
                case "Επίσημο":
                    pictureBox2.Image = Properties.Resources.Tuxedo;
                    pictureBox3.Image = Properties.Resources.TuxedoPants;
                    pictureBox4.Image = Properties.Resources.DressShoes;
                    break;
                case "Εκδρομή":
                    pictureBox2.Image = Properties.Resources.Tribaloski;
                    pictureBox3.Image = Properties.Resources.Sweatpants;
                    pictureBox4.Image = Properties.Resources.Boots;
                    break;
                default:
                    break;
            }
        }
    }
}
