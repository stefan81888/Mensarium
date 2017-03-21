namespace Populisanje_baze
{
    partial class Fakulteti
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
            this.cbxFakulteti = new System.Windows.Forms.ComboBox();
            this.btnFakulteti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxFakulteti
            // 
            this.cbxFakulteti.FormattingEnabled = true;
            this.cbxFakulteti.Items.AddRange(new object[] {
            "Elektronski fakultet Nis",
            "Pravni fakultet",
            "Ekonomski fakultet",
            "Zastita na radu"});
            this.cbxFakulteti.Location = new System.Drawing.Point(12, 12);
            this.cbxFakulteti.Name = "cbxFakulteti";
            this.cbxFakulteti.Size = new System.Drawing.Size(121, 21);
            this.cbxFakulteti.TabIndex = 0;
            // 
            // btnFakulteti
            // 
            this.btnFakulteti.Location = new System.Drawing.Point(12, 39);
            this.btnFakulteti.Name = "btnFakulteti";
            this.btnFakulteti.Size = new System.Drawing.Size(75, 23);
            this.btnFakulteti.TabIndex = 1;
            this.btnFakulteti.Text = "Dodaj";
            this.btnFakulteti.UseVisualStyleBackColor = true;
            this.btnFakulteti.Click += new System.EventHandler(this.btnFakulteti_Click);
            // 
            // Fakulteti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 127);
            this.Controls.Add(this.btnFakulteti);
            this.Controls.Add(this.cbxFakulteti);
            this.Name = "Fakulteti";
            this.Text = "Fakulteti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFakulteti;
        private System.Windows.Forms.Button btnFakulteti;
    }
}