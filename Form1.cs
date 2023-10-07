using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameLab3
{
    public partial class Form1 : Form
    {
        double eps, S, part;
        int k = 0;

        static long Fact(int number)
        {
            long fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eps = Convert.ToDouble(textBox1.Text);
            S = 1;
            part = 1;
            k = 2;
            while (part > eps)
            {
                part = (1 / (Math.Sqrt(Fact(k))));
                S += part;
                k++;
            }
            string st = Convert.ToString(S);
            label3.Text = st;
        }
    }
}
