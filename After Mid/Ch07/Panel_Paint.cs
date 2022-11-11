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
    public partial class Panel_Paint : Form
    {
        public Panel_Paint()
        {
            InitializeComponent();
        }

        private void Panel_Paint_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)); // 0~255의 난수 생성
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle); // 사각형 내부 색 채움
        }

    }
}
