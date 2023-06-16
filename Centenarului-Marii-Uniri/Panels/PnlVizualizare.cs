using Centenarului_Marii_Uniri.Controllers;
using Centenarului_Marii_Uniri.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Centenarului_Marii_Uniri.Panels
{
    internal class PnlVizualizare:Panel
    {

        Form1 form;

        Label lblTitlu;
        RichTextBox richtTextUtilizator;
        ComboBox cmbLectii;
        Label lblSubTitlu;
        PictureBox pctImg;

        ControllerLectii controllerLectii;
        List<Lectie> lectii;

        ControllerUtilizatori controllerUtilizatori;
        List<Utilizator> utilizatorii;

        public PnlVizualizare(Form1 form1)
        {

            form = form1;
            this.form.Size = new System.Drawing.Size(1180, 782);
            this.form.MinimumSize = new System.Drawing.Size(1180, 782);
            this.form.MaximumSize = new System.Drawing.Size(1180, 782);
            this.form.Location = new System.Drawing.Point(120, 5);

            controllerLectii = new ControllerLectii();
            controllerUtilizatori = new ControllerUtilizatori();
            lectii = new List<Lectie>();
            lectii = controllerLectii.getLectii();
            utilizatorii = new List<Utilizator>();
            utilizatorii = controllerUtilizatori.getUtilizatori();

            // MockupVizualizare
            this.Size = new System.Drawing.Size(1180, 782);
            this.Name = "MockupVizualizare";
            this.Text = "MockupVizualizare";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.richtTextUtilizator = new System.Windows.Forms.RichTextBox();
            this.cmbLectii = new System.Windows.Forms.ComboBox();
            this.lblSubTitlu = new System.Windows.Forms.Label();
            this.pctImg = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.pctImg);
            this.Controls.Add(this.lblSubTitlu);
            this.Controls.Add(this.cmbLectii);
            this.Controls.Add(this.richtTextUtilizator);
            this.Controls.Add(this.lblTitlu);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(234, 22);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(698, 60);
            this.lblTitlu.Text = "Centenarul Marii Uniri de la 1918 - aceasta platforma este dedicata\r\naprofundarii" +
            " cunostintelor despre regiunile Marii Uniri de la 1918\r\n";
             
            // richtTextUtilizator
            this.richtTextUtilizator.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtTextUtilizator.Location = new System.Drawing.Point(447, 540);
            this.richtTextUtilizator.Size = new System.Drawing.Size(485, 167);
            this.richtTextUtilizator.Text = "";
             
            // cmbLectii
            this.cmbLectii.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLectii.FormattingEnabled = true;
            this.cmbLectii.Location = new System.Drawing.Point(28, 180);
            this.cmbLectii.Name = "cmbLectii";
            this.cmbLectii.Size = new System.Drawing.Size(237, 38);
            for(int i = 0; i < lectii.Count; i++)
            {
                this.cmbLectii.Items.Add(lectii[i].getNumeImagine());
            }
            this.cmbLectii.SelectedIndexChanged += new EventHandler(cmbLectii_SelectedIndexChanged);
             
            // lblSubTitlu
            this.lblSubTitlu.AutoSize = true;
            this.lblSubTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitlu.Location = new System.Drawing.Point(22, 128);
            this.lblSubTitlu.Name = "lblSubTitlu";
            this.lblSubTitlu.Size = new System.Drawing.Size(85, 36);
            this.lblSubTitlu.Text = "Lectii:";
            
            // pctImg
            this.pctImg.Location = new System.Drawing.Point(288, 90);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(800, 420);
            this.pctImg.BackColor = Color.Gray;
            this.pctImg.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void cmbLectii_SelectedIndexChanged(object sender, EventArgs e)
        {

            string name = cmbLectii.SelectedItem.ToString();
            int idUtilizator = 0;

            Utilizator utilizator = new Utilizator();
            Lectie lectie = new Lectie();

            for (int i = 0; i < lectii.Count; i++)
            {
                if (lectii[i].getNumeImagine().Equals(name))
                {
                    idUtilizator = lectii[i].getIdUtilizator();
                    lectie = lectii[i];
                    break;
                }
            }

            for (int i = 0; i < utilizatorii.Count; i++)
            {
                if (utilizatorii[i].getId() == idUtilizator)
                {
                    utilizator = utilizatorii[i];
                    break;
                }
            }

            string t = "";

            t += "Nume utilizator: " + utilizator.getName() + "\n";
            t += "Email: " + utilizator.getEmail() + "\n";
            t += "Regiunea: " + lectie.getRegiune() + "\n";
            t += "Data creare: " + lectie.getDataCreare().ToString() + "\n";

            richtTextUtilizator.Text = t;

            pctImg.Image = Image.FromFile(Application.StartupPath + @"/ContinutLectii/"+name+".bmp");

        }


    }
}
