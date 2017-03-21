namespace Populisanje_baze
{
    partial class Menze
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.tbRadnoVreme = new System.Windows.Forms.TextBox();
            this.cbxNeRadi = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lokacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radno vreme ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ne radi";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(39, 27);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 4;
            // 
            // tbLokacija
            // 
            this.tbLokacija.Location = new System.Drawing.Point(39, 57);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(100, 20);
            this.tbLokacija.TabIndex = 5;
            // 
            // tbRadnoVreme
            // 
            this.tbRadnoVreme.Location = new System.Drawing.Point(39, 89);
            this.tbRadnoVreme.Name = "tbRadnoVreme";
            this.tbRadnoVreme.Size = new System.Drawing.Size(100, 20);
            this.tbRadnoVreme.TabIndex = 6;
            // 
            // cbxNeRadi
            // 
            this.cbxNeRadi.FormattingEnabled = true;
            this.cbxNeRadi.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cbxNeRadi.Location = new System.Drawing.Point(39, 124);
            this.cbxNeRadi.Name = "cbxNeRadi";
            this.cbxNeRadi.Size = new System.Drawing.Size(100, 21);
            this.cbxNeRadi.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(39, 167);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(39, 233);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(100, 20);
            this.tbBroj.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj skucajno dodatih menzi";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(39, 269);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Menze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 317);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbxNeRadi);
            this.Controls.Add(this.tbRadnoVreme);
            this.Controls.Add(this.tbLokacija);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menze";
            this.Text = "Menze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.TextBox tbRadnoVreme;
        private System.Windows.Forms.ComboBox cbxNeRadi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRandom;
    }
}