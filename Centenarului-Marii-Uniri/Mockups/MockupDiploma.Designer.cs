namespace Centenarului_Marii_Uniri.Mockups
{
    partial class MockupDiploma
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pctdipl = new System.Windows.Forms.PictureBox();
            this.lblelev = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctdipl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.btnBack.Location = new System.Drawing.Point(446, 539);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 60);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pctdipl
            // 
            this.pctdipl.BackColor = System.Drawing.SystemColors.Info;
            this.pctdipl.Location = new System.Drawing.Point(67, 184);
            this.pctdipl.Name = "pctdipl";
            this.pctdipl.Size = new System.Drawing.Size(188, 246);
            this.pctdipl.TabIndex = 32;
            this.pctdipl.TabStop = false;
            // 
            // lblelev
            // 
            this.lblelev.AutoSize = true;
            this.lblelev.BackColor = System.Drawing.SystemColors.Info;
            this.lblelev.Location = new System.Drawing.Point(349, 369);
            this.lblelev.Name = "lblelev";
            this.lblelev.Size = new System.Drawing.Size(332, 30);
            this.lblelev.TabIndex = 33;
            this.lblelev.Text = "Se acorda elevului \"\" premiul \"\"";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe Print", 52F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitlu.ForeColor = System.Drawing.Color.Red;
            this.lblTitlu.Location = new System.Drawing.Point(328, 73);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(427, 154);
            this.lblTitlu.TabIndex = 34;
            this.lblTitlu.Text = "Diploma";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(33, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 464);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // MockupDiploma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 601);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblelev);
            this.Controls.Add(this.pctdipl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupDiploma";
            this.Text = "MockupVizualizare";
            ((System.ComponentModel.ISupportInitialize)(this.pctdipl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pctdipl;
        private System.Windows.Forms.Label lblelev;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}