using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Student_form : Form
    {
        public Student_form()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }


        private void btnDepartment_MouseHover(object sender, EventArgs e)
        {
            btnDepartment.Image = Properties.Resources.button3_hover;
            imgMessage.Text = "In Department form you can add a new Department, delete an existing record and update an existing record";
            imgIcon.Image = Properties.Resources.Building_Clip_Art1;
        }

        private void btnDepartment_MouseLeave(object sender, EventArgs e)
        {
            btnDepartment.Image = Properties.Resources.button3_normal;
            imgMessage.Text = "";
            imgIcon.Image = null;
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            btnRegister.Image = Properties.Resources.button4_hover;
            imgIcon.Image = Properties.Resources.registration1;
            imgMessage.Text = "In Registration form you can register Students, delete an existing record and update an existing record";
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.Image = Properties.Resources.button4_normal;
            imgIcon.Image = null;
            imgMessage.Text = "";
        }

        private void btnStudent_MouseHover(object sender, EventArgs e)
        {
            btnStudent.Image = Properties.Resources.button1_hover;
            imgIcon.Image = Properties.Resources.std;
            imgMessage.Text = "In Student form you can add a new record, delete an existing record and update an existing record";
        }

        private void btnStudent_MouseLeave(object sender, EventArgs e)
        {
            btnStudent.Image = Properties.Resources.button1_normal;
            imgMessage.Text = "";
            imgIcon.Image = null;
        }

        private void btnFaculty_MouseHover(object sender, EventArgs e)
        {
            btnFaculty.Image = Properties.Resources.button2_hover;
            imgIcon.Image = Properties.Resources.sir;
            imgMessage.Text = "In Faculty form you can add a new faculty member, delete an existing record and update an existing record";
        }

        private void btnFaculty_MouseLeave(object sender, EventArgs e)
        {
            btnFaculty.Image = Properties.Resources.button2_normal;
            imgMessage.Text = "";
            imgIcon.Image = null;
        }

        private void btnCourse_MouseHover(object sender, EventArgs e)
        {
            btnCourse.Image = Properties.Resources.button6_hover;
            imgIcon.Image = Properties.Resources.books;
            imgMessage.Text = "In Course form you can add a new course which is being offered, delete an existing record and update an existing record";
        }

        private void btnCourse_MouseLeave(object sender, EventArgs e)
        {
            btnCourse.Image = Properties.Resources.button6_normal;
            imgIcon.Image = null;
            imgMessage.Text = "";
        }
        public bool CheckForm(string arr)
        {
            bool flag = false;
            Form[] array = this.MdiChildren;
            foreach (Form temp in array)
            {
                if (temp.GetType().ToString() == "WindowsFormsApplication1." + arr)
                {
                    flag = true;
                }
            }
            return flag;
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (!CheckForm("student_data"))
            {
                student_data std = new student_data();
                std.MdiParent = this;
                std.Show();
                std.Location = new System.Drawing.Point(137, 0);
            }
            else
            {
                MessageBox.Show("Already");
            }
        }

        private void Student_form_Load(object sender, EventArgs e)
        {

        }
        private void btnFaculty_Click(object sender, EventArgs e)
        {
            if (!CheckForm("Faculty"))
            {
                faculty fac = new faculty();
                fac.MdiParent = this;
                fac.Show();
                fac.Location = new System.Drawing.Point(137, 0);
            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            if (!CheckForm("department"))
            {
                department dp = new department();
                dp.MdiParent = this;
                dp.Show();
                dp.Location = new System.Drawing.Point(137, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!CheckForm("register"))
            {
                register rg = new register();
                rg.MdiParent = this;
                rg.Show();
                rg.Location = new System.Drawing.Point(137, 0);
            }
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            if (!CheckForm("course"))
            {
                course c = new course();
                c.MdiParent = this;
                c.Show();
                c.Location = new System.Drawing.Point(137, 0);
            }
        }
    }
}
