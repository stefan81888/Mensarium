using System.Drawing;

namespace MensariumDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControls = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentUserFName = new System.Windows.Forms.Label();
            this.lblCurrentUserLName = new System.Windows.Forms.Label();
            this.lblCurrentUserAccType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUplata = new System.Windows.Forms.TabPage();
            this.tabNaplata = new System.Windows.Forms.TabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageListMainForm = new System.Windows.Forms.ImageList(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pcbCurrentLocation = new System.Windows.Forms.PictureBox();
            this.pcbCurrentUser = new System.Windows.Forms.PictureBox();
            this.statusBarProfileBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarLocation = new System.Windows.Forms.ToolStripDropDownButton();
            this.promeniLokacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarSettingsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusBarDebug = new System.Windows.Forms.ToolStripDropDownButton();
            this.showSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLoginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarLblOnline = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarProfileBtn,
            this.statusBarLocation,
            this.statusBarSettingsBtn,
            this.statusBarDebug,
            this.toolStripStatusLabel1,
            this.statusBarLblOnline});
            this.statusStrip.Location = new System.Drawing.Point(0, 690);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1122, 27);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusBar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(579, 22);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tabControls
            // 
            this.tabControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControls.Controls.Add(this.tabHome);
            this.tabControls.Controls.Add(this.tabUplata);
            this.tabControls.Controls.Add(this.tabNaplata);
            this.tabControls.Controls.Add(this.tabUsers);
            this.tabControls.Controls.Add(this.tabPage1);
            this.tabControls.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControls.ImageList = this.imageListMainForm;
            this.tabControls.ItemSize = new System.Drawing.Size(64, 40);
            this.tabControls.Location = new System.Drawing.Point(0, 79);
            this.tabControls.Multiline = true;
            this.tabControls.Name = "tabControls";
            this.tabControls.Padding = new System.Drawing.Point(10, 3);
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(1122, 616);
            this.tabControls.TabIndex = 1;
            this.tabControls.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControls_Selecting);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabHome.Controls.Add(this.flowLayoutPanel1);
            this.tabHome.Controls.Add(this.checkBox1);
            this.tabHome.Controls.Add(this.panel3);
            this.tabHome.Controls.Add(this.panel2);
            this.tabHome.ImageKey = "home.png";
            this.tabHome.Location = new System.Drawing.Point(4, 44);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1114, 568);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Početna";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 562);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Brze opcije";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageKey = "close.png";
            this.btnSave.ImageList = this.imageListMainForm;
            this.btnSave.Location = new System.Drawing.Point(4, 232);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = " Odjavi se";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "house.png";
            this.button1.ImageList = this.imageListMainForm;
            this.button1.Location = new System.Drawing.Point(4, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = " Promeni menzu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageKey = "switch-5.png";
            this.button2.ImageList = this.imageListMainForm;
            this.button2.Location = new System.Drawing.Point(4, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = " Podešavanja";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 25);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.pcbCurrentLocation);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(255, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 176);
            this.panel3.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.4186F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(115, 72);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 64);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adresa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(123, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Naziv Menze";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(123, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "Adresa Menze";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Naziv";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Menza";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.pcbCurrentUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(255, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 176);
            this.panel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.4186F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentUserFName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentUserLName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentUserAccType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 87);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tip naloga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prezime";
            // 
            // lblCurrentUserFName
            // 
            this.lblCurrentUserFName.AutoSize = true;
            this.lblCurrentUserFName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserFName.Location = new System.Drawing.Point(123, 0);
            this.lblCurrentUserFName.Name = "lblCurrentUserFName";
            this.lblCurrentUserFName.Size = new System.Drawing.Size(45, 25);
            this.lblCurrentUserFName.TabIndex = 7;
            this.lblCurrentUserFName.Text = "Ime";
            // 
            // lblCurrentUserLName
            // 
            this.lblCurrentUserLName.AutoSize = true;
            this.lblCurrentUserLName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserLName.Location = new System.Drawing.Point(123, 25);
            this.lblCurrentUserLName.Name = "lblCurrentUserLName";
            this.lblCurrentUserLName.Size = new System.Drawing.Size(83, 25);
            this.lblCurrentUserLName.TabIndex = 8;
            this.lblCurrentUserLName.Text = "Prezime";
            // 
            // lblCurrentUserAccType
            // 
            this.lblCurrentUserAccType.AutoSize = true;
            this.lblCurrentUserAccType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserAccType.Location = new System.Drawing.Point(123, 50);
            this.lblCurrentUserAccType.Name = "lblCurrentUserAccType";
            this.lblCurrentUserAccType.Size = new System.Drawing.Size(40, 25);
            this.lblCurrentUserAccType.TabIndex = 9;
            this.lblCurrentUserAccType.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prijavljeni korisnik";
            // 
            // tabUplata
            // 
            this.tabUplata.ImageKey = "list-13.png";
            this.tabUplata.Location = new System.Drawing.Point(4, 44);
            this.tabUplata.Name = "tabUplata";
            this.tabUplata.Padding = new System.Windows.Forms.Padding(3);
            this.tabUplata.Size = new System.Drawing.Size(1114, 568);
            this.tabUplata.TabIndex = 1;
            this.tabUplata.Text = "Uplata obroka";
            this.tabUplata.UseVisualStyleBackColor = true;
            // 
            // tabNaplata
            // 
            this.tabNaplata.ImageKey = "list-14.png";
            this.tabNaplata.Location = new System.Drawing.Point(4, 44);
            this.tabNaplata.Name = "tabNaplata";
            this.tabNaplata.Size = new System.Drawing.Size(1114, 568);
            this.tabNaplata.TabIndex = 2;
            this.tabNaplata.Text = "Naplata obroka";
            this.tabNaplata.UseVisualStyleBackColor = true;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.textBox1);
            this.tabUsers.ImageKey = "users.png";
            this.tabUsers.Location = new System.Drawing.Point(4, 44);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1114, 568);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Korisnici";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 29);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 568);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageListMainForm
            // 
            this.imageListMainForm.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMainForm.ImageStream")));
            this.imageListMainForm.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMainForm.Images.SetKeyName(0, "list-13.png");
            this.imageListMainForm.Images.SetKeyName(1, "list-14.png");
            this.imageListMainForm.Images.SetKeyName(2, "user-3.png");
            this.imageListMainForm.Images.SetKeyName(3, "home.png");
            this.imageListMainForm.Images.SetKeyName(4, "id-card-3.png");
            this.imageListMainForm.Images.SetKeyName(5, "users.png");
            this.imageListMainForm.Images.SetKeyName(6, "close.png");
            this.imageListMainForm.Images.SetKeyName(7, "controls-3.png");
            this.imageListMainForm.Images.SetKeyName(8, "id-card-3.png");
            this.imageListMainForm.Images.SetKeyName(9, "switch-5.png");
            this.imageListMainForm.Images.SetKeyName(10, "house.png");
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Humnst777 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(68, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(183, 36);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Mensarium";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 717);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "InnoStorm";
            // 
            // pcbCurrentLocation
            // 
            this.pcbCurrentLocation.BackColor = System.Drawing.Color.Transparent;
            this.pcbCurrentLocation.BackgroundImage = global::MensariumDesktop.Properties.Resources.house;
            this.pcbCurrentLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbCurrentLocation.ErrorImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.pcbCurrentLocation.InitialImage = null;
            this.pcbCurrentLocation.Location = new System.Drawing.Point(9, 54);
            this.pcbCurrentLocation.Name = "pcbCurrentLocation";
            this.pcbCurrentLocation.Size = new System.Drawing.Size(100, 100);
            this.pcbCurrentLocation.TabIndex = 0;
            this.pcbCurrentLocation.TabStop = false;
            // 
            // pcbCurrentUser
            // 
            this.pcbCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.pcbCurrentUser.BackgroundImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.pcbCurrentUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbCurrentUser.ErrorImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.pcbCurrentUser.InitialImage = null;
            this.pcbCurrentUser.Location = new System.Drawing.Point(9, 54);
            this.pcbCurrentUser.Name = "pcbCurrentUser";
            this.pcbCurrentUser.Size = new System.Drawing.Size(100, 100);
            this.pcbCurrentUser.TabIndex = 0;
            this.pcbCurrentUser.TabStop = false;
            // 
            // statusBarProfileBtn
            // 
            this.statusBarProfileBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusBarProfileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.statusBarProfileBtn.Image = global::MensariumDesktop.Properties.Resources.user_3;
            this.statusBarProfileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusBarProfileBtn.Name = "statusBarProfileBtn";
            this.statusBarProfileBtn.Size = new System.Drawing.Size(125, 25);
            this.statusBarProfileBtn.Text = "Ime Prezime";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            // 
            // statusBarLocation
            // 
            this.statusBarLocation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promeniLokacijuToolStripMenuItem});
            this.statusBarLocation.Image = global::MensariumDesktop.Properties.Resources.placeholder_3;
            this.statusBarLocation.Name = "statusBarLocation";
            this.statusBarLocation.Size = new System.Drawing.Size(125, 25);
            this.statusBarLocation.Text = "Menza XXXX";
            // 
            // promeniLokacijuToolStripMenuItem
            // 
            this.promeniLokacijuToolStripMenuItem.Name = "promeniLokacijuToolStripMenuItem";
            this.promeniLokacijuToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.promeniLokacijuToolStripMenuItem.Text = "Promeni lokaciju";
            // 
            // statusBarSettingsBtn
            // 
            this.statusBarSettingsBtn.Image = global::MensariumDesktop.Properties.Resources.switch_5;
            this.statusBarSettingsBtn.Name = "statusBarSettingsBtn";
            this.statusBarSettingsBtn.ShowDropDownArrow = false;
            this.statusBarSettingsBtn.Size = new System.Drawing.Size(117, 25);
            this.statusBarSettingsBtn.Text = "Podešavanja";
            this.statusBarSettingsBtn.Click += new System.EventHandler(this.statusBarSettingsBtn_Click);
            // 
            // statusBarDebug
            // 
            this.statusBarDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSessionToolStripMenuItem,
            this.showLoginFormToolStripMenuItem});
            this.statusBarDebug.Image = global::MensariumDesktop.Properties.Resources.next;
            this.statusBarDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusBarDebug.Name = "statusBarDebug";
            this.statusBarDebug.Size = new System.Drawing.Size(89, 25);
            this.statusBarDebug.Text = "DEBUG";
            // 
            // showSessionToolStripMenuItem
            // 
            this.showSessionToolStripMenuItem.Name = "showSessionToolStripMenuItem";
            this.showSessionToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.showSessionToolStripMenuItem.Text = "Show Session";
            // 
            // showLoginFormToolStripMenuItem
            // 
            this.showLoginFormToolStripMenuItem.Name = "showLoginFormToolStripMenuItem";
            this.showLoginFormToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.showLoginFormToolStripMenuItem.Text = "Show Login Form";
            this.showLoginFormToolStripMenuItem.Click += new System.EventHandler(this.showLoginFormToolStripMenuItem_Click);
            // 
            // statusBarLblOnline
            // 
            this.statusBarLblOnline.Image = global::MensariumDesktop.Properties.Resources.internet;
            this.statusBarLblOnline.Name = "statusBarLblOnline";
            this.statusBarLblOnline.Size = new System.Drawing.Size(72, 22);
            this.statusBarLblOnline.Text = "Online";
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
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageKey = "id-card-3.png";
            this.button3.ImageList = this.imageListMainForm;
            this.button3.Location = new System.Drawing.Point(4, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = " Profil";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1122, 717);
            this.Controls.Add(this.tabControls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensarium";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControls.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCurrentUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripDropDownButton statusBarProfileBtn;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLblOnline;
        private System.Windows.Forms.TabControl tabControls;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabUplata;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabNaplata;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.ImageList imageListMainForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripDropDownButton statusBarSettingsBtn;
        private System.Windows.Forms.ToolStripDropDownButton statusBarDebug;
        private System.Windows.Forms.ToolStripMenuItem showSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLoginFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton statusBarLocation;
        private System.Windows.Forms.ToolStripMenuItem promeniLokacijuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbCurrentUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentUserFName;
        private System.Windows.Forms.Label lblCurrentUserLName;
        private System.Windows.Forms.Label lblCurrentUserAccType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pcbCurrentLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

