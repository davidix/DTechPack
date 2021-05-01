namespace DTechPack
{
    partial class frmSys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSys));
            this.tabExplore = new System.Windows.Forms.TabControl();
            this.pgeProperties = new System.Windows.Forms.TabPage();
            this.btnRefreshTickCount = new System.Windows.Forms.Button();
            this.btnStackTrace = new System.Windows.Forms.Button();
            this.lblWorkingset = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.lblUserDomainName = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblTickCount = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblSystemDirectory = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblCurrentDirectory = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.pgeSpecialFolders = new System.Windows.Forms.TabPage();
            this.txtResultVar = new System.Windows.Forms.TextBox();
            this.txtEnvirvar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSystemFolder = new System.Windows.Forms.TextBox();
            this.lblSpecialFolder = new System.Windows.Forms.TextBox();
            this.btnGetSystemFolder = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.pgeEnvironmentVariables = new System.Windows.Forms.TabPage();
            this.lblTEMP = new System.Windows.Forms.TextBox();
            this.lblEnvironmentVariable = new System.Windows.Forms.TextBox();
            this.btnGetEnvironmentVariable = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstEnvironmentVariables = new System.Windows.Forms.ListBox();
            this.pgeSystemInformation = new System.Windows.Forms.TabPage();
            this.lvwSystemInformation = new System.Windows.Forms.ListView();
            this.colProperty = new System.Windows.Forms.ColumnHeader();
            this.colValue = new System.Windows.Forms.ColumnHeader();
            this.pgeProcess = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Stop = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prcsTXT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lvProcess = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabExplore.SuspendLayout();
            this.pgeProperties.SuspendLayout();
            this.pgeSpecialFolders.SuspendLayout();
            this.pgeEnvironmentVariables.SuspendLayout();
            this.pgeSystemInformation.SuspendLayout();
            this.pgeProcess.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabExplore
            // 
            this.tabExplore.Controls.Add(this.pgeProperties);
            this.tabExplore.Controls.Add(this.pgeSpecialFolders);
            this.tabExplore.Controls.Add(this.pgeEnvironmentVariables);
            this.tabExplore.Controls.Add(this.pgeSystemInformation);
            this.tabExplore.Controls.Add(this.pgeProcess);
            this.tabExplore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabExplore.ItemSize = new System.Drawing.Size(59, 18);
            this.tabExplore.Location = new System.Drawing.Point(0, 0);
            this.tabExplore.Name = "tabExplore";
            this.tabExplore.SelectedIndex = 0;
            this.tabExplore.Size = new System.Drawing.Size(571, 453);
            this.tabExplore.TabIndex = 0;
            // 
            // pgeProperties
            // 
            this.pgeProperties.BackColor = System.Drawing.SystemColors.Control;
            this.pgeProperties.Controls.Add(this.btnRefreshTickCount);
            this.pgeProperties.Controls.Add(this.btnStackTrace);
            this.pgeProperties.Controls.Add(this.lblWorkingset);
            this.pgeProperties.Controls.Add(this.Label21);
            this.pgeProperties.Controls.Add(this.lblVersion);
            this.pgeProperties.Controls.Add(this.Label19);
            this.pgeProperties.Controls.Add(this.lblUserName);
            this.pgeProperties.Controls.Add(this.Label17);
            this.pgeProperties.Controls.Add(this.lblUserDomainName);
            this.pgeProperties.Controls.Add(this.Label15);
            this.pgeProperties.Controls.Add(this.lblOSVersion);
            this.pgeProperties.Controls.Add(this.Label13);
            this.pgeProperties.Controls.Add(this.lblMachineName);
            this.pgeProperties.Controls.Add(this.Label11);
            this.pgeProperties.Controls.Add(this.lblTickCount);
            this.pgeProperties.Controls.Add(this.Label9);
            this.pgeProperties.Controls.Add(this.lblSystemDirectory);
            this.pgeProperties.Controls.Add(this.Label7);
            this.pgeProperties.Controls.Add(this.lblCurrentDirectory);
            this.pgeProperties.Controls.Add(this.Label5);
            this.pgeProperties.Controls.Add(this.lblCommandLine);
            this.pgeProperties.Controls.Add(this.Label3);
            this.pgeProperties.Location = new System.Drawing.Point(4, 22);
            this.pgeProperties.Name = "pgeProperties";
            this.pgeProperties.Size = new System.Drawing.Size(563, 427);
            this.pgeProperties.TabIndex = 2;
            this.pgeProperties.Text = "Properties";
            // 
            // btnRefreshTickCount
            // 
            this.btnRefreshTickCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefreshTickCount.Location = new System.Drawing.Point(285, 128);
            this.btnRefreshTickCount.Name = "btnRefreshTickCount";
            this.btnRefreshTickCount.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTickCount.TabIndex = 0;
            this.btnRefreshTickCount.Text = "&Refresh";
            this.btnRefreshTickCount.Click += new System.EventHandler(this.btnRefreshTickCount_Click);
            // 
            // btnStackTrace
            // 
            this.btnStackTrace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStackTrace.Location = new System.Drawing.Point(144, 256);
            this.btnStackTrace.Name = "btnStackTrace";
            this.btnStackTrace.Size = new System.Drawing.Size(224, 23);
            this.btnStackTrace.TabIndex = 1;
            this.btnStackTrace.Text = "&Display Current Stack Trace";
            // 
            // lblWorkingset
            // 
            this.lblWorkingset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkingset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWorkingset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWorkingset.Location = new System.Drawing.Point(144, 224);
            this.lblWorkingset.Name = "lblWorkingset";
            this.lblWorkingset.Size = new System.Drawing.Size(549, 23);
            this.lblWorkingset.TabIndex = 19;
            this.lblWorkingset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label21
            // 
            this.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label21.Location = new System.Drawing.Point(8, 224);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(136, 23);
            this.Label21.TabIndex = 18;
            this.Label21.Text = "WorkingSet";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVersion.Location = new System.Drawing.Point(144, 200);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(549, 23);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label19
            // 
            this.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label19.Location = new System.Drawing.Point(8, 200);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(136, 23);
            this.Label19.TabIndex = 16;
            this.Label19.Text = "Version";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(144, 176);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(549, 23);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label17
            // 
            this.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label17.Location = new System.Drawing.Point(8, 176);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(136, 23);
            this.Label17.TabIndex = 14;
            this.Label17.Text = "UserName";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserDomainName
            // 
            this.lblUserDomainName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDomainName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserDomainName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserDomainName.Location = new System.Drawing.Point(144, 152);
            this.lblUserDomainName.Name = "lblUserDomainName";
            this.lblUserDomainName.Size = new System.Drawing.Size(549, 23);
            this.lblUserDomainName.TabIndex = 13;
            this.lblUserDomainName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            this.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label15.Location = new System.Drawing.Point(8, 152);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(136, 23);
            this.Label15.TabIndex = 12;
            this.Label15.Text = "UserDomainName";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOSVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOSVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOSVersion.Location = new System.Drawing.Point(144, 80);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(549, 23);
            this.lblOSVersion.TabIndex = 11;
            this.lblOSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label13.Location = new System.Drawing.Point(8, 80);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(136, 23);
            this.Label13.TabIndex = 10;
            this.Label13.Text = "OSVersion";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMachineName
            // 
            this.lblMachineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMachineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachineName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMachineName.Location = new System.Drawing.Point(144, 56);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(549, 23);
            this.lblMachineName.TabIndex = 9;
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label11.Location = new System.Drawing.Point(8, 56);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(136, 23);
            this.Label11.TabIndex = 8;
            this.Label11.Text = "MachineName";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTickCount
            // 
            this.lblTickCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTickCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTickCount.Location = new System.Drawing.Point(144, 128);
            this.lblTickCount.Name = "lblTickCount";
            this.lblTickCount.Size = new System.Drawing.Size(128, 23);
            this.lblTickCount.TabIndex = 7;
            this.lblTickCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label9.Location = new System.Drawing.Point(8, 128);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(136, 23);
            this.Label9.TabIndex = 6;
            this.Label9.Text = "TickCount";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSystemDirectory
            // 
            this.lblSystemDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSystemDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSystemDirectory.Location = new System.Drawing.Point(144, 104);
            this.lblSystemDirectory.Name = "lblSystemDirectory";
            this.lblSystemDirectory.Size = new System.Drawing.Size(549, 23);
            this.lblSystemDirectory.TabIndex = 5;
            this.lblSystemDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(8, 104);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(136, 23);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "SystemDirectory";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentDirectory
            // 
            this.lblCurrentDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCurrentDirectory.Location = new System.Drawing.Point(144, 32);
            this.lblCurrentDirectory.Name = "lblCurrentDirectory";
            this.lblCurrentDirectory.Size = new System.Drawing.Size(549, 23);
            this.lblCurrentDirectory.TabIndex = 1;
            this.lblCurrentDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label5.Location = new System.Drawing.Point(8, 32);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(136, 23);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "CurrentDirectory";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommandLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCommandLine.Location = new System.Drawing.Point(144, 8);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(549, 23);
            this.lblCommandLine.TabIndex = 0;
            this.lblCommandLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(8, 8);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 23);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "CommandLine:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgeSpecialFolders
            // 
            this.pgeSpecialFolders.BackColor = System.Drawing.SystemColors.Control;
            this.pgeSpecialFolders.Controls.Add(this.txtResultVar);
            this.pgeSpecialFolders.Controls.Add(this.txtEnvirvar);
            this.pgeSpecialFolders.Controls.Add(this.button1);
            this.pgeSpecialFolders.Controls.Add(this.lblSystemFolder);
            this.pgeSpecialFolders.Controls.Add(this.lblSpecialFolder);
            this.pgeSpecialFolders.Controls.Add(this.btnGetSystemFolder);
            this.pgeSpecialFolders.Controls.Add(this.Label1);
            this.pgeSpecialFolders.Controls.Add(this.lstFolders);
            this.pgeSpecialFolders.Location = new System.Drawing.Point(4, 22);
            this.pgeSpecialFolders.Name = "pgeSpecialFolders";
            this.pgeSpecialFolders.Size = new System.Drawing.Size(563, 427);
            this.pgeSpecialFolders.TabIndex = 0;
            this.pgeSpecialFolders.Text = "Special Folders";
            this.pgeSpecialFolders.Visible = false;
            // 
            // txtResultVar
            // 
            this.txtResultVar.Location = new System.Drawing.Point(222, 254);
            this.txtResultVar.Name = "txtResultVar";
            this.txtResultVar.ReadOnly = true;
            this.txtResultVar.Size = new System.Drawing.Size(442, 20);
            this.txtResultVar.TabIndex = 10;
            // 
            // txtEnvirvar
            // 
            this.txtEnvirvar.Location = new System.Drawing.Point(222, 228);
            this.txtEnvirvar.Name = "txtEnvirvar";
            this.txtEnvirvar.Size = new System.Drawing.Size(442, 20);
            this.txtEnvirvar.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(222, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Environment Var";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSystemFolder
            // 
            this.lblSystemFolder.Location = new System.Drawing.Point(222, 173);
            this.lblSystemFolder.Name = "lblSystemFolder";
            this.lblSystemFolder.ReadOnly = true;
            this.lblSystemFolder.Size = new System.Drawing.Size(442, 20);
            this.lblSystemFolder.TabIndex = 7;
            // 
            // lblSpecialFolder
            // 
            this.lblSpecialFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecialFolder.Location = new System.Drawing.Point(222, 24);
            this.lblSpecialFolder.Multiline = true;
            this.lblSpecialFolder.Name = "lblSpecialFolder";
            this.lblSpecialFolder.ReadOnly = true;
            this.lblSpecialFolder.Size = new System.Drawing.Size(469, 114);
            this.lblSpecialFolder.TabIndex = 6;
            // 
            // btnGetSystemFolder
            // 
            this.btnGetSystemFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetSystemFolder.Location = new System.Drawing.Point(224, 144);
            this.btnGetSystemFolder.Name = "btnGetSystemFolder";
            this.btnGetSystemFolder.Size = new System.Drawing.Size(152, 23);
            this.btnGetSystemFolder.TabIndex = 3;
            this.btnGetSystemFolder.Text = "&get {System Folder}";
            this.btnGetSystemFolder.Click += new System.EventHandler(this.btnGetSystemFolder_Click);
            // 
            // Label1
            // 
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(224, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(200, 23);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Special Folder Path:";
            // 
            // lstFolders
            // 
            this.lstFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFolders.Location = new System.Drawing.Point(8, 8);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(208, 290);
            this.lstFolders.TabIndex = 0;
            this.lstFolders.SelectedIndexChanged += new System.EventHandler(this.lstFolders_SelectedIndexChanged);
            // 
            // pgeEnvironmentVariables
            // 
            this.pgeEnvironmentVariables.BackColor = System.Drawing.SystemColors.Control;
            this.pgeEnvironmentVariables.Controls.Add(this.lblTEMP);
            this.pgeEnvironmentVariables.Controls.Add(this.lblEnvironmentVariable);
            this.pgeEnvironmentVariables.Controls.Add(this.btnGetEnvironmentVariable);
            this.pgeEnvironmentVariables.Controls.Add(this.Label2);
            this.pgeEnvironmentVariables.Controls.Add(this.lstEnvironmentVariables);
            this.pgeEnvironmentVariables.Location = new System.Drawing.Point(4, 22);
            this.pgeEnvironmentVariables.Name = "pgeEnvironmentVariables";
            this.pgeEnvironmentVariables.Size = new System.Drawing.Size(563, 427);
            this.pgeEnvironmentVariables.TabIndex = 1;
            this.pgeEnvironmentVariables.Text = "Environment Variables";
            this.pgeEnvironmentVariables.Visible = false;
            // 
            // lblTEMP
            // 
            this.lblTEMP.Location = new System.Drawing.Point(222, 173);
            this.lblTEMP.Multiline = true;
            this.lblTEMP.Name = "lblTEMP";
            this.lblTEMP.ReadOnly = true;
            this.lblTEMP.Size = new System.Drawing.Size(469, 24);
            this.lblTEMP.TabIndex = 6;
            // 
            // lblEnvironmentVariable
            // 
            this.lblEnvironmentVariable.Location = new System.Drawing.Point(224, 23);
            this.lblEnvironmentVariable.Multiline = true;
            this.lblEnvironmentVariable.Name = "lblEnvironmentVariable";
            this.lblEnvironmentVariable.ReadOnly = true;
            this.lblEnvironmentVariable.Size = new System.Drawing.Size(469, 115);
            this.lblEnvironmentVariable.TabIndex = 5;
            // 
            // btnGetEnvironmentVariable
            // 
            this.btnGetEnvironmentVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetEnvironmentVariable.Location = new System.Drawing.Point(224, 144);
            this.btnGetEnvironmentVariable.Name = "btnGetEnvironmentVariable";
            this.btnGetEnvironmentVariable.Size = new System.Drawing.Size(152, 23);
            this.btnGetEnvironmentVariable.TabIndex = 3;
            this.btnGetEnvironmentVariable.Text = "&get {TEMP Variable";
            // 
            // Label2
            // 
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(224, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(200, 23);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Environment Variable Value:";
            // 
            // lstEnvironmentVariables
            // 
            this.lstEnvironmentVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstEnvironmentVariables.Location = new System.Drawing.Point(8, 8);
            this.lstEnvironmentVariables.Name = "lstEnvironmentVariables";
            this.lstEnvironmentVariables.Size = new System.Drawing.Size(208, 290);
            this.lstEnvironmentVariables.TabIndex = 0;
            this.lstEnvironmentVariables.SelectedIndexChanged += new System.EventHandler(this.lstEnvironmentVariables_SelectedIndexChanged);
            // 
            // pgeSystemInformation
            // 
            this.pgeSystemInformation.Controls.Add(this.lvwSystemInformation);
            this.pgeSystemInformation.Location = new System.Drawing.Point(4, 22);
            this.pgeSystemInformation.Name = "pgeSystemInformation";
            this.pgeSystemInformation.Size = new System.Drawing.Size(563, 427);
            this.pgeSystemInformation.TabIndex = 4;
            this.pgeSystemInformation.Text = "System Information";
            this.pgeSystemInformation.UseVisualStyleBackColor = true;
            this.pgeSystemInformation.Visible = false;
            // 
            // lvwSystemInformation
            // 
            this.lvwSystemInformation.BackColor = System.Drawing.SystemColors.Control;
            this.lvwSystemInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProperty,
            this.colValue});
            this.lvwSystemInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSystemInformation.Location = new System.Drawing.Point(0, 0);
            this.lvwSystemInformation.Name = "lvwSystemInformation";
            this.lvwSystemInformation.Size = new System.Drawing.Size(563, 427);
            this.lvwSystemInformation.TabIndex = 0;
            this.lvwSystemInformation.UseCompatibleStateImageBehavior = false;
            this.lvwSystemInformation.View = System.Windows.Forms.View.Details;
            // 
            // colProperty
            // 
            this.colProperty.Text = "Property";
            this.colProperty.Width = 117;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 341;
            // 
            // pgeProcess
            // 
            this.pgeProcess.BackColor = System.Drawing.SystemColors.Control;
            this.pgeProcess.Controls.Add(this.groupBox3);
            this.pgeProcess.Controls.Add(this.groupBox2);
            this.pgeProcess.Controls.Add(this.button3);
            this.pgeProcess.Controls.Add(this.button2);
            this.pgeProcess.Controls.Add(this.prcsTXT);
            this.pgeProcess.Controls.Add(this.label14);
            this.pgeProcess.Controls.Add(this.lvProcess);
            this.pgeProcess.Location = new System.Drawing.Point(4, 22);
            this.pgeProcess.Name = "pgeProcess";
            this.pgeProcess.Size = new System.Drawing.Size(563, 427);
            this.pgeProcess.TabIndex = 5;
            this.pgeProcess.Text = "Process";
            this.pgeProcess.Click += new System.EventHandler(this.pgeProcess_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Stop);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(386, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 266);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Killer";
            // 
            // Stop
            // 
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Location = new System.Drawing.Point(121, 240);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(43, 23);
            this.Stop.TabIndex = 23;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(6, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Kill";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 186);
            this.listBox1.TabIndex = 21;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "If you type a program name in \r\nthis Box this program Can\'t Run";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Location = new System.Drawing.Point(8, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 406);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accassable Process";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(11, 48);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 264);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(187, 48);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(170, 264);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Process List";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(184, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Module List :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Location :";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(302, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Copy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(80, 321);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(216, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(216, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All Process";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Destination :";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(94, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "TaskBar Process";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(11, 372);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(346, 23);
            this.progressBar2.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(302, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(531, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prcsTXT
            // 
            this.prcsTXT.Location = new System.Drawing.Point(439, 20);
            this.prcsTXT.Name = "prcsTXT";
            this.prcsTXT.Size = new System.Drawing.Size(86, 20);
            this.prcsTXT.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(383, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Process :";
            // 
            // lvProcess
            // 
            this.lvProcess.Location = new System.Drawing.Point(392, 43);
            this.lvProcess.Name = "lvProcess";
            this.lvProcess.Size = new System.Drawing.Size(158, 101);
            this.lvProcess.TabIndex = 2;
            this.lvProcess.UseCompatibleStateImageBehavior = false;
            this.lvProcess.View = System.Windows.Forms.View.List;
            this.lvProcess.SelectedIndexChanged += new System.EventHandler(this.lvProcess_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrechToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 26);
            // 
            // refrechToolStripMenuItem
            // 
            this.refrechToolStripMenuItem.Name = "refrechToolStripMenuItem";
            this.refrechToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.refrechToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.refrechToolStripMenuItem.Text = "Refrech";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 453);
            this.Controls.Add(this.tabExplore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSys";
            this.Text = "System";
            this.Load += new System.EventHandler(this.frmSys_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSys_FormClosed);
            this.tabExplore.ResumeLayout(false);
            this.pgeProperties.ResumeLayout(false);
            this.pgeSpecialFolders.ResumeLayout(false);
            this.pgeSpecialFolders.PerformLayout();
            this.pgeEnvironmentVariables.ResumeLayout(false);
            this.pgeEnvironmentVariables.PerformLayout();
            this.pgeSystemInformation.ResumeLayout(false);
            this.pgeProcess.ResumeLayout(false);
            this.pgeProcess.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabExplore;
        private System.Windows.Forms.TabPage pgeProperties;
        private System.Windows.Forms.Button btnRefreshTickCount;
        private System.Windows.Forms.Button btnStackTrace;
        private System.Windows.Forms.Label lblWorkingset;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label lblUserDomainName;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label lblTickCount;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label lblSystemDirectory;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label lblCurrentDirectory;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label lblCommandLine;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TabPage pgeSpecialFolders;
        private System.Windows.Forms.Button btnGetSystemFolder;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabPage pgeEnvironmentVariables;
        private System.Windows.Forms.Button btnGetEnvironmentVariable;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TabPage pgeSystemInformation;
        private System.Windows.Forms.ListView lvwSystemInformation;
        private System.Windows.Forms.ColumnHeader colProperty;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.ListBox lstEnvironmentVariables;
        public System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.TextBox lblSpecialFolder;
        private System.Windows.Forms.TextBox lblSystemFolder;
        private System.Windows.Forms.TextBox txtEnvirvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultVar;
        private System.Windows.Forms.TabPage pgeProcess;
        private System.Windows.Forms.ListView lvProcess;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox lblEnvironmentVariable;
        private System.Windows.Forms.TextBox lblTEMP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox prcsTXT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refrechToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}