namespace AcademicManagementSystem.UserInterface
{
    partial class FacultyForm
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
            this.pnlFacultyBody = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtFacultyId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbOffice = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblFacultyId = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblSearchFaculty = new System.Windows.Forms.Label();
            this.cmbSearchFacultyChooseFromList = new System.Windows.Forms.ComboBox();
            this.lblSearchFacultyId = new System.Windows.Forms.Label();
            this.txtSearchFacultyId = new System.Windows.Forms.TextBox();
            this.chkSearchFacultyChooseFromList = new System.Windows.Forms.CheckBox();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.rdSearch = new System.Windows.Forms.RadioButton();
            this.rdUpdate = new System.Windows.Forms.RadioButton();
            this.rdAddFaculty = new System.Windows.Forms.RadioButton();
            this.lblOperation = new System.Windows.Forms.Label();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.lblFacultyForm = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlFacultyBody.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.pnlFormTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFacultyBody
            // 
            this.pnlFacultyBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFacultyBody.Controls.Add(this.lblError);
            this.pnlFacultyBody.Controls.Add(this.pnlForm);
            this.pnlFacultyBody.Controls.Add(this.pnlSearch);
            this.pnlFacultyBody.Controls.Add(this.pnlOperations);
            this.pnlFacultyBody.Controls.Add(this.pnlFormTitle);
            this.pnlFacultyBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFacultyBody.Location = new System.Drawing.Point(0, 0);
            this.pnlFacultyBody.Name = "pnlFacultyBody";
            this.pnlFacultyBody.Size = new System.Drawing.Size(784, 561);
            this.pnlFacultyBody.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlForm.Controls.Add(this.txtFacultyId);
            this.pnlForm.Controls.Add(this.txtFirstName);
            this.pnlForm.Controls.Add(this.btnSubmit);
            this.pnlForm.Controls.Add(this.cmbOffice);
            this.pnlForm.Controls.Add(this.txtLastName);
            this.pnlForm.Controls.Add(this.lblOffice);
            this.pnlForm.Controls.Add(this.dtpDoB);
            this.pnlForm.Controls.Add(this.txtSalary);
            this.pnlForm.Controls.Add(this.lblFacultyId);
            this.pnlForm.Controls.Add(this.txtContactNo);
            this.pnlForm.Controls.Add(this.lblSalary);
            this.pnlForm.Controls.Add(this.lblPostalCode);
            this.pnlForm.Controls.Add(this.lblContactNo);
            this.pnlForm.Controls.Add(this.txtPostalCode);
            this.pnlForm.Controls.Add(this.cmbGender);
            this.pnlForm.Controls.Add(this.lblAddress);
            this.pnlForm.Controls.Add(this.lblFirstName);
            this.pnlForm.Controls.Add(this.txtAddress);
            this.pnlForm.Controls.Add(this.lblLastName);
            this.pnlForm.Controls.Add(this.lblDoB);
            this.pnlForm.Controls.Add(this.lblGender);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 130);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(784, 266);
            this.pnlForm.TabIndex = 1000;
            // 
            // txtFacultyId
            // 
            this.txtFacultyId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacultyId.Enabled = false;
            this.txtFacultyId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyId.Location = new System.Drawing.Point(99, 24);
            this.txtFacultyId.MaxLength = 10;
            this.txtFacultyId.Name = "txtFacultyId";
            this.txtFacultyId.Size = new System.Drawing.Size(267, 23);
            this.txtFacultyId.TabIndex = 136;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(99, 60);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(267, 23);
            this.txtFirstName.TabIndex = 137;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(640, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 28);
            this.btnSubmit.TabIndex = 134;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // cmbOffice
            // 
            this.cmbOffice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOffice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOffice.FormattingEnabled = true;
            this.cmbOffice.Location = new System.Drawing.Point(99, 140);
            this.cmbOffice.Name = "cmbOffice";
            this.cmbOffice.Size = new System.Drawing.Size(267, 24);
            this.cmbOffice.TabIndex = 155;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(99, 100);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(267, 23);
            this.txtLastName.TabIndex = 138;
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOffice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffice.ForeColor = System.Drawing.Color.Black;
            this.lblOffice.Location = new System.Drawing.Point(0, 144);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(58, 16);
            this.lblOffice.TabIndex = 154;
            this.lblOffice.Text = "Office: ";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoB.Location = new System.Drawing.Point(488, 140);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(288, 23);
            this.dtpDoB.TabIndex = 139;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(488, 60);
            this.txtSalary.MaxLength = 10;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(288, 23);
            this.txtSalary.TabIndex = 153;
            // 
            // lblFacultyId
            // 
            this.lblFacultyId.AutoSize = true;
            this.lblFacultyId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFacultyId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyId.ForeColor = System.Drawing.Color.Black;
            this.lblFacultyId.Location = new System.Drawing.Point(1, 28);
            this.lblFacultyId.Name = "lblFacultyId";
            this.lblFacultyId.Size = new System.Drawing.Size(80, 16);
            this.lblFacultyId.TabIndex = 140;
            this.lblFacultyId.Text = "Faculty Id:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(488, 24);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(288, 23);
            this.txtContactNo.TabIndex = 152;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Black;
            this.lblSalary.Location = new System.Drawing.Point(384, 64);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(60, 16);
            this.lblSalary.TabIndex = 141;
            this.lblSalary.Text = "Salary: ";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPostalCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.ForeColor = System.Drawing.Color.Black;
            this.lblPostalCode.Location = new System.Drawing.Point(384, 184);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(97, 16);
            this.lblPostalCode.TabIndex = 151;
            this.lblPostalCode.Text = "Postal Code: ";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContactNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblContactNo.Location = new System.Drawing.Point(384, 28);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(87, 16);
            this.lblContactNo.TabIndex = 142;
            this.lblContactNo.Text = "Contact #: ";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(488, 180);
            this.txtPostalCode.MaxLength = 6;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(288, 23);
            this.txtPostalCode.TabIndex = 150;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(488, 100);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(288, 24);
            this.cmbGender.TabIndex = 143;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(0, 184);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 16);
            this.lblAddress.TabIndex = 149;
            this.lblAddress.Text = "Address: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(1, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 16);
            this.lblFirstName.TabIndex = 144;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(99, 180);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(267, 23);
            this.txtAddress.TabIndex = 148;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(1, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 16);
            this.lblLastName.TabIndex = 145;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDoB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.ForeColor = System.Drawing.Color.Black;
            this.lblDoB.Location = new System.Drawing.Point(384, 144);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(44, 16);
            this.lblDoB.TabIndex = 147;
            this.lblDoB.Text = "DoB: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(384, 104);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 16);
            this.lblGender.TabIndex = 146;
            this.lblGender.Text = "Gender: ";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlSearch.Controls.Add(this.btnFind);
            this.pnlSearch.Controls.Add(this.lblSearchFaculty);
            this.pnlSearch.Controls.Add(this.cmbSearchFacultyChooseFromList);
            this.pnlSearch.Controls.Add(this.lblSearchFacultyId);
            this.pnlSearch.Controls.Add(this.txtSearchFacultyId);
            this.pnlSearch.Controls.Add(this.chkSearchFacultyChooseFromList);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 66);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(784, 64);
            this.pnlSearch.TabIndex = 100;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(640, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 28);
            this.btnFind.TabIndex = 135;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblSearchFaculty
            // 
            this.lblSearchFaculty.AutoSize = true;
            this.lblSearchFaculty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchFaculty.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSearchFaculty.Location = new System.Drawing.Point(1, 3);
            this.lblSearchFaculty.Name = "lblSearchFaculty";
            this.lblSearchFaculty.Size = new System.Drawing.Size(65, 22);
            this.lblSearchFaculty.TabIndex = 73;
            this.lblSearchFaculty.Text = "Search: ";
            // 
            // cmbSearchFacultyChooseFromList
            // 
            this.cmbSearchFacultyChooseFromList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbSearchFacultyChooseFromList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchFacultyChooseFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearchFacultyChooseFromList.ForeColor = System.Drawing.Color.Black;
            this.cmbSearchFacultyChooseFromList.FormattingEnabled = true;
            this.cmbSearchFacultyChooseFromList.Location = new System.Drawing.Point(288, 32);
            this.cmbSearchFacultyChooseFromList.Name = "cmbSearchFacultyChooseFromList";
            this.cmbSearchFacultyChooseFromList.Size = new System.Drawing.Size(272, 24);
            this.cmbSearchFacultyChooseFromList.TabIndex = 80;
            // 
            // lblSearchFacultyId
            // 
            this.lblSearchFacultyId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchFacultyId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFacultyId.ForeColor = System.Drawing.Color.Black;
            this.lblSearchFacultyId.Location = new System.Drawing.Point(104, 8);
            this.lblSearchFacultyId.Name = "lblSearchFacultyId";
            this.lblSearchFacultyId.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.lblSearchFacultyId.Size = new System.Drawing.Size(64, 23);
            this.lblSearchFacultyId.TabIndex = 77;
            this.lblSearchFacultyId.Text = "Faculty Id:";
            // 
            // txtSearchFacultyId
            // 
            this.txtSearchFacultyId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFacultyId.ForeColor = System.Drawing.Color.Black;
            this.txtSearchFacultyId.Location = new System.Drawing.Point(288, 8);
            this.txtSearchFacultyId.MaxLength = 10;
            this.txtSearchFacultyId.Name = "txtSearchFacultyId";
            this.txtSearchFacultyId.Size = new System.Drawing.Size(272, 23);
            this.txtSearchFacultyId.TabIndex = 78;
            // 
            // chkSearchFacultyChooseFromList
            // 
            this.chkSearchFacultyChooseFromList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkSearchFacultyChooseFromList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchFacultyChooseFromList.ForeColor = System.Drawing.Color.Black;
            this.chkSearchFacultyChooseFromList.Location = new System.Drawing.Point(104, 32);
            this.chkSearchFacultyChooseFromList.Name = "chkSearchFacultyChooseFromList";
            this.chkSearchFacultyChooseFromList.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkSearchFacultyChooseFromList.Size = new System.Drawing.Size(152, 23);
            this.chkSearchFacultyChooseFromList.TabIndex = 79;
            this.chkSearchFacultyChooseFromList.Text = "Choose from list";
            this.chkSearchFacultyChooseFromList.UseVisualStyleBackColor = false;
            this.chkSearchFacultyChooseFromList.CheckedChanged += new System.EventHandler(this.chkSearchFacultyChooseFromList_CheckedChanged);
            // 
            // pnlOperations
            // 
            this.pnlOperations.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlOperations.Controls.Add(this.rdSearch);
            this.pnlOperations.Controls.Add(this.rdUpdate);
            this.pnlOperations.Controls.Add(this.rdAddFaculty);
            this.pnlOperations.Controls.Add(this.lblOperation);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 32);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(784, 34);
            this.pnlOperations.TabIndex = 10;
            // 
            // rdSearch
            // 
            this.rdSearch.AutoSize = true;
            this.rdSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdSearch.Location = new System.Drawing.Point(296, 8);
            this.rdSearch.Name = "rdSearch";
            this.rdSearch.Size = new System.Drawing.Size(75, 20);
            this.rdSearch.TabIndex = 138;
            this.rdSearch.Text = "Search";
            this.rdSearch.UseVisualStyleBackColor = false;
            this.rdSearch.CheckedChanged += new System.EventHandler(this.rdOperation_CheckedChanged);
            // 
            // rdUpdate
            // 
            this.rdUpdate.AutoSize = true;
            this.rdUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdUpdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdUpdate.Location = new System.Drawing.Point(200, 8);
            this.rdUpdate.Name = "rdUpdate";
            this.rdUpdate.Size = new System.Drawing.Size(77, 20);
            this.rdUpdate.TabIndex = 137;
            this.rdUpdate.Text = "Update";
            this.rdUpdate.UseVisualStyleBackColor = false;
            this.rdUpdate.CheckedChanged += new System.EventHandler(this.rdOperation_CheckedChanged);
            // 
            // rdAddFaculty
            // 
            this.rdAddFaculty.AutoSize = true;
            this.rdAddFaculty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdAddFaculty.Checked = true;
            this.rdAddFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdAddFaculty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAddFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdAddFaculty.Location = new System.Drawing.Point(112, 8);
            this.rdAddFaculty.Name = "rdAddFaculty";
            this.rdAddFaculty.Size = new System.Drawing.Size(53, 20);
            this.rdAddFaculty.TabIndex = 136;
            this.rdAddFaculty.TabStop = true;
            this.rdAddFaculty.Text = "Add";
            this.rdAddFaculty.UseVisualStyleBackColor = false;
            this.rdAddFaculty.CheckedChanged += new System.EventHandler(this.rdOperation_CheckedChanged);
            // 
            // lblOperation
            // 
            this.lblOperation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOperation.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOperation.Location = new System.Drawing.Point(0, 2);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblOperation.Size = new System.Drawing.Size(84, 30);
            this.lblOperation.TabIndex = 135;
            this.lblOperation.Text = "Operation:";
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.Controls.Add(this.lblFacultyForm);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(784, 32);
            this.pnlFormTitle.TabIndex = 0;
            // 
            // lblFacultyForm
            // 
            this.lblFacultyForm.AutoSize = true;
            this.lblFacultyForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFacultyForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFacultyForm.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFacultyForm.Location = new System.Drawing.Point(0, 0);
            this.lblFacultyForm.Name = "lblFacultyForm";
            this.lblFacultyForm.Size = new System.Drawing.Size(118, 26);
            this.lblFacultyForm.TabIndex = 1;
            this.lblFacultyForm.Text = "Faculty Form";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(8, 408);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 1001;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlFacultyBody);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            this.pnlFacultyBody.ResumeLayout(false);
            this.pnlFacultyBody.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFacultyBody;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Label lblFacultyForm;
        private System.Windows.Forms.Label lblSearchFaculty;
        private System.Windows.Forms.ComboBox cmbSearchFacultyChooseFromList;
        private System.Windows.Forms.CheckBox chkSearchFacultyChooseFromList;
        private System.Windows.Forms.TextBox txtSearchFacultyId;
        private System.Windows.Forms.Label lblSearchFacultyId;
        private System.Windows.Forms.ComboBox cmbOffice;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblFacultyId;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtFacultyId;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton rdSearch;
        private System.Windows.Forms.RadioButton rdUpdate;
        private System.Windows.Forms.RadioButton rdAddFaculty;
        private System.Windows.Forms.Label lblError;
    }
}