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
    public partial class Button_Time : Form
    {
        public Button_Time()
        {
            InitializeComponent();

            startDateTime = DateTime.Now; // 버튼 누르면 시간나오게 하게 추가함
        }
        DateTime startDateTime;

        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString());
        }
    }
}
