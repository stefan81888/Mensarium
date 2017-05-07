namespace Populisanje_baze
{
    partial class Pozivanja
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDPozivaoca = new System.Windows.Forms.TextBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.nudSati = new System.Windows.Forms.NumericUpDown();
            this.nudMinuti = new System.Windows.Forms.NumericUpDown();
            this.nudSekunde = new System.Windows.Forms.NumericUpDown();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekunde)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID pozivaoca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "datum poziva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vreme poziva";
            // 
            // tbIDPozivaoca
            // 
            this.tbIDPozivaoca.Location = new System.Drawing.Point(12, 12);
            this.tbIDPozivaoca.Name = "tbIDPozivaoca";
            this.tbIDPozivaoca.Size = new System.Drawing.Size(100, 20);
            this.tbIDPozivaoca.TabIndex = 5;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(12, 41);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(100, 20);
            this.dtDatum.TabIndex = 6;
            // 
            // nudSati
            // 
            this.nudSati.Location = new System.Drawing.Point(12, 76);
            this.nudSati.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSati.Name = "nudSati";
            this.nudSati.Size = new System.Drawing.Size(30, 20);
            this.nudSati.TabIndex = 7;
            // 
            // nudMinuti
            // 
            this.nudMinuti.Location = new System.Drawing.Point(48, 76);
            this.nudMinuti.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinuti.Name = "nudMinuti";
            this.nudMinuti.Size = new System.Drawing.Size(30, 20);
            this.nudMinuti.TabIndex = 8;
            // 
            // nudSekunde
            // 
            this.nudSekunde.Location = new System.Drawing.Point(82, 77);
            this.nudSekunde.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSekunde.Name = "nudSekunde";
            this.nudSekunde.Size = new System.Drawing.Size(30, 20);
            this.nudSekunde.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 113);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(12, 167);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(100, 20);
            this.tbBroj.TabIndex = 11;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 205);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Pozivanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 262);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.nudSekunde);
            this.Controls.Add(this.nudMinuti);
            this.Controls.Add(this.nudSati);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.tbIDPozivaoca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Pozivanja";
            this.Text = "Pozivanja";
            ((System.ComponentModel.ISupportInitialize)(this.nudSati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekunde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDPozivaoca;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.NumericUpDown nudSati;
        private System.Windows.Forms.NumericUpDown nudMinuti;
        private System.Windows.Forms.NumericUpDown nudSekunde;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Button btnRandom;
    }
}