using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8 {
    public partial class DrawLineEx : Form {
        public DrawLineEx()
        {
            InitializeComponent();
        }

        private void DrawLineEx_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black);
            Point startPoint = new Point(45, 45);
            Point endPoint = new Point(180, 150);
            g.DrawLine(p, startPoint, endPoint);
            g.DrawLine(p, new Point(190, 60), new Point(65, 170));
            p.Dispose();
        }
    }
}
