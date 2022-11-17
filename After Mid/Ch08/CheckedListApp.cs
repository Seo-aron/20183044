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
    public partial class CheckedListApp : Form
    {
        public CheckedListApp()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strTemp = " ";
            foreach (object obj in checkedListBox1.CheckedItems)
            {
                strTemp += obj.ToString();
                strTemp += " "; }
            MessageBox.Show("당신의 취미는" + strTemp + "입니다.");
        }
    }
}
