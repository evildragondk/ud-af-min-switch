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
        priser prise = new priser();

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

        private void Click_her_Click(object sender, EventArgs e)
        {
            //bygge_selv_pazzer openForm = new bygge_selv_pazzer();
            //     openForm.Show();
            //this.Hide();
        }

        private void lillepepsiBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 40).ToString() + "kr";
        }

        private void lillemonsterBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 30).ToString() + "kr";
        }

        private void lilleløBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 35).ToString() + "kr";
        }

        private void NormalpepsiBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 55).ToString() + "kr";
        }

        private void NormalmonsterBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 45).ToString() + "kr";
        }

        private void NormalløBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 50).ToString() + "kr";
        }

        private void storpepsiBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 70).ToString() + "kr";
        }

        private void stormonsterBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 60).ToString() + "kr";
        }

        private void storløBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise.prise += 65).ToString() + "kr";
        }

        private void NormalpirseBox1_CheckedChanged(object sender, EventArgs e)
        {
            prise.FlerePenge("Normal", penge);
        }

        private void NormalpirseBox2_CheckedChanged(object sender, EventArgs e)
        {
            prise.FlerePenge("Normal", penge);
        }

        private void NormalpirseBox3_CheckedChanged(object sender, EventArgs e)
        {
            prise.FlerePenge("Normal", penge);
        }

        private void storpirseBox1_CheckedChanged(object sender, EventArgs e)
        {
            prise.FlerePenge("stor", penge);
        }

        private void storpirseBox2_CheckedChanged(object sender, EventArgs e)
        {
            prise.FlerePenge("stor", penge);
        }

        private void storpirseBox3_CheckedChanged(object sender, EventArgs e)
        {
            prise.FlerePenge("stor", penge);
        }
    }
}
