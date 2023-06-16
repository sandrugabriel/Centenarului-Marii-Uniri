namespace Centenarului_Marii_Uniri.Mockups
{
    partial class MockupStart
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
            this.btnCreare = new System.Windows.Forms.Button();
            this.btnGhiceste = new System.Windows.Forms.Button();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.lblTitlu.Location = new System.Drawing.Point(30, 23);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(150, 39);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Bun venit:";
            // 
            // btnCreare
            // 
            this.btnCreare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnCreare.Location = new System.Drawing.Point(25, 159);
            this.btnCreare.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCreare.Name = "btnCreare";
            this.btnCreare.Size = new System.Drawing.Size(252, 91);
            this.btnCreare.TabIndex = 3;
            this.btnCreare.Text = "Creare lectie";
            this.btnCreare.UseVisualStyleBackColor = true;
            // 
            // btnGhiceste
            // 
            this.btnGhiceste.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnGhiceste.Location = new System.Drawing.Point(310, 159);
            this.btnGhiceste.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGhiceste.Name = "btnGhiceste";
            this.btnGhiceste.Size = new System.Drawing.Size(252, 91);
            this.btnGhiceste.TabIndex = 8;
            this.btnGhiceste.Text = "Ghiceste regiunea";
            this.btnGhiceste.UseVisualStyleBackColor = true;
            // 
            // btnGenerare
            // 
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.btnGenerare.Location = new System.Drawing.Point(154, 290);
            this.btnGenerare.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(252, 91);
            this.btnGenerare.TabIndex = 18;
            this.btnGenerare.Text = "Generare Traseu";
            this.btnGenerare.UseVisualStyleBackColor = true;
            // 
            // MockupStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 437);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnGhiceste);
            this.Controls.Add(this.btnCreare);
            this.Controls.Add(this.lblTitlu);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupStart";
            this.Text = "MockupVizualizare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnCreare;
        private System.Windows.Forms.Button btnGhiceste;
        private System.Windows.Forms.Button btnGenerare;
    }
}