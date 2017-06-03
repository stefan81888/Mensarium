namespace MensariumDesktop.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.gbxServer = new System.Windows.Forms.GroupBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.imageListButtonIconsSettings = new System.Windows.Forms.ImageList(this.components);
            this.txtmServerPort = new System.Windows.Forms.MaskedTextBox();
            this.txtmServerIP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxLokacija = new System.Windows.Forms.GroupBox();
            this.cbxSettingsMenza = new System.Windows.Forms.ComboBox();
            this.lblMenza = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxServer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxLokacija.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Host / IP";
            // 
            // gbxServer
            // 
            this.gbxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxServer.Controls.Add(this.btnTestConnection);
            this.gbxServer.Controls.Add(this.txtmServerPort);
            this.gbxServer.Controls.Add(this.txtmServerIP);
            this.gbxServer.Controls.Add(this.label2);
            this.gbxServer.Controls.Add(this.label1);
            this.gbxServer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxServer.Location = new System.Drawing.Point(13, 90);
            this.gbxServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxServer.Name = "gbxServer";
            this.gbxServer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxServer.Size = new System.Drawing.Size(321, 128);
            this.gbxServer.TabIndex = 0;
            this.gbxServer.TabStop = false;
            this.gbxServer.Text = " Server ";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.ImageIndex = 3;
            this.btnTestConnection.ImageList = this.imageListButtonIconsSettings;
            this.btnTestConnection.Location = new System.Drawing.Point(179, 87);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(134, 33);
            this.btnTestConnection.TabIndex = 9;
            this.btnTestConnection.Text = "Testiraj vezu";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // imageListButtonIconsSettings
            // 
            this.imageListButtonIconsSettings.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtonIconsSettings.ImageStream")));
            this.imageListButtonIconsSettings.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtonIconsSettings.Images.SetKeyName(0, "save.png");
            this.imageListButtonIconsSettings.Images.SetKeyName(1, "error.png");
            this.imageListButtonIconsSettings.Images.SetKeyName(2, "stop-1.png");
            this.imageListButtonIconsSettings.Images.SetKeyName(3, "cloud-computing-15.png");
            // 
            // txtmServerPort
            // 
            this.txtmServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmServerPort.Location = new System.Drawing.Point(81, 57);
            this.txtmServerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmServerPort.Mask = "09999";
            this.txtmServerPort.Name = "txtmServerPort";
            this.txtmServerPort.PromptChar = ' ';
            this.txtmServerPort.Size = new System.Drawing.Size(232, 25);
            this.txtmServerPort.TabIndex = 1;
            // 
            // txtmServerIP
            // 
            this.txtmServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmServerIP.HidePromptOnLeave = true;
            this.txtmServerIP.Location = new System.Drawing.Point(81, 25);
            this.txtmServerIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmServerIP.Name = "txtmServerIP";
            this.txtmServerIP.Size = new System.Drawing.Size(232, 25);
            this.txtmServerIP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 82);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "InnoStorm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mensarium";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MensariumDesktop.Properties.Resources.MensariumIconWhite;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // gbxLokacija
            // 
            this.gbxLokacija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLokacija.Controls.Add(this.cbxSettingsMenza);
            this.gbxLokacija.Controls.Add(this.lblMenza);
            this.gbxLokacija.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLokacija.Location = new System.Drawing.Point(13, 228);
            this.gbxLokacija.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxLokacija.Name = "gbxLokacija";
            this.gbxLokacija.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxLokacija.Size = new System.Drawing.Size(321, 70);
            this.gbxLokacija.TabIndex = 1;
            this.gbxLokacija.TabStop = false;
            this.gbxLokacija.Text = " Lokacija aplikacije ";
            // 
            // cbxSettingsMenza
            // 
            this.cbxSettingsMenza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSettingsMenza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSettingsMenza.FormattingEnabled = true;
            this.cbxSettingsMenza.Location = new System.Drawing.Point(81, 28);
            this.cbxSettingsMenza.Name = "cbxSettingsMenza";
            this.cbxSettingsMenza.Size = new System.Drawing.Size(232, 25);
            this.cbxSettingsMenza.TabIndex = 0;
            // 
            // lblMenza
            // 
            this.lblMenza.AutoSize = true;
            this.lblMenza.Location = new System.Drawing.Point(25, 31);
            this.lblMenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenza.Name = "lblMenza";
            this.lblMenza.Size = new System.Drawing.Size(47, 17);
            this.lblMenza.TabIndex = 7;
            this.lblMenza.Text = "Menza";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageKey = "save.png";
            this.btnSave.ImageList = this.imageListButtonIconsSettings;
            this.btnSave.Location = new System.Drawing.Point(102, 312);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = " Sačuvaj";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageKey = "error.png";
            this.btnCancel.ImageList = this.imageListButtonIconsSettings;
            this.btnCancel.Location = new System.Drawing.Point(222, 312);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = " Otkaži";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 361);
            this.Controls.Add(this.gbxLokacija);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensarium - Podešavanja";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gbxServer.ResumeLayout(false);
            this.gbxServer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbxLokacija.ResumeLayout(false);
            this.gbxLokacija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxServer;
        private System.Windows.Forms.MaskedTextBox txtmServerPort;
        private System.Windows.Forms.MaskedTextBox txtmServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbxLokacija;
        private System.Windows.Forms.ComboBox cbxSettingsMenza;
        private System.Windows.Forms.Label lblMenza;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.ImageList imageListButtonIconsSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}