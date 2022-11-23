using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp8 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Point[] pts = {
                new Point(ClientRectangle.Width/2, 0), // 윗쪽 포인트
                new Point(0, ClientRectangle.Height), // 왼쪽 포인트
                new Point(ClientRectangle.Width, ClientRectangle.Height) // 오른쪽 포인트
                };
            PathGradientBrush b = new PathGradientBrush(pts);
            g.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
    }
}
