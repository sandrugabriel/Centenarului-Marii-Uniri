using Centenarului_Marii_Uniri.Controllers;
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
    internal class PnlResetareParola : Panel
    {

        Label lblTitlu;
        Button btnVerificare;
        Label lblSubTitlu;
        TextBox txtParola2;
        TextBox txtParola;
        Label lblParola;
        Button btnBack;
        PictureBox pct1;
        PictureBox pct5;
        PictureBox pct4;
        PictureBox pct6;
        PictureBox pct3;
        PictureBox pct2;
        GroupBox groupBox;
        Label lblparola2;
        Button btnSalvare;
        Label label;

        Form1 form;

        ControllerUtilizatori controllerUtilizatori;

        List<Image> images;

        private int ct;

        List<int> oameni;
        List<int> selectOameni;

        List<int> select;

        private string email;
        public PnlResetareParola(Form1 form1, string email)
        {

            this.form = form1;
            this.form.Size = new System.Drawing.Size(860, 850);
            this.form.MinimumSize = new System.Drawing.Size(860, 850);
            this.form.MaximumSize = new System.Drawing.Size(860, 850);
            controllerUtilizatori = new ControllerUtilizatori();
            images = new List<Image>();
            oameni = new List<int>();
            select = new List<int>();
            selectOameni = new List<int>();

            //PnlResetareParola
            this.Size = new System.Drawing.Size(860, 850);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlResetareParola";
            this.AutoScroll = true;

            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnVerificare = new System.Windows.Forms.Button();
            this.lblSubTitlu = new System.Windows.Forms.Label();
            this.txtParola2 = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct5 = new System.Windows.Forms.PictureBox();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct6 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblparola2 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();

            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct6);
            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct5);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSubTitlu);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.label);

            label.Location = new System.Drawing.Point(1, 800);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.lblTitlu.Location = new System.Drawing.Point(14, 18);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(509, 39);
            this.lblTitlu.Text = "Am uitat parola la adresa de email : ";

            // btnVerificare
            this.btnVerificare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnVerificare.Location = new System.Drawing.Point(190, 456);
            this.btnVerificare.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(175, 55);
            this.btnVerificare.Text = "Verificare";
            this.btnVerificare.Click += new EventHandler(btnVerificare_Click);

            // lblSubTitlu
            this.lblSubTitlu.AutoSize = true;
            this.lblSubTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.8F);
            this.lblSubTitlu.Location = new System.Drawing.Point(222, 73);
            this.lblSubTitlu.Name = "lblSubTitlu";
            this.lblSubTitlu.Size = new System.Drawing.Size(375, 27);
            this.lblSubTitlu.Text = "Selecteaza imaginile care contin oameni";

            // txtParola2
            this.txtParola2.Location = new System.Drawing.Point(57, 187);
            this.txtParola2.Name = "txtParola2";
            this.txtParola2.Size = new System.Drawing.Size(383, 38);

            // txtParola
            this.txtParola.Location = new System.Drawing.Point(57, 83);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(383, 38);

            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(52, 43);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(142, 30);
            this.lblParola.Text = "Parola Noua";

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnBack.Location = new System.Drawing.Point(452, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 55);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new EventHandler(btnBack_Click);

            // pct1
            this.pct1.Location = new System.Drawing.Point(106, 115);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(139, 123);

            // pct5
            this.pct5.Location = new System.Drawing.Point(325, 287);
            this.pct5.Name = "pct5";
            this.pct5.Size = new System.Drawing.Size(139, 123);

            // pct4
            this.pct4.Location = new System.Drawing.Point(106, 287);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(139, 123);

            // pct6
            this.pct6.Location = new System.Drawing.Point(578, 287);
            this.pct6.Name = "pct6";
            this.pct6.Size = new System.Drawing.Size(139, 123);

            // pct3
            this.pct3.Location = new System.Drawing.Point(578, 115);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(139, 123);

            // pct2
            this.pct2.Location = new System.Drawing.Point(325, 115);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(139, 123);

            // groupBox
            this.groupBox.Controls.Add(this.btnSalvare);
            this.groupBox.Controls.Add(this.lblparola2);
            this.groupBox.Controls.Add(this.txtParola2);
            this.groupBox.Controls.Add(this.lblParola);
            this.groupBox.Controls.Add(this.txtParola);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(113, 520);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(587, 418);

            // lblparola2
            this.lblparola2.AutoSize = true;
            this.lblparola2.Location = new System.Drawing.Point(52, 144);
            this.lblparola2.Name = "lblparola2";
            this.lblparola2.Size = new System.Drawing.Size(200, 30);
            this.lblparola2.Text = "Confirmare parola";

            // btnSalvare
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnSalvare.Location = new System.Drawing.Point(176, 260);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(175, 55);
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.Click += new EventHandler(btnSalvare_Click);

            this.pct1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct6.SizeMode = PictureBoxSizeMode.StretchImage;

            string path = Application.StartupPath + @"/data/oameni.txt";
            string path1 = Application.StartupPath + @"/Captcha/";
            StreamReader streamReader = new StreamReader(path);
            string t;
            while ((t = streamReader.ReadLine()) != null)
            {
                string[] prop = t.Split('.');
                oameni.Add(int.Parse(prop[0]));
            }
            Random random = new Random();
            List<int> numbers = new List<int>();
            while (numbers.Count < 6)
            {
                int randomNumber = random.Next(1, 21);

                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }
            for (int i = 1; i <= 6; i++)
            {
                images.Add(Image.FromFile(path1 + numbers[i - 1].ToString() + ".jpg"));

                PictureBox pictureBox = Controls.Find("pct" + i, true).FirstOrDefault() as PictureBox;
                if (pictureBox != null)
                {
                    pictureBox.Click += new EventHandler(pcts_Click);
                    pictureBox.Image = images[i - 1];
                    pictureBox.Tag = numbers[i - 1];
                }

                for (int j = 0; j < oameni.Count; j++)
                {
                    if (numbers[i - 1] == oameni[j])
                    {
                        ct++;
                        selectOameni.Add(numbers[i - 1]);
                        j = oameni.Count + 1;
                    }
                }

            }
            selectOameni.Sort();
            this.email = email;
        }

        private int ctSelect = 0;

        private void pcts_Click(object sender, EventArgs e)
        {
            PictureBox selectedPictureBox = sender as PictureBox;

            if (selectedPictureBox != null)
            {
                string imageName = Path.GetFileName(selectedPictureBox.Tag.ToString());

                selectedPictureBox.Visible = false;
                select.Add(int.Parse(imageName));
                ctSelect++;
            }
            select.Sort();
        }

        private void btnVerificare_Click(object sender, EventArgs e)
        {
            int semn = 1;

            if (ctSelect != ct) semn = 0;

            for(int i = 0; i < select.Count; i++)
            {
               // MessageBox.Show(select[i].ToString() + "   " + selectOameni[i].ToString());
                if (select[i] != selectOameni[i]) {
                    semn = 0;
                }
            
            }

            for (int i = 1; i <= 6; i++)
            {
                PictureBox pictureBox = Controls.Find("pct" + i, true).FirstOrDefault() as PictureBox;
                if (pictureBox != null)
                {
                    pictureBox.Visible = false;
                }
            }

                if (semn== 0) {

                MessageBox.Show("Nu ai selectat bine!\n Incearca dini nou!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.form.removepnl("PnlResetareParola");
                this.form.Controls.Add(new PnlResetareParola(form,email));
            }
            else
            {


                groupBox.Enabled = true;
                btnVerificare.Enabled = false;

            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.form.removepnl("PnlResetareParola");
            this.form.Controls.Add(new PnlLogin(form));
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            if (txtParola.Text.Equals("") || txtParola2.Text.Equals(""))
            {
                MessageBox.Show("Introduceti parola!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtParola2.Text.Equals(txtParola.Text))
                {

                    controllerUtilizatori.setParolabyEmail(email, txtParola.Text);
                    controllerUtilizatori.update();
                    MessageBox.Show("Parola a fost schimbata!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.form.removepnl("PnlResetareParola");
                    this.form.Controls.Add(new PnlLogin(form));

                }
                else {
                    MessageBox.Show("Parola este gresita!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtParola2.Text = "";
                }

            }


        }

    }
}
