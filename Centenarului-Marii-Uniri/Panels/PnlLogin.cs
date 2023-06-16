using Centenarului_Marii_Uniri.Controllers;
using Centenarului_Marii_Uniri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centenarului_Marii_Uniri.Panels
{
    internal class PnlLogin : Panel
    {

        Label lblTitlu;
        Button btnLogin;
        Label lblEmail;
        TextBox txtEmail;
        TextBox txtParola;
        Label lblParola;
        Button btnBack;
        LinkLabel linkParola;

        Form1 form;

        ControllerUtilizatori controllerUtilizatori;

        public PnlLogin(Form1 form1)
        {

            form = form1;

            this.form.Size = new System.Drawing.Size(530, 570);
            this.form.MinimumSize = new System.Drawing.Size(530, 570);
            this.form.MaximumSize = new System.Drawing.Size(530, 570);

            controllerUtilizatori = new ControllerUtilizatori();

            //PnlLogin
            this.Size = new System.Drawing.Size(530, 570);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlLogin";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.linkParola = new System.Windows.Forms.LinkLabel();
             
            this.Controls.Add(this.linkParola);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTitlu);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.8F);
            this.lblTitlu.Location = new System.Drawing.Point(159, 43);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(133, 57);
            this.lblTitlu.Text = "Login";
             
            // btnLogin
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnLogin.Location = new System.Drawing.Point(55, 458);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 55);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new EventHandler(btnLogin_Click);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 30);
            this.lblEmail.Text = "Email";
            
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(41, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 38);
             
            // txtParola
            this.txtParola.Location = new System.Drawing.Point(41, 317);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(383, 38);
            this.txtParola.UseSystemPasswordChar = true;
            
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(36, 284);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(78, 30);
            this.lblParola.Text = "Parola";
             
            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnBack.Location = new System.Drawing.Point(243, 458);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 55);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new EventHandler(btnBack_Click);
             
            // linkParola
            this.linkParola.AutoSize = true;
            this.linkParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.8F);
            this.linkParola.Location = new System.Drawing.Point(277, 367);
            this.linkParola.Name = "linkParola";
            this.linkParola.Size = new System.Drawing.Size(147, 27);
            this.linkParola.Text = "Ai uitat parola?";
            this.linkParola.Click += new EventHandler(linkParola_Click);

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text.Equals("") || txtParola.Text.Equals(""))
            {
                MessageBox.Show("Introduceti emailul/parola!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (controllerUtilizatori.verificare(txtEmail.Text, txtParola.Text))
                {

                    Utilizator utilizator = new Utilizator();
                    utilizator = controllerUtilizatori.UtilizatorByEmailParola(txtEmail.Text, txtParola.Text);
                    this.form.removepnl("PnlLogin");


                }
                else MessageBox.Show("Emailul/Parola sunt gresite!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void linkParola_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlLogin");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlLogin");
            this.form.Controls.Add(new PnlCentenarul_Marii_Uniri(form));
        }


    }
}
