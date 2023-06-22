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
    internal class PnlStart:Panel
    {


        Label lblTitlu;
        Button btnCreare;
        Button btnGhiceste;
        Button btnGenerare;
        PictureBox pictureBox;

        Form1 form;
        Utilizator utilizator;

        public PnlStart(Form1 form1, Utilizator utilizator1)
        {

            this.form = form1;
            this.utilizator = utilizator1;

            this.form.Size = new System.Drawing.Size(620, 450);
            this.form.MinimumSize = new System.Drawing.Size(620, 450);
            this.form.MaximumSize = new System.Drawing.Size(620, 450);

            //PnlStart
            this.Size = new System.Drawing.Size(620, 450);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlStart";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnCreare = new System.Windows.Forms.Button();
            this.btnGhiceste = new System.Windows.Forms.Button();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnGhiceste);
            this.Controls.Add(this.btnCreare);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(pictureBox);


            this.pictureBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.pictureBox.Size = new Size(625, 80);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.lblTitlu.Location = new System.Drawing.Point(30, 23);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(150, 39);
            this.lblTitlu.Text = "Bun venit:" + utilizator.getName();
            this.lblTitlu.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.lblTitlu.ForeColor = Color.White;

            // btnCreare
            this.btnCreare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnCreare.Location = new System.Drawing.Point(25, 159);
            this.btnCreare.Name = "btnCreare";
            this.btnCreare.Size = new System.Drawing.Size(252, 91);
            this.btnCreare.Text = "Creare lectie";
            this.btnCreare.Click += new EventHandler(btnCreare_Click);
            this.btnCreare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnCreare.ForeColor = Color.White;

            // btnGhiceste
            this.btnGhiceste.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnGhiceste.Location = new System.Drawing.Point(310, 159);
            this.btnGhiceste.Name = "btnGhiceste";
            this.btnGhiceste.Size = new System.Drawing.Size(252, 91);
            this.btnGhiceste.Text = "Ghiceste regiunea";
            this.btnGhiceste.Click += new EventHandler(btnGhiceste_Click);
            this.btnGhiceste.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnGhiceste.ForeColor = Color.White;

            // btnGenerare
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnGenerare.Location = new System.Drawing.Point(154, 290);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(252, 91);
            this.btnGenerare.Text = "Generare Traseu";
            this.btnGenerare.Click += new EventHandler(btnGenerare_Click);
            this.btnGenerare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnGenerare.ForeColor = Color.White;


        }

        private void btnCreare_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlStart");
            this.form.Controls.Add(new PnlCreare(form, utilizator));

        }

        private void btnGhiceste_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlStart");
            this.form.Controls.Add(new PnlGhiceste(form, utilizator));

        }

        private void btnGenerare_Click(Object sender, EventArgs e)
        {

            this.form.removepnl("PnlStart");
            this.form.Controls.Add(new PnlGenerareTraseu(form, utilizator));

        }


    }
}
