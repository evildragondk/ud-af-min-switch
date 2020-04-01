using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzeria
{
    public partial class Form1 : Form
    {
        int prise = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void betale_Click(object sender, EventArgs e)
        {
            penge.Text = "Tak for dit købe";
        }

        private void NormalpirseBox1_CheckedChanged(object sender, EventArgs e)
        {
           penge.Text = (prise += 70).ToString()+ "kr";
        }
        private void storpirseBox1_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 100).ToString() + "kr";
        }

        private void NormalpirseBox2_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 70).ToString() + "kr";
        }
        private void storpirseBox2_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 100).ToString() + "kr";
        }

        private void NormalpirseBox3_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 70).ToString() + "kr";
        }

        private void storpirseBox3_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 100).ToString() + "kr";
        }
    }
}
