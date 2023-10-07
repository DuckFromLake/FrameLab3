using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameLab3
{
    public partial class Form2 : Form
    {
        double sum = 0;
        static double func(int x)
        {
            double S = Math.Sqrt(2*Math.Pow(2, x - 2)*(8 - x) - 1);
            return S;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                sum += func(i);
            }
            string st = Convert.ToString(sum);
            label2.Text = st;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
