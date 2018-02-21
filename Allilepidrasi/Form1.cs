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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Form2_Load(sender, e);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Form3_Load(sender, e);
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Form4_Load(sender, e);
            form4.Show();
        }
    }
}
