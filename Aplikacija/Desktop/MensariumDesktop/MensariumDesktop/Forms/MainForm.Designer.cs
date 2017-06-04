using System.Drawing;
using MensariumDesktop;
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
            this.STATUS_statbarUser = new System.Windows.Forms.ToolStripDropDownButton();
            this.STATUS_statbarUserProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.STATUS_statbarUserSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.STATUS_statbarMenza = new System.Windows.Forms.ToolStripDropDownButton();
            this.STATUS_statbarMenzaChangeLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.STATUS_statbarSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.statbarDebug = new System.Windows.Forms.ToolStripDropDownButton();
            this.showSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLoginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReclamationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMensaChangerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProfileFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNewUserCreatedFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEBUGMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STATUS_statbarOPStatus = new System.Windows.Forms.ToolStripDropDownButton();
            this.tabControls = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HOME_btnProfile = new System.Windows.Forms.Button();
            this.imageListMainForm = new System.Windows.Forms.ImageList(this.components);
            this.HOME_btnMensaChanger = new System.Windows.Forms.Button();
            this.HOME_btnSettings = new System.Windows.Forms.Button();
            this.HOME_btnSignOut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.HOME_lblCurrentLocation = new System.Windows.Forms.Label();
            this.HOME_lblCurrentLocationAddress = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.HOME_picCurrentLocation = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HOME_lblCurrentUserFName = new System.Windows.Forms.Label();
            this.HOME_lblCurrentUserLName = new System.Windows.Forms.Label();
            this.HOME_lblCurrentUserAccType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HOME_picCurrentUser = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabUplata = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.UPLATA_btnLoadCard = new System.Windows.Forms.Button();
            this.btnExecutePay = new System.Windows.Forms.Button();
            this.btnReclamation = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.UPLATA_lblBreakfast = new System.Windows.Forms.Label();
            this.UPLATA_lblLunch = new System.Windows.Forms.Label();
            this.UPLATA_lblDinner = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtBreakfast = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.UPLATA_lblCardUserName = new System.Windows.Forms.Label();
            this.UPLATA_lblCardUserFax = new System.Windows.Forms.Label();
            this.UPLATA_lblCardUserDatebirth = new System.Windows.Forms.Label();
            this.UPLATA_lblCardUserIndex = new System.Windows.Forms.Label();
            this.UPLATA_lblCardUserValidUntil = new System.Windows.Forms.Label();
            this.UPLATA_picLoadedUser = new System.Windows.Forms.PictureBox();
            this.tabNaplata = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbxAccTypeChooser = new System.Windows.Forms.ComboBox();
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxKriterijum = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgWorkerLoading = new System.ComponentModel.BackgroundWorker();
            this.imageListOPStatus = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOME_picCurrentLocation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOME_picCurrentUser)).BeginInit();
            this.tabUplata.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPLATA_picLoadedUser)).BeginInit();
            this.tabNaplata.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabUsers.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STATUS_statbarUser,
            this.STATUS_statbarMenza,
            this.STATUS_statbarSettings,
            this.statbarDebug,
            this.toolStripStatusLabel1,
            this.STATUS_statbarOPStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 665);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1350, 27);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusBar";
            // 
            // STATUS_statbarUser
            // 
            this.STATUS_statbarUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.STATUS_statbarUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STATUS_statbarUserProfile,
            this.STATUS_statbarUserSignOut});
            this.STATUS_statbarUser.Image = global::MensariumDesktop.Properties.Resources.user_3;
            this.STATUS_statbarUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.STATUS_statbarUser.Name = "STATUS_statbarUser";
            this.STATUS_statbarUser.Size = new System.Drawing.Size(125, 25);
            this.STATUS_statbarUser.Text = "Ime Prezime";
            // 
            // STATUS_statbarUserProfile
            // 
            this.STATUS_statbarUserProfile.Name = "STATUS_statbarUserProfile";
            this.STATUS_statbarUserProfile.Size = new System.Drawing.Size(144, 26);
            this.STATUS_statbarUserProfile.Text = "Profil";
            this.STATUS_statbarUserProfile.Click += new System.EventHandler(this.statbarUserProfile_Click);
            // 
            // STATUS_statbarUserSignOut
            // 
            this.STATUS_statbarUserSignOut.Name = "STATUS_statbarUserSignOut";
            this.STATUS_statbarUserSignOut.Size = new System.Drawing.Size(144, 26);
            this.STATUS_statbarUserSignOut.Text = "Odjavi se";
            this.STATUS_statbarUserSignOut.Click += new System.EventHandler(this.statbarUserSignOut_Click);
            // 
            // STATUS_statbarMenza
            // 
            this.STATUS_statbarMenza.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STATUS_statbarMenzaChangeLocation});
            this.STATUS_statbarMenza.Image = global::MensariumDesktop.Properties.Resources.placeholder_3;
            this.STATUS_statbarMenza.Name = "STATUS_statbarMenza";
            this.STATUS_statbarMenza.Size = new System.Drawing.Size(125, 25);
            this.STATUS_statbarMenza.Text = "Menza XXXX";
            this.STATUS_statbarMenza.ToolTipText = "Lokacija gde je pokrenuta aplikacija";
            // 
            // STATUS_statbarMenzaChangeLocation
            // 
            this.STATUS_statbarMenzaChangeLocation.Name = "STATUS_statbarMenzaChangeLocation";
            this.STATUS_statbarMenzaChangeLocation.Size = new System.Drawing.Size(196, 26);
            this.STATUS_statbarMenzaChangeLocation.Text = "Promeni lokaciju";
            this.STATUS_statbarMenzaChangeLocation.Click += new System.EventHandler(this.promeniLokacijuToolStripMenuItem_Click);
            // 
            // STATUS_statbarSettings
            // 
            this.STATUS_statbarSettings.Image = global::MensariumDesktop.Properties.Resources.switch_5;
            this.STATUS_statbarSettings.Name = "STATUS_statbarSettings";
            this.STATUS_statbarSettings.ShowDropDownArrow = false;
            this.STATUS_statbarSettings.Size = new System.Drawing.Size(116, 25);
            this.STATUS_statbarSettings.Text = "Podešavanja";
            this.STATUS_statbarSettings.Click += new System.EventHandler(this.statusBarSettingsBtn_Click);
            // 
            // statbarDebug
            // 
            this.statbarDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSessionToolStripMenuItem,
            this.showLoginFormToolStripMenuItem,
            this.showReclamationFormToolStripMenuItem,
            this.showMensaChangerFormToolStripMenuItem,
            this.showProfileFormToolStripMenuItem,
            this.showUserFormToolStripMenuItem,
            this.showNewUserCreatedFormToolStripMenuItem,
            this.dEBUGMEToolStripMenuItem});
            this.statbarDebug.Image = global::MensariumDesktop.Properties.Resources.next;
            this.statbarDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statbarDebug.Name = "statbarDebug";
            this.statbarDebug.Size = new System.Drawing.Size(89, 25);
            this.statbarDebug.Text = "DEBUG";
            // 
            // showSessionToolStripMenuItem
            // 
            this.showSessionToolStripMenuItem.Name = "showSessionToolStripMenuItem";
            this.showSessionToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.showSessionToolStripMenuItem.Text = "Show Session";
            // 
            // showLoginFormToolStripMenuItem
            // 
            this.showLoginFormToolStripMenuItem.Name = "showLoginFormToolStripMenuItem";
            this.showLoginFormToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.showLoginFormToolStripMenuItem.Text = "Show Login Form";
            this.showLoginFormToolStripMenuItem.Click += new System.EventHandler(this.showLoginFormToolStripMenuItem_Click);
            // 
            // showReclamationFormToolStripMenuItem
            // 
            this.showReclamationFormToolStripMenuItem.Name = "showReclamationFormToolStripMenuItem";
            this.showReclamationFormToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.showReclamationFormToolStripMenuItem.Text = "Show Reclamation Form";
            this.showReclamationFormToolStripMenuItem.Click += new System.EventHandler(this.showReclamationFormToolStripMenuItem_Click);
            // 
            // showMensaChangerFormToolStripMenuItem
            // 
            this.showMensaChangerFormToolStripMenuItem.Name = "showMensaChangerFormToolStripMenuItem";
            this.showMensaChangerFormToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.showMensaChangerFormToolStripMenuItem.Text = "Show MensaChangerForm";
            this.showMensaChangerFormToolStripMenuItem.Click += new System.EventHandler(this.showMensaChangerFormToolStripMenuItem_Click);
            // 
            // showProfileFormToolStripMenuItem
            // 
            this.showProfileFormToolStripMenuItem.Name = "showProfileFormToolStripMenuItem";
            this.showProfileFormToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.showProfileFormToolStripMenuItem.Text = "Show Profile Form";
            this.showProfileFormToolStripMenuItem.Click += new System.EventHandler(this.showProfileFormToolStripMenuItem_Click);
            // 
            // showUserFormToolStripMenuItem
            // 
            this.showUserFormToolStripMenuItem.Name = "showUserFormToolStripMenuItem";
            this.showUserFormToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.showUserFormToolStripMenuItem.Text = "Show UserForm";
            this.showUserFormToolStripMenuItem.Click += new System.EventHandler(this.showUserFormToolStripMenuItem_Click);
            // 
            // showNewUserCreatedFormToolStripMenuItem
            // 
            this.showNewUserCreatedFormToolStripMenuItem.Name = "showNewUserCreatedFormToolStripMenuItem";
            this.showNewUserCreatedFormToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.showNewUserCreatedFormToolStripMenuItem.Text = "Show New User Created Form";
            this.showNewUserCreatedFormToolStripMenuItem.Click += new System.EventHandler(this.showNewUserCreatedFormToolStripMenuItem_Click);
            // 
            // dEBUGMEToolStripMenuItem
            // 
            this.dEBUGMEToolStripMenuItem.Name = "dEBUGMEToolStripMenuItem";
            this.dEBUGMEToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.dEBUGMEToolStripMenuItem.Text = "DEBUG ME";
            this.dEBUGMEToolStripMenuItem.Click += new System.EventHandler(this.dEBUGMEToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(880, 22);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // STATUS_statbarOPStatus
            // 
            this.STATUS_statbarOPStatus.Image = global::MensariumDesktop.Properties.Resources.internet;
            this.STATUS_statbarOPStatus.Name = "STATUS_statbarOPStatus";
            this.STATUS_statbarOPStatus.ShowDropDownArrow = false;
            this.STATUS_statbarOPStatus.Size = new System.Drawing.Size(20, 25);
            this.STATUS_statbarOPStatus.Visible = false;
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
            this.tabControls.Controls.Add(this.tabAdmin);
            this.tabControls.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControls.ImageList = this.imageListMainForm;
            this.tabControls.ItemSize = new System.Drawing.Size(64, 40);
            this.tabControls.Location = new System.Drawing.Point(0, 79);
            this.tabControls.Multiline = true;
            this.tabControls.Name = "tabControls";
            this.tabControls.Padding = new System.Drawing.Point(10, 3);
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(1350, 591);
            this.tabControls.TabIndex = 1;
            this.tabControls.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControls_Selecting);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabHome.Controls.Add(this.groupBox5);
            this.tabHome.Controls.Add(this.groupBox4);
            this.tabHome.Controls.Add(this.groupBox2);
            this.tabHome.Controls.Add(this.checkBox1);
            this.tabHome.ImageKey = "home.png";
            this.tabHome.Location = new System.Drawing.Point(4, 44);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1342, 543);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Početna";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 537);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Brze opcije";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.HOME_btnProfile);
            this.flowLayoutPanel1.Controls.Add(this.HOME_btnMensaChanger);
            this.flowLayoutPanel1.Controls.Add(this.HOME_btnSettings);
            this.flowLayoutPanel1.Controls.Add(this.HOME_btnSignOut);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 499);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // HOME_btnProfile
            // 
            this.HOME_btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HOME_btnProfile.BackColor = System.Drawing.Color.White;
            this.HOME_btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.HOME_btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOME_btnProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HOME_btnProfile.ImageKey = "id-card-4.png";
            this.HOME_btnProfile.ImageList = this.imageListMainForm;
            this.HOME_btnProfile.Location = new System.Drawing.Point(4, 20);
            this.HOME_btnProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HOME_btnProfile.Name = "HOME_btnProfile";
            this.HOME_btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HOME_btnProfile.Size = new System.Drawing.Size(219, 55);
            this.HOME_btnProfile.TabIndex = 14;
            this.HOME_btnProfile.Text = " Profil";
            this.HOME_btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HOME_btnProfile.UseVisualStyleBackColor = false;
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
            this.imageListMainForm.Images.SetKeyName(11, "plus.png");
            this.imageListMainForm.Images.SetKeyName(12, "edit.png");
            this.imageListMainForm.Images.SetKeyName(13, "id-card-4.png");
            this.imageListMainForm.Images.SetKeyName(14, "list-12.png");
            this.imageListMainForm.Images.SetKeyName(15, "list-13.png");
            this.imageListMainForm.Images.SetKeyName(16, "list-14.png");
            this.imageListMainForm.Images.SetKeyName(17, "notebook-12.png");
            this.imageListMainForm.Images.SetKeyName(18, "notebook-13.png");
            this.imageListMainForm.Images.SetKeyName(19, "user-20.png");
            this.imageListMainForm.Images.SetKeyName(20, "user-21.png");
            this.imageListMainForm.Images.SetKeyName(21, "user-22.png");
            this.imageListMainForm.Images.SetKeyName(22, "user-30.png");
            this.imageListMainForm.Images.SetKeyName(23, "user-32.png");
            this.imageListMainForm.Images.SetKeyName(24, "controls-1.png");
            this.imageListMainForm.Images.SetKeyName(25, "file-4.png");
            this.imageListMainForm.Images.SetKeyName(26, "speech-bubble-12.png");
            this.imageListMainForm.Images.SetKeyName(27, "building.png");
            this.imageListMainForm.Images.SetKeyName(28, "shuffle-1.png");
            this.imageListMainForm.Images.SetKeyName(29, "play-button-1.png");
            // 
            // HOME_btnMensaChanger
            // 
            this.HOME_btnMensaChanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HOME_btnMensaChanger.BackColor = System.Drawing.Color.White;
            this.HOME_btnMensaChanger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.HOME_btnMensaChanger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnMensaChanger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnMensaChanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOME_btnMensaChanger.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_btnMensaChanger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HOME_btnMensaChanger.ImageKey = "house.png";
            this.HOME_btnMensaChanger.ImageList = this.imageListMainForm;
            this.HOME_btnMensaChanger.Location = new System.Drawing.Point(4, 85);
            this.HOME_btnMensaChanger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HOME_btnMensaChanger.Name = "HOME_btnMensaChanger";
            this.HOME_btnMensaChanger.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HOME_btnMensaChanger.Size = new System.Drawing.Size(219, 55);
            this.HOME_btnMensaChanger.TabIndex = 11;
            this.HOME_btnMensaChanger.Text = " Promeni menzu";
            this.HOME_btnMensaChanger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HOME_btnMensaChanger.UseVisualStyleBackColor = false;
            this.HOME_btnMensaChanger.Click += new System.EventHandler(this.HOME_MensaChanger_Click);
            // 
            // HOME_btnSettings
            // 
            this.HOME_btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HOME_btnSettings.BackColor = System.Drawing.Color.White;
            this.HOME_btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.HOME_btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOME_btnSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HOME_btnSettings.ImageKey = "switch-5.png";
            this.HOME_btnSettings.ImageList = this.imageListMainForm;
            this.HOME_btnSettings.Location = new System.Drawing.Point(4, 150);
            this.HOME_btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HOME_btnSettings.Name = "HOME_btnSettings";
            this.HOME_btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HOME_btnSettings.Size = new System.Drawing.Size(219, 55);
            this.HOME_btnSettings.TabIndex = 12;
            this.HOME_btnSettings.Text = " Podešavanja";
            this.HOME_btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HOME_btnSettings.UseVisualStyleBackColor = false;
            this.HOME_btnSettings.Click += new System.EventHandler(this.HOME_btnSettings_Click);
            // 
            // HOME_btnSignOut
            // 
            this.HOME_btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HOME_btnSignOut.BackColor = System.Drawing.Color.White;
            this.HOME_btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.HOME_btnSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.HOME_btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOME_btnSignOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HOME_btnSignOut.ImageKey = "close.png";
            this.HOME_btnSignOut.ImageList = this.imageListMainForm;
            this.HOME_btnSignOut.Location = new System.Drawing.Point(4, 215);
            this.HOME_btnSignOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HOME_btnSignOut.Name = "HOME_btnSignOut";
            this.HOME_btnSignOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HOME_btnSignOut.Size = new System.Drawing.Size(219, 55);
            this.HOME_btnSignOut.TabIndex = 10;
            this.HOME_btnSignOut.Text = " Odjavi se";
            this.HOME_btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HOME_btnSignOut.UseVisualStyleBackColor = false;
            this.HOME_btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(243, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1093, 163);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menza";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.HOME_picCurrentLocation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 125);
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
            this.tableLayoutPanel2.Controls.Add(this.HOME_lblCurrentLocation, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.HOME_lblCurrentLocationAddress, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(118, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(969, 64);
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
            // HOME_lblCurrentLocation
            // 
            this.HOME_lblCurrentLocation.AutoSize = true;
            this.HOME_lblCurrentLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_lblCurrentLocation.Location = new System.Drawing.Point(123, 0);
            this.HOME_lblCurrentLocation.Name = "HOME_lblCurrentLocation";
            this.HOME_lblCurrentLocation.Size = new System.Drawing.Size(125, 25);
            this.HOME_lblCurrentLocation.TabIndex = 7;
            this.HOME_lblCurrentLocation.Text = "Naziv Menze";
            // 
            // HOME_lblCurrentLocationAddress
            // 
            this.HOME_lblCurrentLocationAddress.AutoSize = true;
            this.HOME_lblCurrentLocationAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_lblCurrentLocationAddress.Location = new System.Drawing.Point(123, 25);
            this.HOME_lblCurrentLocationAddress.Name = "HOME_lblCurrentLocationAddress";
            this.HOME_lblCurrentLocationAddress.Size = new System.Drawing.Size(137, 25);
            this.HOME_lblCurrentLocationAddress.TabIndex = 8;
            this.HOME_lblCurrentLocationAddress.Text = "Adresa Menze";
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
            // HOME_picCurrentLocation
            // 
            this.HOME_picCurrentLocation.BackColor = System.Drawing.Color.Transparent;
            this.HOME_picCurrentLocation.BackgroundImage = global::MensariumDesktop.Properties.Resources.house;
            this.HOME_picCurrentLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HOME_picCurrentLocation.ErrorImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.HOME_picCurrentLocation.InitialImage = null;
            this.HOME_picCurrentLocation.Location = new System.Drawing.Point(12, 13);
            this.HOME_picCurrentLocation.Name = "HOME_picCurrentLocation";
            this.HOME_picCurrentLocation.Size = new System.Drawing.Size(100, 100);
            this.HOME_picCurrentLocation.TabIndex = 0;
            this.HOME_picCurrentLocation.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(243, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1093, 162);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prijavljeni radnik";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.HOME_picCurrentUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 124);
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
            this.tableLayoutPanel1.Controls.Add(this.HOME_lblCurrentUserFName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HOME_lblCurrentUserLName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HOME_lblCurrentUserAccType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 87);
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
            // HOME_lblCurrentUserFName
            // 
            this.HOME_lblCurrentUserFName.AutoSize = true;
            this.HOME_lblCurrentUserFName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_lblCurrentUserFName.Location = new System.Drawing.Point(123, 0);
            this.HOME_lblCurrentUserFName.Name = "HOME_lblCurrentUserFName";
            this.HOME_lblCurrentUserFName.Size = new System.Drawing.Size(45, 25);
            this.HOME_lblCurrentUserFName.TabIndex = 7;
            this.HOME_lblCurrentUserFName.Text = "Ime";
            // 
            // HOME_lblCurrentUserLName
            // 
            this.HOME_lblCurrentUserLName.AutoSize = true;
            this.HOME_lblCurrentUserLName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_lblCurrentUserLName.Location = new System.Drawing.Point(123, 25);
            this.HOME_lblCurrentUserLName.Name = "HOME_lblCurrentUserLName";
            this.HOME_lblCurrentUserLName.Size = new System.Drawing.Size(83, 25);
            this.HOME_lblCurrentUserLName.TabIndex = 8;
            this.HOME_lblCurrentUserLName.Text = "Prezime";
            // 
            // HOME_lblCurrentUserAccType
            // 
            this.HOME_lblCurrentUserAccType.AutoSize = true;
            this.HOME_lblCurrentUserAccType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_lblCurrentUserAccType.Location = new System.Drawing.Point(123, 50);
            this.HOME_lblCurrentUserAccType.Name = "HOME_lblCurrentUserAccType";
            this.HOME_lblCurrentUserAccType.Size = new System.Drawing.Size(40, 25);
            this.HOME_lblCurrentUserAccType.TabIndex = 9;
            this.HOME_lblCurrentUserAccType.Text = "Tip";
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
            // HOME_picCurrentUser
            // 
            this.HOME_picCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.HOME_picCurrentUser.BackgroundImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.HOME_picCurrentUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HOME_picCurrentUser.ErrorImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.HOME_picCurrentUser.InitialImage = null;
            this.HOME_picCurrentUser.Location = new System.Drawing.Point(12, 13);
            this.HOME_picCurrentUser.Name = "HOME_picCurrentUser";
            this.HOME_picCurrentUser.Size = new System.Drawing.Size(100, 100);
            this.HOME_picCurrentUser.TabIndex = 0;
            this.HOME_picCurrentUser.TabStop = false;
            this.HOME_picCurrentUser.Paint += new System.Windows.Forms.PaintEventHandler(this.HOME_picCurrentUser_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 378);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 25);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabUplata
            // 
            this.tabUplata.Controls.Add(this.groupBox6);
            this.tabUplata.Controls.Add(this.groupBox3);
            this.tabUplata.Controls.Add(this.groupBox1);
            this.tabUplata.ImageKey = "list-13.png";
            this.tabUplata.Location = new System.Drawing.Point(4, 44);
            this.tabUplata.Name = "tabUplata";
            this.tabUplata.Padding = new System.Windows.Forms.Padding(3);
            this.tabUplata.Size = new System.Drawing.Size(1342, 543);
            this.tabUplata.TabIndex = 1;
            this.tabUplata.Text = "Uplata obroka";
            this.tabUplata.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.flowLayoutPanel2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 537);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kontrole";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.UPLATA_btnLoadCard);
            this.flowLayoutPanel2.Controls.Add(this.btnExecutePay);
            this.flowLayoutPanel2.Controls.Add(this.btnReclamation);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(228, 499);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // UPLATA_btnLoadCard
            // 
            this.UPLATA_btnLoadCard.BackColor = System.Drawing.Color.White;
            this.UPLATA_btnLoadCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.UPLATA_btnLoadCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.UPLATA_btnLoadCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.UPLATA_btnLoadCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UPLATA_btnLoadCard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPLATA_btnLoadCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_btnLoadCard.ImageKey = "id-card-3.png";
            this.UPLATA_btnLoadCard.ImageList = this.imageListMainForm;
            this.UPLATA_btnLoadCard.Location = new System.Drawing.Point(4, 20);
            this.UPLATA_btnLoadCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UPLATA_btnLoadCard.Name = "UPLATA_btnLoadCard";
            this.UPLATA_btnLoadCard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UPLATA_btnLoadCard.Size = new System.Drawing.Size(219, 55);
            this.UPLATA_btnLoadCard.TabIndex = 15;
            this.UPLATA_btnLoadCard.Text = " Učitaj karticu";
            this.UPLATA_btnLoadCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UPLATA_btnLoadCard.UseVisualStyleBackColor = false;
            this.UPLATA_btnLoadCard.Click += new System.EventHandler(this.UPLATA_btnLoadCard_Click);
            // 
            // btnExecutePay
            // 
            this.btnExecutePay.BackColor = System.Drawing.Color.White;
            this.btnExecutePay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.btnExecutePay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.btnExecutePay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.btnExecutePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutePay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutePay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecutePay.ImageKey = "notebook-13.png";
            this.btnExecutePay.ImageList = this.imageListMainForm;
            this.btnExecutePay.Location = new System.Drawing.Point(4, 85);
            this.btnExecutePay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExecutePay.Name = "btnExecutePay";
            this.btnExecutePay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExecutePay.Size = new System.Drawing.Size(219, 55);
            this.btnExecutePay.TabIndex = 18;
            this.btnExecutePay.Text = " Izvrši uplatu";
            this.btnExecutePay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExecutePay.UseVisualStyleBackColor = false;
            this.btnExecutePay.Click += new System.EventHandler(this.btnExecutePay_Click);
            // 
            // btnReclamation
            // 
            this.btnReclamation.BackColor = System.Drawing.Color.White;
            this.btnReclamation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.btnReclamation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.btnReclamation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.btnReclamation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReclamation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclamation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReclamation.ImageKey = "notebook-12.png";
            this.btnReclamation.ImageList = this.imageListMainForm;
            this.btnReclamation.Location = new System.Drawing.Point(4, 150);
            this.btnReclamation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReclamation.Name = "btnReclamation";
            this.btnReclamation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReclamation.Size = new System.Drawing.Size(219, 55);
            this.btnReclamation.TabIndex = 19;
            this.btnReclamation.Text = " Reklamacije";
            this.btnReclamation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReclamation.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.groupBox3.Location = new System.Drawing.Point(243, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1091, 178);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stanje na kartici";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.tableLayoutPanel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel5.Location = new System.Drawing.Point(3, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1085, 140);
            this.panel5.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtDinner, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtLunch, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_lblBreakfast, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_lblLunch, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_lblDinner, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox4, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox5, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtBreakfast, 3, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1079, 134);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // txtDinner
            // 
            this.txtDinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDinner.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDinner.Location = new System.Drawing.Point(182, 73);
            this.txtDinner.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(220, 29);
            this.txtDinner.TabIndex = 15;
            this.txtDinner.Text = "0";
            // 
            // txtLunch
            // 
            this.txtLunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLunch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLunch.Location = new System.Drawing.Point(182, 38);
            this.txtLunch.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(220, 29);
            this.txtLunch.TabIndex = 14;
            this.txtLunch.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 35);
            this.label17.TabIndex = 0;
            this.label17.Text = "Doručak";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label19.Location = new System.Drawing.Point(3, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 35);
            this.label19.TabIndex = 6;
            this.label19.Text = "Ručak";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label20.Location = new System.Drawing.Point(3, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 35);
            this.label20.TabIndex = 7;
            this.label20.Text = "Večera";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UPLATA_lblBreakfast
            // 
            this.UPLATA_lblBreakfast.AutoSize = true;
            this.UPLATA_lblBreakfast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UPLATA_lblBreakfast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_lblBreakfast.Location = new System.Drawing.Point(103, 0);
            this.UPLATA_lblBreakfast.Name = "UPLATA_lblBreakfast";
            this.UPLATA_lblBreakfast.Size = new System.Drawing.Size(44, 35);
            this.UPLATA_lblBreakfast.TabIndex = 5;
            this.UPLATA_lblBreakfast.Text = "7";
            this.UPLATA_lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPLATA_lblLunch
            // 
            this.UPLATA_lblLunch.AutoSize = true;
            this.UPLATA_lblLunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UPLATA_lblLunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_lblLunch.Location = new System.Drawing.Point(103, 35);
            this.UPLATA_lblLunch.Name = "UPLATA_lblLunch";
            this.UPLATA_lblLunch.Size = new System.Drawing.Size(44, 35);
            this.UPLATA_lblLunch.TabIndex = 8;
            this.UPLATA_lblLunch.Text = "3";
            this.UPLATA_lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPLATA_lblDinner
            // 
            this.UPLATA_lblDinner.AutoSize = true;
            this.UPLATA_lblDinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UPLATA_lblDinner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_lblDinner.Location = new System.Drawing.Point(103, 70);
            this.UPLATA_lblDinner.Name = "UPLATA_lblDinner";
            this.UPLATA_lblDinner.Size = new System.Drawing.Size(44, 35);
            this.UPLATA_lblDinner.TabIndex = 9;
            this.UPLATA_lblDinner.Text = "12";
            this.UPLATA_lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::MensariumDesktop.Properties.Resources.plus;
            this.pictureBox3.Location = new System.Drawing.Point(153, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::MensariumDesktop.Properties.Resources.plus;
            this.pictureBox4.Location = new System.Drawing.Point(153, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::MensariumDesktop.Properties.Resources.plus;
            this.pictureBox5.Location = new System.Drawing.Point(153, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // txtBreakfast
            // 
            this.txtBreakfast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBreakfast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakfast.Location = new System.Drawing.Point(182, 3);
            this.txtBreakfast.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.txtBreakfast.Name = "txtBreakfast";
            this.txtBreakfast.Size = new System.Drawing.Size(220, 29);
            this.txtBreakfast.TabIndex = 13;
            this.txtBreakfast.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.groupBox1.Location = new System.Drawing.Point(243, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 189);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Učitani korisnik";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.UPLATA_picLoadedUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1085, 151);
            this.panel4.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.UPLATA_lblCardUserName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.UPLATA_lblCardUserFax, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.UPLATA_lblCardUserDatebirth, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.UPLATA_lblCardUserIndex, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.UPLATA_lblCardUserValidUntil, 0, 4);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(148, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(934, 131);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // UPLATA_lblCardUserName
            // 
            this.UPLATA_lblCardUserName.AutoSize = true;
            this.UPLATA_lblCardUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPLATA_lblCardUserName.Location = new System.Drawing.Point(3, 0);
            this.UPLATA_lblCardUserName.Name = "UPLATA_lblCardUserName";
            this.UPLATA_lblCardUserName.Size = new System.Drawing.Size(116, 25);
            this.UPLATA_lblCardUserName.TabIndex = 7;
            this.UPLATA_lblCardUserName.Text = "Ime Prezime";
            // 
            // UPLATA_lblCardUserFax
            // 
            this.UPLATA_lblCardUserFax.AutoSize = true;
            this.UPLATA_lblCardUserFax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPLATA_lblCardUserFax.Location = new System.Drawing.Point(3, 25);
            this.UPLATA_lblCardUserFax.Name = "UPLATA_lblCardUserFax";
            this.UPLATA_lblCardUserFax.Size = new System.Drawing.Size(77, 25);
            this.UPLATA_lblCardUserFax.TabIndex = 8;
            this.UPLATA_lblCardUserFax.Text = "Fakultet";
            // 
            // UPLATA_lblCardUserDatebirth
            // 
            this.UPLATA_lblCardUserDatebirth.AutoSize = true;
            this.UPLATA_lblCardUserDatebirth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPLATA_lblCardUserDatebirth.Location = new System.Drawing.Point(3, 50);
            this.UPLATA_lblCardUserDatebirth.Name = "UPLATA_lblCardUserDatebirth";
            this.UPLATA_lblCardUserDatebirth.Size = new System.Drawing.Size(138, 25);
            this.UPLATA_lblCardUserDatebirth.TabIndex = 9;
            this.UPLATA_lblCardUserDatebirth.Text = "Datum rođenja";
            // 
            // UPLATA_lblCardUserIndex
            // 
            this.UPLATA_lblCardUserIndex.AutoSize = true;
            this.UPLATA_lblCardUserIndex.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPLATA_lblCardUserIndex.Location = new System.Drawing.Point(3, 75);
            this.UPLATA_lblCardUserIndex.Name = "UPLATA_lblCardUserIndex";
            this.UPLATA_lblCardUserIndex.Size = new System.Drawing.Size(58, 25);
            this.UPLATA_lblCardUserIndex.TabIndex = 10;
            this.UPLATA_lblCardUserIndex.Text = "Index";
            // 
            // UPLATA_lblCardUserValidUntil
            // 
            this.UPLATA_lblCardUserValidUntil.AutoSize = true;
            this.UPLATA_lblCardUserValidUntil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPLATA_lblCardUserValidUntil.Location = new System.Drawing.Point(3, 100);
            this.UPLATA_lblCardUserValidUntil.Name = "UPLATA_lblCardUserValidUntil";
            this.UPLATA_lblCardUserValidUntil.Size = new System.Drawing.Size(209, 25);
            this.UPLATA_lblCardUserValidUntil.TabIndex = 11;
            this.UPLATA_lblCardUserValidUntil.Text = "Validna do: dd.mm.yyyy";
            // 
            // UPLATA_picLoadedUser
            // 
            this.UPLATA_picLoadedUser.BackColor = System.Drawing.Color.Transparent;
            this.UPLATA_picLoadedUser.BackgroundImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.UPLATA_picLoadedUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UPLATA_picLoadedUser.ErrorImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.UPLATA_picLoadedUser.InitialImage = null;
            this.UPLATA_picLoadedUser.Location = new System.Drawing.Point(11, 13);
            this.UPLATA_picLoadedUser.Name = "UPLATA_picLoadedUser";
            this.UPLATA_picLoadedUser.Size = new System.Drawing.Size(131, 131);
            this.UPLATA_picLoadedUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UPLATA_picLoadedUser.TabIndex = 0;
            this.UPLATA_picLoadedUser.TabStop = false;
            this.UPLATA_picLoadedUser.Paint += new System.Windows.Forms.PaintEventHandler(this.UPLATA_picLoadedUser_Paint);
            // 
            // tabNaplata
            // 
            this.tabNaplata.Controls.Add(this.groupBox9);
            this.tabNaplata.Controls.Add(this.groupBox8);
            this.tabNaplata.Controls.Add(this.groupBox7);
            this.tabNaplata.ImageKey = "list-14.png";
            this.tabNaplata.Location = new System.Drawing.Point(4, 44);
            this.tabNaplata.Name = "tabNaplata";
            this.tabNaplata.Padding = new System.Windows.Forms.Padding(3);
            this.tabNaplata.Size = new System.Drawing.Size(1342, 543);
            this.tabNaplata.TabIndex = 2;
            this.tabNaplata.Text = "Naplata obroka";
            this.tabNaplata.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.panel7);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.groupBox9.Location = new System.Drawing.Point(243, 195);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1091, 157);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Stanje na kartici";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.tableLayoutPanel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel7.Location = new System.Drawing.Point(3, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1085, 119);
            this.panel7.TabIndex = 17;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label18, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox6, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox7, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox8, 2, 2);
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1079, 113);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doručak";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label12.Location = new System.Drawing.Point(3, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 35);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ručak";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label13.Location = new System.Drawing.Point(3, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 35);
            this.label13.TabIndex = 7;
            this.label13.Text = "Večera";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(103, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 35);
            this.label15.TabIndex = 5;
            this.label15.Text = "7";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(103, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 35);
            this.label16.TabIndex = 8;
            this.label16.Text = "3";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(103, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 35);
            this.label18.TabIndex = 9;
            this.label18.Text = "12";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::MensariumDesktop.Properties.Resources.minus;
            this.pictureBox6.Location = new System.Drawing.Point(153, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(153, 38);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(153, 73);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(19, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.flowLayoutPanel3);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(234, 537);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kontrole";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.label21);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Controls.Add(this.button4);
            this.flowLayoutPanel3.Controls.Add(this.button5);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(228, 499);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "id-card-3.png";
            this.button1.ImageList = this.imageListMainForm;
            this.button1.Location = new System.Drawing.Point(4, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(219, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = " Učitaj karticu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(3, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 25);
            this.label21.TabIndex = 22;
            this.label21.Text = "Naplati";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "notebook-13.png";
            this.button2.ImageList = this.imageListMainForm;
            this.button2.Location = new System.Drawing.Point(4, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(219, 55);
            this.button2.TabIndex = 18;
            this.button2.Text = " Doručak";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "notebook-13.png";
            this.button3.ImageList = this.imageListMainForm;
            this.button3.Location = new System.Drawing.Point(4, 175);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(219, 55);
            this.button3.TabIndex = 19;
            this.button3.Text = " Ručak";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "notebook-13.png";
            this.button4.ImageList = this.imageListMainForm;
            this.button4.Location = new System.Drawing.Point(4, 240);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(219, 55);
            this.button4.TabIndex = 20;
            this.button4.Text = " Večera";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageKey = "notebook-13.png";
            this.button5.ImageList = this.imageListMainForm;
            this.button5.Location = new System.Drawing.Point(4, 305);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(219, 55);
            this.button5.TabIndex = 23;
            this.button5.Text = " Ručak i večera";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.panel6);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.groupBox7.Location = new System.Drawing.Point(243, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1091, 189);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Učitani korisnik";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.tableLayoutPanel5);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1085, 151);
            this.panel6.TabIndex = 16;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(118, 13);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(964, 131);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fakultet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Datum rođenja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Index";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Validna do: dd.mm.yyyy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(12, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.groupBox11);
            this.tabUsers.Controls.Add(this.groupBox10);
            this.tabUsers.ImageKey = "users.png";
            this.tabUsers.Location = new System.Drawing.Point(4, 44);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1342, 543);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Korisnici";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.panel8);
            this.groupBox11.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.groupBox11.Location = new System.Drawing.Point(243, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1093, 537);
            this.groupBox11.TabIndex = 25;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Korisnici";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.cbxAccTypeChooser);
            this.panel8.Controls.Add(this.dgvMeals);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.cbxKriterijum);
            this.panel8.Controls.Add(this.label22);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel8.Location = new System.Drawing.Point(3, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1087, 499);
            this.panel8.TabIndex = 16;
            // 
            // cbxAccTypeChooser
            // 
            this.cbxAccTypeChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAccTypeChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccTypeChooser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxAccTypeChooser.FormattingEnabled = true;
            this.cbxAccTypeChooser.Items.AddRange(new object[] {
            "Prikaži samo aktivne naloge",
            "Prikaži samo neaktivne naloge",
            "Prikaži i aktivne i neaktivne naloge"});
            this.cbxAccTypeChooser.Location = new System.Drawing.Point(3, 471);
            this.cbxAccTypeChooser.Name = "cbxAccTypeChooser";
            this.cbxAccTypeChooser.Size = new System.Drawing.Size(1081, 25);
            this.cbxAccTypeChooser.TabIndex = 29;
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
            this.dgvMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.FName,
            this.LName,
            this.Email,
            this.Birthdate,
            this.DReg,
            this.Phone,
            this.dgFaculty,
            this.Index});
            this.dgvMeals.Location = new System.Drawing.Point(3, 34);
            this.dgvMeals.MultiSelect = false;
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.ReadOnly = true;
            this.dgvMeals.RowHeadersVisible = false;
            this.dgvMeals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeals.ShowEditingIcon = false;
            this.dgvMeals.Size = new System.Drawing.Size(1081, 436);
            this.dgvMeals.TabIndex = 28;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Username
            // 
            this.Username.HeaderText = "Korisničko ime";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.HeaderText = "Ime";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "Prezime";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Datum rodjenja";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // DReg
            // 
            this.DReg.HeaderText = "Datum registracije";
            this.DReg.Name = "DReg";
            this.DReg.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Telefon";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // dgFaculty
            // 
            this.dgFaculty.HeaderText = "Fakultet";
            this.dgFaculty.Name = "dgFaculty";
            this.dgFaculty.ReadOnly = true;
            // 
            // Index
            // 
            this.Index.HeaderText = "Indeks";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(70, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 25);
            this.textBox1.TabIndex = 27;
            // 
            // cbxKriterijum
            // 
            this.cbxKriterijum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxKriterijum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKriterijum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxKriterijum.FormattingEnabled = true;
            this.cbxKriterijum.Items.AddRange(new object[] {
            "ID",
            "Ime i prezime",
            "Korisnicko ime",
            "Email",
            "Broj telefona",
            "Fakultet"});
            this.cbxKriterijum.Location = new System.Drawing.Point(919, 3);
            this.cbxKriterijum.Name = "cbxKriterijum";
            this.cbxKriterijum.Size = new System.Drawing.Size(165, 25);
            this.cbxKriterijum.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 19);
            this.label22.TabIndex = 25;
            this.label22.Text = "Pretraga";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.flowLayoutPanel4);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox10.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(234, 537);
            this.groupBox10.TabIndex = 23;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Kontrole";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.button9);
            this.flowLayoutPanel4.Controls.Add(this.button6);
            this.flowLayoutPanel4.Controls.Add(this.button7);
            this.flowLayoutPanel4.Controls.Add(this.button8);
            this.flowLayoutPanel4.Controls.Add(this.button14);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(228, 499);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageKey = "user-30.png";
            this.button9.ImageList = this.imageListMainForm;
            this.button9.Location = new System.Drawing.Point(4, 20);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(219, 55);
            this.button9.TabIndex = 20;
            this.button9.Text = " Pregledaj profil";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageKey = "user-20.png";
            this.button6.ImageList = this.imageListMainForm;
            this.button6.Location = new System.Drawing.Point(4, 85);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(219, 55);
            this.button6.TabIndex = 15;
            this.button6.Text = " Dodaj novog";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageKey = "user-32.png";
            this.button7.ImageList = this.imageListMainForm;
            this.button7.Location = new System.Drawing.Point(4, 150);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(219, 55);
            this.button7.TabIndex = 18;
            this.button7.Text = " Izmeni";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageKey = "user-21.png";
            this.button8.ImageList = this.imageListMainForm;
            this.button8.Location = new System.Drawing.Point(4, 215);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(219, 55);
            this.button8.TabIndex = 19;
            this.button8.Text = " Deaktiviraj";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.ImageKey = "user-22.png";
            this.button14.ImageList = this.imageListMainForm;
            this.button14.Location = new System.Drawing.Point(4, 280);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(219, 55);
            this.button14.TabIndex = 21;
            this.button14.Text = " Obriši";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // tabAdmin
            // 
            this.tabAdmin.AutoScroll = true;
            this.tabAdmin.Controls.Add(this.groupBox13);
            this.tabAdmin.Controls.Add(this.groupBox12);
            this.tabAdmin.ImageKey = "controls-1.png";
            this.tabAdmin.Location = new System.Drawing.Point(4, 44);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(1342, 543);
            this.tabAdmin.TabIndex = 4;
            this.tabAdmin.Text = "Admin Panel";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.panel9);
            this.groupBox13.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox13.Location = new System.Drawing.Point(241, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1098, 537);
            this.groupBox13.TabIndex = 23;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Status servera";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.label27);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1092, 499);
            this.panel9.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(234, 32);
            this.label27.TabIndex = 0;
            this.label27.Text = "PRO VERSION ONLY";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.flowLayoutPanel5);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox12.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(234, 537);
            this.groupBox12.TabIndex = 22;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Kontrole";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.Controls.Add(this.label23);
            this.flowLayoutPanel5.Controls.Add(this.button10);
            this.flowLayoutPanel5.Controls.Add(this.label24);
            this.flowLayoutPanel5.Controls.Add(this.button11);
            this.flowLayoutPanel5.Controls.Add(this.label25);
            this.flowLayoutPanel5.Controls.Add(this.button12);
            this.flowLayoutPanel5.Controls.Add(this.label26);
            this.flowLayoutPanel5.Controls.Add(this.button13);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(228, 499);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(3, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 25);
            this.label23.TabIndex = 23;
            this.label23.Text = "Fakulteti";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.ImageKey = "building.png";
            this.button10.ImageList = this.imageListMainForm;
            this.button10.Location = new System.Drawing.Point(4, 45);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(219, 55);
            this.button10.TabIndex = 15;
            this.button10.Text = " Uređivanje";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(3, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 25);
            this.label24.TabIndex = 24;
            this.label24.Text = "Menze";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.ImageKey = "house.png";
            this.button11.ImageList = this.imageListMainForm;
            this.button11.Location = new System.Drawing.Point(4, 135);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(219, 55);
            this.button11.TabIndex = 18;
            this.button11.Text = " Uređivanje";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(3, 195);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 25);
            this.label25.TabIndex = 25;
            this.label25.Text = "Objave korisnika";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.ImageKey = "speech-bubble-12.png";
            this.button12.ImageList = this.imageListMainForm;
            this.button12.Location = new System.Drawing.Point(4, 225);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(219, 55);
            this.button12.TabIndex = 19;
            this.button12.Text = " Uređivanje";
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(3, 285);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(142, 25);
            this.label26.TabIndex = 26;
            this.label26.Text = "Sesije korisnika";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.ImageKey = "shuffle-1.png";
            this.button13.ImageList = this.imageListMainForm;
            this.button13.Location = new System.Drawing.Point(4, 315);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(219, 55);
            this.button13.TabIndex = 27;
            this.button13.Text = " Uređivanje";
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(68, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 33);
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
            this.panel1.Size = new System.Drawing.Size(1350, 692);
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
            // bgWorkerLoading
            // 
            this.bgWorkerLoading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerLoading_DoWork);
            this.bgWorkerLoading.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerLoading_RunWorkerCompleted);
            // 
            // imageListOPStatus
            // 
            this.imageListOPStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOPStatus.ImageStream")));
            this.imageListOPStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOPStatus.Images.SetKeyName(0, "error.png");
            this.imageListOPStatus.Images.SetKeyName(1, "success.png");
            this.imageListOPStatus.Images.SetKeyName(2, "working.png");
            this.imageListOPStatus.Images.SetKeyName(3, "internet.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 692);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControls.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOME_picCurrentLocation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOME_picCurrentUser)).EndInit();
            this.tabUplata.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPLATA_picLoadedUser)).EndInit();
            this.tabNaplata.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripDropDownButton STATUS_statbarUser;
        private System.Windows.Forms.ToolStripMenuItem STATUS_statbarUserProfile;
        private System.Windows.Forms.ToolStripMenuItem STATUS_statbarUserSignOut;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
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
        private System.Windows.Forms.ToolStripDropDownButton STATUS_statbarSettings;
        private System.Windows.Forms.ToolStripDropDownButton statbarDebug;
        private System.Windows.Forms.ToolStripMenuItem showSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLoginFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton STATUS_statbarMenza;
        private System.Windows.Forms.ToolStripMenuItem STATUS_statbarMenzaChangeLocation;
        private System.Windows.Forms.PictureBox HOME_picCurrentUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HOME_lblCurrentUserFName;
        private System.Windows.Forms.Label HOME_lblCurrentUserLName;
        private System.Windows.Forms.Label HOME_lblCurrentUserAccType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HOME_lblCurrentLocation;
        private System.Windows.Forms.Label HOME_lblCurrentLocationAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox HOME_picCurrentLocation;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button HOME_btnSignOut;
        private System.Windows.Forms.Button HOME_btnMensaChanger;
        private System.Windows.Forms.Button HOME_btnSettings;
        private System.Windows.Forms.Button HOME_btnProfile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label UPLATA_lblCardUserName;
        private System.Windows.Forms.Label UPLATA_lblCardUserFax;
        private System.Windows.Forms.Label UPLATA_lblCardUserDatebirth;
        private System.Windows.Forms.PictureBox UPLATA_picLoadedUser;
        private System.Windows.Forms.Button UPLATA_btnLoadCard;
        private System.Windows.Forms.Label UPLATA_lblCardUserIndex;
        private System.Windows.Forms.Label UPLATA_lblCardUserValidUntil;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnExecutePay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label UPLATA_lblBreakfast;
        private System.Windows.Forms.Label UPLATA_lblLunch;
        private System.Windows.Forms.Label UPLATA_lblDinner;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtBreakfast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnReclamation;
        private System.Windows.Forms.ToolStripDropDownButton STATUS_statbarOPStatus;
        private System.Windows.Forms.ToolStripMenuItem showReclamationFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMensaChangerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProfileFormToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxKriterijum;
        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.ToolStripMenuItem showUserFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNewUserCreatedFormToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ComboBox cbxAccTypeChooser;
        private System.Windows.Forms.ToolStripMenuItem dEBUGMEToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.ComponentModel.BackgroundWorker bgWorkerLoading;
        private System.Windows.Forms.ImageList imageListOPStatus;
    }
}

