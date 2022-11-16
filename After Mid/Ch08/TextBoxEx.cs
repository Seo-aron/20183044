using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08
{
    public partial class TextBoxEx : Form
    {
        public TextBoxEx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Name: " + textBox1.Text + "\r\nPassword: " + textBox2.Text;
        }
    }
}
