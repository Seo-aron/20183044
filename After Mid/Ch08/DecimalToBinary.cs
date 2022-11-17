using System;
using System.Windows.Forms;

namespace Chapter08
{
    public partial class DecimalToBinary : Form
    {
        int num = 0;
        public DecimalToBinary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            num = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(num, 2);
        }
    }
}
