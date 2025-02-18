﻿
namespace nmf_view
{
    partial class frmMain
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
            System.Windows.Forms.ColumnHeader chManifest;
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("User-Registered (HKCU)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("System-Registered (HKLM)", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcApp = new System.Windows.Forms.TabControl();
            this.pageMonitor = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.clbOptions = new System.Windows.Forms.CheckedListBox();
            this.pbApp = new System.Windows.Forms.PictureBox();
            this.pbExt = new System.Windows.Forms.PictureBox();
            this.lblArrow = new System.Windows.Forms.Label();
            this.pageRegisteredHosts = new System.Windows.Forms.TabPage();
            this.lvHosts = new nmf_view.HostListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBrowsers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlConfigureControls = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pageInjector = new System.Windows.Forms.TabPage();
            this.scInjector = new System.Windows.Forms.SplitContainer();
            this.btnSendToApp = new System.Windows.Forms.Button();
            this.txtSendToApp = new System.Windows.Forms.TextBox();
            this.txtSendToExtension = new System.Windows.Forms.TextBox();
            this.btnSendToExtension = new System.Windows.Forms.Button();
            this.pageTroubleshooter = new System.Windows.Forms.TabPage();
            this.rtbTroubleshoot = new System.Windows.Forms.RichTextBox();
            this.pageAbout = new System.Windows.Forms.TabPage();
            this.lblQuickStart = new System.Windows.Forms.Label();
            this.lnkEric = new System.Windows.Forms.LinkLabel();
            this.lnkDocs = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            chManifest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcApp.SuspendLayout();
            this.pageMonitor.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExt)).BeginInit();
            this.pageRegisteredHosts.SuspendLayout();
            this.pnlConfigureControls.SuspendLayout();
            this.pageInjector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInjector)).BeginInit();
            this.scInjector.Panel1.SuspendLayout();
            this.scInjector.Panel2.SuspendLayout();
            this.scInjector.SuspendLayout();
            this.pageTroubleshooter.SuspendLayout();
            this.pageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // chManifest
            // 
            chManifest.Text = "Manifest";
            chManifest.Width = 120;
            // 
            // tcApp
            // 
            this.tcApp.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcApp.Controls.Add(this.pageMonitor);
            this.tcApp.Controls.Add(this.pageRegisteredHosts);
            this.tcApp.Controls.Add(this.pageInjector);
            this.tcApp.Controls.Add(this.pageTroubleshooter);
            this.tcApp.Controls.Add(this.pageAbout);
            this.tcApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcApp.Location = new System.Drawing.Point(0, 0);
            this.tcApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcApp.Multiline = true;
            this.tcApp.Name = "tcApp";
            this.tcApp.SelectedIndex = 0;
            this.tcApp.Size = new System.Drawing.Size(1479, 866);
            this.tcApp.TabIndex = 0;
            this.tcApp.SelectedIndexChanged += new System.EventHandler(this.tcApp_SelectedIndexChanged);
            // 
            // pageMonitor
            // 
            this.pageMonitor.Controls.Add(this.txtLog);
            this.pageMonitor.Controls.Add(this.pnlTop);
            this.pageMonitor.Location = new System.Drawing.Point(4, 4);
            this.pageMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageMonitor.Name = "pageMonitor";
            this.pageMonitor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageMonitor.Size = new System.Drawing.Size(1471, 823);
            this.pageMonitor.TabIndex = 0;
            this.pageMonitor.Text = "Monitor";
            this.pageMonitor.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(3, 178);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1465, 641);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            this.txtLog.WordWrap = false;
            this.txtLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLog_KeyDown);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.clbOptions);
            this.pnlTop.Controls.Add(this.pbApp);
            this.pnlTop.Controls.Add(this.pbExt);
            this.pnlTop.Controls.Add(this.lblArrow);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 4);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1465, 174);
            this.pnlTop.TabIndex = 2;
            // 
            // clbOptions
            // 
            this.clbOptions.CheckOnClick = true;
            this.clbOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.clbOptions.FormattingEnabled = true;
            this.clbOptions.IntegralHeight = false;
            this.clbOptions.Items.AddRange(new object[] {
            "Reflect to extension",
            "Tamper using Fiddler",
            "Propagate closures",
            "Log message bodies",
            "Write log to Desktop"});
            this.clbOptions.Location = new System.Drawing.Point(1020, 0);
            this.clbOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbOptions.Name = "clbOptions";
            this.clbOptions.Size = new System.Drawing.Size(445, 174);
            this.clbOptions.TabIndex = 1;
            this.clbOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbOptions_ItemCheck);
            // 
            // pbApp
            // 
            this.pbApp.Image = ((System.Drawing.Image)(resources.GetObject("pbApp.Image")));
            this.pbApp.Location = new System.Drawing.Point(696, -5);
            this.pbApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbApp.Name = "pbApp";
            this.pbApp.Size = new System.Drawing.Size(193, 172);
            this.pbApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbApp.TabIndex = 2;
            this.pbApp.TabStop = false;
            this.pbApp.Click += new System.EventHandler(this.pbApp_Click);
            this.pbApp.DoubleClick += new System.EventHandler(this.pbApp_DoubleClick);
            // 
            // pbExt
            // 
            this.pbExt.Image = global::nmf_view.Properties.Resources.ext;
            this.pbExt.Location = new System.Drawing.Point(0, 0);
            this.pbExt.Margin = new System.Windows.Forms.Padding(0);
            this.pbExt.Name = "pbExt";
            this.pbExt.Size = new System.Drawing.Size(193, 168);
            this.pbExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExt.TabIndex = 3;
            this.pbExt.TabStop = false;
            this.toolTip1.SetToolTip(this.pbExt, "Calling extension is unknown");
            this.pbExt.DoubleClick += new System.EventHandler(this.pbExt_DoubleClick);
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Segoe Print", 39.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArrow.Location = new System.Drawing.Point(168, -4);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(565, 164);
            this.lblArrow.TabIndex = 4;
            this.lblArrow.Text = "⇿ (this) ⇿";
            this.lblArrow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pageRegisteredHosts
            // 
            this.pageRegisteredHosts.Controls.Add(this.lvHosts);
            this.pageRegisteredHosts.Controls.Add(this.pnlConfigureControls);
            this.pageRegisteredHosts.Location = new System.Drawing.Point(4, 4);
            this.pageRegisteredHosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageRegisteredHosts.Name = "pageRegisteredHosts";
            this.pageRegisteredHosts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageRegisteredHosts.Size = new System.Drawing.Size(1471, 823);
            this.pageRegisteredHosts.TabIndex = 1;
            this.pageRegisteredHosts.Text = "Configure Hosts";
            this.pageRegisteredHosts.UseVisualStyleBackColor = true;
            // 
            // lvHosts
            // 
            this.lvHosts.CheckBoxes = true;
            this.lvHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.colPriority,
            chManifest,
            this.chExe,
            this.chDescription,
            this.chBrowsers,
            this.chExtensions});
            this.lvHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHosts.FullRowSelect = true;
            this.lvHosts.GridLines = true;
            listViewGroup3.Header = "User-Registered (HKCU)";
            listViewGroup3.Name = "lvgHKCU";
            listViewGroup4.Header = "System-Registered (HKLM)";
            listViewGroup4.Name = "lvgHKLM";
            this.lvHosts.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.lvHosts.HideSelection = false;
            this.lvHosts.Location = new System.Drawing.Point(3, 104);
            this.lvHosts.Name = "lvHosts";
            this.lvHosts.ShowItemToolTips = true;
            this.lvHosts.Size = new System.Drawing.Size(1465, 715);
            this.lvHosts.TabIndex = 0;
            this.lvHosts.UseCompatibleStateImageBehavior = false;
            this.lvHosts.View = System.Windows.Forms.View.Details;
            this.lvHosts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvHosts_ItemCheck);
            this.lvHosts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvHosts_KeyDown);
            this.lvHosts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvHosts_MouseDoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 430;
            // 
            // colPriority
            // 
            this.colPriority.Text = "Priority";
            // 
            // chExe
            // 
            this.chExe.Text = "Exe";
            this.chExe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chExe.Width = 200;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 120;
            // 
            // chBrowsers
            // 
            this.chBrowsers.Text = "Browsers";
            this.chBrowsers.Width = 100;
            // 
            // chExtensions
            // 
            this.chExtensions.Text = "Extensions";
            // 
            // pnlConfigureControls
            // 
            this.pnlConfigureControls.Controls.Add(this.label2);
            this.pnlConfigureControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfigureControls.Location = new System.Drawing.Point(3, 4);
            this.pnlConfigureControls.Name = "pnlConfigureControls";
            this.pnlConfigureControls.Size = new System.Drawing.Size(1465, 100);
            this.pnlConfigureControls.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1063, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOT YET IMPLEMENTED (Eventually, select which NativeMessagingHosts this applicati" +
    "on should intercept/proxy.)";
            // 
            // pageInjector
            // 
            this.pageInjector.Controls.Add(this.scInjector);
            this.pageInjector.Location = new System.Drawing.Point(4, 4);
            this.pageInjector.Name = "pageInjector";
            this.pageInjector.Size = new System.Drawing.Size(1471, 823);
            this.pageInjector.TabIndex = 3;
            this.pageInjector.Text = "Injector";
            this.pageInjector.UseVisualStyleBackColor = true;
            // 
            // scInjector
            // 
            this.scInjector.BackColor = System.Drawing.Color.Transparent;
            this.scInjector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scInjector.Location = new System.Drawing.Point(0, 0);
            this.scInjector.Name = "scInjector";
            this.scInjector.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scInjector.Panel1
            // 
            this.scInjector.Panel1.Controls.Add(this.btnSendToApp);
            this.scInjector.Panel1.Controls.Add(this.txtSendToApp);
            // 
            // scInjector.Panel2
            // 
            this.scInjector.Panel2.Controls.Add(this.txtSendToExtension);
            this.scInjector.Panel2.Controls.Add(this.btnSendToExtension);
            this.scInjector.Size = new System.Drawing.Size(1471, 823);
            this.scInjector.SplitterDistance = 410;
            this.scInjector.TabIndex = 4;
            // 
            // btnSendToApp
            // 
            this.btnSendToApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToApp.Enabled = false;
            this.btnSendToApp.Location = new System.Drawing.Point(1021, 350);
            this.btnSendToApp.Name = "btnSendToApp";
            this.btnSendToApp.Size = new System.Drawing.Size(442, 41);
            this.btnSendToApp.TabIndex = 5;
            this.btnSendToApp.Text = "Send to Native Host app";
            this.btnSendToApp.UseVisualStyleBackColor = true;
            this.btnSendToApp.Click += new System.EventHandler(this.btnSendToApp_Click);
            // 
            // txtSendToApp
            // 
            this.txtSendToApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendToApp.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtSendToApp.Location = new System.Drawing.Point(8, 8);
            this.txtSendToApp.Multiline = true;
            this.txtSendToApp.Name = "txtSendToApp";
            this.txtSendToApp.Size = new System.Drawing.Size(1455, 336);
            this.txtSendToApp.TabIndex = 5;
            this.txtSendToApp.Text = "{\"example_1\": \"to nmh.exe\", \"field_2\": 2, \"field_3\":false}";
            this.txtSendToApp.TextChanged += new System.EventHandler(this.txtSendToApp_TextChanged);
            // 
            // txtSendToExtension
            // 
            this.txtSendToExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendToExtension.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtSendToExtension.Location = new System.Drawing.Point(8, 3);
            this.txtSendToExtension.Multiline = true;
            this.txtSendToExtension.Name = "txtSendToExtension";
            this.txtSendToExtension.Size = new System.Drawing.Size(1455, 341);
            this.txtSendToExtension.TabIndex = 3;
            this.txtSendToExtension.Text = "{\"example_1\": \"to browser\", \"field_2\": 2, \"field_3\":false}";
            this.txtSendToExtension.TextChanged += new System.EventHandler(this.txtSendToExtension_TextChanged);
            // 
            // btnSendToExtension
            // 
            this.btnSendToExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToExtension.Enabled = false;
            this.btnSendToExtension.Location = new System.Drawing.Point(1021, 350);
            this.btnSendToExtension.Name = "btnSendToExtension";
            this.btnSendToExtension.Size = new System.Drawing.Size(442, 41);
            this.btnSendToExtension.TabIndex = 4;
            this.btnSendToExtension.Text = "Send to Browser/Extension";
            this.btnSendToExtension.UseVisualStyleBackColor = true;
            this.btnSendToExtension.Click += new System.EventHandler(this.btnSendToExtension_Click);
            // 
            // pageTroubleshooter
            // 
            this.pageTroubleshooter.Controls.Add(this.rtbTroubleshoot);
            this.pageTroubleshooter.Location = new System.Drawing.Point(4, 4);
            this.pageTroubleshooter.Name = "pageTroubleshooter";
            this.pageTroubleshooter.Size = new System.Drawing.Size(1471, 823);
            this.pageTroubleshooter.TabIndex = 4;
            this.pageTroubleshooter.Text = "Troubleshooter";
            this.pageTroubleshooter.UseVisualStyleBackColor = true;
            // 
            // rtbTroubleshoot
            // 
            this.rtbTroubleshoot.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtbTroubleshoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTroubleshoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTroubleshoot.Font = new System.Drawing.Font("Consolas", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTroubleshoot.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbTroubleshoot.Location = new System.Drawing.Point(0, 0);
            this.rtbTroubleshoot.Name = "rtbTroubleshoot";
            this.rtbTroubleshoot.ReadOnly = true;
            this.rtbTroubleshoot.Size = new System.Drawing.Size(1471, 823);
            this.rtbTroubleshoot.TabIndex = 4;
            this.rtbTroubleshoot.Text = "";
            this.rtbTroubleshoot.WordWrap = false;
            // 
            // pageAbout
            // 
            this.pageAbout.Controls.Add(this.lblQuickStart);
            this.pageAbout.Controls.Add(this.lnkEric);
            this.pageAbout.Controls.Add(this.lnkDocs);
            this.pageAbout.Controls.Add(this.lblVersion);
            this.pageAbout.Controls.Add(this.label1);
            this.pageAbout.Controls.Add(this.lnkGithub);
            this.pageAbout.Location = new System.Drawing.Point(4, 4);
            this.pageAbout.Name = "pageAbout";
            this.pageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.pageAbout.Size = new System.Drawing.Size(1471, 823);
            this.pageAbout.TabIndex = 2;
            this.pageAbout.Text = "About";
            this.pageAbout.UseVisualStyleBackColor = true;
            // 
            // lblQuickStart
            // 
            this.lblQuickStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuickStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQuickStart.Location = new System.Drawing.Point(29, 251);
            this.lblQuickStart.Name = "lblQuickStart";
            this.lblQuickStart.Size = new System.Drawing.Size(1384, 425);
            this.lblQuickStart.TabIndex = 5;
            this.lblQuickStart.Text = resources.GetString("lblQuickStart.Text");
            this.lblQuickStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkEric
            // 
            this.lnkEric.AutoSize = true;
            this.lnkEric.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lnkEric.LinkArea = new System.Windows.Forms.LinkArea(3, 8);
            this.lnkEric.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEric.Location = new System.Drawing.Point(827, 66);
            this.lnkEric.Name = "lnkEric";
            this.lnkEric.Size = new System.Drawing.Size(150, 41);
            this.lnkEric.TabIndex = 4;
            this.lnkEric.TabStop = true;
            this.lnkEric.Text = "by @ericlaw";
            this.lnkEric.UseCompatibleTextRendering = true;
            this.lnkEric.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEric_LinkClicked);
            // 
            // lnkDocs
            // 
            this.lnkDocs.AutoSize = true;
            this.lnkDocs.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lnkDocs.LinkArea = new System.Windows.Forms.LinkArea(9, 13);
            this.lnkDocs.Location = new System.Drawing.Point(35, 198);
            this.lnkDocs.Name = "lnkDocs";
            this.lnkDocs.Size = new System.Drawing.Size(303, 41);
            this.lnkDocs.TabIndex = 3;
            this.lnkDocs.TabStop = true;
            this.lnkDocs.Text = "Read the documentation.";
            this.lnkDocs.UseCompatibleTextRendering = true;
            this.lnkDocs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDocs_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(39, 113);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(82, 30);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "v0.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "NativeMessaging Meddler";
            // 
            // lnkGithub
            // 
            this.lnkGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lnkGithub.LinkArea = new System.Windows.Forms.LinkArea(37, 9);
            this.lnkGithub.Location = new System.Drawing.Point(35, 676);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(580, 41);
            this.lnkGithub.TabIndex = 0;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "Please report bugs and view the code on GitHub.";
            this.lnkGithub.UseCompatibleTextRendering = true;
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 866);
            this.Controls.Add(this.tcApp);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(830, 350);
            this.Name = "frmMain";
            this.Text = "NativeMessaging Meddler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tcApp.ResumeLayout(false);
            this.pageMonitor.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExt)).EndInit();
            this.pageRegisteredHosts.ResumeLayout(false);
            this.pnlConfigureControls.ResumeLayout(false);
            this.pnlConfigureControls.PerformLayout();
            this.pageInjector.ResumeLayout(false);
            this.scInjector.Panel1.ResumeLayout(false);
            this.scInjector.Panel1.PerformLayout();
            this.scInjector.Panel2.ResumeLayout(false);
            this.scInjector.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInjector)).EndInit();
            this.scInjector.ResumeLayout(false);
            this.pageTroubleshooter.ResumeLayout(false);
            this.pageAbout.ResumeLayout(false);
            this.pageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcApp;
        private System.Windows.Forms.TabPage pageMonitor;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbApp;
        private System.Windows.Forms.CheckedListBox clbOptions;
        private System.Windows.Forms.PictureBox pbExt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.TabPage pageRegisteredHosts;
        private System.Windows.Forms.TabPage pageAbout;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkDocs;
        private System.Windows.Forms.LinkLabel lnkEric;
        private System.Windows.Forms.Label lblQuickStart;
        private HostListView lvHosts;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chExe;
        private System.Windows.Forms.Panel pnlConfigureControls;
        private System.Windows.Forms.ColumnHeader colPriority;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader chBrowsers;
        private System.Windows.Forms.ColumnHeader chExtensions;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TabPage pageInjector;
        private System.Windows.Forms.SplitContainer scInjector;
        private System.Windows.Forms.Button btnSendToExtension;
        private System.Windows.Forms.Button btnSendToApp;
        private System.Windows.Forms.TextBox txtSendToExtension;
        private System.Windows.Forms.TextBox txtSendToApp;
        private System.Windows.Forms.TabPage pageTroubleshooter;
        private System.Windows.Forms.RichTextBox rtbTroubleshoot;
    }
}