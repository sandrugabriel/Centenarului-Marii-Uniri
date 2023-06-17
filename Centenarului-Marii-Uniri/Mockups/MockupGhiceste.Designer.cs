namespace Centenarului_Marii_Uniri.Mockups
{
    partial class MockupGhiceste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnGenereaza = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRaspunde = new System.Windows.Forms.Button();
            this.pctHarta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctHarta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F);
            this.lblTitlu.Location = new System.Drawing.Point(961, 178);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(70, 30);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12.8F);
            this.txtNota.Location = new System.Drawing.Point(966, 211);
            this.txtNota.Name = "txtNota";
            this.txtNota.ReadOnly = true;
            this.txtNota.Size = new System.Drawing.Size(266, 35);
            this.txtNota.TabIndex = 20;
            // 
            // btnGenereaza
            // 
            this.btnGenereaza.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnGenereaza.Location = new System.Drawing.Point(1028, 446);
            this.btnGenereaza.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGenereaza.Name = "btnGenereaza";
            this.btnGenereaza.Size = new System.Drawing.Size(182, 80);
            this.btnGenereaza.TabIndex = 8;
            this.btnGenereaza.Text = "Genereaza Diploma";
            this.btnGenereaza.UseVisualStyleBackColor = true;
            this.btnGenereaza.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnStart.Location = new System.Drawing.Point(1028, 102);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 60);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnRaspunde
            // 
            this.btnRaspunde.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnRaspunde.Location = new System.Drawing.Point(1028, 324);
            this.btnRaspunde.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRaspunde.Name = "btnRaspunde";
            this.btnRaspunde.Size = new System.Drawing.Size(182, 80);
            this.btnRaspunde.TabIndex = 31;
            this.btnRaspunde.Text = "Raspunde";
            this.btnRaspunde.UseVisualStyleBackColor = true;
            this.btnRaspunde.Visible = false;
            // 
            // pctHarta
            // 
            this.pctHarta.BackColor = System.Drawing.Color.LightBlue;
            this.pctHarta.Location = new System.Drawing.Point(39, 12);
            this.pctHarta.Name = "pctHarta";
            this.pctHarta.Size = new System.Drawing.Size(851, 560);
            this.pctHarta.TabIndex = 32;
            this.pctHarta.TabStop = false;
            // 
            // MockupGhiceste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 584);
            this.Controls.Add(this.pctHarta);
            this.Controls.Add(this.btnRaspunde);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btnGenereaza);
            this.Controls.Add(this.lblTitlu);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupGhiceste";
            this.Text = "MockupVizualizare";
            ((System.ComponentModel.ISupportInitialize)(this.pctHarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnGenereaza;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRaspunde;
        private System.Windows.Forms.PictureBox pctHarta;
    }
}