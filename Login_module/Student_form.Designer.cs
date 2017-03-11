namespace AcademicManagementSystem
{
    partial class Student_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_form));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.imgMessage = new System.Windows.Forms.Label();
            this.btnCourse = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.PictureBox();
            this.btnDepartment = new System.Windows.Forms.PictureBox();
            this.btnFaculty = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.PictureBox();
            this.Form_Pages = new System.Windows.Forms.PictureBox();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_Pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(663, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "< Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(10, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(125, 42);
            this.lblMenu.TabIndex = 9;
            this.lblMenu.Text = "Choose From Menu";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(4, 358);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 10;
            // 
            // imgMessage
            // 
            this.imgMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgMessage.Location = new System.Drawing.Point(10, 354);
            this.imgMessage.Name = "imgMessage";
            this.imgMessage.Size = new System.Drawing.Size(125, 164);
            this.imgMessage.TabIndex = 11;
            this.imgMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCourse
            // 
            this.btnCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourse.Image = global::AcademicManagementSystem.Properties.Resources.button6_normal;
            this.btnCourse.Location = new System.Drawing.Point(6, 251);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(130, 42);
            this.btnCourse.TabIndex = 8;
            this.btnCourse.TabStop = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            this.btnCourse.MouseLeave += new System.EventHandler(this.btnCourse_MouseLeave);
            this.btnCourse.MouseHover += new System.EventHandler(this.btnCourse_MouseHover);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Image = global::AcademicManagementSystem.Properties.Resources.button4_normal;
            this.btnRegister.Location = new System.Drawing.Point(7, 203);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 42);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.TabStop = false;
            this.btnRegister.Click += new System.EventHandler(this.button4_Click);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            this.btnRegister.MouseHover += new System.EventHandler(this.btnRegister_MouseHover);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartment.Image = global::AcademicManagementSystem.Properties.Resources.button3_normal;
            this.btnDepartment.Location = new System.Drawing.Point(7, 155);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(130, 42);
            this.btnDepartment.TabIndex = 5;
            this.btnDepartment.TabStop = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            this.btnDepartment.MouseLeave += new System.EventHandler(this.btnDepartment_MouseLeave);
            this.btnDepartment.MouseHover += new System.EventHandler(this.btnDepartment_MouseHover);
            // 
            // btnFaculty
            // 
            this.btnFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaculty.Image = global::AcademicManagementSystem.Properties.Resources.button2_normal;
            this.btnFaculty.Location = new System.Drawing.Point(7, 107);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(130, 42);
            this.btnFaculty.TabIndex = 4;
            this.btnFaculty.TabStop = false;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            this.btnFaculty.MouseLeave += new System.EventHandler(this.btnFaculty_MouseLeave);
            this.btnFaculty.MouseHover += new System.EventHandler(this.btnFaculty_MouseHover);
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Image = global::AcademicManagementSystem.Properties.Resources.button1_normal1;
            this.btnStudent.Location = new System.Drawing.Point(7, 59);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(130, 42);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.TabStop = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.MouseLeave += new System.EventHandler(this.btnStudent_MouseLeave);
            this.btnStudent.MouseHover += new System.EventHandler(this.btnStudent_MouseHover);
            // 
            // Form_Pages
            // 
            this.Form_Pages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Form_Pages.Location = new System.Drawing.Point(0, 0);
            this.Form_Pages.Name = "Form_Pages";
            this.Form_Pages.Size = new System.Drawing.Size(137, 798);
            this.Form_Pages.TabIndex = 2;
            this.Form_Pages.TabStop = false;
            // 
            // imgIcon
            // 
            this.imgIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgIcon.Location = new System.Drawing.Point(7, 521);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(128, 247);
            this.imgIcon.TabIndex = 12;
            this.imgIcon.TabStop = false;
            // 
            // Student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AcademicManagementSystem.Properties.Resources.Student_form;
            this.ClientSize = new System.Drawing.Size(750, 772);
            this.Controls.Add(this.imgIcon);
            this.Controls.Add(this.imgMessage);
            this.Controls.Add(this.message);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.Form_Pages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_form";
            this.Text = "Student_form";
            this.Load += new System.EventHandler(this.Student_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_Pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox Form_Pages;
        private System.Windows.Forms.PictureBox btnStudent;
        private System.Windows.Forms.PictureBox btnFaculty;
        private System.Windows.Forms.PictureBox btnDepartment;
        private System.Windows.Forms.PictureBox btnRegister;
        private System.Windows.Forms.PictureBox btnCourse;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label imgMessage;
        private System.Windows.Forms.PictureBox imgIcon;
    }
}