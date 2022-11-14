using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08
{
    public partial class event_method_sharing : Form
    {
        public event_method_sharing()
        {
            InitializeComponent();
        }

        private void RG_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoExample;
            string buttonName;

            // 어떤 버튼이 눌러 졌는지 검사
            rdoExample = (RadioButton)sender;
            buttonName = rdoExample.Name;

            switch (buttonName)
            {
                case "radioButton1":
                    label1.Text = radioButton1.Text;
                    break;
                case "radioButton2":
                    label1.Text = radioButton2.Text;
                    break;
                case "radioButton3":
                    label1.Text = radioButton3.Text;
                    break;
                case "radioButton4":
                    label1.Text = radioButton4.Text;
                    break;
                default:
                    label1.Text = radioButton1.Text;
                    break;
            }

        }
    }
}
