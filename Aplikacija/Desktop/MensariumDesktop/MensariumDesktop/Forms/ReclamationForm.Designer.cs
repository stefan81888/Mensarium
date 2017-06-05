namespace MensariumDesktop.Forms
{
    partial class ReclamationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReclamationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxServer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUserLName = new System.Windows.Forms.TextBox();
            this.txtUserFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.btnFinish = new System.Windows.Forms.Button();
            this.imageListButtonIconsReclamation = new System.Windows.Forms.ImageList(this.components);
            this.btnExecute = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxServer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 82);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "InnoStorm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensarium";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MensariumDesktop.Properties.Resources.MensariumIconWhite;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gbxServer
            // 
            this.gbxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxServer.Controls.Add(this.tableLayoutPanel1);
            this.gbxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxServer.Location = new System.Drawing.Point(13, 90);
            this.gbxServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxServer.Name = "gbxServer";
            this.gbxServer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxServer.Size = new System.Drawing.Size(658, 114);
            this.gbxServer.TabIndex = 12;
            this.gbxServer.TabStop = false;
            this.gbxServer.Text = " Korisnik";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtUserLName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUserFName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtUserLName
            // 
            this.txtUserLName.BackColor = System.Drawing.Color.White;
            this.txtUserLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserLName.Location = new System.Drawing.Point(100, 59);
            this.txtUserLName.Name = "txtUserLName";
            this.txtUserLName.ReadOnly = true;
            this.txtUserLName.Size = new System.Drawing.Size(541, 22);
            this.txtUserLName.TabIndex = 5;
            this.txtUserLName.Text = "Prezime";
            // 
            // txtUserFName
            // 
            this.txtUserFName.BackColor = System.Drawing.Color.White;
            this.txtUserFName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserFName.Location = new System.Drawing.Point(100, 31);
            this.txtUserFName.Name = "txtUserFName";
            this.txtUserFName.ReadOnly = true;
            this.txtUserFName.Size = new System.Drawing.Size(541, 22);
            this.txtUserFName.TabIndex = 3;
            this.txtUserFName.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ime";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "KorisnikID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.White;
            this.txtUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserID.Location = new System.Drawing.Point(100, 3);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(541, 22);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.Text = "2121394124";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prezime";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbFilter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvMeals);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 207);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(658, 356);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Uplaćeni obroci";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Sve",
            "Doručak",
            "Ručak",
            "Večera"});
            this.cmbFilter.Location = new System.Drawing.Point(459, 23);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(192, 24);
            this.cmbFilter.TabIndex = 2;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Prikaži";
            // 
            // dgvMeals
            // 
            this.dgvMeals.AllowUserToAddRows = false;
            this.dgvMeals.AllowUserToDeleteRows = false;
            this.dgvMeals.AllowUserToResizeRows = false;
            this.dgvMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeals.BackgroundColor = System.Drawing.Color.White;
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Location = new System.Drawing.Point(7, 53);
            this.dgvMeals.MultiSelect = false;
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.ReadOnly = true;
            this.dgvMeals.RowHeadersVisible = false;
            this.dgvMeals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeals.ShowEditingIcon = false;
            this.dgvMeals.Size = new System.Drawing.Size(644, 295);
            this.dgvMeals.TabIndex = 0;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ImageKey = "success.png";
            this.btnFinish.ImageList = this.imageListButtonIconsReclamation;
            this.btnFinish.Location = new System.Drawing.Point(559, 573);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 35);
            this.btnFinish.TabIndex = 14;
            this.btnFinish.Text = " Završi";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imageListButtonIconsReclamation
            // 
            this.imageListButtonIconsReclamation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtonIconsReclamation.ImageStream")));
            this.imageListButtonIconsReclamation.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtonIconsReclamation.Images.SetKeyName(0, "save.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(1, "error.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(2, "success.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(3, "garbage-2.png");
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ImageKey = "garbage-2.png";
            this.btnExecute.ImageList = this.imageListButtonIconsReclamation;
            this.btnExecute.Location = new System.Drawing.Point(13, 573);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(203, 35);
            this.btnExecute.TabIndex = 15;
            this.btnExecute.Text = "Obriši obrok";
            this.btnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // ReclamationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 622);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxServer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(510, 520);
            this.Name = "ReclamationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reklamacije";
            this.Load += new System.EventHandler(this.ReclamationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxServer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtUserFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserLName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.ImageList imageListButtonIconsReclamation;
        private System.Windows.Forms.Button btnExecute;
    }
}