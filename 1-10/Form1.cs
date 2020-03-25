using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_10
{
    public partial class Form1 : Form
    {
        string forhjøt = "forhjøt";
        string forlat = "forlat";
        string riget = "riget";

        public Form1()
        {
            InitializeComponent();
        }

        private void en_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void to_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void tre_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void fire_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void fem_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void seks_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void sye_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void otto_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void ni_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void ti_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dit_tal.Text = dit_tal.Text + button.Text;
        }

        private void hvad_er_tal_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int randomnummer = 0;
        }
    }
}
