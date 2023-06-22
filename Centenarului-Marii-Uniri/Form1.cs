using Centenarului_Marii_Uniri.Models;
using Centenarului_Marii_Uniri.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centenarului_Marii_Uniri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utilizator utilizator = new Utilizator("1*Popescu Ion*1234*popescu@gmail.com");
            this.Controls.Add(new PnlCentenarul_Marii_Uniri(this));

        }

        public void removepnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }

    }
}
