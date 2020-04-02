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
    public partial class bygge_selv_pazzer : Form
    {
        int prise = 0;

        public bygge_selv_pazzer()
        {
            InitializeComponent();
        }

        private void Tilbare_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
        }

        private void betal_Click(object sender, EventArgs e)
        {
            penge.Text = "Tak for dit købe";
        }

        private void dejBox1_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 40).ToString() + "kr";
        }

        private void dejBox2_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 50).ToString() + "kr";
        }

        private void dejBox3_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 65).ToString() + "kr";
        }

        private void OstBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void ChampignonBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void oksekødBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void LøgBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void AnanasBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void dressingBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void fritesBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void KebabBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void PepperoniBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void SkinBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void ChiliBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 7).ToString() + "kr";
        }

        private void lillepepsiBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 40).ToString() + "kr";
        }

        private void lillemonsterBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 30).ToString() + "kr";
        }

        private void lilleløBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 35).ToString() + "kr";
        }

        private void NormalpepsiBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 55).ToString() + "kr";
        }

        private void NormalmonsterBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 45).ToString() + "kr";
        }

        private void NormalløBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 50).ToString() + "kr";
        }

        private void storpepsiBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 70).ToString() + "kr";
        }

        private void stormonsterBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 60).ToString() + "kr";
        }

        private void storløBox_CheckedChanged(object sender, EventArgs e)
        {
            penge.Text = (prise += 65).ToString() + "kr";
        }
    }
}
