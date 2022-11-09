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
    public partial class Button_Code : Form
    {
        public Button_Code()
        {
            InitializeComponent();

            Button button = new Button();
            Controls.Add(button);

            button.Location = new Point(250, 100); // (x, y)
            button.Text = "동적 생성";
            button.Width = 100;

            button.Click += Button_Click; // button.Clock += 까지 적은 뒤 Tab키 누르면 자동 완성
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("동적인 버튼 생성 확인 ");
        }

        private void Button_Code_Load(object sender, EventArgs e)
        {

        }
    }
}
