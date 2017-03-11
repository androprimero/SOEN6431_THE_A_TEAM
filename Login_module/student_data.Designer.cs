namespace AcademicManagementSystem
{
    partial class student_data
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentLName = new System.Windows.Forms.TextBox();
            this.cmbStudentDep = new System.Windows.Forms.ComboBox();
            this.dtpStudentBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentCourse = new System.Windows.Forms.Label();
            this.cmbStudentCourse = new System.Windows.Forms.ComboBox();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.cmbStudentGenre = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentLName = new System.Windows.Forms.Label();
            this.lblStudentGenre = new System.Windows.Forms.Label();
            this.lblStudentBirthDay = new System.Windows.Forms.Label();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.txtStudentPostCode = new System.Windows.Forms.TextBox();
            this.lblStudentPostCode = new System.Windows.Forms.Label();
            this.lblStudentUpDate = new System.Windows.Forms.Label();
            this.txtUDStudent = new System.Windows.Forms.TextBox();
            this.lblUDStudentID = new System.Windows.Forms.Label();
            this.chkListUDStudent = new System.Windows.Forms.CheckBox();
            this.cmbUDStudentList = new System.Windows.Forms.ComboBox();
            this.btnUDStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblStudentSearch = new System.Windows.Forms.Label();
            this.lblSStudentID = new System.Windows.Forms.Label();
            this.txtSStudentId = new System.Windows.Forms.TextBox();
            this.chkListSStudent = new System.Windows.Forms.CheckBox();
            this.cmbSStudentList = new System.Windows.Forms.ComboBox();
            this.lblStudentDelete = new System.Windows.Forms.Label();
            this.lblDStudentID = new System.Windows.Forms.Label();
            this.txtDStudentID = new System.Windows.Forms.TextBox();
            this.chkListDStudent = new System.Windows.Forms.CheckBox();
            this.cmbDStudentList = new System.Windows.Forms.ComboBox();
            this.btnDStudent = new System.Windows.Forms.Button();
            this.chkUpdateStudent = new System.Windows.Forms.CheckBox();
            this.chkSearchStudent = new System.Windows.Forms.CheckBox();
            this.chkDeleteStudent = new System.Windows.Forms.CheckBox();
            this.cmbStudentClass = new System.Windows.Forms.ComboBox();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.chkAddStudent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudent.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(283, 49);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(113, 26);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "Student Data";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(175, 119);
            this.txtStudentId.MaxLength = 10;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(119, 20);
            this.txtStudentId.TabIndex = 3;
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            this.txtStudentId.Leave += new System.EventHandler(this.txtStudentId_Leave);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(469, 119);
            this.txtStudentName.MaxLength = 15;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(119, 20);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.Leave += new System.EventHandler(this.txtStudentName_Leave);
            // 
            // txtStudentLName
            // 
            this.txtStudentLName.Location = new System.Drawing.Point(469, 146);
            this.txtStudentLName.MaxLength = 15;
            this.txtStudentLName.Name = "txtStudentLName";
            this.txtStudentLName.Size = new System.Drawing.Size(119, 20);
            this.txtStudentLName.TabIndex = 5;
            this.txtStudentLName.Leave += new System.EventHandler(this.txtStudentLName_Leave);
            // 
            // cmbStudentDep
            // 
            this.cmbStudentDep.FormattingEnabled = true;
            this.cmbStudentDep.Location = new System.Drawing.Point(175, 145);
            this.cmbStudentDep.Name = "cmbStudentDep";
            this.cmbStudentDep.Size = new System.Drawing.Size(119, 21);
            this.cmbStudentDep.TabIndex = 6;
            this.cmbStudentDep.SelectedIndexChanged += new System.EventHandler(this.cmbStudentDep_SelectedIndexChanged);
            // 
            // dtpStudentBirthday
            // 
            this.dtpStudentBirthday.Location = new System.Drawing.Point(469, 197);
            this.dtpStudentBirthday.Name = "dtpStudentBirthday";
            this.dtpStudentBirthday.Size = new System.Drawing.Size(119, 20);
            this.dtpStudentBirthday.TabIndex = 7;
            this.dtpStudentBirthday.ValueChanged += new System.EventHandler(this.dtpStudentBirthday_ValueChanged);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(95, 126);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(70, 13);
            this.lblStudentID.TabIndex = 8;
            this.lblStudentID.Text = "Student Id:";
            // 
            // lblStudentCourse
            // 
            this.lblStudentCourse.AutoSize = true;
            this.lblStudentCourse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCourse.Location = new System.Drawing.Point(95, 180);
            this.lblStudentCourse.Name = "lblStudentCourse";
            this.lblStudentCourse.Size = new System.Drawing.Size(54, 13);
            this.lblStudentCourse.TabIndex = 9;
            this.lblStudentCourse.Text = "Course: ";
            // 
            // cmbStudentCourse
            // 
            this.cmbStudentCourse.FormattingEnabled = true;
            this.cmbStudentCourse.Location = new System.Drawing.Point(175, 172);
            this.cmbStudentCourse.Name = "cmbStudentCourse";
            this.cmbStudentCourse.Size = new System.Drawing.Size(119, 21);
            this.cmbStudentCourse.TabIndex = 10;
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.AutoSize = true;
            this.lblStudentDepartment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartment.Location = new System.Drawing.Point(95, 153);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(80, 13);
            this.lblStudentDepartment.TabIndex = 11;
            this.lblStudentDepartment.Text = "Department: ";
            // 
            // cmbStudentGenre
            // 
            this.cmbStudentGenre.FormattingEnabled = true;
            this.cmbStudentGenre.Location = new System.Drawing.Point(469, 171);
            this.cmbStudentGenre.Name = "cmbStudentGenre";
            this.cmbStudentGenre.Size = new System.Drawing.Size(119, 21);
            this.cmbStudentGenre.TabIndex = 14;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(390, 123);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 15;
            this.lblStudentName.Text = "First Name: ";
            // 
            // lblStudentLName
            // 
            this.lblStudentLName.AutoSize = true;
            this.lblStudentLName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLName.Location = new System.Drawing.Point(390, 151);
            this.lblStudentLName.Name = "lblStudentLName";
            this.lblStudentLName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentLName.TabIndex = 16;
            this.lblStudentLName.Text = "Last Name: ";
            // 
            // lblStudentGenre
            // 
            this.lblStudentGenre.AutoSize = true;
            this.lblStudentGenre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGenre.Location = new System.Drawing.Point(390, 176);
            this.lblStudentGenre.Name = "lblStudentGenre";
            this.lblStudentGenre.Size = new System.Drawing.Size(56, 13);
            this.lblStudentGenre.TabIndex = 17;
            this.lblStudentGenre.Text = "Gender: ";
            // 
            // lblStudentBirthDay
            // 
            this.lblStudentBirthDay.AutoSize = true;
            this.lblStudentBirthDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentBirthDay.Location = new System.Drawing.Point(390, 201);
            this.lblStudentBirthDay.Name = "lblStudentBirthDay";
            this.lblStudentBirthDay.Size = new System.Drawing.Size(39, 13);
            this.lblStudentBirthDay.TabIndex = 18;
            this.lblStudentBirthDay.Text = "DoB: ";
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(175, 243);
            this.txtStudentAddress.MaxLength = 50;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(249, 20);
            this.txtStudentAddress.TabIndex = 19;
            this.txtStudentAddress.TextChanged += new System.EventHandler(this.txtStudentAddress_TextChanged);
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAddress.Location = new System.Drawing.Point(95, 250);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(53, 13);
            this.lblStudentAddress.TabIndex = 20;
            this.lblStudentAddress.Text = "Adress: ";
            // 
            // txtStudentPostCode
            // 
            this.txtStudentPostCode.Location = new System.Drawing.Point(518, 247);
            this.txtStudentPostCode.MaxLength = 6;
            this.txtStudentPostCode.Name = "txtStudentPostCode";
            this.txtStudentPostCode.Size = new System.Drawing.Size(70, 20);
            this.txtStudentPostCode.TabIndex = 21;
            this.txtStudentPostCode.TextChanged += new System.EventHandler(this.txtStudentPostCode_TextChanged);
            this.txtStudentPostCode.Leave += new System.EventHandler(this.txtStudentPostCode_Leave);
            // 
            // lblStudentPostCode
            // 
            this.lblStudentPostCode.AutoSize = true;
            this.lblStudentPostCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentPostCode.Location = new System.Drawing.Point(429, 248);
            this.lblStudentPostCode.Name = "lblStudentPostCode";
            this.lblStudentPostCode.Size = new System.Drawing.Size(83, 13);
            this.lblStudentPostCode.TabIndex = 22;
            this.lblStudentPostCode.Text = "Postal Code: ";
            // 
            // lblStudentUpDate
            // 
            this.lblStudentUpDate.AutoSize = true;
            this.lblStudentUpDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentUpDate.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentUpDate.Location = new System.Drawing.Point(87, 386);
            this.lblStudentUpDate.Name = "lblStudentUpDate";
            this.lblStudentUpDate.Size = new System.Drawing.Size(68, 22);
            this.lblStudentUpDate.TabIndex = 23;
            this.lblStudentUpDate.Text = "Update: ";
            // 
            // txtUDStudent
            // 
            this.txtUDStudent.Location = new System.Drawing.Point(171, 414);
            this.txtUDStudent.MaxLength = 10;
            this.txtUDStudent.Name = "txtUDStudent";
            this.txtUDStudent.Size = new System.Drawing.Size(119, 20);
            this.txtUDStudent.TabIndex = 24;
            this.txtUDStudent.TextChanged += new System.EventHandler(this.txtUDStudent_TextChanged);
            // 
            // lblUDStudentID
            // 
            this.lblUDStudentID.AutoSize = true;
            this.lblUDStudentID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUDStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUDStudentID.Location = new System.Drawing.Point(91, 421);
            this.lblUDStudentID.Name = "lblUDStudentID";
            this.lblUDStudentID.Size = new System.Drawing.Size(70, 13);
            this.lblUDStudentID.TabIndex = 25;
            this.lblUDStudentID.Text = "Student Id:";
            // 
            // chkListUDStudent
            // 
            this.chkListUDStudent.AutoSize = true;
            this.chkListUDStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkListUDStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListUDStudent.Location = new System.Drawing.Point(342, 417);
            this.chkListUDStudent.Name = "chkListUDStudent";
            this.chkListUDStudent.Size = new System.Drawing.Size(116, 17);
            this.chkListUDStudent.TabIndex = 26;
            this.chkListUDStudent.Text = "Choose from list";
            this.chkListUDStudent.UseVisualStyleBackColor = false;
            this.chkListUDStudent.CheckedChanged += new System.EventHandler(this.chkListUDStudent_CheckedChanged);
            // 
            // cmbUDStudentList
            // 
            this.cmbUDStudentList.FormattingEnabled = true;
            this.cmbUDStudentList.Location = new System.Drawing.Point(465, 415);
            this.cmbUDStudentList.Name = "cmbUDStudentList";
            this.cmbUDStudentList.Size = new System.Drawing.Size(119, 21);
            this.cmbUDStudentList.TabIndex = 27;
            this.cmbUDStudentList.SelectedIndexChanged += new System.EventHandler(this.cmbUDStudentList_SelectedIndexChanged);
            // 
            // btnUDStudent
            // 
            this.btnUDStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDStudent.Location = new System.Drawing.Point(96, 451);
            this.btnUDStudent.Name = "btnUDStudent";
            this.btnUDStudent.Size = new System.Drawing.Size(490, 23);
            this.btnUDStudent.TabIndex = 28;
            this.btnUDStudent.Text = "Update";
            this.btnUDStudent.UseVisualStyleBackColor = true;
            this.btnUDStudent.Click += new System.EventHandler(this.btnUDStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(98, 282);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(490, 23);
            this.btnAddStudent.TabIndex = 29;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblStudentSearch
            // 
            this.lblStudentSearch.AutoSize = true;
            this.lblStudentSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentSearch.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSearch.Location = new System.Drawing.Point(93, 509);
            this.lblStudentSearch.Name = "lblStudentSearch";
            this.lblStudentSearch.Size = new System.Drawing.Size(65, 22);
            this.lblStudentSearch.TabIndex = 30;
            this.lblStudentSearch.Text = "Search: ";
            // 
            // lblSStudentID
            // 
            this.lblSStudentID.AutoSize = true;
            this.lblSStudentID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSStudentID.Location = new System.Drawing.Point(93, 538);
            this.lblSStudentID.Name = "lblSStudentID";
            this.lblSStudentID.Size = new System.Drawing.Size(70, 13);
            this.lblSStudentID.TabIndex = 31;
            this.lblSStudentID.Text = "Student Id:";
            this.lblSStudentID.Click += new System.EventHandler(this.lblSStudentID_Click);
            // 
            // txtSStudentId
            // 
            this.txtSStudentId.Location = new System.Drawing.Point(173, 535);
            this.txtSStudentId.MaxLength = 10;
            this.txtSStudentId.Name = "txtSStudentId";
            this.txtSStudentId.Size = new System.Drawing.Size(119, 20);
            this.txtSStudentId.TabIndex = 32;
            this.txtSStudentId.TextChanged += new System.EventHandler(this.txtSStudentId_TextChanged);
            // 
            // chkListSStudent
            // 
            this.chkListSStudent.AutoSize = true;
            this.chkListSStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkListSStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListSStudent.Location = new System.Drawing.Point(342, 537);
            this.chkListSStudent.Name = "chkListSStudent";
            this.chkListSStudent.Size = new System.Drawing.Size(116, 17);
            this.chkListSStudent.TabIndex = 33;
            this.chkListSStudent.Text = "Choose from list";
            this.chkListSStudent.UseVisualStyleBackColor = false;
            this.chkListSStudent.CheckedChanged += new System.EventHandler(this.chkListSStudent_CheckedChanged);
            // 
            // cmbSStudentList
            // 
            this.cmbSStudentList.FormattingEnabled = true;
            this.cmbSStudentList.Location = new System.Drawing.Point(467, 530);
            this.cmbSStudentList.Name = "cmbSStudentList";
            this.cmbSStudentList.Size = new System.Drawing.Size(117, 21);
            this.cmbSStudentList.TabIndex = 34;
            this.cmbSStudentList.SelectedIndexChanged += new System.EventHandler(this.cmbSStudentList_SelectedIndexChanged);
            // 
            // lblStudentDelete
            // 
            this.lblStudentDelete.AutoSize = true;
            this.lblStudentDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentDelete.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDelete.Location = new System.Drawing.Point(95, 598);
            this.lblStudentDelete.Name = "lblStudentDelete";
            this.lblStudentDelete.Size = new System.Drawing.Size(61, 22);
            this.lblStudentDelete.TabIndex = 36;
            this.lblStudentDelete.Text = "Delete: ";
            // 
            // lblDStudentID
            // 
            this.lblDStudentID.AutoSize = true;
            this.lblDStudentID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDStudentID.Location = new System.Drawing.Point(90, 630);
            this.lblDStudentID.Name = "lblDStudentID";
            this.lblDStudentID.Size = new System.Drawing.Size(70, 13);
            this.lblDStudentID.TabIndex = 37;
            this.lblDStudentID.Text = "Student Id:";
            // 
            // txtDStudentID
            // 
            this.txtDStudentID.Location = new System.Drawing.Point(175, 627);
            this.txtDStudentID.MaxLength = 10;
            this.txtDStudentID.Name = "txtDStudentID";
            this.txtDStudentID.Size = new System.Drawing.Size(117, 20);
            this.txtDStudentID.TabIndex = 38;
            this.txtDStudentID.TextChanged += new System.EventHandler(this.txtDStudentID_TextChanged);
            // 
            // chkListDStudent
            // 
            this.chkListDStudent.AutoSize = true;
            this.chkListDStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkListDStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListDStudent.Location = new System.Drawing.Point(344, 630);
            this.chkListDStudent.Name = "chkListDStudent";
            this.chkListDStudent.Size = new System.Drawing.Size(116, 17);
            this.chkListDStudent.TabIndex = 39;
            this.chkListDStudent.Text = "Choose from list";
            this.chkListDStudent.UseVisualStyleBackColor = false;
            this.chkListDStudent.CheckedChanged += new System.EventHandler(this.chkListDStudent_CheckedChanged);
            // 
            // cmbDStudentList
            // 
            this.cmbDStudentList.FormattingEnabled = true;
            this.cmbDStudentList.Location = new System.Drawing.Point(467, 626);
            this.cmbDStudentList.Name = "cmbDStudentList";
            this.cmbDStudentList.Size = new System.Drawing.Size(121, 21);
            this.cmbDStudentList.TabIndex = 40;
            this.cmbDStudentList.SelectedIndexChanged += new System.EventHandler(this.cmbDStudentList_SelectedIndexChanged);
            // 
            // btnDStudent
            // 
            this.btnDStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDStudent.Location = new System.Drawing.Point(98, 668);
            this.btnDStudent.Name = "btnDStudent";
            this.btnDStudent.Size = new System.Drawing.Size(488, 23);
            this.btnDStudent.TabIndex = 41;
            this.btnDStudent.Text = "Delete";
            this.btnDStudent.UseVisualStyleBackColor = true;
            this.btnDStudent.Click += new System.EventHandler(this.btnDStudent_Click);
            // 
            // chkUpdateStudent
            // 
            this.chkUpdateStudent.AutoSize = true;
            this.chkUpdateStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateStudent.Location = new System.Drawing.Point(112, 22);
            this.chkUpdateStudent.Name = "chkUpdateStudent";
            this.chkUpdateStudent.Size = new System.Drawing.Size(67, 17);
            this.chkUpdateStudent.TabIndex = 42;
            this.chkUpdateStudent.Text = "Update";
            this.chkUpdateStudent.UseVisualStyleBackColor = false;
            this.chkUpdateStudent.CheckedChanged += new System.EventHandler(this.chkUpdateStudent_CheckedChanged);
            this.chkUpdateStudent.CheckStateChanged += new System.EventHandler(this.chkUpdateStudent_CheckStateChanged);
            // 
            // chkSearchStudent
            // 
            this.chkSearchStudent.AutoSize = true;
            this.chkSearchStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchStudent.Location = new System.Drawing.Point(112, 45);
            this.chkSearchStudent.Name = "chkSearchStudent";
            this.chkSearchStudent.Size = new System.Drawing.Size(66, 17);
            this.chkSearchStudent.TabIndex = 43;
            this.chkSearchStudent.Text = "Search";
            this.chkSearchStudent.UseVisualStyleBackColor = false;
            this.chkSearchStudent.CheckedChanged += new System.EventHandler(this.chkSearchStudent_CheckedChanged);
            // 
            // chkDeleteStudent
            // 
            this.chkDeleteStudent.AutoSize = true;
            this.chkDeleteStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteStudent.Location = new System.Drawing.Point(112, 68);
            this.chkDeleteStudent.Name = "chkDeleteStudent";
            this.chkDeleteStudent.Size = new System.Drawing.Size(63, 17);
            this.chkDeleteStudent.TabIndex = 44;
            this.chkDeleteStudent.Text = "Delete";
            this.chkDeleteStudent.UseVisualStyleBackColor = false;
            this.chkDeleteStudent.CheckedChanged += new System.EventHandler(this.chkDeleteStudent_CheckedChanged);
            // 
            // cmbStudentClass
            // 
            this.cmbStudentClass.FormattingEnabled = true;
            this.cmbStudentClass.Location = new System.Drawing.Point(176, 199);
            this.cmbStudentClass.Name = "cmbStudentClass";
            this.cmbStudentClass.Size = new System.Drawing.Size(117, 21);
            this.cmbStudentClass.TabIndex = 45;
            this.cmbStudentClass.SelectedIndexChanged += new System.EventHandler(this.cmbStudentClass_SelectedIndexChanged);
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentClass.Location = new System.Drawing.Point(95, 207);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(45, 13);
            this.lblStudentClass.TabIndex = 46;
            this.lblStudentClass.Text = "Class: ";
            // 
            // chkAddStudent
            // 
            this.chkAddStudent.AutoSize = true;
            this.chkAddStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAddStudent.Location = new System.Drawing.Point(112, 0);
            this.chkAddStudent.Name = "chkAddStudent";
            this.chkAddStudent.Size = new System.Drawing.Size(48, 17);
            this.chkAddStudent.TabIndex = 47;
            this.chkAddStudent.Text = "Add";
            this.chkAddStudent.UseVisualStyleBackColor = false;
            this.chkAddStudent.CheckedChanged += new System.EventHandler(this.chkAddStudent_CheckedChanged);
            // 
            // student_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AcademicManagementSystem.Properties.Resources.Student_form_data;
            this.ClientSize = new System.Drawing.Size(600, 772);
            this.Controls.Add(this.chkAddStudent);
            this.Controls.Add(this.lblStudentClass);
            this.Controls.Add(this.cmbStudentClass);
            this.Controls.Add(this.chkDeleteStudent);
            this.Controls.Add(this.chkSearchStudent);
            this.Controls.Add(this.chkUpdateStudent);
            this.Controls.Add(this.btnDStudent);
            this.Controls.Add(this.cmbDStudentList);
            this.Controls.Add(this.chkListDStudent);
            this.Controls.Add(this.txtDStudentID);
            this.Controls.Add(this.lblDStudentID);
            this.Controls.Add(this.lblStudentDelete);
            this.Controls.Add(this.cmbSStudentList);
            this.Controls.Add(this.chkListSStudent);
            this.Controls.Add(this.txtSStudentId);
            this.Controls.Add(this.lblSStudentID);
            this.Controls.Add(this.lblStudentSearch);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnUDStudent);
            this.Controls.Add(this.cmbUDStudentList);
            this.Controls.Add(this.chkListUDStudent);
            this.Controls.Add(this.lblUDStudentID);
            this.Controls.Add(this.txtUDStudent);
            this.Controls.Add(this.lblStudentUpDate);
            this.Controls.Add(this.lblStudentPostCode);
            this.Controls.Add(this.txtStudentPostCode);
            this.Controls.Add(this.lblStudentAddress);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.lblStudentBirthDay);
            this.Controls.Add(this.lblStudentGenre);
            this.Controls.Add(this.lblStudentLName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.cmbStudentGenre);
            this.Controls.Add(this.lblStudentDepartment);
            this.Controls.Add(this.cmbStudentCourse);
            this.Controls.Add(this.lblStudentCourse);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.dtpStudentBirthday);
            this.Controls.Add(this.cmbStudentDep);
            this.Controls.Add(this.txtStudentLName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(137, 0);
            this.Name = "student_data";
            this.Text = "student_data";
            this.Load += new System.EventHandler(this.student_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentLName;
        private System.Windows.Forms.ComboBox cmbStudentDep;
        private System.Windows.Forms.DateTimePicker dtpStudentBirthday;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentCourse;
        private System.Windows.Forms.ComboBox cmbStudentCourse;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.ComboBox cmbStudentGenre;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentLName;
        private System.Windows.Forms.Label lblStudentGenre;
        private System.Windows.Forms.Label lblStudentBirthDay;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.TextBox txtStudentPostCode;
        private System.Windows.Forms.Label lblStudentPostCode;
        private System.Windows.Forms.Label lblStudentUpDate;
        private System.Windows.Forms.TextBox txtUDStudent;
        private System.Windows.Forms.Label lblUDStudentID;
        private System.Windows.Forms.CheckBox chkListUDStudent;
        private System.Windows.Forms.ComboBox cmbUDStudentList;
        private System.Windows.Forms.Button btnUDStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblStudentSearch;
        private System.Windows.Forms.Label lblSStudentID;
        private System.Windows.Forms.TextBox txtSStudentId;
        private System.Windows.Forms.CheckBox chkListSStudent;
        private System.Windows.Forms.ComboBox cmbSStudentList;
        private System.Windows.Forms.Label lblStudentDelete;
        private System.Windows.Forms.Label lblDStudentID;
        private System.Windows.Forms.TextBox txtDStudentID;
        private System.Windows.Forms.CheckBox chkListDStudent;
        private System.Windows.Forms.ComboBox cmbDStudentList;
        private System.Windows.Forms.Button btnDStudent;
        private System.Windows.Forms.CheckBox chkUpdateStudent;
        private System.Windows.Forms.CheckBox chkSearchStudent;
        private System.Windows.Forms.CheckBox chkDeleteStudent;
        private System.Windows.Forms.ComboBox cmbStudentClass;
        private System.Windows.Forms.Label lblStudentClass;
        private System.Windows.Forms.CheckBox chkAddStudent;
    }
}