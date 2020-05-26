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
        }
   }
}
