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
    internal class PnlGenerareTraseu : Panel
    {


        Form1 form;
        Utilizator utilizator;

        Button btnBack;
        PictureBox pctHarta;

        List<Point> pointRegiuni;

        public PnlGenerareTraseu(Form1 form1, Utilizator utilizator1)
        {

            this.form = form1;
            this.utilizator = utilizator1;
            pointRegiuni = new List<Point>();

            this.form.Size = new System.Drawing.Size(1278, 584);
            this.form.MaximumSize = new System.Drawing.Size(1278, 584);
            this.form.MinimumSize = new System.Drawing.Size(1278, 584);

            //PnlGenerareTraseu
            this.Size = new System.Drawing.Size(1278, 584);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlGenerareTraseu";

            this.btnBack = new Button();
            this.pctHarta = new PictureBox();

            this.Controls.Add(this.btnBack);
            this.Controls.Add(pctHarta);

            // btnStart
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnBack.Location = new System.Drawing.Point(1028, 102);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 60);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new EventHandler(btnBack_Click);

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
            regiuni(g);
            traseu(g);


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
                        Pen pen = new Pen(Color.Black, 5);
                        Label label = new Label();
                        label.Text = prop[2];
                        label.Location = new Point(x+10, y+10);
                        label.AutoSize = true;
                        this.pctHarta.Controls.Add(label);
                        g.DrawEllipse(pen, x, y,5,5);
                        pointRegiuni.Add(new Point(x, y));
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

        private void traseu(Graphics g)
        {

            for(int i=0;i<pointRegiuni.Count-1;i++)
            {

                Pen pen = new Pen(Color.Green, 7);
                g.DrawLine(pen, pointRegiuni[i], pointRegiuni[i + 1]);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlGenerareTraseu");
            this.form.Controls.Add(new PnlStart(form, utilizator));

        }
    }
}
