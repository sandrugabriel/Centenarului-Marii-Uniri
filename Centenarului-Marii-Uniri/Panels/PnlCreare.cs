using Centenarului_Marii_Uniri.Controllers;
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
    internal class PnlCreare:Panel
    {

        Label lblTitlu;
        Button btnRandNou;
        Label lblregiune;
        TextBox textBox1;
        TextBox txtRegiunea;
        Button btnStergeRand;
        Button btnColoanaNou;
        Button btnStergeColoana;
        Button btnCrescLatimeColoana;
        Button btnReduceLatimeColoana;
        Button btnCresteInaltimeRand;
        Button btnReduceInaltimeRand;
        Button btnPoza;
        Button btnText;
        Button btnSalvare;
        Button btnBack;
        TableLayoutPanel tableLayoutPanel;

        Form1 form;
        Utilizator utilizator;

        ControllerLectii controllerLectii;

        public PnlCreare(Form1 form1,Utilizator utilizator1)
        {
            this.form = form1;
            this.utilizator = utilizator1;

            this.form.Size = new System.Drawing.Size(1322, 773);
            this.form.MinimumSize = new System.Drawing.Size(1322, 773);
            this.form.MaximumSize = new System.Drawing.Size(1322, 773); 
            this.form.Location = new System.Drawing.Point(100, 5);

            controllerLectii = new ControllerLectii();

            //PnlCreare
            this.Size = new System.Drawing.Size(1322, 773);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlCreare";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnRandNou = new System.Windows.Forms.Button();
            this.lblregiune = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRegiunea = new System.Windows.Forms.TextBox();
            this.btnStergeRand = new System.Windows.Forms.Button();
            this.btnColoanaNou = new System.Windows.Forms.Button();
            this.btnStergeColoana = new System.Windows.Forms.Button();
            this.btnCrescLatimeColoana = new System.Windows.Forms.Button();
            this.btnReduceLatimeColoana = new System.Windows.Forms.Button();
            this.btnCresteInaltimeRand = new System.Windows.Forms.Button();
            this.btnReduceInaltimeRand = new System.Windows.Forms.Button();
            this.btnPoza = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();

            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnReduceInaltimeRand);
            this.Controls.Add(this.btnCresteInaltimeRand);
            this.Controls.Add(this.btnReduceLatimeColoana);
            this.Controls.Add(this.btnCrescLatimeColoana);
            this.Controls.Add(this.btnStergeColoana);
            this.Controls.Add(this.btnColoanaNou);
            this.Controls.Add(this.btnStergeRand);
            this.Controls.Add(this.txtRegiunea);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblregiune);
            this.Controls.Add(this.btnPoza);
            this.Controls.Add(this.btnRandNou);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnBack);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblTitlu.Location = new System.Drawing.Point(30, 23);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(123, 30);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu lectie:";
            
            // btnRandNou
            this.btnRandNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.8F);
            this.btnRandNou.Location = new System.Drawing.Point(25, 259);
            this.btnRandNou.Name = "btnRandNou";
            this.btnRandNou.Size = new System.Drawing.Size(153, 60);
            this.btnRandNou.Text = "Rand nou";
            this.btnRandNou.Click += new EventHandler(btnRandNou_Click);
            
            // lblregiune
            this.lblregiune.AutoSize = true;
            this.lblregiune.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblregiune.Location = new System.Drawing.Point(30, 122);
            this.lblregiune.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblregiune.Name = "lblregiune";
            this.lblregiune.Size = new System.Drawing.Size(116, 30);
            this.lblregiune.TabIndex = 19;
            this.lblregiune.Text = "Regiunea:";
            
            // textBox1
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12.8F);
            this.textBox1.Location = new System.Drawing.Point(35, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 35);
             
            // txtRegiunea
            this.txtRegiunea.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12.8F);
            this.txtRegiunea.Location = new System.Drawing.Point(35, 166);
            this.txtRegiunea.Name = "txtRegiunea";
            this.txtRegiunea.Size = new System.Drawing.Size(266, 35);
             
            // btnStergeRand
            this.btnStergeRand.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnStergeRand.Location = new System.Drawing.Point(207, 259);
            this.btnStergeRand.Name = "btnStergeRand";
            this.btnStergeRand.Size = new System.Drawing.Size(153, 60);
            this.btnStergeRand.Text = "Sterge rand";
            this.btnStergeRand.Click += new EventHandler(btnStergeRand_Click);
            
            // btnColoanaNou
            this.btnColoanaNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnColoanaNou.Location = new System.Drawing.Point(25, 356);
            this.btnColoanaNou.Name = "btnColoanaNou";
            this.btnColoanaNou.Size = new System.Drawing.Size(153, 60);
            this.btnColoanaNou.Text = "Coloana noua";
            this.btnColoanaNou.Click += new EventHandler(btnColoanaNou_Click);
             
            // btnStergeColoana
            this.btnStergeColoana.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnStergeColoana.Location = new System.Drawing.Point(207, 356);
            this.btnStergeColoana.Name = "btnStergeColoana";
            this.btnStergeColoana.Size = new System.Drawing.Size(153, 60);
            this.btnStergeColoana.Text = "Sterge coloana";
            this.btnStergeColoana.Click += new EventHandler(btnStergeColoana_Click);
             
            // btnCrescLatimeColoana
            this.btnCrescLatimeColoana.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnCrescLatimeColoana.Location = new System.Drawing.Point(25, 460);
            this.btnCrescLatimeColoana.Name = "btnCrescLatimeColoana";
            this.btnCrescLatimeColoana.Size = new System.Drawing.Size(153, 60);
            this.btnCrescLatimeColoana.Text = "Creste latime coloana";
            this.btnCrescLatimeColoana.Click += new EventHandler(btnCrescLatimeColoana_Click);
             
            // btnReduceLatimeColoana
            this.btnReduceLatimeColoana.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnReduceLatimeColoana.Location = new System.Drawing.Point(207, 460);
            this.btnReduceLatimeColoana.Name = "btnReduceLatimeColoana";
            this.btnReduceLatimeColoana.Size = new System.Drawing.Size(153, 60);
            this.btnReduceLatimeColoana.Text = "Reduce latime coloana";
            this.btnReduceLatimeColoana.Click += new EventHandler(btnReduceLatimeColoana_Click);

            // btnCresteInaltimeRand
            this.btnCresteInaltimeRand.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnCresteInaltimeRand.Location = new System.Drawing.Point(25, 560);
            this.btnCresteInaltimeRand.Name = "btnCresteInaltimeRand";
            this.btnCresteInaltimeRand.Size = new System.Drawing.Size(153, 60);
            this.btnCresteInaltimeRand.Text = "Creste inaltime rand";
            this.btnCresteInaltimeRand.Click += new EventHandler(btnCresteInaltimeRand_Click);
            
            // btnReduceInaltimeRand
            this.btnReduceInaltimeRand.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnReduceInaltimeRand.Location = new System.Drawing.Point(207, 560);
            this.btnReduceInaltimeRand.Name = "btnReduceInaltimeRand";
            this.btnReduceInaltimeRand.Size = new System.Drawing.Size(153, 60);
            this.btnReduceInaltimeRand.Text = "Reduce inaltime rand";
            this.btnReduceInaltimeRand.Click += new EventHandler(btnReduceInaltimeRand_Click);
             
            // btnPoza
            this.btnPoza.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnPoza.Location = new System.Drawing.Point(25, 644);
            this.btnPoza.Name = "btnPoza";
            this.btnPoza.Size = new System.Drawing.Size(153, 60);
            this.btnPoza.Text = "Poza";
            this.btnPoza.Click += new EventHandler(btnPoza_Click);
             
            // btnText
            this.btnText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnText.Location = new System.Drawing.Point(207, 644);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(153, 60);
            this.btnText.Text = "Text";
            this.btnText.Click += new EventHandler(btnText_Click);

            // btnSalvare
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnSalvare.Location = new System.Drawing.Point(499, 644);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(238, 70);
            this.btnSalvare.Text = "Salvare lectie";
            this.btnSalvare.Click += new EventHandler(btnSalvare_Click);

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnBack.Location = new System.Drawing.Point(900, 644);
            this.btnBack.Size = new System.Drawing.Size(238, 70);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new EventHandler(btnBack_Click);

            // tableLayoutPanel
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(384, 23);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(910, 597);
            this.tableLayoutPanel.BackColor = Color.Gray;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlCreare");
            this.form.Controls.Add(new PnlStart(form, utilizator));

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            if(textBox1.Text.Equals("") || txtRegiunea.Text.Equals(""))
            {
                MessageBox.Show("Introduceti titlul/regiunea!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.form.removepnl("PnlCreare");
                this.form.Controls.Add(new PnlStart(form, utilizator));

            }



        }

        private void btnRandNou_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10));

        }

        private void btnStergeRand_Click(object sender, EventArgs e)
        {
            if(tableLayoutPanel.RowCount > 0)
            this.tableLayoutPanel.RowStyles.RemoveAt(tableLayoutPanel.RowCount-1);

        }

        private void btnColoanaNou_Click(Object sender, EventArgs e)
        {
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10));
        }

        private void btnStergeColoana_Click(Object sender, EventArgs e)
        {
            if (tableLayoutPanel.ColumnCount > 0)
                this.tableLayoutPanel.ColumnStyles.RemoveAt(tableLayoutPanel.ColumnCount - 1);


        }

        private void btnCrescLatimeColoana_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel.ColumnCount > 0)
                this.tableLayoutPanel.ColumnStyles[tableLayoutPanel.ColumnCount - 1].Width += 10;


        }

        private void btnReduceLatimeColoana_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel.ColumnCount > 0)
                this.tableLayoutPanel.ColumnStyles[tableLayoutPanel.ColumnCount - 1].Width -= 10;

        }

        private void btnCresteInaltimeRand_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel.RowCount > 0)
                this.tableLayoutPanel.RowStyles[tableLayoutPanel.RowCount - 1].Height += 10;


        }

        private void btnReduceInaltimeRand_Click(Object sender, EventArgs e)
        {
            if (tableLayoutPanel.RowCount > 0)
                this.tableLayoutPanel.RowStyles[tableLayoutPanel.RowCount - 1].Height -= 10;


        }

        private void btnPoza_Click(object sender, EventArgs e)
        {



        }

        private void btnText_Click(object sender, EventArgs e)
        {

            RichTextBox richTextBox = new RichTextBox();
           // int width = int.Parse(tableLayoutPanel.ColumnStyles[tableLayoutPanel.ColumnCount - 1].Width.ToString());
           // richTextBox.Size = new Size(width, int.Parse(tableLayoutPanel.RowStyles[tableLayoutPanel.RowCount - 1].Height.ToString()));
            //this.tableLayoutPanel.Controls.Add(richTextBox,tableLayoutPanel.ColumnCount - 1, tableLayoutPanel.RowCount - 1);

        }

    }
}
