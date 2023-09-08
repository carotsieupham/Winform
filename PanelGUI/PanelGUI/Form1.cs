using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Hello";
            btn.AutoSize = true;
            Random random = new Random();
            btn.Location = new Point(random.Next(0,panel1.Size.Width), random.Next(0,panel1.Height));
            panel1.Controls.Add(btn);
        }

        
    }
}
