﻿using Centenarului_Marii_Uniri.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centenarului_Marii_Uniri.Panels
{
    internal class PnlGhiceste:Panel
    {


        Form1 form;
        Utilizator utilizator;

        Label lblTitlu;
        TextBox txtNota;
        Button btnGenereaza;
        Button btnStart;
        Button btnRaspunde;
        PictureBox pctHarta;
        PictureBox pictureBox;
        Label lblTit;
        Button btnBack;

        List<TextBox> txtList;

        public PnlGhiceste(Form1 form1,  Utilizator utilizator1)
        {

            this.form = form1;
            this.utilizator = utilizator1;
            txtList = new List<TextBox>();
            this.form.Size = new System.Drawing.Size(1278, 670);
            this.form.MaximumSize = new System.Drawing.Size(1278, 670);
            this.form.MinimumSize = new System.Drawing.Size(1278, 670);

            //PnlGhiceste
            this.Size = new System.Drawing.Size(1278, 670);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlGhiceste";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnGenereaza = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRaspunde = new System.Windows.Forms.Button();
            this.pctHarta = new System.Windows.Forms.PictureBox();
            lblTit = new System.Windows.Forms.Label();
            pictureBox = new System.Windows.Forms.PictureBox();
            btnBack = new System.Windows.Forms.Button();

            this.Controls.Add(this.pctHarta);
            this.Controls.Add(this.btnRaspunde);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btnGenereaza);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(lblTit);
            this.Controls.Add(pictureBox);
            this.Controls.Add(btnBack);

            pictureBox.Size = new Size(1285,90);
            this.pictureBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.lblTit.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.lblTit.ForeColor = Color.White;
            this.lblTit.AutoSize = true;
            this.lblTit.Text = "Ghiceste Regiunea";
            this.lblTit.Location = new Point(510,20);
            this.lblTit.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.8F);

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnBack.Location = new System.Drawing.Point(1045, 550);
            this.btnBack.Size = new System.Drawing.Size(153, 60);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new EventHandler(btnBack_Click);
            this.btnBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnBack.ForeColor = Color.White;

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblTitlu.Location = new System.Drawing.Point(961, 178);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(70, 30);
            this.lblTitlu.Text = "Nota:";
             
            // txtNota
            this.txtNota.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12.8F);
            this.txtNota.Location = new System.Drawing.Point(966, 211);
            this.txtNota.Name = "txtNota";
            this.txtNota.ReadOnly = true;
            this.txtNota.Size = new System.Drawing.Size(266, 35);
            
            // btnGenereaza
            this.btnGenereaza.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnGenereaza.Location = new System.Drawing.Point(1028, 446);
            this.btnGenereaza.Name = "btnGenereaza";
            this.btnGenereaza.Size = new System.Drawing.Size(182, 80);
            this.btnGenereaza.Text = "Genereaza Diploma";
            this.btnGenereaza.Visible = false;
            this.btnGenereaza.Click += new EventHandler(btnGenereaza_Click);
            this.btnGenereaza.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnGenereaza.ForeColor = Color.White;

            // btnStart
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnStart.Location = new System.Drawing.Point(1028, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 60);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new EventHandler(btnStart_Click);
            this.btnStart.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnStart.ForeColor = Color.White;

            // btnRaspunde
            this.btnRaspunde.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnRaspunde.Location = new System.Drawing.Point(1028, 324);
            this.btnRaspunde.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRaspunde.Name = "btnRaspunde";
            this.btnRaspunde.Size = new System.Drawing.Size(182, 80);
            this.btnRaspunde.TabIndex = 31;
            this.btnRaspunde.Text = "Raspunde";
            this.btnRaspunde.Visible = false;
            this.btnRaspunde.Click += new EventHandler(btnRaspunde_Click);
            this.btnRaspunde.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnRaspunde.ForeColor = Color.White;

            // pctHarta
            this.pctHarta.BackColor = System.Drawing.Color.LightBlue;
            this.pctHarta.SendToBack();
            this.pctHarta.Location = new System.Drawing.Point(39, 12);
            this.pctHarta.Name = "pctHarta";
            this.pctHarta.Size = new System.Drawing.Size(851, 560);
            this.pctHarta.Paint += new PaintEventHandler(pctHarta_Paint);
            this.pctHarta.Visible = false;
        }

        private void pctHarta_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            conturHarta(g);

            regiuni(g);
            //MessageBox.Show("asd");

        }

        private void regiuni(Graphics g)
        {
            List<string> nameFisier = new List<string>();
            string path1 = Application.StartupPath + @"/Harti/";
            string[] imageFile = Directory.GetFiles(path1, "*.txt");

            for (int i = 0; i < imageFile.Length; i++)
            {
                string image1 = imageFile[i].Remove(0, 83);
                if (image1 != "RomaniaMare.txt")
                {
                    nameFisier.Add(image1);
                }
            }

            for (int i = 0; i < nameFisier.Count; i++)
            {
                StreamReader streamReader1 = new StreamReader(path1 + nameFisier[i]);

                string t1 = null;
                List<Point> points1 = new List<Point>();
                int ct = 0;

                while ((t1 = streamReader1.ReadLine()) != null)
                {
                    string[] prop = t1.Split('*');

                    if (ct == 0)
                    {
                        int x = int.Parse(prop[0]) + 100;
                        int y = int.Parse(prop[1]) + 100;

                        TextBox textBox = new TextBox();
                        textBox.Name = prop[2];
                        textBox.Location = new Point(x, y);
                        this.pctHarta.Controls.Add(textBox);
                        txtList.Add(textBox);
                        ct++;
                    }
                    else
                    {
                        int x = int.Parse(prop[0]) + 100;
                        int y = int.Parse(prop[1]) + 100;

                        points1.Add(new Point(x, y));
                    }
                }

                for (int j = 0; j < points1.Count - 1; j++)
                {
                    Pen pen = new Pen(Color.White, 7);
                    g.DrawLine(pen, points1[j], points1[j + 1]);
                }

                points1.Clear();
            }
        }

        private void conturHarta(Graphics g)
        {

            string path = Application.StartupPath + @"/Harti/RomaniaMare.txt";

            StreamReader streamReader = new StreamReader(path);

            string t;

            List<Point> points = new List<Point>();

            while ((t = streamReader.ReadLine()) != null)
            {

                string[] prop = t.Split('*');

                int x = int.Parse(prop[0]) + 100;
                int y = int.Parse(prop[1]) + 100;

                points.Add(new Point(x, y));

            }

            for (int i = 0; i < points.Count - 1; i++)
            {
                Pen pen = new Pen(Color.Green, 7);
                g.DrawLine(pen, points[i], points[i + 1]);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.pctHarta.Visible = true;
            this.btnStart.Enabled = false;
            this.btnRaspunde.Visible = true;
            this.btnStart.BackColor = Color.White;
            this.btnStart.ForeColor = Color.Gray;
        }

        private void btnRaspunde_Click(object sender, EventArgs e)
        {
            int nota = 10;
            MessageBox.Show(txtList.Count.ToString());
            for(int i = 0; i < txtList.Count; i++)
            {

                if (txtList[i].Text != txtList[i].Name) nota--;

            }

            txtNota.Text = nota.ToString();
            this.btnGenereaza.Visible = true;
        }

        private void btnGenereaza_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlGhiceste");
            this.form.Controls.Add(new PnlDiploma(form,int.Parse(txtNota.Text), utilizator));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlGhiceste");
            this.form.Controls.Add(new PnlStart(form, utilizator));

        }
    }
}
