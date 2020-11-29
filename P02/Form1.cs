using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random xd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int cisla = xd.Next(0, 11);
                listBox1.Items.Add(cisla);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soucet = 0;
            foreach(int nwm in listBox1.SelectedItems)
            {
                soucet = soucet + nwm;
            }
            label1.Text = "Počet: " + listBox1.SelectedItems.Count.ToString();
            label2.Text = "Soucet: " + soucet.ToString();
        }
    }
}
