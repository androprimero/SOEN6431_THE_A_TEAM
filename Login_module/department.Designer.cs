namespace WindowsFormsApplication1
{
    partial class department
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.chkDeleteDept = new System.Windows.Forms.CheckBox();
            this.chkSearchDept = new System.Windows.Forms.CheckBox();
            this.chkUpdateDept = new System.Windows.Forms.CheckBox();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.lblDepartmentname = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDEpartmentFacultyId = new System.Windows.Forms.Label();
            this.lblDepartmentFacultyFirstname = new System.Windows.Forms.Label();
            this.lblDepartmentFacultyLastName = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptLocation = new System.Windows.Forms.TextBox();
            this.txtDeptFacultyFirstName = new System.Windows.Forms.TextBox();
            this.txtDeptFacultyLastName = new System.Windows.Forms.TextBox();
            this.lblDeptmentHeadBy = new System.Windows.Forms.Label();
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.cmbDeptDeleteChoose = new System.Windows.Forms.ComboBox();
            this.chkDeptDeleteChoose = new System.Windows.Forms.CheckBox();
            this.txtDeptSearchDeptid = new System.Windows.Forms.TextBox();
            this.lblDeptmentDeleteDeptid = new System.Windows.Forms.Label();
            this.lblDeptmentDelete = new System.Windows.Forms.Label();
            this.cmbSearchDept = new System.Windows.Forms.ComboBox();
            this.chkDeptmentSearchChoose = new System.Windows.Forms.CheckBox();
            this.txtDeptSearchId = new System.Windows.Forms.TextBox();
            this.lblDepartmentSearchId = new System.Windows.Forms.Label();
            this.lblDepartmentSearch = new System.Windows.Forms.Label();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.cmbDeptUpdate = new System.Windows.Forms.ComboBox();
            this.chkDeptUpdateChooseFromList = new System.Windows.Forms.CheckBox();
            this.lblDepartmentIdDept = new System.Windows.Forms.Label();
            this.txtDepartmentUpdateId = new System.Windows.Forms.TextBox();
            this.lblDepartmentUpdate = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.cmbDeptFacultyId = new System.Windows.Forms.ComboBox();
            this.chkAddDepartmnt = new System.Windows.Forms.CheckBox();
            this.txtDeptClass = new System.Windows.Forms.TextBox();
            this.lblDepartmentClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartment.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(330, 49);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(144, 38);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department";
            // 
            // chkDeleteDept
            // 
            this.chkDeleteDept.AutoSize = true;
            this.chkDeleteDept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkDeleteDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteDept.Location = new System.Drawing.Point(132, 70);
            this.chkDeleteDept.Name = "chkDeleteDept";
            this.chkDeleteDept.Size = new System.Drawing.Size(90, 24);
            this.chkDeleteDept.TabIndex = 82;
            this.chkDeleteDept.Text = "Delete";
            this.chkDeleteDept.UseVisualStyleBackColor = false;
            this.chkDeleteDept.CheckedChanged += new System.EventHandler(this.chkDeleteDept_CheckedChanged);
            // 
            // chkSearchDept
            // 
            this.chkSearchDept.AutoSize = true;
            this.chkSearchDept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkSearchDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchDept.Location = new System.Drawing.Point(132, 47);
            this.chkSearchDept.Name = "chkSearchDept";
            this.chkSearchDept.Size = new System.Drawing.Size(94, 24);
            this.chkSearchDept.TabIndex = 81;
            this.chkSearchDept.Text = "Search";
            this.chkSearchDept.UseVisualStyleBackColor = false;
            this.chkSearchDept.CheckedChanged += new System.EventHandler(this.chkSearchDept_CheckedChanged);
            // 
            // chkUpdateDept
            // 
            this.chkUpdateDept.AutoSize = true;
            this.chkUpdateDept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkUpdateDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateDept.Location = new System.Drawing.Point(132, 24);
            this.chkUpdateDept.Name = "chkUpdateDept";
            this.chkUpdateDept.Size = new System.Drawing.Size(94, 24);
            this.chkUpdateDept.TabIndex = 80;
            this.chkUpdateDept.Text = "Update";
            this.chkUpdateDept.UseVisualStyleBackColor = false;
            this.chkUpdateDept.CheckedChanged += new System.EventHandler(this.chkUpdateDept_CheckedChanged);
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.AutoSize = true;
            this.lblDepartmentId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentId.Location = new System.Drawing.Point(88, 120);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(140, 20);
            this.lblDepartmentId.TabIndex = 83;
            this.lblDepartmentId.Text = "Department Id: ";
            // 
            // lblDepartmentname
            // 
            this.lblDepartmentname.AutoSize = true;
            this.lblDepartmentname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentname.Location = new System.Drawing.Point(88, 147);
            this.lblDepartmentname.Name = "lblDepartmentname";
            this.lblDepartmentname.Size = new System.Drawing.Size(167, 20);
            this.lblDepartmentname.TabIndex = 84;
            this.lblDepartmentname.Text = "Department Name:";
            this.lblDepartmentname.Click += new System.EventHandler(this.lblDepartmentname_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(88, 174);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(87, 20);
            this.lblLocation.TabIndex = 85;
            this.lblLocation.Text = "Location:";
            // 
            // lblDEpartmentFacultyId
            // 
            this.lblDEpartmentFacultyId.AutoSize = true;
            this.lblDEpartmentFacultyId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDEpartmentFacultyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEpartmentFacultyId.Location = new System.Drawing.Point(376, 123);
            this.lblDEpartmentFacultyId.Name = "lblDEpartmentFacultyId";
            this.lblDEpartmentFacultyId.Size = new System.Drawing.Size(97, 20);
            this.lblDEpartmentFacultyId.TabIndex = 86;
            this.lblDEpartmentFacultyId.Text = "Faculty Id:";
            // 
            // lblDepartmentFacultyFirstname
            // 
            this.lblDepartmentFacultyFirstname.AutoSize = true;
            this.lblDepartmentFacultyFirstname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentFacultyFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentFacultyFirstname.Location = new System.Drawing.Point(376, 149);
            this.lblDepartmentFacultyFirstname.Name = "lblDepartmentFacultyFirstname";
            this.lblDepartmentFacultyFirstname.Size = new System.Drawing.Size(108, 20);
            this.lblDepartmentFacultyFirstname.TabIndex = 87;
            this.lblDepartmentFacultyFirstname.Text = "First Name:";
            // 
            // lblDepartmentFacultyLastName
            // 
            this.lblDepartmentFacultyLastName.AutoSize = true;
            this.lblDepartmentFacultyLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentFacultyLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentFacultyLastName.Location = new System.Drawing.Point(376, 173);
            this.lblDepartmentFacultyLastName.Name = "lblDepartmentFacultyLastName";
            this.lblDepartmentFacultyLastName.Size = new System.Drawing.Size(106, 20);
            this.lblDepartmentFacultyLastName.TabIndex = 88;
            this.lblDepartmentFacultyLastName.Text = "Last Name:";
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(210, 113);
            this.txtDeptId.MaxLength = 10;
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(129, 26);
            this.txtDeptId.TabIndex = 89;
            this.txtDeptId.TextChanged += new System.EventHandler(this.txtDeptId_TextChanged);
            this.txtDeptId.Leave += new System.EventHandler(this.txtDeptId_Leave);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(210, 139);
            this.txtDeptName.MaxLength = 25;
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(129, 26);
            this.txtDeptName.TabIndex = 90;
            this.txtDeptName.Leave += new System.EventHandler(this.txtDeptName_Leave);
            // 
            // txtDeptLocation
            // 
            this.txtDeptLocation.Location = new System.Drawing.Point(210, 165);
            this.txtDeptLocation.MaxLength = 25;
            this.txtDeptLocation.Name = "txtDeptLocation";
            this.txtDeptLocation.Size = new System.Drawing.Size(129, 26);
            this.txtDeptLocation.TabIndex = 91;
            this.txtDeptLocation.TextChanged += new System.EventHandler(this.txtDeptLocation_TextChanged);
            this.txtDeptLocation.Leave += new System.EventHandler(this.txtDeptLocation_Leave);
            // 
            // txtDeptFacultyFirstName
            // 
            this.txtDeptFacultyFirstName.Enabled = false;
            this.txtDeptFacultyFirstName.Location = new System.Drawing.Point(453, 143);
            this.txtDeptFacultyFirstName.Name = "txtDeptFacultyFirstName";
            this.txtDeptFacultyFirstName.Size = new System.Drawing.Size(129, 26);
            this.txtDeptFacultyFirstName.TabIndex = 93;
            // 
            // txtDeptFacultyLastName
            // 
            this.txtDeptFacultyLastName.Enabled = false;
            this.txtDeptFacultyLastName.Location = new System.Drawing.Point(453, 167);
            this.txtDeptFacultyLastName.Name = "txtDeptFacultyLastName";
            this.txtDeptFacultyLastName.Size = new System.Drawing.Size(129, 26);
            this.txtDeptFacultyLastName.TabIndex = 94;
            this.txtDeptFacultyLastName.TextChanged += new System.EventHandler(this.txtDeptFacultyLastName_TextChanged);
            // 
            // lblDeptmentHeadBy
            // 
            this.lblDeptmentHeadBy.AutoSize = true;
            this.lblDeptmentHeadBy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeptmentHeadBy.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptmentHeadBy.Location = new System.Drawing.Point(348, 89);
            this.lblDeptmentHeadBy.Name = "lblDeptmentHeadBy";
            this.lblDeptmentHeadBy.Size = new System.Drawing.Size(114, 34);
            this.lblDeptmentHeadBy.TabIndex = 95;
            this.lblDeptmentHeadBy.Text = "Head By: ";
            // 
            // btnDepartmentDelete
            // 
            this.btnDepartmentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentDelete.Location = new System.Drawing.Point(94, 644);
            this.btnDepartmentDelete.Name = "btnDepartmentDelete";
            this.btnDepartmentDelete.Size = new System.Drawing.Size(488, 23);
            this.btnDepartmentDelete.TabIndex = 113;
            this.btnDepartmentDelete.Text = "Delete";
            this.btnDepartmentDelete.UseVisualStyleBackColor = true;
            this.btnDepartmentDelete.Click += new System.EventHandler(this.btnDepartmentDelete_Click);
            // 
            // cmbDeptDeleteChoose
            // 
            this.cmbDeptDeleteChoose.FormattingEnabled = true;
            this.cmbDeptDeleteChoose.Location = new System.Drawing.Point(463, 602);
            this.cmbDeptDeleteChoose.Name = "cmbDeptDeleteChoose";
            this.cmbDeptDeleteChoose.Size = new System.Drawing.Size(121, 28);
            this.cmbDeptDeleteChoose.TabIndex = 112;
            this.cmbDeptDeleteChoose.SelectedIndexChanged += new System.EventHandler(this.cmbDeptDeleteChoose_SelectedIndexChanged);
            // 
            // chkDeptDeleteChoose
            // 
            this.chkDeptDeleteChoose.AutoSize = true;
            this.chkDeptDeleteChoose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkDeptDeleteChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeptDeleteChoose.Location = new System.Drawing.Point(340, 606);
            this.chkDeptDeleteChoose.Name = "chkDeptDeleteChoose";
            this.chkDeptDeleteChoose.Size = new System.Drawing.Size(174, 24);
            this.chkDeptDeleteChoose.TabIndex = 111;
            this.chkDeptDeleteChoose.Text = "Choose from list";
            this.chkDeptDeleteChoose.UseVisualStyleBackColor = false;
            this.chkDeptDeleteChoose.CheckedChanged += new System.EventHandler(this.chkDeptDeleteChoose_CheckedChanged);
            // 
            // txtDeptSearchDeptid
            // 
            this.txtDeptSearchDeptid.Location = new System.Drawing.Point(188, 603);
            this.txtDeptSearchDeptid.MaxLength = 10;
            this.txtDeptSearchDeptid.Name = "txtDeptSearchDeptid";
            this.txtDeptSearchDeptid.Size = new System.Drawing.Size(119, 26);
            this.txtDeptSearchDeptid.TabIndex = 110;
            this.txtDeptSearchDeptid.TextChanged += new System.EventHandler(this.txtDeptSearchDeptid_TextChanged);
            // 
            // lblDeptmentDeleteDeptid
            // 
            this.lblDeptmentDeleteDeptid.AutoSize = true;
            this.lblDeptmentDeleteDeptid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeptmentDeleteDeptid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptmentDeleteDeptid.Location = new System.Drawing.Point(86, 606);
            this.lblDeptmentDeleteDeptid.Name = "lblDeptmentDeleteDeptid";
            this.lblDeptmentDeleteDeptid.Size = new System.Drawing.Size(134, 20);
            this.lblDeptmentDeleteDeptid.TabIndex = 109;
            this.lblDeptmentDeleteDeptid.Text = "Department Id:";
            // 
            // lblDeptmentDelete
            // 
            this.lblDeptmentDelete.AutoSize = true;
            this.lblDeptmentDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeptmentDelete.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptmentDelete.Location = new System.Drawing.Point(91, 574);
            this.lblDeptmentDelete.Name = "lblDeptmentDelete";
            this.lblDeptmentDelete.Size = new System.Drawing.Size(87, 34);
            this.lblDeptmentDelete.TabIndex = 108;
            this.lblDeptmentDelete.Text = "Delete: ";
            // 
            // cmbSearchDept
            // 
            this.cmbSearchDept.FormattingEnabled = true;
            this.cmbSearchDept.Location = new System.Drawing.Point(467, 480);
            this.cmbSearchDept.Name = "cmbSearchDept";
            this.cmbSearchDept.Size = new System.Drawing.Size(117, 28);
            this.cmbSearchDept.TabIndex = 106;
            this.cmbSearchDept.SelectedIndexChanged += new System.EventHandler(this.cmbSearchDept_SelectedIndexChanged);
            // 
            // chkDeptmentSearchChoose
            // 
            this.chkDeptmentSearchChoose.AutoSize = true;
            this.chkDeptmentSearchChoose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkDeptmentSearchChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeptmentSearchChoose.Location = new System.Drawing.Point(342, 487);
            this.chkDeptmentSearchChoose.Name = "chkDeptmentSearchChoose";
            this.chkDeptmentSearchChoose.Size = new System.Drawing.Size(174, 24);
            this.chkDeptmentSearchChoose.TabIndex = 105;
            this.chkDeptmentSearchChoose.Text = "Choose from list";
            this.chkDeptmentSearchChoose.UseVisualStyleBackColor = false;
            this.chkDeptmentSearchChoose.CheckedChanged += new System.EventHandler(this.chkDeptmentSearchChoose_CheckedChanged);
            // 
            // txtDeptSearchId
            // 
            this.txtDeptSearchId.Location = new System.Drawing.Point(188, 480);
            this.txtDeptSearchId.MaxLength = 10;
            this.txtDeptSearchId.Name = "txtDeptSearchId";
            this.txtDeptSearchId.Size = new System.Drawing.Size(119, 26);
            this.txtDeptSearchId.TabIndex = 104;
            this.txtDeptSearchId.TextChanged += new System.EventHandler(this.txtDeptSearchId_TextChanged);
            // 
            // lblDepartmentSearchId
            // 
            this.lblDepartmentSearchId.AutoSize = true;
            this.lblDepartmentSearchId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSearchId.Location = new System.Drawing.Point(93, 488);
            this.lblDepartmentSearchId.Name = "lblDepartmentSearchId";
            this.lblDepartmentSearchId.Size = new System.Drawing.Size(134, 20);
            this.lblDepartmentSearchId.TabIndex = 103;
            this.lblDepartmentSearchId.Text = "Department Id:";
            // 
            // lblDepartmentSearch
            // 
            this.lblDepartmentSearch.AutoSize = true;
            this.lblDepartmentSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentSearch.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentSearch.Location = new System.Drawing.Point(93, 459);
            this.lblDepartmentSearch.Name = "lblDepartmentSearch";
            this.lblDepartmentSearch.Size = new System.Drawing.Size(92, 34);
            this.lblDepartmentSearch.TabIndex = 102;
            this.lblDepartmentSearch.Text = "Search: ";
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(96, 402);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(490, 23);
            this.btnDepartmentUpdate.TabIndex = 101;
            this.btnDepartmentUpdate.Text = "Update";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnDepartmentUpdate_Click);
            // 
            // cmbDeptUpdate
            // 
            this.cmbDeptUpdate.FormattingEnabled = true;
            this.cmbDeptUpdate.Location = new System.Drawing.Point(465, 366);
            this.cmbDeptUpdate.Name = "cmbDeptUpdate";
            this.cmbDeptUpdate.Size = new System.Drawing.Size(119, 28);
            this.cmbDeptUpdate.TabIndex = 100;
            this.cmbDeptUpdate.SelectedIndexChanged += new System.EventHandler(this.cmbDeptUpdate_SelectedIndexChanged);
            // 
            // chkDeptUpdateChooseFromList
            // 
            this.chkDeptUpdateChooseFromList.AutoSize = true;
            this.chkDeptUpdateChooseFromList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkDeptUpdateChooseFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeptUpdateChooseFromList.Location = new System.Drawing.Point(342, 368);
            this.chkDeptUpdateChooseFromList.Name = "chkDeptUpdateChooseFromList";
            this.chkDeptUpdateChooseFromList.Size = new System.Drawing.Size(174, 24);
            this.chkDeptUpdateChooseFromList.TabIndex = 99;
            this.chkDeptUpdateChooseFromList.Text = "Choose from list";
            this.chkDeptUpdateChooseFromList.UseVisualStyleBackColor = false;
            this.chkDeptUpdateChooseFromList.CheckedChanged += new System.EventHandler(this.chkDeptUpdateChooseFromList_CheckedChanged);
            // 
            // lblDepartmentIdDept
            // 
            this.lblDepartmentIdDept.AutoSize = true;
            this.lblDepartmentIdDept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentIdDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentIdDept.Location = new System.Drawing.Point(91, 372);
            this.lblDepartmentIdDept.Name = "lblDepartmentIdDept";
            this.lblDepartmentIdDept.Size = new System.Drawing.Size(134, 20);
            this.lblDepartmentIdDept.TabIndex = 98;
            this.lblDepartmentIdDept.Text = "Department Id:";
            // 
            // txtDepartmentUpdateId
            // 
            this.txtDepartmentUpdateId.Location = new System.Drawing.Point(188, 367);
            this.txtDepartmentUpdateId.MaxLength = 10;
            this.txtDepartmentUpdateId.Name = "txtDepartmentUpdateId";
            this.txtDepartmentUpdateId.Size = new System.Drawing.Size(119, 26);
            this.txtDepartmentUpdateId.TabIndex = 97;
            this.txtDepartmentUpdateId.TextChanged += new System.EventHandler(this.txtDepartmentUpdateId_TextChanged);
            // 
            // lblDepartmentUpdate
            // 
            this.lblDepartmentUpdate.AutoSize = true;
            this.lblDepartmentUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentUpdate.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentUpdate.Location = new System.Drawing.Point(87, 337);
            this.lblDepartmentUpdate.Name = "lblDepartmentUpdate";
            this.lblDepartmentUpdate.Size = new System.Drawing.Size(99, 34);
            this.lblDepartmentUpdate.TabIndex = 96;
            this.lblDepartmentUpdate.Text = "Update: ";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.Location = new System.Drawing.Point(92, 240);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(490, 23);
            this.btnAddDepartment.TabIndex = 114;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // cmbDeptFacultyId
            // 
            this.cmbDeptFacultyId.FormattingEnabled = true;
            this.cmbDeptFacultyId.Location = new System.Drawing.Point(453, 115);
            this.cmbDeptFacultyId.Name = "cmbDeptFacultyId";
            this.cmbDeptFacultyId.Size = new System.Drawing.Size(129, 28);
            this.cmbDeptFacultyId.TabIndex = 115;
            this.cmbDeptFacultyId.SelectedIndexChanged += new System.EventHandler(this.cmbDeptFacultyId_SelectedIndexChanged);
            // 
            // chkAddDepartmnt
            // 
            this.chkAddDepartmnt.AutoSize = true;
            this.chkAddDepartmnt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAddDepartmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddDepartmnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAddDepartmnt.Location = new System.Drawing.Point(132, 1);
            this.chkAddDepartmnt.Name = "chkAddDepartmnt";
            this.chkAddDepartmnt.Size = new System.Drawing.Size(67, 24);
            this.chkAddDepartmnt.TabIndex = 131;
            this.chkAddDepartmnt.Text = "Add";
            this.chkAddDepartmnt.UseVisualStyleBackColor = false;
            this.chkAddDepartmnt.CheckedChanged += new System.EventHandler(this.chkAddDepartmnt_CheckedChanged);
            // 
            // txtDeptClass
            // 
            this.txtDeptClass.Location = new System.Drawing.Point(210, 191);
            this.txtDeptClass.MaxLength = 25;
            this.txtDeptClass.Name = "txtDeptClass";
            this.txtDeptClass.Size = new System.Drawing.Size(129, 26);
            this.txtDeptClass.TabIndex = 132;
            this.txtDeptClass.MouseLeave += new System.EventHandler(this.txtDeptClass_MouseLeave);
            // 
            // lblDepartmentClass
            // 
            this.lblDepartmentClass.AutoSize = true;
            this.lblDepartmentClass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentClass.Location = new System.Drawing.Point(88, 198);
            this.lblDepartmentClass.Name = "lblDepartmentClass";
            this.lblDepartmentClass.Size = new System.Drawing.Size(63, 20);
            this.lblDepartmentClass.TabIndex = 133;
            this.lblDepartmentClass.Text = "Class:";
            // 
            // department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Student_form_data;
            this.ClientSize = new System.Drawing.Size(600, 775);
            this.Controls.Add(this.lblDepartmentClass);
            this.Controls.Add(this.txtDeptClass);
            this.Controls.Add(this.chkAddDepartmnt);
            this.Controls.Add(this.cmbDeptFacultyId);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.btnDepartmentDelete);
            this.Controls.Add(this.cmbDeptDeleteChoose);
            this.Controls.Add(this.chkDeptDeleteChoose);
            this.Controls.Add(this.txtDeptSearchDeptid);
            this.Controls.Add(this.lblDeptmentDeleteDeptid);
            this.Controls.Add(this.lblDeptmentDelete);
            this.Controls.Add(this.cmbSearchDept);
            this.Controls.Add(this.chkDeptmentSearchChoose);
            this.Controls.Add(this.txtDeptSearchId);
            this.Controls.Add(this.lblDepartmentSearchId);
            this.Controls.Add(this.lblDepartmentSearch);
            this.Controls.Add(this.btnDepartmentUpdate);
            this.Controls.Add(this.cmbDeptUpdate);
            this.Controls.Add(this.chkDeptUpdateChooseFromList);
            this.Controls.Add(this.lblDepartmentIdDept);
            this.Controls.Add(this.txtDepartmentUpdateId);
            this.Controls.Add(this.lblDepartmentUpdate);
            this.Controls.Add(this.lblDeptmentHeadBy);
            this.Controls.Add(this.txtDeptFacultyLastName);
            this.Controls.Add(this.txtDeptFacultyFirstName);
            this.Controls.Add(this.txtDeptLocation);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.lblDepartmentFacultyLastName);
            this.Controls.Add(this.lblDepartmentFacultyFirstname);
            this.Controls.Add(this.lblDEpartmentFacultyId);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDepartmentname);
            this.Controls.Add(this.lblDepartmentId);
            this.Controls.Add(this.chkDeleteDept);
            this.Controls.Add(this.chkSearchDept);
            this.Controls.Add(this.chkUpdateDept);
            this.Controls.Add(this.lblDepartment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "department";
            this.Text = "department";
            this.Load += new System.EventHandler(this.department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.CheckBox chkDeleteDept;
        private System.Windows.Forms.CheckBox chkSearchDept;
        private System.Windows.Forms.CheckBox chkUpdateDept;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.Label lblDepartmentname;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDEpartmentFacultyId;
        private System.Windows.Forms.Label lblDepartmentFacultyFirstname;
        private System.Windows.Forms.Label lblDepartmentFacultyLastName;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptLocation;
        private System.Windows.Forms.TextBox txtDeptFacultyFirstName;
        private System.Windows.Forms.TextBox txtDeptFacultyLastName;
        private System.Windows.Forms.Label lblDeptmentHeadBy;
        private System.Windows.Forms.Button btnDepartmentDelete;
        private System.Windows.Forms.ComboBox cmbDeptDeleteChoose;
        private System.Windows.Forms.CheckBox chkDeptDeleteChoose;
        private System.Windows.Forms.TextBox txtDeptSearchDeptid;
        private System.Windows.Forms.Label lblDeptmentDeleteDeptid;
        private System.Windows.Forms.Label lblDeptmentDelete;
        private System.Windows.Forms.ComboBox cmbSearchDept;
        private System.Windows.Forms.CheckBox chkDeptmentSearchChoose;
        private System.Windows.Forms.TextBox txtDeptSearchId;
        private System.Windows.Forms.Label lblDepartmentSearchId;
        private System.Windows.Forms.Label lblDepartmentSearch;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.ComboBox cmbDeptUpdate;
        private System.Windows.Forms.CheckBox chkDeptUpdateChooseFromList;
        private System.Windows.Forms.Label lblDepartmentIdDept;
        private System.Windows.Forms.TextBox txtDepartmentUpdateId;
        private System.Windows.Forms.Label lblDepartmentUpdate;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.ComboBox cmbDeptFacultyId;
        private System.Windows.Forms.CheckBox chkAddDepartmnt;
        private System.Windows.Forms.TextBox txtDeptClass;
        private System.Windows.Forms.Label lblDepartmentClass;
    }
}