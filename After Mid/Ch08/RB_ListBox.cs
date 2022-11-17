using System;
using System.Windows.Forms;

namespace Chapter08
{
    public partial class UpdateItems : Form
    {
        public UpdateItems()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // 버튼 기반
        {
            if (radioButton1.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("버튼");
                listBox1.Items.Add("체크 상자");
                listBox1.Items.Add("라디오 버튼");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // 리스트 기반
        {
            if (radioButton2.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("리스트 상자");
                listBox1.Items.Add("콤보 상자");
                listBox1.Items.Add("체크 리스트 상자");
            }
        }
    }
}
