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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 23D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 75D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 53D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 63D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 25D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 17D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 53D);
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
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.UPLATA_lblTotalPrice = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.UPLATA_lblBreakfastCount = new System.Windows.Forms.Label();
            this.UPLATA_lblLunchCount = new System.Windows.Forms.Label();
            this.UPLATA_lblDinnerCount = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.UPLATA_txtBreakfastTotal = new System.Windows.Forms.TextBox();
            this.UPLATA_txtLunchTotal = new System.Windows.Forms.TextBox();
            this.UPLATA_txtDinnerTotal = new System.Windows.Forms.TextBox();
            this.UPLATA_lblBreakfastPrice = new System.Windows.Forms.Label();
            this.UPLATA_lblLunchPrice = new System.Windows.Forms.Label();
            this.UPLATA_lblDinnerPrice = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.UPLATA_btnLoadCard = new System.Windows.Forms.Button();
            this.btnExecutePay = new System.Windows.Forms.Button();
            this.btnReclamation = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UPLATA_txtDinner = new System.Windows.Forms.TextBox();
            this.UPLATA_txtLunch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.UPLATA_lblBreakfast = new System.Windows.Forms.Label();
            this.UPLATA_lblLunch = new System.Windows.Forms.Label();
            this.UPLATA_lblDinner = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.UPLATA_txtBreakfast = new System.Windows.Forms.TextBox();
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
            this.NAPLATA_lblBreakfastCount = new System.Windows.Forms.Label();
            this.NAPLATA_lblLunchCount = new System.Windows.Forms.Label();
            this.NAPLATA_lblDinnerCount = new System.Windows.Forms.Label();
            this.NAPLATA_picBminus = new System.Windows.Forms.PictureBox();
            this.NAPLATA_picLminus = new System.Windows.Forms.PictureBox();
            this.NAPLATA_picDminus = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.NAPLATA_btnLoadCard = new System.Windows.Forms.Button();
            this.NAPLATA_btnReclamation = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.NAPLATA_btnUseBreakfast = new System.Windows.Forms.Button();
            this.NAPLATA_btnUseLunch = new System.Windows.Forms.Button();
            this.NAPLATA_btnUseDinner = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.NAPLATA_lblUserName = new System.Windows.Forms.Label();
            this.NAPLATA_lblUserFax = new System.Windows.Forms.Label();
            this.NAPLATA_lblUserBday = new System.Windows.Forms.Label();
            this.NAPLATA_lblUserIndex = new System.Windows.Forms.Label();
            this.NAPLATA_lblUserValidUntil = new System.Windows.Forms.Label();
            this.NAPLATA_picLoadedUser = new System.Windows.Forms.PictureBox();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.KORSN_cbxAccTypeChooser = new System.Windows.Forms.ComboBox();
            this.KORSN_dgvUsers = new System.Windows.Forms.DataGridView();
            this.KORSN_txtSearch = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.KORSN_btnProfile = new System.Windows.Forms.Button();
            this.KORSN_btnAddNewUser = new System.Windows.Forms.Button();
            this.KORSN_btnChangeUser = new System.Windows.Forms.Button();
            this.KORSN_btnDeleteUser = new System.Windows.Forms.Button();
            this.KORSN_btnRefreshList = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
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
            this.groupBox14.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picBminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picLminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picDminus)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picLoadedUser)).BeginInit();
            this.tabUsers.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KORSN_dgvUsers)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 659);
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
            this.statbarDebug.Visible = false;
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(949, 22);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // STATUS_statbarOPStatus
            // 
            this.STATUS_statbarOPStatus.Image = global::MensariumDesktop.Properties.Resources.internet;
            this.STATUS_statbarOPStatus.Name = "STATUS_statbarOPStatus";
            this.STATUS_statbarOPStatus.ShowDropDownArrow = false;
            this.STATUS_statbarOPStatus.Size = new System.Drawing.Size(20, 25);
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
            this.tabControls.Size = new System.Drawing.Size(1350, 585);
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
            this.tabHome.Size = new System.Drawing.Size(1342, 537);
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
            this.groupBox5.Size = new System.Drawing.Size(234, 531);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 493);
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
            this.HOME_btnProfile.Click += new System.EventHandler(this.HOME_btnProfile_Click);
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
            this.imageListMainForm.Images.SetKeyName(30, "browser-8.png");
            this.imageListMainForm.Images.SetKeyName(31, "browser-10.png");
            this.imageListMainForm.Images.SetKeyName(32, "garbage-1.png");
            this.imageListMainForm.Images.SetKeyName(33, "server-15.png");
            this.imageListMainForm.Images.SetKeyName(34, "user-35.png");
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
            this.HOME_btnSignOut.Click += new System.EventHandler(this.HOME_btnSignOut_Click);
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
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabUplata
            // 
            this.tabUplata.Controls.Add(this.groupBox14);
            this.tabUplata.Controls.Add(this.groupBox6);
            this.tabUplata.Controls.Add(this.groupBox3);
            this.tabUplata.Controls.Add(this.groupBox1);
            this.tabUplata.ImageKey = "list-13.png";
            this.tabUplata.Location = new System.Drawing.Point(4, 44);
            this.tabUplata.Name = "tabUplata";
            this.tabUplata.Padding = new System.Windows.Forms.Padding(3);
            this.tabUplata.Size = new System.Drawing.Size(1342, 537);
            this.tabUplata.TabIndex = 1;
            this.tabUplata.Text = "Uplata obroka";
            this.tabUplata.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox14.Controls.Add(this.UPLATA_lblTotalPrice);
            this.groupBox14.Controls.Add(this.label43);
            this.groupBox14.Controls.Add(this.tableLayoutPanel7);
            this.groupBox14.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.groupBox14.Location = new System.Drawing.Point(243, 376);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1091, 158);
            this.groupBox14.TabIndex = 22;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Za naplatu";
            // 
            // UPLATA_lblTotalPrice
            // 
            this.UPLATA_lblTotalPrice.AutoSize = true;
            this.UPLATA_lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
            this.UPLATA_lblTotalPrice.Location = new System.Drawing.Point(567, 71);
            this.UPLATA_lblTotalPrice.Name = "UPLATA_lblTotalPrice";
            this.UPLATA_lblTotalPrice.Size = new System.Drawing.Size(87, 41);
            this.UPLATA_lblTotalPrice.TabIndex = 9;
            this.UPLATA_lblTotalPrice.Text = "0 din";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
            this.label43.Location = new System.Drawing.Point(434, 71);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(134, 41);
            this.label43.TabIndex = 8;
            this.label43.Text = "Ukupno:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label29, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label30, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_lblBreakfastCount, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_lblLunchCount, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_lblDinnerCount, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label34, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label35, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.label36, 4, 2);
            this.tableLayoutPanel7.Controls.Add(this.label37, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label38, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.label39, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_txtBreakfastTotal, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_txtLunchTotal, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_txtDinnerTotal, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_lblBreakfastPrice, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_lblLunchPrice, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.UPLATA_lblDinnerPrice, 3, 2);
            this.tableLayoutPanel7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(425, 117);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label28.Location = new System.Drawing.Point(3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(94, 35);
            this.label28.TabIndex = 0;
            this.label28.Text = "Doručak";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label29.Location = new System.Drawing.Point(3, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(94, 35);
            this.label29.TabIndex = 6;
            this.label29.Text = "Ručak";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label30.Location = new System.Drawing.Point(3, 70);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 35);
            this.label30.TabIndex = 7;
            this.label30.Text = "Večera";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UPLATA_lblBreakfastCount
            // 
            this.UPLATA_lblBreakfastCount.AutoSize = true;
            this.UPLATA_lblBreakfastCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblBreakfastCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UPLATA_lblBreakfastCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_lblBreakfastCount.Location = new System.Drawing.Point(103, 0);
            this.UPLATA_lblBreakfastCount.Name = "UPLATA_lblBreakfastCount";
            this.UPLATA_lblBreakfastCount.Size = new System.Drawing.Size(44, 35);
            this.UPLATA_lblBreakfastCount.TabIndex = 5;
            this.UPLATA_lblBreakfastCount.Text = "0";
            this.UPLATA_lblBreakfastCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPLATA_lblLunchCount
            // 
            this.UPLATA_lblLunchCount.AutoSize = true;
            this.UPLATA_lblLunchCount.BackColor = System.Drawing.Color.Transparent;
            this.UPLATA_lblLunchCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblLunchCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UPLATA_lblLunchCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_lblLunchCount.Location = new System.Drawing.Point(103, 35);
            this.UPLATA_lblLunchCount.Name = "UPLATA_lblLunchCount";
            this.UPLATA_lblLunchCount.Size = new System.Drawing.Size(44, 35);
            this.UPLATA_lblLunchCount.TabIndex = 8;
            this.UPLATA_lblLunchCount.Text = "0";
            this.UPLATA_lblLunchCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPLATA_lblDinnerCount
            // 
            this.UPLATA_lblDinnerCount.AutoSize = true;
            this.UPLATA_lblDinnerCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblDinnerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UPLATA_lblDinnerCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_lblDinnerCount.Location = new System.Drawing.Point(103, 70);
            this.UPLATA_lblDinnerCount.Name = "UPLATA_lblDinnerCount";
            this.UPLATA_lblDinnerCount.Size = new System.Drawing.Size(44, 35);
            this.UPLATA_lblDinnerCount.TabIndex = 9;
            this.UPLATA_lblDinnerCount.Text = "0";
            this.UPLATA_lblDinnerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label34.Location = new System.Drawing.Point(251, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 35);
            this.label34.TabIndex = 16;
            this.label34.Text = "din =";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label35.Location = new System.Drawing.Point(251, 35);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 35);
            this.label35.TabIndex = 17;
            this.label35.Text = "din =";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label36.Location = new System.Drawing.Point(251, 70);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 35);
            this.label36.TabIndex = 18;
            this.label36.Text = "din =";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label37.Location = new System.Drawing.Point(153, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(21, 35);
            this.label37.TabIndex = 19;
            this.label37.Text = "x";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label38.Location = new System.Drawing.Point(153, 35);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(21, 35);
            this.label38.TabIndex = 20;
            this.label38.Text = "x";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.label39.Location = new System.Drawing.Point(153, 70);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(21, 35);
            this.label39.TabIndex = 21;
            this.label39.Text = "x";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UPLATA_txtBreakfastTotal
            // 
            this.UPLATA_txtBreakfastTotal.BackColor = System.Drawing.Color.White;
            this.UPLATA_txtBreakfastTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UPLATA_txtBreakfastTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_txtBreakfastTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.UPLATA_txtBreakfastTotal.Location = new System.Drawing.Point(320, 3);
            this.UPLATA_txtBreakfastTotal.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.UPLATA_txtBreakfastTotal.Name = "UPLATA_txtBreakfastTotal";
            this.UPLATA_txtBreakfastTotal.ReadOnly = true;
            this.UPLATA_txtBreakfastTotal.Size = new System.Drawing.Size(88, 26);
            this.UPLATA_txtBreakfastTotal.TabIndex = 13;
            this.UPLATA_txtBreakfastTotal.Text = "0";
            // 
            // UPLATA_txtLunchTotal
            // 
            this.UPLATA_txtLunchTotal.BackColor = System.Drawing.Color.White;
            this.UPLATA_txtLunchTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UPLATA_txtLunchTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_txtLunchTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.UPLATA_txtLunchTotal.Location = new System.Drawing.Point(320, 38);
            this.UPLATA_txtLunchTotal.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.UPLATA_txtLunchTotal.Name = "UPLATA_txtLunchTotal";
            this.UPLATA_txtLunchTotal.ReadOnly = true;
            this.UPLATA_txtLunchTotal.Size = new System.Drawing.Size(88, 26);
            this.UPLATA_txtLunchTotal.TabIndex = 14;
            this.UPLATA_txtLunchTotal.Text = "0";
            // 
            // UPLATA_txtDinnerTotal
            // 
            this.UPLATA_txtDinnerTotal.BackColor = System.Drawing.Color.White;
            this.UPLATA_txtDinnerTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UPLATA_txtDinnerTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_txtDinnerTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.UPLATA_txtDinnerTotal.Location = new System.Drawing.Point(320, 73);
            this.UPLATA_txtDinnerTotal.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.UPLATA_txtDinnerTotal.Name = "UPLATA_txtDinnerTotal";
            this.UPLATA_txtDinnerTotal.ReadOnly = true;
            this.UPLATA_txtDinnerTotal.Size = new System.Drawing.Size(88, 26);
            this.UPLATA_txtDinnerTotal.TabIndex = 15;
            this.UPLATA_txtDinnerTotal.Text = "0";
            // 
            // UPLATA_lblBreakfastPrice
            // 
            this.UPLATA_lblBreakfastPrice.AutoSize = true;
            this.UPLATA_lblBreakfastPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblBreakfastPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.UPLATA_lblBreakfastPrice.Location = new System.Drawing.Point(180, 0);
            this.UPLATA_lblBreakfastPrice.Name = "UPLATA_lblBreakfastPrice";
            this.UPLATA_lblBreakfastPrice.Size = new System.Drawing.Size(65, 35);
            this.UPLATA_lblBreakfastPrice.TabIndex = 22;
            this.UPLATA_lblBreakfastPrice.Text = "/";
            this.UPLATA_lblBreakfastPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UPLATA_lblLunchPrice
            // 
            this.UPLATA_lblLunchPrice.AutoSize = true;
            this.UPLATA_lblLunchPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblLunchPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.UPLATA_lblLunchPrice.Location = new System.Drawing.Point(180, 35);
            this.UPLATA_lblLunchPrice.Name = "UPLATA_lblLunchPrice";
            this.UPLATA_lblLunchPrice.Size = new System.Drawing.Size(65, 35);
            this.UPLATA_lblLunchPrice.TabIndex = 23;
            this.UPLATA_lblLunchPrice.Text = "/";
            this.UPLATA_lblLunchPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UPLATA_lblDinnerPrice
            // 
            this.UPLATA_lblDinnerPrice.AutoSize = true;
            this.UPLATA_lblDinnerPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblDinnerPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.UPLATA_lblDinnerPrice.Location = new System.Drawing.Point(180, 70);
            this.UPLATA_lblDinnerPrice.Name = "UPLATA_lblDinnerPrice";
            this.UPLATA_lblDinnerPrice.Size = new System.Drawing.Size(65, 35);
            this.UPLATA_lblDinnerPrice.TabIndex = 24;
            this.UPLATA_lblDinnerPrice.Text = "/";
            this.UPLATA_lblDinnerPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.flowLayoutPanel2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 531);
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(228, 493);
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
            this.btnExecutePay.Click += new System.EventHandler(this.UPLATA_btnExecutePay_Click);
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
            this.btnReclamation.Text = " Ispravi grešku";
            this.btnReclamation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReclamation.UseVisualStyleBackColor = false;
            this.btnReclamation.Click += new System.EventHandler(this.UPLATA_btnReclamation_Click);
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
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_txtDinner, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_txtLunch, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_lblBreakfast, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_lblLunch, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_lblDinner, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox4, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox5, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.UPLATA_txtBreakfast, 3, 0);
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
            // UPLATA_txtDinner
            // 
            this.UPLATA_txtDinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_txtDinner.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UPLATA_txtDinner.Location = new System.Drawing.Point(182, 73);
            this.UPLATA_txtDinner.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.UPLATA_txtDinner.Name = "UPLATA_txtDinner";
            this.UPLATA_txtDinner.Size = new System.Drawing.Size(220, 29);
            this.UPLATA_txtDinner.TabIndex = 15;
            this.UPLATA_txtDinner.Text = "0";
            this.UPLATA_txtDinner.TextChanged += new System.EventHandler(this.UPLATA_txtDinner_TextChanged);
            // 
            // UPLATA_txtLunch
            // 
            this.UPLATA_txtLunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_txtLunch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UPLATA_txtLunch.Location = new System.Drawing.Point(182, 38);
            this.UPLATA_txtLunch.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.UPLATA_txtLunch.Name = "UPLATA_txtLunch";
            this.UPLATA_txtLunch.Size = new System.Drawing.Size(220, 29);
            this.UPLATA_txtLunch.TabIndex = 14;
            this.UPLATA_txtLunch.Text = "0";
            this.UPLATA_txtLunch.TextChanged += new System.EventHandler(this.UPLATA_txtLunch_TextChanged);
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
            this.UPLATA_lblBreakfast.Text = "/";
            this.UPLATA_lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPLATA_lblLunch
            // 
            this.UPLATA_lblLunch.AutoSize = true;
            this.UPLATA_lblLunch.BackColor = System.Drawing.Color.Transparent;
            this.UPLATA_lblLunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.UPLATA_lblLunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UPLATA_lblLunch.Location = new System.Drawing.Point(103, 35);
            this.UPLATA_lblLunch.Name = "UPLATA_lblLunch";
            this.UPLATA_lblLunch.Size = new System.Drawing.Size(44, 35);
            this.UPLATA_lblLunch.TabIndex = 8;
            this.UPLATA_lblLunch.Text = "/";
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
            this.UPLATA_lblDinner.Text = "/";
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
            // UPLATA_txtBreakfast
            // 
            this.UPLATA_txtBreakfast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPLATA_txtBreakfast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPLATA_txtBreakfast.Location = new System.Drawing.Point(182, 3);
            this.UPLATA_txtBreakfast.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.UPLATA_txtBreakfast.Name = "UPLATA_txtBreakfast";
            this.UPLATA_txtBreakfast.Size = new System.Drawing.Size(220, 29);
            this.UPLATA_txtBreakfast.TabIndex = 13;
            this.UPLATA_txtBreakfast.Text = "0";
            this.UPLATA_txtBreakfast.TextChanged += new System.EventHandler(this.UPLATA_txtBreakfast_TextChanged);
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
            this.tabNaplata.Size = new System.Drawing.Size(1342, 537);
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
            this.tableLayoutPanel6.Controls.Add(this.NAPLATA_lblBreakfastCount, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.NAPLATA_lblLunchCount, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.NAPLATA_lblDinnerCount, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.NAPLATA_picBminus, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.NAPLATA_picLminus, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.NAPLATA_picDminus, 2, 2);
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
            // NAPLATA_lblBreakfastCount
            // 
            this.NAPLATA_lblBreakfastCount.AutoSize = true;
            this.NAPLATA_lblBreakfastCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NAPLATA_lblBreakfastCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NAPLATA_lblBreakfastCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_lblBreakfastCount.Location = new System.Drawing.Point(103, 0);
            this.NAPLATA_lblBreakfastCount.Name = "NAPLATA_lblBreakfastCount";
            this.NAPLATA_lblBreakfastCount.Size = new System.Drawing.Size(44, 35);
            this.NAPLATA_lblBreakfastCount.TabIndex = 5;
            this.NAPLATA_lblBreakfastCount.Text = "/";
            this.NAPLATA_lblBreakfastCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NAPLATA_lblLunchCount
            // 
            this.NAPLATA_lblLunchCount.AutoSize = true;
            this.NAPLATA_lblLunchCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NAPLATA_lblLunchCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NAPLATA_lblLunchCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_lblLunchCount.Location = new System.Drawing.Point(103, 35);
            this.NAPLATA_lblLunchCount.Name = "NAPLATA_lblLunchCount";
            this.NAPLATA_lblLunchCount.Size = new System.Drawing.Size(44, 35);
            this.NAPLATA_lblLunchCount.TabIndex = 8;
            this.NAPLATA_lblLunchCount.Text = "/";
            this.NAPLATA_lblLunchCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NAPLATA_lblDinnerCount
            // 
            this.NAPLATA_lblDinnerCount.AutoSize = true;
            this.NAPLATA_lblDinnerCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NAPLATA_lblDinnerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NAPLATA_lblDinnerCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_lblDinnerCount.Location = new System.Drawing.Point(103, 70);
            this.NAPLATA_lblDinnerCount.Name = "NAPLATA_lblDinnerCount";
            this.NAPLATA_lblDinnerCount.Size = new System.Drawing.Size(44, 35);
            this.NAPLATA_lblDinnerCount.TabIndex = 9;
            this.NAPLATA_lblDinnerCount.Text = "/";
            this.NAPLATA_lblDinnerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NAPLATA_picBminus
            // 
            this.NAPLATA_picBminus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NAPLATA_picBminus.Image = global::MensariumDesktop.Properties.Resources.minus;
            this.NAPLATA_picBminus.Location = new System.Drawing.Point(153, 3);
            this.NAPLATA_picBminus.Name = "NAPLATA_picBminus";
            this.NAPLATA_picBminus.Size = new System.Drawing.Size(19, 29);
            this.NAPLATA_picBminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NAPLATA_picBminus.TabIndex = 11;
            this.NAPLATA_picBminus.TabStop = false;
            this.NAPLATA_picBminus.Visible = false;
            // 
            // NAPLATA_picLminus
            // 
            this.NAPLATA_picLminus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NAPLATA_picLminus.Image = ((System.Drawing.Image)(resources.GetObject("NAPLATA_picLminus.Image")));
            this.NAPLATA_picLminus.Location = new System.Drawing.Point(153, 38);
            this.NAPLATA_picLminus.Name = "NAPLATA_picLminus";
            this.NAPLATA_picLminus.Size = new System.Drawing.Size(19, 29);
            this.NAPLATA_picLminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NAPLATA_picLminus.TabIndex = 12;
            this.NAPLATA_picLminus.TabStop = false;
            this.NAPLATA_picLminus.Visible = false;
            // 
            // NAPLATA_picDminus
            // 
            this.NAPLATA_picDminus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NAPLATA_picDminus.Image = ((System.Drawing.Image)(resources.GetObject("NAPLATA_picDminus.Image")));
            this.NAPLATA_picDminus.Location = new System.Drawing.Point(153, 73);
            this.NAPLATA_picDminus.Name = "NAPLATA_picDminus";
            this.NAPLATA_picDminus.Size = new System.Drawing.Size(19, 29);
            this.NAPLATA_picDminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NAPLATA_picDminus.TabIndex = 13;
            this.NAPLATA_picDminus.TabStop = false;
            this.NAPLATA_picDminus.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.flowLayoutPanel3);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(234, 531);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kontrole";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.NAPLATA_btnLoadCard);
            this.flowLayoutPanel3.Controls.Add(this.NAPLATA_btnReclamation);
            this.flowLayoutPanel3.Controls.Add(this.label21);
            this.flowLayoutPanel3.Controls.Add(this.NAPLATA_btnUseBreakfast);
            this.flowLayoutPanel3.Controls.Add(this.NAPLATA_btnUseLunch);
            this.flowLayoutPanel3.Controls.Add(this.NAPLATA_btnUseDinner);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(228, 493);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // NAPLATA_btnLoadCard
            // 
            this.NAPLATA_btnLoadCard.BackColor = System.Drawing.Color.White;
            this.NAPLATA_btnLoadCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.NAPLATA_btnLoadCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnLoadCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnLoadCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAPLATA_btnLoadCard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_btnLoadCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnLoadCard.ImageKey = "id-card-3.png";
            this.NAPLATA_btnLoadCard.ImageList = this.imageListMainForm;
            this.NAPLATA_btnLoadCard.Location = new System.Drawing.Point(4, 20);
            this.NAPLATA_btnLoadCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NAPLATA_btnLoadCard.Name = "NAPLATA_btnLoadCard";
            this.NAPLATA_btnLoadCard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NAPLATA_btnLoadCard.Size = new System.Drawing.Size(219, 55);
            this.NAPLATA_btnLoadCard.TabIndex = 15;
            this.NAPLATA_btnLoadCard.Text = " Učitaj karticu";
            this.NAPLATA_btnLoadCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnLoadCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NAPLATA_btnLoadCard.UseVisualStyleBackColor = false;
            this.NAPLATA_btnLoadCard.Click += new System.EventHandler(this.NAPLATA_btnLoadCard_Click);
            // 
            // NAPLATA_btnReclamation
            // 
            this.NAPLATA_btnReclamation.BackColor = System.Drawing.Color.White;
            this.NAPLATA_btnReclamation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.NAPLATA_btnReclamation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnReclamation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnReclamation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAPLATA_btnReclamation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_btnReclamation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnReclamation.ImageKey = "notebook-12.png";
            this.NAPLATA_btnReclamation.ImageList = this.imageListMainForm;
            this.NAPLATA_btnReclamation.Location = new System.Drawing.Point(4, 85);
            this.NAPLATA_btnReclamation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NAPLATA_btnReclamation.Name = "NAPLATA_btnReclamation";
            this.NAPLATA_btnReclamation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NAPLATA_btnReclamation.Size = new System.Drawing.Size(219, 55);
            this.NAPLATA_btnReclamation.TabIndex = 23;
            this.NAPLATA_btnReclamation.Text = " Ispravi grešku";
            this.NAPLATA_btnReclamation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnReclamation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NAPLATA_btnReclamation.UseVisualStyleBackColor = false;
            this.NAPLATA_btnReclamation.Click += new System.EventHandler(this.NAPLATA_btnReclamation_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(3, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 25);
            this.label21.TabIndex = 22;
            this.label21.Text = "Naplati";
            // 
            // NAPLATA_btnUseBreakfast
            // 
            this.NAPLATA_btnUseBreakfast.BackColor = System.Drawing.Color.White;
            this.NAPLATA_btnUseBreakfast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.NAPLATA_btnUseBreakfast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnUseBreakfast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnUseBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAPLATA_btnUseBreakfast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_btnUseBreakfast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnUseBreakfast.ImageKey = "notebook-13.png";
            this.NAPLATA_btnUseBreakfast.ImageList = this.imageListMainForm;
            this.NAPLATA_btnUseBreakfast.Location = new System.Drawing.Point(4, 175);
            this.NAPLATA_btnUseBreakfast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NAPLATA_btnUseBreakfast.Name = "NAPLATA_btnUseBreakfast";
            this.NAPLATA_btnUseBreakfast.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NAPLATA_btnUseBreakfast.Size = new System.Drawing.Size(219, 55);
            this.NAPLATA_btnUseBreakfast.TabIndex = 18;
            this.NAPLATA_btnUseBreakfast.Text = " Doručak";
            this.NAPLATA_btnUseBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnUseBreakfast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NAPLATA_btnUseBreakfast.UseVisualStyleBackColor = false;
            this.NAPLATA_btnUseBreakfast.Click += new System.EventHandler(this.NAPLATA_btnUseBreakfast_Click);
            // 
            // NAPLATA_btnUseLunch
            // 
            this.NAPLATA_btnUseLunch.BackColor = System.Drawing.Color.White;
            this.NAPLATA_btnUseLunch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.NAPLATA_btnUseLunch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnUseLunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnUseLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAPLATA_btnUseLunch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_btnUseLunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnUseLunch.ImageKey = "notebook-13.png";
            this.NAPLATA_btnUseLunch.ImageList = this.imageListMainForm;
            this.NAPLATA_btnUseLunch.Location = new System.Drawing.Point(4, 240);
            this.NAPLATA_btnUseLunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NAPLATA_btnUseLunch.Name = "NAPLATA_btnUseLunch";
            this.NAPLATA_btnUseLunch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NAPLATA_btnUseLunch.Size = new System.Drawing.Size(219, 55);
            this.NAPLATA_btnUseLunch.TabIndex = 19;
            this.NAPLATA_btnUseLunch.Text = " Ručak";
            this.NAPLATA_btnUseLunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnUseLunch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NAPLATA_btnUseLunch.UseVisualStyleBackColor = false;
            this.NAPLATA_btnUseLunch.Click += new System.EventHandler(this.NAPLATA_btnUseLunch_Click);
            // 
            // NAPLATA_btnUseDinner
            // 
            this.NAPLATA_btnUseDinner.BackColor = System.Drawing.Color.White;
            this.NAPLATA_btnUseDinner.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.NAPLATA_btnUseDinner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnUseDinner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.NAPLATA_btnUseDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAPLATA_btnUseDinner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_btnUseDinner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnUseDinner.ImageKey = "notebook-13.png";
            this.NAPLATA_btnUseDinner.ImageList = this.imageListMainForm;
            this.NAPLATA_btnUseDinner.Location = new System.Drawing.Point(4, 305);
            this.NAPLATA_btnUseDinner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NAPLATA_btnUseDinner.Name = "NAPLATA_btnUseDinner";
            this.NAPLATA_btnUseDinner.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NAPLATA_btnUseDinner.Size = new System.Drawing.Size(219, 55);
            this.NAPLATA_btnUseDinner.TabIndex = 20;
            this.NAPLATA_btnUseDinner.Text = " Večera";
            this.NAPLATA_btnUseDinner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NAPLATA_btnUseDinner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NAPLATA_btnUseDinner.UseVisualStyleBackColor = false;
            this.NAPLATA_btnUseDinner.Click += new System.EventHandler(this.NAPLATA_btnUseDinner_Click);
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
            this.panel6.Controls.Add(this.NAPLATA_picLoadedUser);
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
            this.tableLayoutPanel5.Controls.Add(this.NAPLATA_lblUserName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.NAPLATA_lblUserFax, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.NAPLATA_lblUserBday, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.NAPLATA_lblUserIndex, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.NAPLATA_lblUserValidUntil, 0, 4);
            this.tableLayoutPanel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(148, 13);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(934, 131);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // NAPLATA_lblUserName
            // 
            this.NAPLATA_lblUserName.AutoSize = true;
            this.NAPLATA_lblUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_lblUserName.Location = new System.Drawing.Point(3, 0);
            this.NAPLATA_lblUserName.Name = "NAPLATA_lblUserName";
            this.NAPLATA_lblUserName.Size = new System.Drawing.Size(116, 25);
            this.NAPLATA_lblUserName.TabIndex = 7;
            this.NAPLATA_lblUserName.Text = "Ime Prezime";
            // 
            // NAPLATA_lblUserFax
            // 
            this.NAPLATA_lblUserFax.AutoSize = true;
            this.NAPLATA_lblUserFax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_lblUserFax.Location = new System.Drawing.Point(3, 25);
            this.NAPLATA_lblUserFax.Name = "NAPLATA_lblUserFax";
            this.NAPLATA_lblUserFax.Size = new System.Drawing.Size(77, 25);
            this.NAPLATA_lblUserFax.TabIndex = 8;
            this.NAPLATA_lblUserFax.Text = "Fakultet";
            // 
            // NAPLATA_lblUserBday
            // 
            this.NAPLATA_lblUserBday.AutoSize = true;
            this.NAPLATA_lblUserBday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_lblUserBday.Location = new System.Drawing.Point(3, 50);
            this.NAPLATA_lblUserBday.Name = "NAPLATA_lblUserBday";
            this.NAPLATA_lblUserBday.Size = new System.Drawing.Size(138, 25);
            this.NAPLATA_lblUserBday.TabIndex = 9;
            this.NAPLATA_lblUserBday.Text = "Datum rođenja";
            // 
            // NAPLATA_lblUserIndex
            // 
            this.NAPLATA_lblUserIndex.AutoSize = true;
            this.NAPLATA_lblUserIndex.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_lblUserIndex.Location = new System.Drawing.Point(3, 75);
            this.NAPLATA_lblUserIndex.Name = "NAPLATA_lblUserIndex";
            this.NAPLATA_lblUserIndex.Size = new System.Drawing.Size(58, 25);
            this.NAPLATA_lblUserIndex.TabIndex = 10;
            this.NAPLATA_lblUserIndex.Text = "Index";
            // 
            // NAPLATA_lblUserValidUntil
            // 
            this.NAPLATA_lblUserValidUntil.AutoSize = true;
            this.NAPLATA_lblUserValidUntil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAPLATA_lblUserValidUntil.Location = new System.Drawing.Point(3, 100);
            this.NAPLATA_lblUserValidUntil.Name = "NAPLATA_lblUserValidUntil";
            this.NAPLATA_lblUserValidUntil.Size = new System.Drawing.Size(209, 25);
            this.NAPLATA_lblUserValidUntil.TabIndex = 11;
            this.NAPLATA_lblUserValidUntil.Text = "Validna do: dd.mm.yyyy";
            // 
            // NAPLATA_picLoadedUser
            // 
            this.NAPLATA_picLoadedUser.BackColor = System.Drawing.Color.Transparent;
            this.NAPLATA_picLoadedUser.BackgroundImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.NAPLATA_picLoadedUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NAPLATA_picLoadedUser.ErrorImage = global::MensariumDesktop.Properties.Resources.user_3;
            this.NAPLATA_picLoadedUser.InitialImage = null;
            this.NAPLATA_picLoadedUser.Location = new System.Drawing.Point(11, 13);
            this.NAPLATA_picLoadedUser.Name = "NAPLATA_picLoadedUser";
            this.NAPLATA_picLoadedUser.Size = new System.Drawing.Size(131, 131);
            this.NAPLATA_picLoadedUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NAPLATA_picLoadedUser.TabIndex = 0;
            this.NAPLATA_picLoadedUser.TabStop = false;
            this.NAPLATA_picLoadedUser.Paint += new System.Windows.Forms.PaintEventHandler(this.NAPLATA_picLoadedUser_Paint);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.groupBox11);
            this.tabUsers.Controls.Add(this.groupBox10);
            this.tabUsers.ImageKey = "users.png";
            this.tabUsers.Location = new System.Drawing.Point(4, 44);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1342, 537);
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
            this.panel8.Controls.Add(this.KORSN_cbxAccTypeChooser);
            this.panel8.Controls.Add(this.KORSN_dgvUsers);
            this.panel8.Controls.Add(this.KORSN_txtSearch);
            this.panel8.Controls.Add(this.label22);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel8.Location = new System.Drawing.Point(3, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1087, 499);
            this.panel8.TabIndex = 16;
            // 
            // KORSN_cbxAccTypeChooser
            // 
            this.KORSN_cbxAccTypeChooser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KORSN_cbxAccTypeChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KORSN_cbxAccTypeChooser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KORSN_cbxAccTypeChooser.FormattingEnabled = true;
            this.KORSN_cbxAccTypeChooser.Items.AddRange(new object[] {
            "Prikaži samo aktivne naloge",
            "Prikaži samo neaktivne naloge",
            "Prikaži i aktivne i neaktivne naloge"});
            this.KORSN_cbxAccTypeChooser.Location = new System.Drawing.Point(3, 471);
            this.KORSN_cbxAccTypeChooser.Name = "KORSN_cbxAccTypeChooser";
            this.KORSN_cbxAccTypeChooser.Size = new System.Drawing.Size(1081, 25);
            this.KORSN_cbxAccTypeChooser.TabIndex = 29;
            this.KORSN_cbxAccTypeChooser.SelectedIndexChanged += new System.EventHandler(this.KORSN_cbxAccTypeChooser_SelectedIndexChanged);
            // 
            // KORSN_dgvUsers
            // 
            this.KORSN_dgvUsers.AllowUserToAddRows = false;
            this.KORSN_dgvUsers.AllowUserToDeleteRows = false;
            this.KORSN_dgvUsers.AllowUserToOrderColumns = true;
            this.KORSN_dgvUsers.AllowUserToResizeRows = false;
            this.KORSN_dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KORSN_dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KORSN_dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.KORSN_dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KORSN_dgvUsers.Location = new System.Drawing.Point(3, 34);
            this.KORSN_dgvUsers.MultiSelect = false;
            this.KORSN_dgvUsers.Name = "KORSN_dgvUsers";
            this.KORSN_dgvUsers.ReadOnly = true;
            this.KORSN_dgvUsers.RowHeadersVisible = false;
            this.KORSN_dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KORSN_dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KORSN_dgvUsers.ShowEditingIcon = false;
            this.KORSN_dgvUsers.Size = new System.Drawing.Size(1081, 436);
            this.KORSN_dgvUsers.TabIndex = 28;
            // 
            // KORSN_txtSearch
            // 
            this.KORSN_txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KORSN_txtSearch.Location = new System.Drawing.Point(70, 3);
            this.KORSN_txtSearch.Name = "KORSN_txtSearch";
            this.KORSN_txtSearch.Size = new System.Drawing.Size(1014, 25);
            this.KORSN_txtSearch.TabIndex = 27;
            this.KORSN_txtSearch.TextChanged += new System.EventHandler(this.KORSN_txtSearch_TextChanged);
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
            this.groupBox10.Size = new System.Drawing.Size(234, 531);
            this.groupBox10.TabIndex = 23;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Kontrole";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.KORSN_btnProfile);
            this.flowLayoutPanel4.Controls.Add(this.KORSN_btnAddNewUser);
            this.flowLayoutPanel4.Controls.Add(this.KORSN_btnChangeUser);
            this.flowLayoutPanel4.Controls.Add(this.KORSN_btnDeleteUser);
            this.flowLayoutPanel4.Controls.Add(this.KORSN_btnRefreshList);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(228, 493);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // KORSN_btnProfile
            // 
            this.KORSN_btnProfile.BackColor = System.Drawing.Color.White;
            this.KORSN_btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.KORSN_btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KORSN_btnProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KORSN_btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnProfile.ImageKey = "user-30.png";
            this.KORSN_btnProfile.ImageList = this.imageListMainForm;
            this.KORSN_btnProfile.Location = new System.Drawing.Point(4, 20);
            this.KORSN_btnProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KORSN_btnProfile.Name = "KORSN_btnProfile";
            this.KORSN_btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.KORSN_btnProfile.Size = new System.Drawing.Size(219, 55);
            this.KORSN_btnProfile.TabIndex = 20;
            this.KORSN_btnProfile.Text = " Pregledaj profil";
            this.KORSN_btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KORSN_btnProfile.UseVisualStyleBackColor = false;
            this.KORSN_btnProfile.Click += new System.EventHandler(this.KORSN_btnProfile_Click);
            // 
            // KORSN_btnAddNewUser
            // 
            this.KORSN_btnAddNewUser.BackColor = System.Drawing.Color.White;
            this.KORSN_btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.KORSN_btnAddNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnAddNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KORSN_btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KORSN_btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnAddNewUser.ImageKey = "user-20.png";
            this.KORSN_btnAddNewUser.ImageList = this.imageListMainForm;
            this.KORSN_btnAddNewUser.Location = new System.Drawing.Point(4, 85);
            this.KORSN_btnAddNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KORSN_btnAddNewUser.Name = "KORSN_btnAddNewUser";
            this.KORSN_btnAddNewUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.KORSN_btnAddNewUser.Size = new System.Drawing.Size(219, 55);
            this.KORSN_btnAddNewUser.TabIndex = 15;
            this.KORSN_btnAddNewUser.Text = " Dodaj novog";
            this.KORSN_btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnAddNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KORSN_btnAddNewUser.UseVisualStyleBackColor = false;
            this.KORSN_btnAddNewUser.Click += new System.EventHandler(this.KORSN_btnAddNewUser_Click);
            // 
            // KORSN_btnChangeUser
            // 
            this.KORSN_btnChangeUser.BackColor = System.Drawing.Color.White;
            this.KORSN_btnChangeUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.KORSN_btnChangeUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnChangeUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KORSN_btnChangeUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KORSN_btnChangeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnChangeUser.ImageKey = "user-32.png";
            this.KORSN_btnChangeUser.ImageList = this.imageListMainForm;
            this.KORSN_btnChangeUser.Location = new System.Drawing.Point(4, 150);
            this.KORSN_btnChangeUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KORSN_btnChangeUser.Name = "KORSN_btnChangeUser";
            this.KORSN_btnChangeUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.KORSN_btnChangeUser.Size = new System.Drawing.Size(219, 55);
            this.KORSN_btnChangeUser.TabIndex = 18;
            this.KORSN_btnChangeUser.Text = " Izmeni";
            this.KORSN_btnChangeUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnChangeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KORSN_btnChangeUser.UseVisualStyleBackColor = false;
            this.KORSN_btnChangeUser.Click += new System.EventHandler(this.KORSN_btnChangeUser_Click);
            // 
            // KORSN_btnDeleteUser
            // 
            this.KORSN_btnDeleteUser.BackColor = System.Drawing.Color.White;
            this.KORSN_btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.KORSN_btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KORSN_btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.KORSN_btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnDeleteUser.ImageKey = "user-22.png";
            this.KORSN_btnDeleteUser.ImageList = this.imageListMainForm;
            this.KORSN_btnDeleteUser.Location = new System.Drawing.Point(4, 215);
            this.KORSN_btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KORSN_btnDeleteUser.Name = "KORSN_btnDeleteUser";
            this.KORSN_btnDeleteUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.KORSN_btnDeleteUser.Size = new System.Drawing.Size(219, 55);
            this.KORSN_btnDeleteUser.TabIndex = 21;
            this.KORSN_btnDeleteUser.Text = " Obriši";
            this.KORSN_btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KORSN_btnDeleteUser.UseVisualStyleBackColor = false;
            this.KORSN_btnDeleteUser.Click += new System.EventHandler(this.KORSN_btnDeleteUser_Click);
            // 
            // KORSN_btnRefreshList
            // 
            this.KORSN_btnRefreshList.BackColor = System.Drawing.Color.White;
            this.KORSN_btnRefreshList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(108)))), ((int)(((byte)(98)))));
            this.KORSN_btnRefreshList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnRefreshList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.KORSN_btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KORSN_btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.KORSN_btnRefreshList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnRefreshList.ImageKey = "user-35.png";
            this.KORSN_btnRefreshList.ImageList = this.imageListMainForm;
            this.KORSN_btnRefreshList.Location = new System.Drawing.Point(4, 280);
            this.KORSN_btnRefreshList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KORSN_btnRefreshList.Name = "KORSN_btnRefreshList";
            this.KORSN_btnRefreshList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.KORSN_btnRefreshList.Size = new System.Drawing.Size(219, 55);
            this.KORSN_btnRefreshList.TabIndex = 19;
            this.KORSN_btnRefreshList.Text = "Osveži listu";
            this.KORSN_btnRefreshList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KORSN_btnRefreshList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KORSN_btnRefreshList.UseVisualStyleBackColor = false;
            this.KORSN_btnRefreshList.Click += new System.EventHandler(this.KORSN_btnRefreshList_Click);
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
            this.tabAdmin.Size = new System.Drawing.Size(1342, 537);
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
            this.groupBox13.Enabled = false;
            this.groupBox13.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox13.Location = new System.Drawing.Point(241, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1098, 531);
            this.groupBox13.TabIndex = 23;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Status servera";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.chart1);
            this.panel9.Controls.Add(this.button4);
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.button1);
            this.panel9.Controls.Add(this.label27);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1092, 493);
            this.panel9.TabIndex = 7;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Enabled = false;
            this.chart1.Location = new System.Drawing.Point(245, 59);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Name = "Series1";
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.Points.Add(dataPoint16);
            series2.Points.Add(dataPoint17);
            series2.Points.Add(dataPoint18);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(844, 431);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
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
            this.button4.ImageKey = "garbage-1.png";
            this.button4.ImageList = this.imageListMainForm;
            this.button4.Location = new System.Drawing.Point(19, 254);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(219, 55);
            this.button4.TabIndex = 19;
            this.button4.Text = "Očisti cache";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
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
            this.button3.ImageKey = "browser-10.png";
            this.button3.ImageList = this.imageListMainForm;
            this.button3.Location = new System.Drawing.Point(19, 189);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(219, 55);
            this.button3.TabIndex = 18;
            this.button3.Text = "Hard Disk";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
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
            this.button2.ImageKey = "browser-8.png";
            this.button2.ImageList = this.imageListMainForm;
            this.button2.Location = new System.Drawing.Point(19, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(219, 55);
            this.button2.TabIndex = 17;
            this.button2.Text = "Upotreba RAM-a";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
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
            this.button1.ImageKey = "server-15.png";
            this.button1.ImageList = this.imageListMainForm;
            this.button1.Location = new System.Drawing.Point(19, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(219, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = " Restartuj";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(219, 32);
            this.label27.TabIndex = 0;
            this.label27.Text = "KUPI PRO VERZIJU";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.flowLayoutPanel5);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox12.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(234, 531);
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
            this.flowLayoutPanel5.Controls.Add(this.label26);
            this.flowLayoutPanel5.Controls.Add(this.button13);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(228, 493);
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
            this.button10.Click += new System.EventHandler(this.button10_Click);
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
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(3, 195);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(142, 25);
            this.label26.TabIndex = 26;
            this.label26.Text = "Sesije korisnika";
            this.label26.Visible = false;
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
            this.button13.Location = new System.Drawing.Point(4, 225);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(219, 55);
            this.button13.TabIndex = 27;
            this.button13.Text = " Uređivanje";
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Visible = false;
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
            this.panel1.Size = new System.Drawing.Size(1350, 686);
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
            this.ClientSize = new System.Drawing.Size(1350, 686);
            this.Controls.Add(this.tabControls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(960, 725);
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
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picBminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picLminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picDminus)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NAPLATA_picLoadedUser)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KORSN_dgvUsers)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TextBox UPLATA_txtDinner;
        private System.Windows.Forms.TextBox UPLATA_txtLunch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox UPLATA_txtBreakfast;
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
        private System.Windows.Forms.Label NAPLATA_lblUserName;
        private System.Windows.Forms.Label NAPLATA_lblUserFax;
        private System.Windows.Forms.Label NAPLATA_lblUserBday;
        private System.Windows.Forms.Label NAPLATA_lblUserIndex;
        private System.Windows.Forms.Label NAPLATA_lblUserValidUntil;
        private System.Windows.Forms.PictureBox NAPLATA_picLoadedUser;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label NAPLATA_lblBreakfastCount;
        private System.Windows.Forms.Label NAPLATA_lblLunchCount;
        private System.Windows.Forms.Label NAPLATA_lblDinnerCount;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button NAPLATA_btnLoadCard;
        private System.Windows.Forms.Button NAPLATA_btnUseBreakfast;
        private System.Windows.Forms.Button NAPLATA_btnUseLunch;
        private System.Windows.Forms.Button NAPLATA_btnUseDinner;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button NAPLATA_btnReclamation;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button KORSN_btnAddNewUser;
        private System.Windows.Forms.Button KORSN_btnChangeUser;
        private System.Windows.Forms.Button KORSN_btnRefreshList;
        private System.Windows.Forms.Button KORSN_btnProfile;
        private System.Windows.Forms.PictureBox NAPLATA_picBminus;
        private System.Windows.Forms.PictureBox NAPLATA_picLminus;
        private System.Windows.Forms.PictureBox NAPLATA_picDminus;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox KORSN_txtSearch;
        private System.Windows.Forms.DataGridView KORSN_dgvUsers;
        private System.Windows.Forms.ToolStripMenuItem showUserFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNewUserCreatedFormToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button KORSN_btnDeleteUser;
        private System.Windows.Forms.ComboBox KORSN_cbxAccTypeChooser;
        private System.Windows.Forms.ToolStripMenuItem dEBUGMEToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgWorkerLoading;
        private System.Windows.Forms.ImageList imageListOPStatus;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label UPLATA_lblBreakfastCount;
        private System.Windows.Forms.Label UPLATA_lblLunchCount;
        private System.Windows.Forms.Label UPLATA_lblDinnerCount;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox UPLATA_txtBreakfastTotal;
        private System.Windows.Forms.TextBox UPLATA_txtLunchTotal;
        private System.Windows.Forms.TextBox UPLATA_txtDinnerTotal;
        private System.Windows.Forms.Label UPLATA_lblBreakfastPrice;
        private System.Windows.Forms.Label UPLATA_lblLunchPrice;
        private System.Windows.Forms.Label UPLATA_lblDinnerPrice;
        private System.Windows.Forms.Label UPLATA_lblTotalPrice;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

