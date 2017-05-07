namespace Populisanje_baze
{
    partial class Objave
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
            this.cbxLokacija = new System.Windows.Forms.ComboBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.tbTekst = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lokacija ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum objave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tekst objave";
            // 
            // cbxLokacija
            // 
            this.cbxLokacija.FormattingEnabled = true;
            this.cbxLokacija.Items.AddRange(new object[] {
            "Lokacija1",
            "Lokacija2",
            "Lokacija3",
            "Lokacija4",
            "Lokacija5",
            "Lokacija6",
            "Lokacija7",
            "Lokacija8",
            "Lokacija9"});
            this.cbxLokacija.Location = new System.Drawing.Point(40, 15);
            this.cbxLokacija.Name = "cbxLokacija";
            this.cbxLokacija.Size = new System.Drawing.Size(121, 21);
            this.cbxLokacija.TabIndex = 3;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(40, 44);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(121, 20);
            this.dtDatum.TabIndex = 4;
            // 
            // tbTekst
            // 
            this.tbTekst.Location = new System.Drawing.Point(40, 75);
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(121, 20);
            this.tbTekst.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(40, 102);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(40, 164);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(100, 20);
            this.tbBroj.TabIndex = 7;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(40, 191);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(100, 23);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Broj random objava";
            // 
            // Objave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbTekst);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.cbxLokacija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Objave";
            this.Text = "Objave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLokacija;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label4;
    }
}