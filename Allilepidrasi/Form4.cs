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
            Global.DressingOccasion = comboBox1.SelectedIndex;
            switch (comboBox1.Items[comboBox1.SelectedIndex])
            {
                case "Καθημερινό":
                    pictureBox2.Image = Properties.Resources.hoodie;
                    Global.DressingTopImage = Properties.Resources.hoodie;
                    pictureBox3.Image = Properties.Resources.jeans;
                    Global.DressingPantsImage = Properties.Resources.jeans;
                    pictureBox4.Image = Properties.Resources.sneakers;
                    Global.DressingShoesImage = Properties.Resources.sneakers;
                    break;
                case "Επίσημο":
                    pictureBox2.Image = Properties.Resources.Tuxedo;
                    Global.DressingTopImage = Properties.Resources.Tuxedo;
                    pictureBox3.Image = Properties.Resources.TuxedoPants;
                    Global.DressingPantsImage = Properties.Resources.TuxedoPants;
                    pictureBox4.Image = Properties.Resources.DressShoes;
                    Global.DressingShoesImage = Properties.Resources.DressShoes;
                    break;
                case "Εκδρομή":
                    pictureBox2.Image = Properties.Resources.Tribaloski;
                    Global.DressingTopImage = Properties.Resources.Tribaloski;
                    pictureBox3.Image = Properties.Resources.Sweatpants;
                    Global.DressingPantsImage = Properties.Resources.Sweatpants;
                    pictureBox4.Image = Properties.Resources.Boots;
                    Global.DressingShoesImage = Properties.Resources.Boots;
                    break;
                default:
                    break;
            }
        }
    }
}
