using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07
{
    public partial class PromptCloseApp : Form
    {
        public PromptCloseApp()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false; // 예 선택시 창 닫음
            else
                e.Cancel = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); // FormClosing과 FormClosed 발생
        }
    }
}

