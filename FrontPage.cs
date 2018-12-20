using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagement
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
