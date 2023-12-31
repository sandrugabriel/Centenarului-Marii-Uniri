﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centenarului_Marii_Uniri.Panels
{
    internal class PnlCentenarul_Marii_Uniri:Panel
    {

        Form1 form;

        Label label1;
        Button btnVizualizare;
        Button btnLogare;
        PictureBox pictureBox1;

        public PnlCentenarul_Marii_Uniri(Form1 form1)
        {

            form = form1;

            this.form.Size = new System.Drawing.Size(555, 458);
            this.form.MinimumSize = new System.Drawing.Size(555, 458);
            this.form.MaximumSize = new System.Drawing.Size(555, 458);

            //pnlCentenarulMariiUnirii
            this.Size = new System.Drawing.Size(555, 458);
            this.Name = "pnlCentenarulMariiUnirii";

            this.label1 = new System.Windows.Forms.Label();
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.btnLogare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);

            //picturebox1
            this.pictureBox1.Size = new System.Drawing.Size(560,100);
            this.pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.Text = "Centenar Start";
            this.label1.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.label1.ForeColor = System.Drawing.Color.White;

            // btnVizualizare
            this.btnVizualizare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.2F);
            this.btnVizualizare.Location = new System.Drawing.Point(155, 166);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(224, 75);
            this.btnVizualizare.Text = "Vizualizare lectii";
            this.btnVizualizare.Click += new EventHandler(btnVizualizare_Click);
            this.btnVizualizare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnVizualizare.ForeColor = System.Drawing.Color.White;

            // btnLogare
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.2F);
            this.btnLogare.Location = new System.Drawing.Point(155, 287);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(224, 75);
            this.btnLogare.Text = "Logare utilizator";
            this.btnLogare.Click += new EventHandler(btnLogare_Click);
            this.btnLogare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnLogare.ForeColor = System.Drawing.Color.White;

        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlCentenarulMariiUnirii");
            this.form.Controls.Add(new PnlVizualizare(this.form));

        }

        private void btnLogare_Click(object sender, EventArgs e)
        {

            this.form.removepnl("pnlCentenarulMariiUnirii");
            this.form.Controls.Add(new PnlLogin(this.form));

        }


    }
}
