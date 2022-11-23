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
            Point[] pts = { new Point(40, 40), new Point(180, 40),
                new Point(180, 180), new Point(40, 180),new Point(40, 60), 
                new Point(160, 60),new Point(160, 160), new Point(60, 160),
                new Point(60, 80), new Point(140, 80),new Point(140, 140), 
                new Point(80, 140),new Point(80, 100), new Point(120, 100),
                new Point(120, 120), new Point(100, 120)
        };
            g.DrawLines(new Pen(Color.BlueViolet), pts); // DrawLines => 점 배열 사이를 연결하는 선 
        }
    }
}
