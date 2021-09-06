﻿namespace loading_screen
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("System Information", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Power Config Value", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Host Name",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "System Model",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Serial Number",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "IP Address",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "DNS Address",
            "4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "Static",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(new string[] {
            "NS Lookup Hostname",
            "6"}, -1);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem(new string[] {
            "Time Zone",
            "7"}, -1);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(new string[] {
            "CPU Information",
            "8"}, -1);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem(new string[] {
            "Disk Storage information",
            "9"}, -1);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem(new string[] {
            "RAM information",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem(new string[] {
            "Display Resolution",
            "11"}, -1);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem(new string[] {
            "1) Sleep After AC Power Value",
            "12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem(new string[] {
            "2) Turn off display after AC Power Value",
            "13"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem(new string[] {
            "asdfsdfds",
            "dsfdsfds"}, -1);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSystemInfo = new System.Windows.Forms.TabPage();
            this.lstDisplayHardware = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCertificateInfo = new System.Windows.Forms.TabPage();
            this.listViewCertificate = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.btnAutoLoginEnable = new System.Windows.Forms.Button();
            this.btnAutoLoginDisable = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEnableScreenSaver = new System.Windows.Forms.Button();
            this.btnDisableScreenSaver = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnChangeTimeZone = new System.Windows.Forms.Button();
            this.lblCurrentTimeZone = new System.Windows.Forms.Label();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnGetPrograms = new System.Windows.Forms.Button();
            this.listViewPrograms = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPortQueryValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckPort = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChangeTurnoffAfter = new System.Windows.Forms.Button();
            this.textBoxTurnoffAfter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeSleepAfter = new System.Windows.Forms.Button();
            this.textBoxSleepAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMailBody = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMailTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMailTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMailPwd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMailUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMailPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMailHost = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAutoLoginUserName = new System.Windows.Forms.TextBox();
            this.txtAutoLoginPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSystemInfo.SuspendLayout();
            this.tabCertificateInfo.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabSystemInfo);
            this.tabControl1.Controls.Add(this.tabCertificateInfo);
            this.tabControl1.Controls.Add(this.tabConfiguration);
            this.tabControl1.Controls.Add(this.tabEmail);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 21);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 490);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabSystemInfo
            // 
            this.tabSystemInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabSystemInfo.Controls.Add(this.lstDisplayHardware);
            this.tabSystemInfo.Location = new System.Drawing.Point(4, 25);
            this.tabSystemInfo.Name = "tabSystemInfo";
            this.tabSystemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemInfo.Size = new System.Drawing.Size(758, 461);
            this.tabSystemInfo.TabIndex = 0;
            this.tabSystemInfo.Text = "System Information";
            // 
            // lstDisplayHardware
            // 
            this.lstDisplayHardware.BackColor = System.Drawing.Color.Gainsboro;
            this.lstDisplayHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDisplayHardware.FullRowSelect = true;
            this.lstDisplayHardware.GridLines = true;
            listViewGroup4.Header = "System Information";
            listViewGroup4.Name = "ListViewGroupSystemInfo";
            listViewGroup5.Header = "Power Config Value";
            listViewGroup5.Name = "listGroupPowerConfig";
            this.lstDisplayHardware.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5});
            this.lstDisplayHardware.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDisplayHardware.HideSelection = false;
            listViewItem16.Group = listViewGroup4;
            listViewItem17.Group = listViewGroup4;
            listViewItem18.Group = listViewGroup4;
            listViewItem19.Group = listViewGroup4;
            listViewItem20.Group = listViewGroup4;
            listViewItem21.Group = listViewGroup4;
            listViewItem22.Group = listViewGroup4;
            listViewItem23.Group = listViewGroup4;
            listViewItem24.Group = listViewGroup4;
            listViewItem25.Group = listViewGroup4;
            listViewItem26.Group = listViewGroup4;
            listViewItem27.Group = listViewGroup4;
            listViewItem28.Group = listViewGroup5;
            listViewItem29.Group = listViewGroup5;
            this.lstDisplayHardware.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29});
            this.lstDisplayHardware.Location = new System.Drawing.Point(0, 0);
            this.lstDisplayHardware.Name = "lstDisplayHardware";
            this.lstDisplayHardware.Size = new System.Drawing.Size(758, 461);
            this.lstDisplayHardware.TabIndex = 1;
            this.lstDisplayHardware.UseCompatibleStateImageBehavior = false;
            this.lstDisplayHardware.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 381;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 365;
            // 
            // tabCertificateInfo
            // 
            this.tabCertificateInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCertificateInfo.Controls.Add(this.listViewCertificate);
            this.tabCertificateInfo.Location = new System.Drawing.Point(4, 25);
            this.tabCertificateInfo.Name = "tabCertificateInfo";
            this.tabCertificateInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCertificateInfo.Size = new System.Drawing.Size(758, 461);
            this.tabCertificateInfo.TabIndex = 1;
            this.tabCertificateInfo.Text = "Certificate Information";
            // 
            // listViewCertificate
            // 
            this.listViewCertificate.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewCertificate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCertificate.FullRowSelect = true;
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup1";
            this.listViewCertificate.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6});
            this.listViewCertificate.HideSelection = false;
            listViewItem30.Group = listViewGroup6;
            this.listViewCertificate.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem30});
            this.listViewCertificate.Location = new System.Drawing.Point(0, 0);
            this.listViewCertificate.Name = "listViewCertificate";
            this.listViewCertificate.Size = new System.Drawing.Size(758, 461);
            this.listViewCertificate.TabIndex = 0;
            this.listViewCertificate.UseCompatibleStateImageBehavior = false;
            this.listViewCertificate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 609;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.BackColor = System.Drawing.Color.Gainsboro;
            this.tabConfiguration.Controls.Add(this.txtAutoLoginPassword);
            this.tabConfiguration.Controls.Add(this.label19);
            this.tabConfiguration.Controls.Add(this.txtAutoLoginUserName);
            this.tabConfiguration.Controls.Add(this.label18);
            this.tabConfiguration.Controls.Add(this.btnAutoLoginEnable);
            this.tabConfiguration.Controls.Add(this.btnAutoLoginDisable);
            this.tabConfiguration.Controls.Add(this.label17);
            this.tabConfiguration.Controls.Add(this.btnEnableScreenSaver);
            this.tabConfiguration.Controls.Add(this.btnDisableScreenSaver);
            this.tabConfiguration.Controls.Add(this.label16);
            this.tabConfiguration.Controls.Add(this.btnChangeTimeZone);
            this.tabConfiguration.Controls.Add(this.lblCurrentTimeZone);
            this.tabConfiguration.Controls.Add(this.cmbTimeZone);
            this.tabConfiguration.Controls.Add(this.label15);
            this.tabConfiguration.Controls.Add(this.label14);
            this.tabConfiguration.Controls.Add(this.btnUninstall);
            this.tabConfiguration.Controls.Add(this.btnGetPrograms);
            this.tabConfiguration.Controls.Add(this.listViewPrograms);
            this.tabConfiguration.Controls.Add(this.textBoxPort);
            this.tabConfiguration.Controls.Add(this.labelPortQueryValue);
            this.tabConfiguration.Controls.Add(this.label4);
            this.tabConfiguration.Controls.Add(this.btnCheckPort);
            this.tabConfiguration.Controls.Add(this.textBoxAddress);
            this.tabConfiguration.Controls.Add(this.label5);
            this.tabConfiguration.Controls.Add(this.label6);
            this.tabConfiguration.Controls.Add(this.btnChangeTurnoffAfter);
            this.tabConfiguration.Controls.Add(this.textBoxTurnoffAfter);
            this.tabConfiguration.Controls.Add(this.label3);
            this.tabConfiguration.Controls.Add(this.btnChangeSleepAfter);
            this.tabConfiguration.Controls.Add(this.textBoxSleepAfter);
            this.tabConfiguration.Controls.Add(this.label2);
            this.tabConfiguration.Controls.Add(this.label1);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Size = new System.Drawing.Size(758, 461);
            this.tabConfiguration.TabIndex = 2;
            this.tabConfiguration.Text = "Configuration";
            // 
            // btnAutoLoginEnable
            // 
            this.btnAutoLoginEnable.Location = new System.Drawing.Point(502, 387);
            this.btnAutoLoginEnable.Name = "btnAutoLoginEnable";
            this.btnAutoLoginEnable.Size = new System.Drawing.Size(75, 23);
            this.btnAutoLoginEnable.TabIndex = 26;
            this.btnAutoLoginEnable.Text = "Enable";
            this.btnAutoLoginEnable.UseVisualStyleBackColor = true;
            this.btnAutoLoginEnable.Click += new System.EventHandler(this.btnAutoLoginEnable_Click);
            // 
            // btnAutoLoginDisable
            // 
            this.btnAutoLoginDisable.Location = new System.Drawing.Point(588, 387);
            this.btnAutoLoginDisable.Name = "btnAutoLoginDisable";
            this.btnAutoLoginDisable.Size = new System.Drawing.Size(75, 23);
            this.btnAutoLoginDisable.TabIndex = 25;
            this.btnAutoLoginDisable.Text = "Disable";
            this.btnAutoLoginDisable.UseVisualStyleBackColor = true;
            this.btnAutoLoginDisable.Click += new System.EventHandler(this.btnAutoLoginDisable_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Auto Login";
            // 
            // btnEnableScreenSaver
            // 
            this.btnEnableScreenSaver.Location = new System.Drawing.Point(226, 346);
            this.btnEnableScreenSaver.Name = "btnEnableScreenSaver";
            this.btnEnableScreenSaver.Size = new System.Drawing.Size(75, 23);
            this.btnEnableScreenSaver.TabIndex = 23;
            this.btnEnableScreenSaver.Text = "Enable";
            this.btnEnableScreenSaver.UseVisualStyleBackColor = true;
            this.btnEnableScreenSaver.Click += new System.EventHandler(this.btnEnableScreenSaver_Click);
            // 
            // btnDisableScreenSaver
            // 
            this.btnDisableScreenSaver.Location = new System.Drawing.Point(312, 346);
            this.btnDisableScreenSaver.Name = "btnDisableScreenSaver";
            this.btnDisableScreenSaver.Size = new System.Drawing.Size(75, 23);
            this.btnDisableScreenSaver.TabIndex = 22;
            this.btnDisableScreenSaver.Text = "Disable";
            this.btnDisableScreenSaver.UseVisualStyleBackColor = true;
            this.btnDisableScreenSaver.Click += new System.EventHandler(this.btnDisableScreenSaver_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Disable Screen Saver";
            // 
            // btnChangeTimeZone
            // 
            this.btnChangeTimeZone.Location = new System.Drawing.Point(521, 316);
            this.btnChangeTimeZone.Name = "btnChangeTimeZone";
            this.btnChangeTimeZone.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTimeZone.TabIndex = 20;
            this.btnChangeTimeZone.Text = "Change";
            this.btnChangeTimeZone.UseVisualStyleBackColor = true;
            this.btnChangeTimeZone.Click += new System.EventHandler(this.btnChangeTimeZone_Click);
            // 
            // lblCurrentTimeZone
            // 
            this.lblCurrentTimeZone.AutoSize = true;
            this.lblCurrentTimeZone.Location = new System.Drawing.Point(148, 321);
            this.lblCurrentTimeZone.Name = "lblCurrentTimeZone";
            this.lblCurrentTimeZone.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentTimeZone.TabIndex = 19;
            this.lblCurrentTimeZone.Text = "Tokyo Standard Time";
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Location = new System.Drawing.Point(312, 317);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(195, 21);
            this.cmbTimeZone.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Time Zone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Programs";
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(666, 217);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 15;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnGetPrograms
            // 
            this.btnGetPrograms.Location = new System.Drawing.Point(666, 188);
            this.btnGetPrograms.Name = "btnGetPrograms";
            this.btnGetPrograms.Size = new System.Drawing.Size(75, 23);
            this.btnGetPrograms.TabIndex = 14;
            this.btnGetPrograms.Text = "Get";
            this.btnGetPrograms.UseVisualStyleBackColor = true;
            this.btnGetPrograms.Click += new System.EventHandler(this.btnGetPrograms_Click);
            // 
            // listViewPrograms
            // 
            this.listViewPrograms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listViewPrograms.FullRowSelect = true;
            this.listViewPrograms.HideSelection = false;
            this.listViewPrograms.Location = new System.Drawing.Point(61, 188);
            this.listViewPrograms.Name = "listViewPrograms";
            this.listViewPrograms.Size = new System.Drawing.Size(602, 117);
            this.listViewPrograms.TabIndex = 13;
            this.listViewPrograms.UseCompatibleStateImageBehavior = false;
            this.listViewPrograms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Programs";
            this.columnHeader5.Width = 584;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(513, 135);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(67, 20);
            this.textBoxPort.TabIndex = 10;
            this.textBoxPort.Text = "443";
            // 
            // labelPortQueryValue
            // 
            this.labelPortQueryValue.AutoSize = true;
            this.labelPortQueryValue.Location = new System.Drawing.Point(625, 139);
            this.labelPortQueryValue.Name = "labelPortQueryValue";
            this.labelPortQueryValue.Size = new System.Drawing.Size(0, 13);
            this.labelPortQueryValue.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "value:";
            // 
            // btnCheckPort
            // 
            this.btnCheckPort.Location = new System.Drawing.Point(666, 134);
            this.btnCheckPort.Name = "btnCheckPort";
            this.btnCheckPort.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPort.TabIndex = 10;
            this.btnCheckPort.Text = "Check";
            this.btnCheckPort.UseVisualStyleBackColor = true;
            this.btnCheckPort.Click += new System.EventHandler(this.btnCheckPort_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(328, 135);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxAddress.TabIndex = 9;
            this.textBoxAddress.Text = "www.google.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "If listening, value: true, if denied, value: false";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port Query";
            // 
            // btnChangeTurnoffAfter
            // 
            this.btnChangeTurnoffAfter.Location = new System.Drawing.Point(432, 69);
            this.btnChangeTurnoffAfter.Name = "btnChangeTurnoffAfter";
            this.btnChangeTurnoffAfter.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTurnoffAfter.TabIndex = 6;
            this.btnChangeTurnoffAfter.Text = "Change";
            this.btnChangeTurnoffAfter.UseVisualStyleBackColor = true;
            this.btnChangeTurnoffAfter.Click += new System.EventHandler(this.btnChangeTurnoffAfter_Click);
            // 
            // textBoxTurnoffAfter
            // 
            this.textBoxTurnoffAfter.Location = new System.Drawing.Point(310, 71);
            this.textBoxTurnoffAfter.Name = "textBoxTurnoffAfter";
            this.textBoxTurnoffAfter.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurnoffAfter.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "2) Turn off display after AC Power Value";
            // 
            // btnChangeSleepAfter
            // 
            this.btnChangeSleepAfter.Location = new System.Drawing.Point(432, 40);
            this.btnChangeSleepAfter.Name = "btnChangeSleepAfter";
            this.btnChangeSleepAfter.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSleepAfter.TabIndex = 3;
            this.btnChangeSleepAfter.Text = "Change";
            this.btnChangeSleepAfter.UseVisualStyleBackColor = true;
            this.btnChangeSleepAfter.Click += new System.EventHandler(this.btnChangeSleepAfter_Click);
            // 
            // textBoxSleepAfter
            // 
            this.textBoxSleepAfter.Location = new System.Drawing.Point(310, 42);
            this.textBoxSleepAfter.Name = "textBoxSleepAfter";
            this.textBoxSleepAfter.Size = new System.Drawing.Size(100, 20);
            this.textBoxSleepAfter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "1) Sleep After AC Power Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power Config Value";
            // 
            // tabEmail
            // 
            this.tabEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.tabEmail.Controls.Add(this.btnGenerate);
            this.tabEmail.Controls.Add(this.btnSend);
            this.tabEmail.Controls.Add(this.txtMailBody);
            this.tabEmail.Controls.Add(this.label13);
            this.tabEmail.Controls.Add(this.label12);
            this.tabEmail.Controls.Add(this.txtMailTitle);
            this.tabEmail.Controls.Add(this.label8);
            this.tabEmail.Controls.Add(this.txtMailTo);
            this.tabEmail.Controls.Add(this.label7);
            this.tabEmail.Controls.Add(this.txtMailPwd);
            this.tabEmail.Controls.Add(this.label11);
            this.tabEmail.Controls.Add(this.txtMailUserName);
            this.tabEmail.Controls.Add(this.label9);
            this.tabEmail.Controls.Add(this.txtMailPort);
            this.tabEmail.Controls.Add(this.label10);
            this.tabEmail.Controls.Add(this.txtMailHost);
            this.tabEmail.Location = new System.Drawing.Point(4, 25);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Size = new System.Drawing.Size(758, 461);
            this.tabEmail.TabIndex = 3;
            this.tabEmail.Text = "Email";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(299, 427);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(468, 427);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMailBody
            // 
            this.txtMailBody.Location = new System.Drawing.Point(134, 183);
            this.txtMailBody.Multiline = true;
            this.txtMailBody.Name = "txtMailBody";
            this.txtMailBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMailBody.Size = new System.Drawing.Size(577, 228);
            this.txtMailBody.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Body";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Title";
            // 
            // txtMailTitle
            // 
            this.txtMailTitle.Location = new System.Drawing.Point(134, 157);
            this.txtMailTitle.Name = "txtMailTitle";
            this.txtMailTitle.Size = new System.Drawing.Size(577, 20);
            this.txtMailTitle.TabIndex = 18;
            this.txtMailTitle.Text = "Report";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "To";
            // 
            // txtMailTo
            // 
            this.txtMailTo.Location = new System.Drawing.Point(134, 131);
            this.txtMailTo.Name = "txtMailTo";
            this.txtMailTo.Size = new System.Drawing.Size(577, 20);
            this.txtMailTo.TabIndex = 16;
            this.txtMailTo.Text = "shkuratovmong@mail.ru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // txtMailPwd
            // 
            this.txtMailPwd.Location = new System.Drawing.Point(134, 105);
            this.txtMailPwd.Name = "txtMailPwd";
            this.txtMailPwd.Size = new System.Drawing.Size(577, 20);
            this.txtMailPwd.TabIndex = 14;
            this.txtMailPwd.Text = "aaa";
            this.txtMailPwd.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "UserName";
            // 
            // txtMailUserName
            // 
            this.txtMailUserName.Location = new System.Drawing.Point(134, 79);
            this.txtMailUserName.Name = "txtMailUserName";
            this.txtMailUserName.Size = new System.Drawing.Size(577, 20);
            this.txtMailUserName.TabIndex = 12;
            this.txtMailUserName.Text = "shkuratovu@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Port";
            // 
            // txtMailPort
            // 
            this.txtMailPort.Location = new System.Drawing.Point(134, 53);
            this.txtMailPort.Name = "txtMailPort";
            this.txtMailPort.Size = new System.Drawing.Size(577, 20);
            this.txtMailPort.TabIndex = 10;
            this.txtMailPort.Text = "587";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Host";
            // 
            // txtMailHost
            // 
            this.txtMailHost.Location = new System.Drawing.Point(134, 27);
            this.txtMailHost.Name = "txtMailHost";
            this.txtMailHost.Size = new System.Drawing.Size(577, 20);
            this.txtMailHost.TabIndex = 8;
            this.txtMailHost.Text = "smtp.gmail.com";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(138, 393);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "User Name";
            // 
            // txtAutoLoginUserName
            // 
            this.txtAutoLoginUserName.Location = new System.Drawing.Point(204, 390);
            this.txtAutoLoginUserName.Name = "txtAutoLoginUserName";
            this.txtAutoLoginUserName.Size = new System.Drawing.Size(100, 20);
            this.txtAutoLoginUserName.TabIndex = 28;
            // 
            // txtAutoLoginPassword
            // 
            this.txtAutoLoginPassword.Location = new System.Drawing.Point(391, 390);
            this.txtAutoLoginPassword.Name = "txtAutoLoginPassword";
            this.txtAutoLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAutoLoginPassword.TabIndex = 30;
            this.txtAutoLoginPassword.UseSystemPasswordChar = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(325, 393);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Password";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 488);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Board";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSystemInfo.ResumeLayout(false);
            this.tabCertificateInfo.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.tabConfiguration.PerformLayout();
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSystemInfo;
        private System.Windows.Forms.TabPage tabCertificateInfo;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.ListView lstDisplayHardware;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewCertificate;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeSleepAfter;
        private System.Windows.Forms.TextBox textBoxSleepAfter;
        private System.Windows.Forms.Button btnChangeTurnoffAfter;
        private System.Windows.Forms.TextBox textBoxTurnoffAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckPort;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPortQueryValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ListView listViewPrograms;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnGetPrograms;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMailUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMailPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMailHost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMailPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMailTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMailTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMailBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.Button btnChangeTimeZone;
        private System.Windows.Forms.Label lblCurrentTimeZone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDisableScreenSaver;
        private System.Windows.Forms.Button btnEnableScreenSaver;
        private System.Windows.Forms.Button btnAutoLoginEnable;
        private System.Windows.Forms.Button btnAutoLoginDisable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAutoLoginPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAutoLoginUserName;
    }
}