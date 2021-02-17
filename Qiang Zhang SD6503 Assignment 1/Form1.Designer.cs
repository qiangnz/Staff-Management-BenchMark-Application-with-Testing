namespace Qiang_Zhang_SD6503_Assignment_1
{
    partial class Form1
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
            this.gbxNewStaff = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDateofBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.tbxDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxDepartment = new System.Windows.Forms.TextBox();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.tbxAnnualSalary = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStaffID = new System.Windows.Forms.TextBox();
            this.gbxDisplayStaffs = new System.Windows.Forms.GroupBox();
            this.lbxDisplayStaffs = new System.Windows.Forms.ListBox();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxSearchStaff = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbxSearch = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.tlsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxNewStaff.SuspendLayout();
            this.gbxDisplayStaffs.SuspendLayout();
            this.gbxSearchStaff.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNewStaff
            // 
            this.gbxNewStaff.Controls.Add(this.btnAdd);
            this.gbxNewStaff.Controls.Add(this.lblDepartment);
            this.gbxNewStaff.Controls.Add(this.lblPosition);
            this.gbxNewStaff.Controls.Add(this.lblAnnualSalary);
            this.gbxNewStaff.Controls.Add(this.lblEmail);
            this.gbxNewStaff.Controls.Add(this.lblDateofBirth);
            this.gbxNewStaff.Controls.Add(this.lblName);
            this.gbxNewStaff.Controls.Add(this.lblStaffID);
            this.gbxNewStaff.Controls.Add(this.tbxDateofBirth);
            this.gbxNewStaff.Controls.Add(this.tbxDepartment);
            this.gbxNewStaff.Controls.Add(this.tbxPosition);
            this.gbxNewStaff.Controls.Add(this.tbxAnnualSalary);
            this.gbxNewStaff.Controls.Add(this.tbxEmail);
            this.gbxNewStaff.Controls.Add(this.tbxName);
            this.gbxNewStaff.Controls.Add(this.tbxStaffID);
            this.gbxNewStaff.Location = new System.Drawing.Point(29, 85);
            this.gbxNewStaff.Name = "gbxNewStaff";
            this.gbxNewStaff.Size = new System.Drawing.Size(472, 491);
            this.gbxNewStaff.TabIndex = 0;
            this.gbxNewStaff.TabStop = false;
            this.gbxNewStaff.Text = "New Staff";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 60);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.ttpToolTips.SetToolTip(this.btnAdd, "Add a new staff");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(39, 356);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(129, 25);
            this.lblDepartment.TabIndex = 14;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(73, 308);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(95, 25);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Position:";
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Location = new System.Drawing.Point(16, 260);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(152, 25);
            this.lblAnnualSalary.TabIndex = 12;
            this.lblAnnualSalary.Text = "Annual Salary:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(97, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblDateofBirth
            // 
            this.lblDateofBirth.AutoSize = true;
            this.lblDateofBirth.Location = new System.Drawing.Point(31, 164);
            this.lblDateofBirth.Name = "lblDateofBirth";
            this.lblDateofBirth.Size = new System.Drawing.Size(137, 25);
            this.lblDateofBirth.TabIndex = 10;
            this.lblDateofBirth.Text = "Date of Birth:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(80, 68);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(88, 25);
            this.lblStaffID.TabIndex = 8;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // tbxDateofBirth
            // 
            this.tbxDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbxDateofBirth.Location = new System.Drawing.Point(197, 159);
            this.tbxDateofBirth.Name = "tbxDateofBirth";
            this.tbxDateofBirth.Size = new System.Drawing.Size(240, 31);
            this.tbxDateofBirth.TabIndex = 7;
            this.ttpToolTips.SetToolTip(this.tbxDateofBirth, "Select date of birth");
            // 
            // tbxDepartment
            // 
            this.tbxDepartment.Location = new System.Drawing.Point(197, 351);
            this.tbxDepartment.Name = "tbxDepartment";
            this.tbxDepartment.Size = new System.Drawing.Size(240, 31);
            this.tbxDepartment.TabIndex = 5;
            this.ttpToolTips.SetToolTip(this.tbxDepartment, "Enter department");
            // 
            // tbxPosition
            // 
            this.tbxPosition.Location = new System.Drawing.Point(197, 303);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(240, 31);
            this.tbxPosition.TabIndex = 4;
            this.ttpToolTips.SetToolTip(this.tbxPosition, "Enter position");
            // 
            // tbxAnnualSalary
            // 
            this.tbxAnnualSalary.Location = new System.Drawing.Point(197, 255);
            this.tbxAnnualSalary.Name = "tbxAnnualSalary";
            this.tbxAnnualSalary.Size = new System.Drawing.Size(240, 31);
            this.tbxAnnualSalary.TabIndex = 3;
            this.ttpToolTips.SetToolTip(this.tbxAnnualSalary, "Enter annual salary");
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(197, 207);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(240, 31);
            this.tbxEmail.TabIndex = 2;
            this.ttpToolTips.SetToolTip(this.tbxEmail, "Enter an Email");
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(197, 111);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(240, 31);
            this.tbxName.TabIndex = 1;
            this.ttpToolTips.SetToolTip(this.tbxName, "Enter a staff name");
            // 
            // tbxStaffID
            // 
            this.tbxStaffID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxStaffID.Location = new System.Drawing.Point(197, 63);
            this.tbxStaffID.MaxLength = 3;
            this.tbxStaffID.Name = "tbxStaffID";
            this.tbxStaffID.Size = new System.Drawing.Size(240, 31);
            this.tbxStaffID.TabIndex = 0;
            this.ttpToolTips.SetToolTip(this.tbxStaffID, "Enter a staff ID");
            // 
            // gbxDisplayStaffs
            // 
            this.gbxDisplayStaffs.Controls.Add(this.lbxDisplayStaffs);
            this.gbxDisplayStaffs.Controls.Add(this.btnZA);
            this.gbxDisplayStaffs.Controls.Add(this.btnAZ);
            this.gbxDisplayStaffs.Controls.Add(this.btnLoad);
            this.gbxDisplayStaffs.Location = new System.Drawing.Point(524, 85);
            this.gbxDisplayStaffs.Name = "gbxDisplayStaffs";
            this.gbxDisplayStaffs.Size = new System.Drawing.Size(617, 735);
            this.gbxDisplayStaffs.TabIndex = 1;
            this.gbxDisplayStaffs.TabStop = false;
            this.gbxDisplayStaffs.Text = "Display Staffs";
            // 
            // lbxDisplayStaffs
            // 
            this.lbxDisplayStaffs.FormattingEnabled = true;
            this.lbxDisplayStaffs.HorizontalScrollbar = true;
            this.lbxDisplayStaffs.ItemHeight = 25;
            this.lbxDisplayStaffs.Location = new System.Drawing.Point(24, 139);
            this.lbxDisplayStaffs.Name = "lbxDisplayStaffs";
            this.lbxDisplayStaffs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxDisplayStaffs.Size = new System.Drawing.Size(563, 529);
            this.lbxDisplayStaffs.TabIndex = 5;
            this.ttpToolTips.SetToolTip(this.lbxDisplayStaffs, "Display a list of staffs");
            // 
            // btnZA
            // 
            this.btnZA.Location = new System.Drawing.Point(446, 51);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(120, 60);
            this.btnZA.TabIndex = 2;
            this.btnZA.Text = "Z-A";
            this.ttpToolTips.SetToolTip(this.btnZA, "Sort staff name ZA");
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // btnAZ
            // 
            this.btnAZ.Location = new System.Drawing.Point(250, 51);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(120, 60);
            this.btnAZ.TabIndex = 1;
            this.btnAZ.Text = "A-Z";
            this.ttpToolTips.SetToolTip(this.btnAZ, "Sort staff name AZ");
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(54, 51);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 60);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.ttpToolTips.SetToolTip(this.btnLoad, "Load a list of Staffs");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(152, 635);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.ttpToolTips.SetToolTip(this.btnDelete, "Delete selected staff");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxSearchStaff
            // 
            this.gbxSearchStaff.Controls.Add(this.btnSave);
            this.gbxSearchStaff.Controls.Add(this.btnDelete);
            this.gbxSearchStaff.Controls.Add(this.lbxSearch);
            this.gbxSearchStaff.Controls.Add(this.btnSearch);
            this.gbxSearchStaff.Controls.Add(this.tbxSearch);
            this.gbxSearchStaff.Location = new System.Drawing.Point(1164, 85);
            this.gbxSearchStaff.Name = "gbxSearchStaff";
            this.gbxSearchStaff.Size = new System.Drawing.Size(632, 735);
            this.gbxSearchStaff.TabIndex = 1;
            this.gbxSearchStaff.TabStop = false;
            this.gbxSearchStaff.Text = "Search Staff";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 635);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 60);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.ttpToolTips.SetToolTip(this.btnSave, "Delete selected staff");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbxSearch
            // 
            this.lbxSearch.FormattingEnabled = true;
            this.lbxSearch.HorizontalScrollbar = true;
            this.lbxSearch.ItemHeight = 25;
            this.lbxSearch.Location = new System.Drawing.Point(39, 139);
            this.lbxSearch.Name = "lbxSearch";
            this.lbxSearch.Size = new System.Drawing.Size(563, 454);
            this.lbxSearch.TabIndex = 17;
            this.ttpToolTips.SetToolTip(this.lbxSearch, "Display a list of searched staffs");
            this.lbxSearch.SelectedIndexChanged += new System.EventHandler(this.lbxSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(446, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 60);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.ttpToolTips.SetToolTip(this.btnSearch, "Search selected staff");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(101, 61);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(316, 31);
            this.tbxSearch.TabIndex = 0;
            this.ttpToolTips.SetToolTip(this.tbxSearch, "Enter a search term");
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 865);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1844, 38);
            this.stsStatus.TabIndex = 2;
            this.stsStatus.Text = "statusStrip1";
            // 
            // tlsStatus
            // 
            this.tlsStatus.Name = "tlsStatus";
            this.tlsStatus.Size = new System.Drawing.Size(79, 33);
            this.tlsStatus.Text = "Ready";
            // 
            // mnsMenu
            // 
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStaffToolStripMenuItem,
            this.displayStaffsToolStripMenuItem,
            this.searchStaffToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1844, 40);
            this.mnsMenu.TabIndex = 3;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.newStaffToolStripMenuItem.Text = "New Staff";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // displayStaffsToolStripMenuItem
            // 
            this.displayStaffsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.sortAZToolStripMenuItem,
            this.sortZAToolStripMenuItem});
            this.displayStaffsToolStripMenuItem.Name = "displayStaffsToolStripMenuItem";
            this.displayStaffsToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.displayStaffsToolStripMenuItem.Text = "Display Staffs";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // sortAZToolStripMenuItem
            // 
            this.sortAZToolStripMenuItem.Name = "sortAZToolStripMenuItem";
            this.sortAZToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.sortAZToolStripMenuItem.Text = "Sort A-Z";
            this.sortAZToolStripMenuItem.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // sortZAToolStripMenuItem
            // 
            this.sortZAToolStripMenuItem.Name = "sortZAToolStripMenuItem";
            this.sortZAToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.sortZAToolStripMenuItem.Text = "Sort Z-A";
            this.sortZAToolStripMenuItem.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // searchStaffToolStripMenuItem
            // 
            this.searchStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.searchStaffToolStripMenuItem.Name = "searchStaffToolStripMenuItem";
            this.searchStaffToolStripMenuItem.Size = new System.Drawing.Size(153, 36);
            this.searchStaffToolStripMenuItem.Text = "Search Staff";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 903);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.mnsMenu);
            this.Controls.Add(this.gbxSearchStaff);
            this.Controls.Add(this.gbxDisplayStaffs);
            this.Controls.Add(this.gbxNewStaff);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "Form1";
            this.Text = "BenchMark Application SD6503 Assignment1 Qiang Zhang";
            this.gbxNewStaff.ResumeLayout(false);
            this.gbxNewStaff.PerformLayout();
            this.gbxDisplayStaffs.ResumeLayout(false);
            this.gbxSearchStaff.ResumeLayout(false);
            this.gbxSearchStaff.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNewStaff;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDateofBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.DateTimePicker tbxDateofBirth;
        private System.Windows.Forms.TextBox tbxDepartment;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.TextBox tbxAnnualSalary;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStaffID;
        private System.Windows.Forms.GroupBox gbxDisplayStaffs;
        private System.Windows.Forms.GroupBox gbxSearchStaff;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxDisplayStaffs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tlsStatus;
        private System.Windows.Forms.ToolTip ttpToolTips;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStaffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

