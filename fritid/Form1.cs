using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fritid
{
    public partial class Form1 : Form
    {
        int a, b, c;

        private void Muls_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(nummer1.Text);
            b = Convert.ToInt32(nummer2.Text);
            c = a - b;
            Total.Text = c.ToString();
        }

        private void Gang_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(nummer1.Text);
            b = Convert.ToInt32(nummer2.Text);
            c = a * b;
            Total.Text = c.ToString();
        }

        private void Dividere_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(nummer1.Text);
            b = Convert.ToInt32(nummer2.Text);
            c = a / b;
            Total.Text = c.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(nummer1.Text);
            b = Convert.ToInt32(nummer2.Text);
            c = a + b;
            Total.Text = c.ToString();
        }
    }
}
