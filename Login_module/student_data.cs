using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class student_data : Form
    {
        public student_data()
        {
            InitializeComponent();
        }
        //Global Variable
        public OleDbConnection con = new OleDbConnection();

        private void student_data_Load(object sender, EventArgs e)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string dbDir = Directory.GetParent(Directory.GetParent(currentDir).FullName).FullName;
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbDir + @"\\university.accdb;Persist Security Info=False";
            con.Open();
            btnAddStudent.Enabled = false;
            //Connection with database
            //form load activities
            cmbStudentDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUDStudentList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSStudentList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDStudentList.DropDownStyle = ComboBoxStyle.DropDownList;
            //Update
            txtUDStudent.Enabled = false;
            chkListUDStudent.Enabled = false;
            cmbUDStudentList.Enabled = false;
            btnUDStudent.Enabled = false;
            //Search
            txtSStudentId.Enabled = false;
            chkListSStudent.Enabled = false;
            cmbSStudentList.Enabled = false;

            //Delete
            txtDStudentID.Enabled = false;
            cmbDStudentList.Enabled = false;
            btnDStudent.Enabled = false;
            chkListDStudent.Enabled = false;
        }
        private void chkUpdateStudent_CheckedChanged(object sender, EventArgs e)
        {
            //Update
            if (chkUpdateStudent.Checked == true)
            {
                txtStudentId.Enabled = false;
                txtStudentName.Enabled = true;
                txtStudentLName.Enabled = true;
                txtStudentAddress.Enabled = true;
                txtStudentPostCode.Enabled = true;
                //Add checkbox
                chkAddStudent.Checked = false;
                txtUDStudent.Enabled = true;
                chkListUDStudent.Enabled = true;
                cmbUDStudentList.Enabled = false;
                btnUDStudent.Enabled = true;
                //Search
                txtSStudentId.Enabled = false;
                chkListSStudent.Enabled = false;
                cmbSStudentList.Enabled = false;
                //Delete
                txtDStudentID.Enabled = false;
                cmbDStudentList.Enabled = false;
                btnDStudent.Enabled = false;
                chkListDStudent.Enabled = false;
                //Check boxes
                chkSearchStudent.Checked = false;
                chkDeleteStudent.Checked = false;
            }
            else
            {

                txtStudentId.Enabled = true;
                txtUDStudent.Enabled = false;
                chkListUDStudent.Enabled = false;
                cmbUDStudentList.Enabled = false;
                btnUDStudent.Enabled = false;
            }
        }

        private void chkUpdateStudent_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void chkSearchStudent_CheckedChanged(object sender, EventArgs e)
        {
            //Search
            if (chkSearchStudent.Checked == true)
            {

                //Add checkbox
                chkAddStudent.Checked = false;
                txtSStudentId.Enabled = true;
                chkListSStudent.Enabled = true;
                cmbSStudentList.Enabled = false;
                //Update
                txtUDStudent.Enabled = false;
                chkListUDStudent.Enabled = false;
                cmbUDStudentList.Enabled = false;
                btnUDStudent.Enabled = false;
                //Delete  
                txtDStudentID.Enabled = false;
                cmbDStudentList.Enabled = false;
                btnDStudent.Enabled = false;
                chkListDStudent.Enabled = false;
                //Check boxes
                chkUpdateStudent.Checked = false;
                chkDeleteStudent.Checked = false;
            }
            else
            {
                txtSStudentId.Enabled = false;
                chkListSStudent.Enabled = false;
                cmbSStudentList.Enabled = false;
            }
        }

        private void chkDeleteStudent_CheckedChanged(object sender, EventArgs e)
        {
            //Delete
            if (chkDeleteStudent.Checked == true)
            {
                txtStudentId.Enabled = true;
                txtStudentName.Enabled = true;
                txtStudentLName.Enabled = true;
                txtStudentAddress.Enabled = true;
                txtStudentPostCode.Enabled = true;


                //Add checkbox
                chkAddStudent.Checked = false;
                txtDStudentID.Enabled = true;
                cmbDStudentList.Enabled = false;
                btnDStudent.Enabled = true;
                chkListDStudent.Enabled = true;
                //Update
                txtUDStudent.Enabled = false;
                chkListUDStudent.Enabled = false;
                cmbUDStudentList.Enabled = false;
                btnUDStudent.Enabled = false;
                //Search
                txtSStudentId.Enabled = false;
                chkListSStudent.Enabled = false;
                cmbSStudentList.Enabled = false;
                //check boxes
                chkUpdateStudent.Checked = false;
                chkSearchStudent.Checked = false;
            }
            else
            {
                txtDStudentID.Enabled = false;
                cmbDStudentList.Enabled = false;
                btnDStudent.Enabled = false;
                chkListDStudent.Enabled = false;
            }
        }

        private void chkListUDStudent_CheckedChanged(object sender, EventArgs e)
        {
            cmbUDStudentList.Items.Clear();
            if (chkListUDStudent.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, student s where p.PersonId = s.studentid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbUDStudentList.Items.Add(reader["personnum"].ToString());
                }
                //Update Checkbox
                txtUDStudent.Enabled = false;
                cmbUDStudentList.Enabled = true;
            }
            else
            {
                txtUDStudent.Enabled = true;
                cmbUDStudentList.Enabled = false;
            }
        }

        private void chkListSStudent_CheckedChanged(object sender, EventArgs e)
        {
            cmbSStudentList.Items.Clear();
            if (chkListSStudent.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, student s where p.PersonId = s.studentid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbSStudentList.Items.Add(reader["personnum"].ToString());
                }
                //Search Checkbox
                txtSStudentId.Enabled = false;
                cmbSStudentList.Enabled = true;
            }
            else
            {
                txtSStudentId.Enabled = true;
                cmbSStudentList.Enabled = false;
            }
        }

        private void chkListDStudent_CheckedChanged(object sender, EventArgs e)
        {
            cmbDStudentList.Items.Clear();
            if (chkListDStudent.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, student s where p.PersonId = s.studentid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbDStudentList.Items.Add(reader["personnum"].ToString());
                }
                //Delete Checkbox
                txtDStudentID.Enabled = false;
                cmbDStudentList.Enabled = true;
            }
            else
            {
                txtDStudentID.Enabled = true;
                cmbDStudentList.Enabled = false;
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            bool flag = false;
            string input = txtStudentId.Text;
            try
            {
                int id = int.Parse(input);
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT PersonId FROM PERSON";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    if (id.ToString() == reader["PersonId"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    lblStudentID.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblStudentID.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                lblStudentID.ForeColor = System.Drawing.Color.Red;
            }

        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            OleDbCommand com2 = new OleDbCommand();
            OleDbCommand com3 = new OleDbCommand();
            OleDbCommand com4 = new OleDbCommand();
            OleDbCommand com5 = new OleDbCommand();

            com1.Connection = con;
            com2.Connection = con;
            com3.Connection = con;
            com4.Connection = con;
            com5.Connection = con;
            bool flag1 = false, flag2 = false;
            string studentId = txtStudentId.Text;
            string fname = txtStudentName.Text;
            string lname = txtStudentLName.Text;
            string address = txtStudentAddress.Text;
            string postalCode = txtStudentPostCode.Text;

            if (studentId != "" && fname != "" && lname != "" && address != "" && postalCode != "" && cmbStudentDep.SelectedItem != null && cmbStudentGenre.SelectedItem != null && cmbStudentCourse.SelectedItem != null)
            {
                com4.CommandText = "Select courseid , coursetitle from course";
                OleDbDataReader courseRead = com4.ExecuteReader();
                while (courseRead.Read())
                {
                    if (cmbStudentCourse.SelectedItem.ToString() == courseRead["coursetitle"].ToString())
                    {
                        flag1 = true;
                        break;
                    }
                }
                com5.CommandText = "SELECT c.courseid as cID, d.deptid as stdDept, d.dname as depName FROM Course c, Department d where c.deptid = d.deptid";
                OleDbDataReader DeRead = com5.ExecuteReader();
                while (DeRead.Read())
                {
                    if (cmbStudentDep.SelectedItem.ToString() == DeRead["depName"].ToString())
                    {
                        flag2 = true;
                        break;
                    }
                }
                if (flag1 && flag2)
                {
                    try
                    {
                        com1.CommandText = "Insert into person(personId,fname,lname,dob,postalcode,gender,address) values(" + int.Parse(studentId) + ",'" + fname + "','" + lname + "'," + dtpStudentBirthday.Value.ToString("mm-dd-yyyy") + "," + long.Parse(postalCode) + ",'" + cmbStudentGenre.SelectedItem.ToString() + "','" + address + "')";
                        com2.CommandText = "Insert into student(studentid,class,Deptid) values(" + int.Parse(studentId) + ",'" + cmbStudentClass.SelectedItem.ToString() + "'," + int.Parse(DeRead["stdDept"].ToString()) + ")";
                        com3.CommandText = "Insert into Register(courseid, studentid) values(" + int.Parse(courseRead["courseid"].ToString()) + "," + int.Parse(studentId) + ")";

                        com1.ExecuteNonQuery();
                        com2.ExecuteNonQuery();
                        com3.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added");
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Values");
            }
        }

        private void txtStudentId_Leave(object sender, EventArgs e)
        {
            string input = txtStudentId.Text;
            try
            {
                long id = long.Parse(input);
                lblStudentID.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtStudentId.Focus();
                lblStudentID.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            string input = txtStudentName.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (input.Length != 0)
            {
                if (count == input.Length)
                    lblStudentName.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtStudentName.Focus();
                lblStudentName.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtStudentLName_Leave(object sender, EventArgs e)
        {
            string input = txtStudentLName.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (input.Length != 0)
            {
                if (count == input.Length)
                {
                    lblStudentLName.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                txtStudentLName.Focus();
                lblStudentLName.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtStudentPostCode_Leave(object sender, EventArgs e)
        {
            string input = txtStudentPostCode.Text;
            try
            {
                long id = long.Parse(input);
                lblStudentPostCode.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtStudentPostCode.Focus();
                lblStudentPostCode.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void dtpStudentBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUDStudent_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtStudentId.Enabled = false;
            cmbStudentDep.Items.Clear();
            cmbStudentCourse.Items.Clear();
            cmbStudentClass.Items.Clear();
            cmbStudentGenre.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtUDStudent.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblUDStudentID.ForeColor = System.Drawing.Color.Green;
                txtStudentId.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbStudentDep.Items.Add(readStd["deptname"].ToString());
                        cmbStudentClass.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbStudentDep.SelectedIndex = 0;
                cmbStudentClass.SelectedIndex = 0;
                txtStudentName.Text = reader["perfname"].ToString();
                txtStudentLName.Text = reader["perlname"].ToString();
                cmbStudentGenre.Items.Add(reader["pergen"].ToString());
                cmbStudentGenre.SelectedIndex = 0;
                txtStudentPostCode.Text = reader["perpost"].ToString();
                txtStudentAddress.Text = reader["peradd"].ToString();
                dtpStudentBirthday.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txtStudentLName.Text = "";
                cmbStudentDep.Items.Clear();
                cmbStudentClass.Items.Clear();
                cmbStudentGenre.Items.Clear();
                txtStudentAddress.Text = "";
                txtStudentPostCode.Text = "";
                dtpStudentBirthday.Value = DateTime.Now;
                lblUDStudentID.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void txtSStudentId_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtStudentId.Enabled = false;
            txtStudentName.Enabled = false;
            txtStudentLName.Enabled = false;
            txtStudentAddress.Enabled = false;
            txtStudentPostCode.Enabled = false;
            cmbStudentDep.Items.Clear();
            cmbStudentCourse.Items.Clear();
            cmbStudentClass.Items.Clear();
            cmbStudentGenre.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtSStudentId.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblSStudentID.ForeColor = System.Drawing.Color.Green;
                txtStudentId.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbStudentDep.Items.Add(readStd["deptname"].ToString());
                        cmbStudentClass.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbStudentDep.SelectedIndex = 0;
                cmbStudentClass.SelectedIndex = 0;
                txtStudentName.Text = reader["perfname"].ToString();
                txtStudentLName.Text = reader["perlname"].ToString();
                cmbStudentGenre.Items.Add(reader["pergen"].ToString());
                cmbStudentGenre.SelectedIndex = 0;
                txtStudentPostCode.Text = reader["perpost"].ToString();
                txtStudentAddress.Text = reader["peradd"].ToString();
                dtpStudentBirthday.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txtStudentLName.Text = "";
                cmbStudentDep.Items.Clear();
                cmbStudentClass.Items.Clear();
                cmbStudentGenre.Items.Clear();
                txtStudentAddress.Text = "";
                txtStudentPostCode.Text = "";
                dtpStudentBirthday.Value = DateTime.Now;
                lblUDStudentID.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtDStudentID_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            //Check box with database
            txtStudentId.Enabled = false;
            txtStudentName.Enabled = false;
            txtStudentLName.Enabled = false;
            txtStudentAddress.Enabled = false;
            txtStudentPostCode.Enabled = false;
            cmbStudentDep.Items.Clear();
            cmbStudentCourse.Items.Clear();
            cmbStudentClass.Items.Clear();
            cmbStudentGenre.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtDStudentID.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblDStudentID.ForeColor = System.Drawing.Color.Green;
                txtStudentId.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbStudentDep.Items.Add(readStd["deptname"].ToString());
                        cmbStudentClass.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbStudentDep.SelectedIndex = 0;
                cmbStudentClass.SelectedIndex = 0;
                txtStudentName.Text = reader["perfname"].ToString();
                txtStudentLName.Text = reader["perlname"].ToString();
                cmbStudentGenre.Items.Add(reader["pergen"].ToString());
                cmbStudentGenre.SelectedIndex = 0;
                txtStudentPostCode.Text = reader["perpost"].ToString();
                txtStudentAddress.Text = reader["peradd"].ToString();
                dtpStudentBirthday.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txtStudentLName.Text = "";
                cmbStudentDep.Items.Clear();
                cmbStudentClass.Items.Clear();
                cmbStudentGenre.Items.Clear();
                txtStudentAddress.Text = "";
                txtStudentPostCode.Text = "";
                dtpStudentBirthday.Value = DateTime.Now;
                lblUDStudentID.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cmbStudentDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudentCourse.Items.Clear();
            cmbStudentClass.Items.Clear();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = "SELECT c.deptid as coursedept, c.courseid as cID , d.dname as dename, d.deptid as deptnum,  c.coursetitle as coursename  FROM Course c, Department d where c.deptid = d.deptid";
            OleDbDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (cmbStudentDep.SelectedItem.ToString() == read["dename"].ToString())
                {
                    cmbStudentCourse.Items.Add(read["coursename"].ToString());
                }
            }
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            com1.CommandText = "SELECT c.className as cName, d.deptid as dptid, d.dname as depname from class c, department d where d.deptid = c.deptid ";
            OleDbDataReader readclass = com1.ExecuteReader();
            while (readclass.Read())
            {
                if (cmbStudentDep.SelectedItem.ToString() == readclass["depname"].ToString())
                {
                    cmbStudentClass.Items.Add(readclass["cName"].ToString());
                    cmbStudentClass.SelectedIndex = 0;
                    break;
                }
            }
        }

        private void cmbUDStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update combobox
            txtStudentId.Enabled = false;
            cmbStudentDep.Items.Clear();
            cmbStudentCourse.Items.Clear();
            cmbStudentClass.Items.Clear();
            cmbStudentGenre.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbUDStudentList.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblUDStudentID.ForeColor = System.Drawing.Color.Green;
                txtStudentId.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbStudentDep.Items.Add(readStd["deptname"].ToString());
                        cmbStudentClass.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbStudentDep.SelectedIndex = 0;
                cmbStudentClass.SelectedIndex = 0;
                txtStudentName.Text = reader["perfname"].ToString();
                txtStudentLName.Text = reader["perlname"].ToString();
                cmbStudentGenre.Items.Add(reader["pergen"].ToString());
                cmbStudentGenre.SelectedIndex = 0;
                txtStudentPostCode.Text = reader["perpost"].ToString();
                txtStudentAddress.Text = reader["peradd"].ToString();
                dtpStudentBirthday.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txtStudentLName.Text = "";
                cmbStudentDep.Items.Clear();
                cmbStudentClass.Items.Clear();
                cmbStudentGenre.Items.Clear();
                txtStudentAddress.Text = "";
                txtStudentPostCode.Text = "";
                dtpStudentBirthday.Value = DateTime.Now;
                lblUDStudentID.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cmbStudentClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkAddStudent_CheckedChanged(object sender, EventArgs e)
        {
            //Add check box
            if (chkAddStudent.Checked == true)
            {
                cmbStudentDep.Items.Clear();
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Select dname from department";
                OleDbDataReader reDeptid = com.ExecuteReader();
                while (reDeptid.Read())
                {
                    cmbStudentDep.Items.Add(reDeptid["dname"].ToString());
                }
                txtStudentId.Enabled = true;
                txtStudentName.Enabled = true;
                txtStudentLName.Enabled = true;
                txtStudentAddress.Enabled = true;
                txtStudentPostCode.Enabled = true;
                cmbStudentDep.Items.Clear();
                cmbStudentCourse.Items.Clear();
                cmbStudentClass.Items.Clear();
                cmbStudentGenre.Items.Clear();
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT DNAME FROM DEPARTMENT";
                OleDbDataReader dept = com2.ExecuteReader();
                while (dept.Read())
                {
                    cmbStudentDep.Items.Add(dept["dname"].ToString());
                }
                cmbStudentGenre.Items.Add("Male");
                cmbStudentGenre.Items.Add("Female");
                chkUpdateStudent.Checked = false;
                chkSearchStudent.Checked = false;
                chkDeleteStudent.Checked = false;
                btnAddStudent.Enabled = true;
            }
            else
            {
                btnAddStudent.Enabled = false;
            }


        }

        private void txtStudentPostCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblSStudentID_Click(object sender, EventArgs e)
        {

        }

        private void cmbSStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update combobox
            txtStudentId.Enabled = false;
            txtStudentName.Enabled = false;
            txtStudentLName.Enabled = false;
            txtStudentAddress.Enabled = false;
            txtStudentPostCode.Enabled = false;
            cmbStudentDep.Items.Clear();
            cmbStudentCourse.Items.Clear();
            cmbStudentClass.Items.Clear();
            cmbStudentGenre.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbSStudentList.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblUDStudentID.ForeColor = System.Drawing.Color.Green;
                txtStudentId.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbStudentDep.Items.Add(readStd["deptname"].ToString());
                        cmbStudentClass.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbStudentDep.SelectedIndex = 0;
                cmbStudentClass.SelectedIndex = 0;
                txtStudentName.Text = reader["perfname"].ToString();
                txtStudentLName.Text = reader["perlname"].ToString();
                cmbStudentGenre.Items.Add(reader["pergen"].ToString());
                cmbStudentGenre.SelectedIndex = 0;
                txtStudentPostCode.Text = reader["perpost"].ToString();
                txtStudentAddress.Text = reader["peradd"].ToString();
                dtpStudentBirthday.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txtStudentLName.Text = "";
                cmbStudentDep.Items.Clear();
                cmbStudentClass.Items.Clear();
                cmbStudentGenre.Items.Clear();
                txtStudentAddress.Text = "";
                txtStudentPostCode.Text = "";
                dtpStudentBirthday.Value = DateTime.Now;
                lblUDStudentID.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnUDStudent_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            if (txtUDStudent.Text != "" || cmbUDStudentList.SelectedItem != null)
            {
                if (txtUDStudent.Enabled == true && cmbUDStudentList.Enabled == false)
                {
                    try
                    {
                        com.CommandText = "Update Person set fname ='" + txtStudentName.Text + "', lname ='" + txtStudentLName.Text + "', address ='" + txtStudentAddress.Text + "', postalcode = " + int.Parse(txtStudentPostCode.Text) + " where personid =" + int.Parse(txtStudentId.Text) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Can Not be Updated");
                    }
                }
                else
                {
                    try
                    {
                        com.CommandText = "Update Person set fname ='" + txtStudentName.Text + "', lname ='" + txtStudentLName.Text + "', address ='" + txtStudentAddress.Text + "', postalcode = " + int.Parse(txtStudentPostCode.Text) + " where personid =" + int.Parse(cmbUDStudentList.SelectedItem.ToString()) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Can Not be Updated");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Values");
            }
        }

        private void cmbDStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStudentId.Enabled = false;
            cmbStudentDep.Items.Clear();
            cmbStudentCourse.Items.Clear();
            cmbStudentClass.Items.Clear();
            cmbStudentGenre.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbDStudentList.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblUDStudentID.ForeColor = System.Drawing.Color.Green;
                txtStudentId.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbStudentDep.Items.Add(readStd["deptname"].ToString());
                        cmbStudentClass.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbStudentDep.SelectedIndex = 0;
                cmbStudentClass.SelectedIndex = 0;
                txtStudentName.Text = reader["perfname"].ToString();
                txtStudentLName.Text = reader["perlname"].ToString();
                cmbStudentGenre.Items.Add(reader["pergen"].ToString());
                cmbStudentGenre.SelectedIndex = 0;
                txtStudentPostCode.Text = reader["perpost"].ToString();
                txtStudentAddress.Text = reader["peradd"].ToString();
                dtpStudentBirthday.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtStudentId.Text = "";
                txtStudentName.Text = "";
                txtStudentLName.Text = "";
                cmbStudentDep.Items.Clear();
                cmbStudentClass.Items.Clear();
                cmbStudentGenre.Items.Clear();
                txtStudentAddress.Text = "";
                txtStudentPostCode.Text = "";
                dtpStudentBirthday.Value = DateTime.Now;
                lblUDStudentID.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnDStudent_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            OleDbCommand com2 = new OleDbCommand();
            OleDbCommand com3 = new OleDbCommand();
            com3.Connection = con;
            com2.Connection = con;
            com1.Connection = con;
            if (txtDStudentID.Text != "" || cmbDStudentList.SelectedItem != null)
            {
                if (txtDStudentID.Enabled == true && cmbDStudentList.Enabled == false)
                {
                    try
                    {
                        com3.CommandText = "Delete from Register where studentid =" + int.Parse(txtDStudentID.Text) + "";
                        com1.CommandText = "Delete  from Student where studentid =" + int.Parse(txtDStudentID.Text) + "";
                        com2.CommandText = "Delete  from Person where PersonId =" + int.Parse(txtDStudentID.Text) + "";
                        com3.ExecuteNonQuery();
                        com1.ExecuteNonQuery();
                        com2.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                    }
                    catch
                    {
                        MessageBox.Show("Can Not be Deleted");
                    }
                }
                else
                {
                    try
                    {
                        com3.CommandText = "Delete from Register where studentid =" + int.Parse(cmbDStudentList.SelectedItem.ToString()) + "";
                        com1.CommandText = "Delete  from Student where studentid =" + int.Parse(cmbDStudentList.SelectedItem.ToString()) + "";
                        com2.CommandText = "Delete  from Person where PersonId =" + int.Parse(cmbDStudentList.SelectedItem.ToString()) + "";
                        com3.ExecuteNonQuery();
                        com1.ExecuteNonQuery();
                        com2.ExecuteNonQuery();
                        MessageBox.Show("Successfully Deleted");
                    }
                    catch
                    {
                        MessageBox.Show("Can Not be Deleted");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Value Please");
            }
        }

    }
}
