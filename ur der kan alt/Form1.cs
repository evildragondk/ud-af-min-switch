using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ur_der_kan_alt
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

            timer2.Start();   

            stopwatch.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer2.Stop();

            stopwatch.Stop();
        }

        private void nåstil_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();

            DrawTime(new TimeSpan(0, 0, 0, 0, 0));           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DrawTime(stopwatch.Elapsed);
        }

        private void DrawTime(TimeSpan ts)
        {
            timer.Text = string.Format("{0:00}:",
            ts.Hours);

            min.Text = string.Format("{0:00}:",
            ts.Minutes);

            sec.Text = string.Format("{0:00}:",
            ts.Seconds);

            cs.Text = string.Format("{0:00}",
            ts.Milliseconds / 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void kl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kl.Text = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = DateTime.Now.ToString("MM / dd / yyyy");
            label2.Text = DateTime.Now.ToString("dddd");
        }
    }
}
