namespace loading_screen
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("System Information", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Power Config Value", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Host Name",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "System Model",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Serial Number",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "IP Address",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "DNS Address",
            "4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Static",
            "5"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "NS Lookup Hostname",
            "6"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Time Zone",
            "7"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "CPU Information",
            "8"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Disk Storage information",
            "9"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "RAM information",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Display Resolution",
            "11"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "1) Sleep After AC Power Value",
            "12"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "2) Turn off display after AC Power Value",
            "13"}, -1);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSystemInfo = new System.Windows.Forms.TabPage();
            this.lstDisplayHardware = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCertificateInfo = new System.Windows.Forms.TabPage();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabSystemInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabSystemInfo);
            this.tabControl1.Controls.Add(this.tabCertificateInfo);
            this.tabControl1.Controls.Add(this.tabConfiguration);
            this.tabControl1.Controls.Add(this.tabEmail);
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
            this.lstDisplayHardware.GridLines = true;
            listViewGroup1.Header = "System Information";
            listViewGroup1.Name = "ListViewGroupSystemInfo";
            listViewGroup2.Header = "Power Config Value";
            listViewGroup2.Name = "listGroupPowerConfig";
            this.lstDisplayHardware.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lstDisplayHardware.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDisplayHardware.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup1;
            listViewItem8.Group = listViewGroup1;
            listViewItem9.Group = listViewGroup1;
            listViewItem10.Group = listViewGroup1;
            listViewItem11.Group = listViewGroup1;
            listViewItem12.Group = listViewGroup1;
            listViewItem13.Group = listViewGroup2;
            listViewItem14.Group = listViewGroup2;
            this.lstDisplayHardware.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
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
            this.columnHeader1.Width = 378;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 503;
            // 
            // tabCertificateInfo
            // 
            this.tabCertificateInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCertificateInfo.Location = new System.Drawing.Point(4, 25);
            this.tabCertificateInfo.Name = "tabCertificateInfo";
            this.tabCertificateInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCertificateInfo.Size = new System.Drawing.Size(758, 461);
            this.tabCertificateInfo.TabIndex = 1;
            this.tabCertificateInfo.Text = "Certificate Information";
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.BackColor = System.Drawing.Color.Gainsboro;
            this.tabConfiguration.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Size = new System.Drawing.Size(758, 461);
            this.tabConfiguration.TabIndex = 2;
            this.tabConfiguration.Text = "Configuration";
            // 
            // tabEmail
            // 
            this.tabEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.tabEmail.Location = new System.Drawing.Point(4, 25);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Size = new System.Drawing.Size(758, 461);
            this.tabEmail.TabIndex = 3;
            this.tabEmail.Text = "Email";
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
    }
}