using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ur_der_kan_alt
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        TimeSpan ts;
        bool nejdethar = false;

        Regex hoursAndMilliSecRegex = new Regex(@"([0-9]?[0-9])");
        Regex minutesAndSecondsRegex = new Regex(@"([0-5]?[0-9]|60)");

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
            ts = ReadInput();

            timer2.Start();

            stopwatch.Start();
        }

        private TimeSpan ReadInput()
        {
            string[] strArr = { Nedtælletime.Text, Nedtællemin.Text, Nedtællesec.Text, Nedtællecs.Text };
            int[] values = new int[4];
            if (hoursAndMilliSecRegex.IsMatch(strArr[0]) && minutesAndSecondsRegex.IsMatch(strArr[1]) && minutesAndSecondsRegex.IsMatch(strArr[2]) && hoursAndMilliSecRegex.IsMatch(strArr[3]))
            {
                for (int i = 0; i < strArr.Length; i++)
                {
                    values[i] = Convert.ToInt32(strArr[i]);
                }
            }
            return new TimeSpan(0, values[0], values[1], values[2], values[3]);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void nåstil_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();

            DrawTime(new TimeSpan(0, 0, 0, 0, 0));           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (nejdethar == true)
            {
                DrawTime(ts - stopwatch.Elapsed);
            }
            else
            {
                DrawTime(stopwatch.Elapsed);
            }

            if (ts < stopwatch.Elapsed && ts != new TimeSpan(0))
            {
                Stop();
                MessageBox.Show("HEY IT DONE!" , "Alame");
                stopwatch.Reset();
            }
        }

        private void Stop()
        {
            timer2.Stop();

            stopwatch.Reset();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nedtælle_Click(object sender, EventArgs e)
        {
            timer2.Start();
            stopwatch.Start();
            ts = ReadInput();
            nejdethar = !nejdethar;            
        }

        private void Alame_Click(object sender, EventArgs e)
        {
            du_skal_op openForm = new du_skal_op();
            this.Hide();
            openForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
