using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Project_empty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Rezultat(int x, int y)
        {
            int c;
            c = x;
            return c;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float a;
            float.TryParse(textBox1.Text, out a);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float b;
            float.TryParse(textBox2.Text, out b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a=0;
            float b=0;
            float c=0;
            c = a + b;
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Text = button1.ToString();
        }
    }
}
