using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzeria
{
   public class priser
   {
       public int prise;
        public static int penge1 { get; set; }

        public void FlerePenge(object Tag, Label penge )
        {
            if (Tag.ToString() == "fule")
            {
                prise = 7;
                penge.Text = $"{prise} kr";
            }

            if (Tag.ToString() == "Normal")
            {
                prise = 70;
                penge.Text = $"{prise} kr";
            }

            if (Tag.ToString() == "Stor")
            {
                prise = 100;
                penge.Text = $"{prise} kr";
            }

            if (Tag.ToString() == "sovs")
            {
                prise = 15;
                penge.Text = $"{prise} kr";
            }

            if (penge1 < 0)
            {
                penge1 = 0;
            }

        }

        public static void addpenge(int i)
        {
            penge1 += i;
        }
   }
}
