namespace Populisanje_baze
{
    partial class Pozvani
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOdgovor = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbIDpoziva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(12, 42);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID pozvanog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odgovor";
            // 
            // cbxOdgovor
            // 
            this.cbxOdgovor.FormattingEnabled = true;
            this.cbxOdgovor.Items.AddRange(new object[] {
            "Ne",
            "Da"});
            this.cbxOdgovor.Location = new System.Drawing.Point(12, 76);
            this.cbxOdgovor.Name = "cbxOdgovor";
            this.cbxOdgovor.Size = new System.Drawing.Size(100, 21);
            this.cbxOdgovor.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 114);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbIDpoziva
            // 
            this.tbIDpoziva.Location = new System.Drawing.Point(12, 12);
            this.tbIDpoziva.Name = "tbIDpoziva";
            this.tbIDpoziva.Size = new System.Drawing.Size(100, 20);
            this.tbIDpoziva.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID poziva";
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(12, 176);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(100, 20);
            this.tbBroj.TabIndex = 7;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 202);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Pozvani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 237);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIDpoziva);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbxOdgovor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Name = "Pozvani";
            this.Text = "Pozvani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxOdgovor;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbIDpoziva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Button btnRandom;
    }
}