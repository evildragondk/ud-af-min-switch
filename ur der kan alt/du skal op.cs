using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ur_der_kan_alt
{
    public partial class du_skal_op : Form
    {
        public du_skal_op()
        {
            InitializeComponent();
        }

        private void Tilbage_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            this.Hide();
            openForm.ShowDialog();
            this.Close();
        }
    }
}
