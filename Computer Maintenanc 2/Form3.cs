using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Maintenanc_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newform = new Form4();
            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Form2();
            newform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
