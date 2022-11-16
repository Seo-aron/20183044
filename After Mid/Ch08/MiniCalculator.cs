using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chapter08
{
    public partial class MiniCalculator : Form
    {
        double num1, num2, rev = 0;

        public MiniCalculator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) // 더하기
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            rev = num1 + num2;
            textBox3.Text = rev.ToString(); // 계산값 출력
        }

        private void button2_Click(object sender, EventArgs e) // 빼기
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            rev = num1 - num2;
            textBox3.Text = rev.ToString(); // 계산값 출력
        }
        private void button3_Click(object sender, EventArgs e) // 곱하기
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            rev = num1 * num2;
            textBox3.Text = rev.ToString(); // 계산값 출력
        }
        private void button4_Click(object sender, EventArgs e) // 나누기
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            rev = num1 / num2;
            textBox3.Text = rev.ToString(); // 계산값 출력
        }

        private void button5_Click(object sender, EventArgs e) // 퍼센트
        {
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            rev = num1 % num2;
            textBox3.Text = rev.ToString(); // 계산값 출력
        }
    }
}
