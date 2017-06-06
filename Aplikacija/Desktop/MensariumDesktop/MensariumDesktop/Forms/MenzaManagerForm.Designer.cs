namespace MensariumDesktop.Forms
{
    partial class MenzaManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenzaManagerForm));
            this.imageListButtonIconsReclamation = new System.Windows.Forms.ImageList(this.components);
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenzaID = new System.Windows.Forms.TextBox();
            this.dgvMensaList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtGPS_Lon = new System.Windows.Forms.TextBox();
            this.txtGPS_Lat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkTime = new System.Windows.Forms.TextBox();
            this.cbxNotWorking = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxServer = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensaList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxServer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListButtonIconsReclamation
            // 
            this.imageListButtonIconsReclamation.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtonIconsReclamation.ImageStream")));
            this.imageListButtonIconsReclamation.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtonIconsReclamation.Images.SetKeyName(0, "save.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(1, "error.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(2, "success.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(3, "garbage-2.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(4, "plus.png");
            this.imageListButtonIconsReclamation.Images.SetKeyName(5, "edit.png");
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocation.Location = new System.Drawing.Point(100, 59);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(490, 22);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.Text = "Prezime";
            this.txtLocation.Enter += new System.EventHandler(this.txtBox_SelectAll_Enter);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(100, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(490, 22);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Ime";
            this.txtName.Enter += new System.EventHandler(this.txtBox_SelectAll_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Naziv";
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
            this.label3.Text = "MenzaID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMenzaID
            // 
            this.txtMenzaID.BackColor = System.Drawing.Color.White;
            this.txtMenzaID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMenzaID.Location = new System.Drawing.Point(100, 3);
            this.txtMenzaID.Name = "txtMenzaID";
            this.txtMenzaID.ReadOnly = true;
            this.txtMenzaID.Size = new System.Drawing.Size(490, 22);
            this.txtMenzaID.TabIndex = 1;
            this.txtMenzaID.Text = "2121394124";
            this.txtMenzaID.Enter += new System.EventHandler(this.txtBox_SelectAll_Enter);
            // 
            // dgvMensaList
            // 
            this.dgvMensaList.AllowUserToAddRows = false;
            this.dgvMensaList.AllowUserToDeleteRows = false;
            this.dgvMensaList.AllowUserToResizeRows = false;
            this.dgvMensaList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMensaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMensaList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMensaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensaList.Location = new System.Drawing.Point(7, 23);
            this.dgvMensaList.MultiSelect = false;
            this.dgvMensaList.Name = "dgvMensaList";
            this.dgvMensaList.ReadOnly = true;
            this.dgvMensaList.RowHeadersVisible = false;
            this.dgvMensaList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMensaList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensaList.ShowEditingIcon = false;
            this.dgvMensaList.Size = new System.Drawing.Size(593, 296);
            this.dgvMensaList.TabIndex = 0;
            this.dgvMensaList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMensaList_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lokacija";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMensaList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 373);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(607, 327);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Lista menza";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtGPS_Lon, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGPS_Lat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMenzaID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLocation, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtWorkTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxNotWorking, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtGPS_Lon
            // 
            this.txtGPS_Lon.BackColor = System.Drawing.Color.White;
            this.txtGPS_Lon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGPS_Lon.Location = new System.Drawing.Point(100, 169);
            this.txtGPS_Lon.Name = "txtGPS_Lon";
            this.txtGPS_Lon.Size = new System.Drawing.Size(490, 22);
            this.txtGPS_Lon.TabIndex = 13;
            this.txtGPS_Lon.Text = "Prezime";
            this.txtGPS_Lon.Enter += new System.EventHandler(this.txtBox_SelectAll_Enter);
            // 
            // txtGPS_Lat
            // 
            this.txtGPS_Lat.BackColor = System.Drawing.Color.White;
            this.txtGPS_Lat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGPS_Lat.Location = new System.Drawing.Point(100, 141);
            this.txtGPS_Lat.Name = "txtGPS_Lat";
            this.txtGPS_Lat.Size = new System.Drawing.Size(490, 22);
            this.txtGPS_Lat.TabIndex = 12;
            this.txtGPS_Lat.Text = "Prezime";
            this.txtGPS_Lat.Enter += new System.EventHandler(this.txtBox_SelectAll_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Radi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Radno vreme";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWorkTime
            // 
            this.txtWorkTime.BackColor = System.Drawing.Color.White;
            this.txtWorkTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWorkTime.Location = new System.Drawing.Point(100, 87);
            this.txtWorkTime.Name = "txtWorkTime";
            this.txtWorkTime.Size = new System.Drawing.Size(490, 22);
            this.txtWorkTime.TabIndex = 8;
            this.txtWorkTime.Text = "Prezime";
            this.txtWorkTime.Enter += new System.EventHandler(this.txtBox_SelectAll_Enter);
            // 
            // cbxNotWorking
            // 
            this.cbxNotWorking.AutoSize = true;
            this.cbxNotWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxNotWorking.Location = new System.Drawing.Point(100, 115);
            this.cbxNotWorking.Name = "cbxNotWorking";
            this.cbxNotWorking.Size = new System.Drawing.Size(490, 20);
            this.cbxNotWorking.TabIndex = 9;
            this.cbxNotWorking.Text = "Vanredno ne radi";
            this.cbxNotWorking.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "GPS_LAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "GPS_LON";
            // 
            // gbxServer
            // 
            this.gbxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxServer.Controls.Add(this.btnSave);
            this.gbxServer.Controls.Add(this.tableLayoutPanel1);
            this.gbxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxServer.Location = new System.Drawing.Point(13, 90);
            this.gbxServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxServer.Name = "gbxServer";
            this.gbxServer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxServer.Size = new System.Drawing.Size(607, 273);
            this.gbxServer.TabIndex = 17;
            this.gbxServer.TabStop = false;
            this.gbxServer.Text = " Menza";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageKey = "save.png";
            this.btnSave.ImageList = this.imageListButtonIconsReclamation;
            this.btnSave.Location = new System.Drawing.Point(482, 228);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 35);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 82);
            this.panel1.TabIndex = 16;
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageKey = "plus.png";
            this.btnAdd.ImageList = this.imageListButtonIconsReclamation;
            this.btnAdd.Location = new System.Drawing.Point(13, 710);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 35);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageKey = "garbage-2.png";
            this.btnDelete.ImageList = this.imageListButtonIconsReclamation;
            this.btnDelete.Location = new System.Drawing.Point(123, 710);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 35);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ImageKey = "success.png";
            this.btnFinish.ImageList = this.imageListButtonIconsReclamation;
            this.btnFinish.Location = new System.Drawing.Point(508, 710);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 35);
            this.btnFinish.TabIndex = 19;
            this.btnFinish.Text = " Završi";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // MenzaManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 759);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxServer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenzaManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uređivanje menze";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensaList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbxServer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageListButtonIconsReclamation;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMenzaID;
        private System.Windows.Forms.DataGridView dgvMensaList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkTime;
        private System.Windows.Forms.CheckBox cbxNotWorking;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGPS_Lon;
        private System.Windows.Forms.TextBox txtGPS_Lat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}