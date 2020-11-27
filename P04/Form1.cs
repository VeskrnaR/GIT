using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.SelectedItem.ToString();
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = int.Parse(comboBox1.SelectedItem.ToString());
            int moc = 1;
            for(int i=0;i<x;i++)
            {
                moc *= a;
            }
            textBox1.Text= moc.ToString();
            moc = 1;
            for (int i = 0; i < x; i++)
            {
                moc *= b;
            }
            textBox2.Text = moc.ToString();
            moc = 1;
            for (int i = 0; i < x; i++)
            {
                moc *= c;
            }
            textBox3.Text = moc.ToString();
        }
    }
}
