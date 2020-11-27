using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            double soucet, arit;
            soucet = a + b + c;
            arit = soucet / 3;
            MessageBox.Show("Aritmetický průměr je: " + arit.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
            label2.Text = listBox1.SelectedItem.ToString();
            label3.Text = listBox1.SelectedItem.ToString();
        }
    }
}
