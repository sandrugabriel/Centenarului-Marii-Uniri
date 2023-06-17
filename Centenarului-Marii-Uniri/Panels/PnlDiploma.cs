using Centenarului_Marii_Uniri.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centenarului_Marii_Uniri.Panels
{
    internal class PnlDiploma:Panel
    {


        Button btnBack;
        PictureBox pctdipl;
        Label lblelev;
        Label lblTitlu;
        PictureBox pictureBox1;

        Form1 form;
        Utilizator utilizator;

        public PnlDiploma(Form1 form1,int nota,Utilizator utilizator1)
        {

            this.form = form1;
            this.utilizator = utilizator1;

            this.form.Size = new System.Drawing.Size(1051, 651);
            this.form.MinimumSize = new System.Drawing.Size(1051, 651);
            this.form.MaximumSize = new System.Drawing.Size(1051, 651);

            //PnlDiploma
            this.Size = new System.Drawing.Size(1051, 651);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlDiploma";

            this.btnBack = new System.Windows.Forms.Button();
            this.pctdipl = new System.Windows.Forms.PictureBox();
            this.lblelev = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblelev);
            this.Controls.Add(this.pctdipl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnBack.Location = new System.Drawing.Point(446, 539);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 60);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new EventHandler(btnBack_Click);
             
            // pctdipl
            this.pctdipl.BackColor = System.Drawing.SystemColors.Info;
            this.pctdipl.Location = new System.Drawing.Point(67, 184);
            this.pctdipl.Name = "pctdipl";
            this.pctdipl.Size = new System.Drawing.Size(188, 246);
            this.pctdipl.Image = Image.FromFile(Application.StartupPath + @"/sigiliu.jpg");
            this.pctdipl.SizeMode = PictureBoxSizeMode.StretchImage;
             
            // lblelev
            this.lblelev.AutoSize = true;
            this.lblelev.BackColor = System.Drawing.SystemColors.Info;
            this.lblelev.Location = new System.Drawing.Point(349, 369);
            this.lblelev.Name = "lblelev";
            this.lblelev.Size = new System.Drawing.Size(332, 30);

            string t = "Se acorda elevului " + utilizator.getName();
            if (nota == 10) t += "  Premiul I";
            else if (nota == 9) t += "  Premiul II";
            else if (nota == 8) t += "  Premiul III";
            else if (nota <= 7 && nota>=5) t += "  Mentiune";
            else t += " Diploma de participre";
            this.lblelev.Text = t;
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe Print", 52F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitlu.ForeColor = System.Drawing.Color.Red;
            this.lblTitlu.Location = new System.Drawing.Point(328, 73);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(427, 154);
            this.lblTitlu.TabIndex = 34;
            this.lblTitlu.Text = "Diploma";
             
            // pictureBox1
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(33, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 464);


        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.form.removepnl("PnlDiploma");
            this.form.Controls.Add(new PnlStart(form,utilizator));
        }


    }
}
