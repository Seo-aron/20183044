using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08
{
    public partial class LableTextFont : Form
    {
        public LableTextFont()
        {
            InitializeComponent();
        }

        private void RG_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoExample;
            string btn;

            btn = ((RadioButton)sender).Name; // 무슨 버튼이 눌러졌는지 확인

            switch (btn)
            {
                case "radioButton1":
                    label3.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case "radioButton2":
                    label3.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case "radioButton3":
                    label3.TextAlign = ContentAlignment.MiddleRight;
                    break;
            }
        }
        private void CB_ClickedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;           

            if (checkBox1.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (checkBox2.Checked == true)
            {

                style |= FontStyle.Underline;
            }
            if (checkBox3.Checked == true)
            {
                style |= FontStyle.Italic;
            }
            if (checkBox4.Checked == true)
            {
                style |= FontStyle.Strikeout;
            }
            label3.Font = new Font(label3.Font.Name, 10, style);
        }
    }
}
 
