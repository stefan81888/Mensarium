namespace Populisanje_baze
{
    partial class Obroci
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
            this.tbIdObroka = new System.Windows.Forms.TextBox();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.cbxIskoriscen = new System.Windows.Forms.ComboBox();
            this.tbIddUplatioca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxLokUplate = new System.Windows.Forms.ComboBox();
            this.cbxLokIskoriscenja = new System.Windows.Forms.ComboBox();
            this.dtUplata = new System.Windows.Forms.DateTimePicker();
            this.dtIskoriscenje = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbIdObroka
            // 
            this.tbIdObroka.Location = new System.Drawing.Point(13, 13);
            this.tbIdObroka.Name = "tbIdObroka";
            this.tbIdObroka.Size = new System.Drawing.Size(120, 20);
            this.tbIdObroka.TabIndex = 0;
            // 
            // cbxTip
            // 
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Items.AddRange(new object[] {
            "Dorucak",
            "Rucak",
            "Vecera"});
            this.cbxTip.Location = new System.Drawing.Point(13, 40);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(121, 21);
            this.cbxTip.TabIndex = 1;
            // 
            // cbxIskoriscen
            // 
            this.cbxIskoriscen.FormattingEnabled = true;
            this.cbxIskoriscen.Items.AddRange(new object[] {
            "Ne",
            "Da"});
            this.cbxIskoriscen.Location = new System.Drawing.Point(12, 94);
            this.cbxIskoriscen.Name = "cbxIskoriscen";
            this.cbxIskoriscen.Size = new System.Drawing.Size(121, 21);
            this.cbxIskoriscen.TabIndex = 2;
            // 
            // tbIddUplatioca
            // 
            this.tbIddUplatioca.Location = new System.Drawing.Point(13, 67);
            this.tbIddUplatioca.Name = "tbIddUplatioca";
            this.tbIddUplatioca.Size = new System.Drawing.Size(120, 20);
            this.tbIddUplatioca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "idObroka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "idUplatioca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iskoriscen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum uplacivanja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum iskoriscenja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lokacija uplate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Lokacija iskoriscenja";
            // 
            // cbxLokUplate
            // 
            this.cbxLokUplate.FormattingEnabled = true;
            this.cbxLokUplate.Items.AddRange(new object[] {
            "Elfak",
            "Pravni",
            "Medicinski",
            "Ekonomski",
            "Zastita na radu"});
            this.cbxLokUplate.Location = new System.Drawing.Point(12, 180);
            this.cbxLokUplate.Name = "cbxLokUplate";
            this.cbxLokUplate.Size = new System.Drawing.Size(121, 21);
            this.cbxLokUplate.TabIndex = 12;
            // 
            // cbxLokIskoriscenja
            // 
            this.cbxLokIskoriscenja.FormattingEnabled = true;
            this.cbxLokIskoriscenja.Items.AddRange(new object[] {
            "Elfak",
            "Pravni",
            "Medicinski",
            "Ekonomski",
            "Zastita na radu"});
            this.cbxLokIskoriscenja.Location = new System.Drawing.Point(12, 209);
            this.cbxLokIskoriscenja.Name = "cbxLokIskoriscenja";
            this.cbxLokIskoriscenja.Size = new System.Drawing.Size(121, 21);
            this.cbxLokIskoriscenja.TabIndex = 13;
            // 
            // dtUplata
            // 
            this.dtUplata.Location = new System.Drawing.Point(13, 126);
            this.dtUplata.Name = "dtUplata";
            this.dtUplata.Size = new System.Drawing.Size(120, 20);
            this.dtUplata.TabIndex = 14;
            // 
            // dtIskoriscenje
            // 
            this.dtIskoriscenje.Location = new System.Drawing.Point(13, 154);
            this.dtIskoriscenje.Name = "dtIskoriscenje";
            this.dtIskoriscenje.Size = new System.Drawing.Size(120, 20);
            this.dtIskoriscenje.TabIndex = 15;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(13, 249);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(338, 38);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 17;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(338, 12);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(127, 20);
            this.tbBroj.TabIndex = 18;
            // 
            // Obroci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 284);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtIskoriscenje);
            this.Controls.Add(this.dtUplata);
            this.Controls.Add(this.cbxLokIskoriscenja);
            this.Controls.Add(this.cbxLokUplate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIddUplatioca);
            this.Controls.Add(this.cbxIskoriscen);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.tbIdObroka);
            this.Name = "Obroci";
            this.Text = "Obroci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdObroka;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.ComboBox cbxIskoriscen;
        private System.Windows.Forms.TextBox tbIddUplatioca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxLokUplate;
        private System.Windows.Forms.ComboBox cbxLokIskoriscenja;
        private System.Windows.Forms.DateTimePicker dtUplata;
        private System.Windows.Forms.DateTimePicker dtIskoriscenje;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox tbBroj;
    }
}