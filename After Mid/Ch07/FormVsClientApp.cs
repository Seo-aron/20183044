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
    public partial class FormVsClientApp : Form
    {
        public FormVsClientApp()
        {
            InitializeComponent();
        }
        private void SetButtonText() // 사용자 정의 메소드
        {
            button1.Text = "Form.FormBorderStyle = " + FormBorderStyle.ToString() + "\n" +
            "Form.Size = " + Size.ToString() + "\n" +
            "Form.ClientSize = " + ClientSize.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.SizableToolWindow) // Sizable 크기를 조정할 수 있는 테두리
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle++; // 보드스타일(Size만) 변경
            SetButtonText();

        }

        private void FormVsClientApp_Load(object sender, EventArgs e)
        {
            SetButtonText();
        }
    }
}
