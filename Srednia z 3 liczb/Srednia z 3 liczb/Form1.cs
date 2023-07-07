using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srednia_z_3_liczb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double srednia;
            double number;
            if (double.TryParse(textBox1.Text, out number))
                a = number; else a = 0;
            if (double.TryParse(textBox2.Text, out number))
                b = number; else b = 0;
            if (double.TryParse(textBox3.Text, out number))
                c = number; else c = 0;
            srednia = (a + b + c) / 3.0;
            textBox4.Text = srednia.ToString();
            MessageBox.Show("Wynik: " + srednia.ToString(), "Srednia z 3 liczb");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "";        }
    }
}
