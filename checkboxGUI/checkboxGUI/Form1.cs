using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkboxGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Checked");

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckState");

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string isRobot = checkBox1.CheckState == CheckState.Checked ? "Khong phai la " : checkBox1.CheckState == CheckState.Unchecked ? "la ":"phai cung khong phai";
            string showString = string.Format("Chao ban {0},ban {1} robot", name, isRobot);
            MessageBox.Show(showString);
        }
    }
}
