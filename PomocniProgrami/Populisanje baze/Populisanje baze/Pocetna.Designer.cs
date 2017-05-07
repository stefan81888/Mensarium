namespace Populisanje_baze
{
    partial class formPocetna
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
            this.btnFakulteti = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnPracenje = new System.Windows.Forms.Button();
            this.btnObroci = new System.Windows.Forms.Button();
            this.btnMenze = new System.Windows.Forms.Button();
            this.btnObjave = new System.Windows.Forms.Button();
            this.btnPozivanja = new System.Windows.Forms.Button();
            this.btnPozvani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFakulteti
            // 
            this.btnFakulteti.Location = new System.Drawing.Point(12, 12);
            this.btnFakulteti.Name = "btnFakulteti";
            this.btnFakulteti.Size = new System.Drawing.Size(75, 23);
            this.btnFakulteti.TabIndex = 0;
            this.btnFakulteti.Text = "Fakulteti";
            this.btnFakulteti.UseVisualStyleBackColor = true;
            this.btnFakulteti.Click += new System.EventHandler(this.btnFakulteti_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Location = new System.Drawing.Point(12, 41);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnici.TabIndex = 1;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnPracenje
            // 
            this.btnPracenje.Location = new System.Drawing.Point(12, 70);
            this.btnPracenje.Name = "btnPracenje";
            this.btnPracenje.Size = new System.Drawing.Size(75, 23);
            this.btnPracenje.TabIndex = 2;
            this.btnPracenje.Text = "Pracenje";
            this.btnPracenje.UseVisualStyleBackColor = true;
            this.btnPracenje.Click += new System.EventHandler(this.btnPracenje_Click);
            // 
            // btnObroci
            // 
            this.btnObroci.Location = new System.Drawing.Point(12, 99);
            this.btnObroci.Name = "btnObroci";
            this.btnObroci.Size = new System.Drawing.Size(75, 23);
            this.btnObroci.TabIndex = 3;
            this.btnObroci.Text = "Obroci";
            this.btnObroci.UseVisualStyleBackColor = true;
            this.btnObroci.Click += new System.EventHandler(this.btnObroci_Click);
            // 
            // btnMenze
            // 
            this.btnMenze.Location = new System.Drawing.Point(124, 12);
            this.btnMenze.Name = "btnMenze";
            this.btnMenze.Size = new System.Drawing.Size(75, 23);
            this.btnMenze.TabIndex = 4;
            this.btnMenze.Text = "Menze";
            this.btnMenze.UseVisualStyleBackColor = true;
            this.btnMenze.Click += new System.EventHandler(this.btnMenze_Click);
            // 
            // btnObjave
            // 
            this.btnObjave.Location = new System.Drawing.Point(124, 40);
            this.btnObjave.Name = "btnObjave";
            this.btnObjave.Size = new System.Drawing.Size(75, 23);
            this.btnObjave.TabIndex = 5;
            this.btnObjave.Text = "Objave";
            this.btnObjave.UseVisualStyleBackColor = true;
            this.btnObjave.Click += new System.EventHandler(this.btnObjave_Click);
            // 
            // btnPozivanja
            // 
            this.btnPozivanja.Location = new System.Drawing.Point(124, 69);
            this.btnPozivanja.Name = "btnPozivanja";
            this.btnPozivanja.Size = new System.Drawing.Size(75, 23);
            this.btnPozivanja.TabIndex = 6;
            this.btnPozivanja.Text = "Pozivanja";
            this.btnPozivanja.UseVisualStyleBackColor = true;
            this.btnPozivanja.Click += new System.EventHandler(this.btnPozivanja_Click);
            // 
            // btnPozvani
            // 
            this.btnPozvani.Location = new System.Drawing.Point(124, 98);
            this.btnPozvani.Name = "btnPozvani";
            this.btnPozvani.Size = new System.Drawing.Size(75, 23);
            this.btnPozvani.TabIndex = 7;
            this.btnPozvani.Text = "Pozvani";
            this.btnPozvani.UseVisualStyleBackColor = true;
            this.btnPozvani.Click += new System.EventHandler(this.btnPozvani_Click);
            // 
            // formPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 137);
            this.Controls.Add(this.btnPozvani);
            this.Controls.Add(this.btnPozivanja);
            this.Controls.Add(this.btnObjave);
            this.Controls.Add(this.btnMenze);
            this.Controls.Add(this.btnObroci);
            this.Controls.Add(this.btnPracenje);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnFakulteti);
            this.Name = "formPocetna";
            this.Text = "Mensarium Data Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFakulteti;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnPracenje;
        private System.Windows.Forms.Button btnObroci;
        private System.Windows.Forms.Button btnMenze;
        private System.Windows.Forms.Button btnObjave;
        private System.Windows.Forms.Button btnPozivanja;
        private System.Windows.Forms.Button btnPozvani;
    }
}

