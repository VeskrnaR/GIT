using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pismena = "++ .,MNBVCXY?!LKJHGFDSAPOIUZTREWQ";
            int i = 0;
            foreach(Control srandarna in panel1.Controls)
            {
                if (srandarna is Button)
                {
                    (srandarna as Button).Text = pismena[i].ToString();
                }
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = "";
                string text = textBox1.Text;
                foreach (char znak in text)
                {
                    int ascii = Convert.ToInt32(znak);
                    if (ascii >= 88 && ascii <= 90)
                        ascii -= 23;
                    else if (znak != '?' && znak != '!' && znak != ',' && znak != '.' && znak != ' ')
                    {
                        ascii += 3;
                    }
                    textBox2.Text += Convert.ToChar(ascii);
                }
            }
        }
    }
}
