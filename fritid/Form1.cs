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
        Double resultvalue = 0;
        string operationperformed = "";
        bool isOperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Nul_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void En_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0")|| (isOperationperformed))
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            if (textBox_Result.Text == ".")
            {
                if(!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            {
               textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void To_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Tre_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Fem_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Seks_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Sye_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Otto_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Ni_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultvalue != 0)
            {
                lidemed.PerformClick();
                operationperformed = button.Text;
                udrager.Text = resultvalue + " " + operationperformed;
                isOperationperformed = true;
            }
            else
            {

                operationperformed = button.Text;
                resultvalue = Double.Parse(textBox_Result.Text);
                udrager.Text = resultvalue + " " + operationperformed;
                isOperationperformed = true;
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";            
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultvalue = 0;
        }

        private void Lidemed_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox_Result.Text = (resultvalue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultvalue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultvalue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultvalue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultvalue = Double.Parse(textBox_Result.Text);
            udrager.Text = "";
        }

    }
}
