using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiobtnGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void showresult(Label lb,Panel p)
        {
            RadioButton rbtn = null;
            foreach(RadioButton item in p.Controls)
            {
                if (item.Checked)
                {
                    rbtn = item;
                    break;
                }
                
            }
            if (rbtn != null)
            {
                lb.Text = rbtn.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showresult(label1, pnl1);
            showresult(label2, pnl2);
            showresult(label3, pnl3);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb= sender as RadioButton;
            if(rb.Checked)
            {
                label1.Text= rb.Text;
            }
        }
    }
}
