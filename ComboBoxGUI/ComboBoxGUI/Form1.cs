using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxGUI
{
    public partial class Form1 : Form
    {
        List<CBclass> listclass;
        public Form1()
        {
            InitializeComponent();
            listclass = new List<CBclass>();
            listclass.Add( new CBclass(){className="12A1",ListStudent= new List<string>() {"Trí","Bảo"} });
            listclass.Add(new CBclass() { className = "12A2", ListStudent = new List<string>() { "Nhi", "Khang" } });
            cbBranch.DataSource = listclass;
            cbBranch.DisplayMember = "className";
            AddClassBinđing();
        }
        List<food> listitme;
        private void button1_Click(object sender, EventArgs e)
        {
            listitme = new List<food>() 
            {
                new food (){Name = "Thịt ba rọi nướng",price = 10},
                new food (){Name = "Com Tam suon",price = 5},
                new food (){Name = "Suong bi cha",price = 20}
            };
            comboBox1.DataSource = listitme;
            comboBox1.DisplayMember= "Name";
            AddBinding();

        }
        void AddClassBinđing() 
        {
            cbClass.DataBindings.Add(new Binding("DataSource", cbBranch.DataSource, "ListStudent"));
        }
        void AddBinding()
        {
         textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "price")); 
                
        }
        private void comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //if(comboBox1.SelectedValue != null)
            //{
            //    food f = cb.SelectedValue as food;
            //    textBox1.Text = f.price.ToString();
            //}

        }
    }
    public class food
    {
        public string Name { get; set; }
        public float price { get; set; }
    }
    public class CBclass 
    { 
        public string className { get; set; }
        public List<string> ListStudent { get; set; }
    }
}
