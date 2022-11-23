using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8 {
    public partial class DrawArcEx : Form {
        public DrawArcEx()
        {
            InitializeComponent();
        }

        private void DrawArcEx_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillPie(Brushes.LightGreen, r, 45, 270);
            g.DrawPie(Pens.DarkGreen, r, 45, 270);
        }
    }
}
