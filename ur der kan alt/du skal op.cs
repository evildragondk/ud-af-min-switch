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
    // the code works
    public partial class du_skal_op : Form
    {
        readonly List<DayOfWeek> days = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
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

        private void du_skal_op_Load(object sender, EventArgs e)
        {
            slåfraalarme.Text = "";
            slåtilalarme.Text = "";
            dage.Items.AddRange(new string[] { "Mandag", "Tirsdag", "Onsdag", "Tordag", "Fredag", "Lørdag", "Søndag", "Alle Dage", "Alle Vardag" });
            for (int i = 0; i < 24; i++)
            {
                timer.Items.Add(i);
            }

            for (int i = 0; i < 60; i++)
            {
                min.Items.Add(i);
            }
        }



        private void add_Click(object sender, EventArgs e)
        {
            List<DayOfWeek> tem = new List<DayOfWeek>();

            if (dage.SelectedIndex >= 0 && dage.SelectedIndex < 7)
            {
                tem.Add(days[dage.SelectedIndex]);
            }
            else if (dage.SelectedIndex == 7)
            {
                tem = days;
            }
            else if (dage.SelectedIndex == 8)
            {
                for (int i = 0; i < 5; i++)
                {
                    tem.Add(days[i]);
                }
            }

            alarm temp = new alarm(tem, new TimeSpan(Convert.ToInt32(timer.Text), Convert.ToInt32(min.Text), 0));

            duerilive.Add(temp);

            slåtilalarme.Items.Add(temp.ToDateString());

            /*
            slåtilalarme.Items.Add(string.Format("{0} kl. {1:00}:{2:00}", dage.Text, Convert.ToInt32(timer.Text), Convert.ToInt32(min.Text)));
            */
        }

        List<alarm> duerilive = new List<alarm>();

        private void slåfra_Click(object sender, EventArgs e)
        {
            if (slåtilalarme.SelectedIndex > -1)
            {
                slåfraalarme.Items.Add(duerilive[slåtilalarme.SelectedIndex].ToDateString());
                duerdød.Add(duerilive[slåtilalarme.SelectedIndex]);

                duerilive.RemoveAt(slåtilalarme.SelectedIndex);
                slåtilalarme.Items.RemoveAt(slåtilalarme.SelectedIndex);
            }
        }



        List<alarm> duerdød = new List<alarm>();
        private void slåtil_Click(object sender, EventArgs e)
        {
            if (slåfraalarme.SelectedIndex > -1)
            {
                slåtilalarme.Items.Add(duerdød[slåfraalarme.SelectedIndex].ToDateString());
                duerilive.Add(duerdød[slåfraalarme.SelectedIndex]);

                duerdød.RemoveAt(slåfraalarme.SelectedIndex);
                slåfraalarme.Items.RemoveAt(slåfraalarme.SelectedIndex);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(slåfraalarme.SelectedIndex > -1)
            {
                duerdød.RemoveAt(slåfraalarme.SelectedIndex);
                slåfraalarme.Items.RemoveAt(slåfraalarme.SelectedIndex);
            }

            if (slåtilalarme.SelectedIndex > -1)
            {
                duerilive.RemoveAt(slåtilalarme.SelectedIndex);
                slåtilalarme.Items.RemoveAt(slåtilalarme.SelectedIndex);
            }
        }

        List<alarm> toDisable = new List<alarm>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("it just works");
            foreach (alarm item in duerilive)
            {
                if (item.op <= DateTime.Now)
                {
                    if (item.dayOfs.Contains(DateTime.Today.DayOfWeek))
                    {
                        // toDisable.Add(item);
                        //timer1.Stop();
                        item.op += new TimeSpan(1, 0, 0, 0);
                        MessageBox.Show("you are finally awake");
                    }
                    else
                    {
                        item.op += new TimeSpan(1, 0, 0, 0);
                    }
                }
            }

            //toDisable.Reverse();

            //for (int i = 0; i < toDisable.Count; i++)
            //{
            //    slåfraalarme.Items.Add(toDisable[i].ToDateString());
            //    slåtilalarme.Items.Remove(toDisable[i]);

            //    duerdød.Add(toDisable[i]);
            //    duerilive.Remove(toDisable[i]);
            //}
            //toDisable.Clear();
            //timer1.Start();
        }
    }
}
