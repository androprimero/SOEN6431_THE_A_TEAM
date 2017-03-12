using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcademicManagementSystem.UserInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void removeOpenForms()
        {
            if (this.pnlMainBody.Controls.Count > 0)
            {
                foreach (Control ctrl in this.pnlMainBody.Controls)
                {
                    this.pnlMainBody.Controls.Remove(ctrl);
                }
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {

            removeOpenForms();
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.WindowState = FormWindowState.Maximized;
            facultyForm.TopLevel = false;
            facultyForm.AutoScroll = true;
            // Set the Parent Form of the Child window.   
            this.pnlMainBody.Controls.Add(facultyForm);
            // Display the new form.
            facultyForm.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            removeOpenForms();
            StudentForm studentForm = new StudentForm();
            studentForm.WindowState = FormWindowState.Maximized;
            studentForm.TopLevel = false;
            studentForm.AutoScroll = true;
            // Set the Parent Form of the Child window.   
            this.pnlMainBody.Controls.Add(studentForm);
            // Display the new form.
            studentForm.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            removeOpenForms();
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.WindowState = FormWindowState.Maximized;
            departmentForm.TopLevel = false;
            departmentForm.AutoScroll = true;
            // Set the Parent Form of the Child window.   
            this.pnlMainBody.Controls.Add(departmentForm);
            // Display the new form.
            departmentForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            removeOpenForms();
            RegisterForm registerForm = new RegisterForm();
            registerForm.WindowState = FormWindowState.Maximized;
            registerForm.TopLevel = false;
            registerForm.AutoScroll = true;
            // Set the Parent Form of the Child window.   
            this.pnlMainBody.Controls.Add(registerForm);
            // Display the new form.
            registerForm.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            removeOpenForms();
            CourseForm courseForm = new CourseForm();
            courseForm.WindowState = FormWindowState.Maximized;
            courseForm.TopLevel = false;
            courseForm.AutoScroll = true;
            // Set the Parent Form of the Child window.   
            this.pnlMainBody.Controls.Add(courseForm);
            // Display the new form.
            courseForm.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
           
        }
    }
}
