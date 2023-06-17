using Centenarului_Marii_Uniri.Models;
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

        public PnlGhiceste(Form1 form1,  Utilizator utilizator1)
        {

            this.form = form1;
            this.utilizator = utilizator1;

            this.form.Size = new System.Drawing.Size(1278, 584);
            this.form.MaximumSize = new System.Drawing.Size(1278, 584);
            this.form.MinimumSize = new System.Drawing.Size(1278, 584);

            //PnlGhiceste
            this.Size = new System.Drawing.Size(1278, 584);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlGhiceste";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnGenereaza = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRaspunde = new System.Windows.Forms.Button();
            this.pctHarta = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.pctHarta);
            this.Controls.Add(this.btnRaspunde);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btnGenereaza);
            this.Controls.Add(this.lblTitlu);

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
            this.btnGenereaza.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGenereaza.Name = "btnGenereaza";
            this.btnGenereaza.Size = new System.Drawing.Size(182, 80);
            this.btnGenereaza.Text = "Genereaza Diploma";
            this.btnGenereaza.Visible = false;
             
            // btnStart
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnStart.Location = new System.Drawing.Point(1028, 102);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 60);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new EventHandler(btnStart_Click);
            
            // btnRaspunde
            this.btnRaspunde.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnRaspunde.Location = new System.Drawing.Point(1028, 324);
            this.btnRaspunde.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRaspunde.Name = "btnRaspunde";
            this.btnRaspunde.Size = new System.Drawing.Size(182, 80);
            this.btnRaspunde.TabIndex = 31;
            this.btnRaspunde.Text = "Raspunde";
            this.btnRaspunde.Visible = false;
             
            // pctHarta
            this.pctHarta.BackColor = System.Drawing.Color.LightBlue;
            this.pctHarta.Location = new System.Drawing.Point(39, 12);
            this.pctHarta.Name = "pctHarta";
            this.pctHarta.Size = new System.Drawing.Size(851, 560);
            this.pctHarta.Paint += new PaintEventHandler(pctHarta_Paint);

        }

        private void pctHarta_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            conturHarta(g);

          //  regiuni(g);

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
                        this.pctHarta.Controls.Add(textBox);
                        textBox.Location = new Point(x, y);
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
            this.btnStart.Enabled = false;
        }

    }
}
