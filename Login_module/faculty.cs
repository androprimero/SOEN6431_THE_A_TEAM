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
    public partial class faculty : Form
    {
        public faculty()
        {
            InitializeComponent();
        }
        //Global Variable
        public OleDbConnection con = new OleDbConnection();



        private void faculty_Load(object sender, EventArgs e)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string dbDir = Directory.GetParent(Directory.GetParent(currentDir).FullName).FullName;
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbDir + @"\\university.accdb;Persist Security Info=False";
            con.Open();
            btnAddFaculty.Enabled = false;
            cmbOffice.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdateFacultyChooseFromList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchFacultyChooseFromList.DropDownStyle = ComboBoxStyle.DropDownList;
            //Update
            txtUpdateFacultyId.Enabled = false;
            chkUpdateFacultyChooseFromList.Enabled = false;
            cmbUpdateFacultyChooseFromList.Enabled = false;
            btnUpdateFaculty.Enabled = false;
            //Search
            txtSearchFacultyId.Enabled = false;
            chkSearchFacultyChooseFromList.Enabled = false;
            cmbSearchFacultyChooseFromList.Enabled = false;
        }


        #region "Faculty Form Functionality Options"


        private void chkAddFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddFaculty.Checked)
            {
                cmbOffice.Items.Clear();
                btnAddFaculty.Enabled = true;
                txtFacultyId.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtAddress.Enabled = true;
                txtPostalCode.Enabled = true;
                txtSalary.Enabled = true;
                txtContactNo.Enabled = true;
                cmbGender.Items.Clear();
                cmbGender.Items.Add("Male");
                cmbGender.Items.Add("Female");
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select dname from department";

                OleDbDataReader Fread = com.ExecuteReader();
                while (Fread.Read())
                {
                    cmbOffice.Items.Add(Fread["dname"].ToString());
                }
                chkUpdateFaculty.Checked = false;
                chkSearchFaculty.Checked = false;
            }
            else
            {
                cmbOffice.Items.Clear();
                btnAddFaculty.Enabled = false;
            }
        }

        private void chkUpdateFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdateFaculty.Checked == true)
            {
                //Add checkbox
                chkAddFaculty.Checked = false;
                txtUpdateFacultyId.Enabled = true;
                chkUpdateFacultyChooseFromList.Enabled = true;
                cmbUpdateFacultyChooseFromList.Enabled = false;
                btnUpdateFaculty.Enabled = true;
                //Search
                txtSearchFacultyId.Enabled = false;
                chkSearchFacultyChooseFromList.Enabled = false;
                cmbSearchFacultyChooseFromList.Enabled = false;
                //Check boxes
                chkSearchFaculty.Checked = false;
            }
            else
            {
                txtUpdateFacultyId.Enabled = false;
                chkUpdateFacultyChooseFromList.Enabled = false;
                cmbUpdateFacultyChooseFromList.Enabled = false;
                btnUpdateFaculty.Enabled = false;
            }
        }


        private void chkSearchFaculty_CheckedChanged(object sender, EventArgs e)
        {
            //Search
            if (chkSearchFaculty.Checked == true)
            {
                //Add checkbox
                chkAddFaculty.Checked = false;
                txtSearchFacultyId.Enabled = true;
                chkSearchFacultyChooseFromList.Enabled = true;
                cmbSearchFacultyChooseFromList.Enabled = false;
                //Update
                txtUpdateFacultyId.Enabled = false;
                chkUpdateFacultyChooseFromList.Enabled = false;
                cmbUpdateFacultyChooseFromList.Enabled = false;
                btnUpdateFaculty.Enabled = false;
                chkUpdateFaculty.Checked = false;
            }
            else
            {

                txtSearchFacultyId.Enabled = false;
                chkSearchFacultyChooseFromList.Enabled = false;
                cmbSearchFacultyChooseFromList.Enabled = false;
            }
        }
        #endregion



        #region "Add Faculty"

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            string fId = txtFacultyId.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string address = txtAddress.Text;
            string postalCode = txtPostalCode.Text;
            string fcon = txtContactNo.Text;
            string fsal = txtSalary.Text;
            if (fId != "" && fname != "" && lname != "" && address != "" && postalCode != "" && fcon != "" && fsal != "" && cmbGender.SelectedItem != null && dtpDoB.Value != null && cmbOffice.SelectedItem != null)
            {
                OleDbCommand com1 = new OleDbCommand();
                OleDbCommand com2 = new OleDbCommand();
                com1.Connection = con;
                com2.Connection = con;
                try
                {
                    com1.CommandText = "Insert into person(personId,fname,lname,dob,postalcode,gender,address) values(" + fId + ",'" + fname + "','" + lname + "'," + dtpDoB.Value.ToString("mm-dd-yyyy") + "," + postalCode + ",'" + cmbGender.SelectedItem.ToString() + "','" + address + "')";
                    com2.CommandText = "Insert into faculty(facultyid, office, salary, contactNo) values(" + fId + ",'" + cmbOffice.SelectedItem.ToString() + "'," + long.Parse(txtSalary.Text) + "," + long.Parse(txtContactNo.Text) + ")";
                    com1.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                }
                catch
                {
                    MessageBox.Show("Can not be added");
                }
            }
            else
            {
                MessageBox.Show("Enter Missing Values");
            }

        }


        private void txtFacultyId_Leave(object sender, EventArgs e)
        {
            string input = txtFacultyId.Text;
            try
            {
                long id = long.Parse(input);
                lblFacultyId.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtFacultyId.Focus();
                lblFacultyId.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {

            string input = txtFirstName.Text;
            int count = 0;
            if (input.Length > 3)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(input[i]) || input[i] == ' ')
                        count++;
                }
                if (count == input.Length)
                {
                    lblFirstName.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txtFirstName.Focus();
                    lblFirstName.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                txtFirstName.Focus();
                lblFirstName.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {

            string input = txtLastName.Text;
            int count = 0;
            if (input.Length > 3)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(input[i]) || input[i] == ' ')
                        count++;
                }
                if (count == input.Length)
                {
                    lblLastName.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txtLastName.Focus();
                    lblLastName.ForeColor = System.Drawing.Color.Red;
                }
            }

            else
            {
                txtLastName.Focus();
                lblLastName.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtContactNo_Leave(object sender, EventArgs e)
        {
            string input = txtContactNo.Text;
            try
            {
                long id = long.Parse(input);
                lblContactNo.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtContactNo.Focus();
                lblContactNo.ForeColor = System.Drawing.Color.Red;
            }

        }


        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                lblAddress.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblAddress.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void txtFacultyId_TextChanged(object sender, EventArgs e)
        {
            bool flag = false;
            string input = txtFacultyId.Text;
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
                    lblFacultyId.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblFacultyId.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                lblFacultyId.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            string input = txtPostalCode.Text;
            try
            {
                long id = long.Parse(input);
                lblPostalCode.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtPostalCode.Focus();
                lblPostalCode.ForeColor = System.Drawing.Color.Red;
            }


        }

        #endregion


        #region "Update Faculty"

        private void txtUpdateFacultyId_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtFacultyId.Enabled = false;
            cmbOffice.Items.Clear();
            cmbGender.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, f.salary as fSal, f.contactNo as fCon, f.office as foffice  FROM PERSON p, Faculty f where p.PersonId = f.facultyid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtUpdateFacultyId.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblUpdateFacultyId.ForeColor = System.Drawing.Color.Green;
                txtFacultyId.Text = reader["personnum"].ToString();
                txtFirstName.Text = reader["perfname"].ToString();
                txtLastName.Text = reader["perlname"].ToString();
                cmbOffice.Items.Add(reader["foffice"].ToString());
                cmbGender.Items.Add(reader["pergen"].ToString());
                cmbGender.SelectedIndex = 0;
                cmbOffice.SelectedIndex = 0;
                txtPostalCode.Text = reader["perpost"].ToString();
                txtAddress.Text = reader["peradd"].ToString();
                dtpDoB.Value = Convert.ToDateTime(reader["perdob"]);
                txtContactNo.Text = reader["fCon"].ToString();
                txtSalary.Text = reader["fSal"].ToString();

            }
            else
            {
                txtFacultyId.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                cmbGender.Items.Clear();
                txtAddress.Text = "";
                txtPostalCode.Text = "";
                txtSalary.Text = "";
                txtContactNo.Text = "";
                dtpDoB.Value = DateTime.Now;
                lblUpdateFacultyId.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void cmbUpdateFacultyChooseFromList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtFacultyId.Enabled = false;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtAddress.Enabled = true;
            txtPostalCode.Enabled = true;
            txtContactNo.Enabled = true;
            txtSalary.Enabled = true;

            cmbOffice.Items.Clear();
            cmbGender.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, f.salary as fSal, f.contactNo as fCon, f.office as foffice  FROM PERSON p, Faculty f where p.PersonId = f.facultyid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbUpdateFacultyChooseFromList.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblUpdateFacultyId.ForeColor = System.Drawing.Color.Green;
                txtFacultyId.Text = reader["personnum"].ToString();
                txtFirstName.Text = reader["perfname"].ToString();
                txtLastName.Text = reader["perlname"].ToString();
                cmbGender.Items.Add(reader["pergen"].ToString());
                cmbGender.SelectedIndex = 0;
                cmbOffice.Items.Add(reader["foffice"].ToString());
                cmbOffice.SelectedIndex = 0;
                txtPostalCode.Text = reader["perpost"].ToString();
                txtAddress.Text = reader["peradd"].ToString();
                dtpDoB.Value = Convert.ToDateTime(reader["perdob"]);
                txtContactNo.Text = reader["fCon"].ToString();
                txtSalary.Text = reader["fSal"].ToString();

            }
        }

        private void btnUpdateFaculty_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            OleDbCommand com2 = new OleDbCommand();
            com1.Connection = con;
            com2.Connection = con;
            if (txtUpdateFacultyId.Text != "" || cmbUpdateFacultyChooseFromList.SelectedItem != null)
            {
                try
                {
                    com1.CommandText = "Update Person set fname ='" + txtFirstName.Text + "', lname ='" + txtLastName.Text + "', address ='" + txtAddress.Text + "', postalcode = " + int.Parse(txtPostalCode.Text) + " where personid =" + int.Parse(txtFacultyId.Text) + "";
                    com2.CommandText = "Update Faculty set salary = " + long.Parse(txtSalary.Text) + ", contactNo = " + long.Parse(txtContactNo.Text) + " where facultyid =" + int.Parse(txtFacultyId.Text) + "";
                    com1.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                }
                catch
                {
                    MessageBox.Show("Can not be updated");
                }
            }
            else
            {
                MessageBox.Show("Enter Values");
            }

        }

        private void chkUpdateFacultyChooseFromList_CheckedChanged(object sender, EventArgs e)
        {
            cmbUpdateFacultyChooseFromList.Items.Clear();
            if (chkUpdateFacultyChooseFromList.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, faculty f where p.PersonId = f.facultyid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbUpdateFacultyChooseFromList.Items.Add(reader["personnum"].ToString());
                }
                //Update Checkbox
                txtUpdateFacultyId.Enabled = false;
                cmbUpdateFacultyChooseFromList.Enabled = true;
            }
            else
            {
                txtUpdateFacultyId.Enabled = true;
                cmbUpdateFacultyChooseFromList.Enabled = false;
            }
        }

        #endregion


        #region "Search Faculty"

        private void cmbSearchFacultyChooseFromList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkSearchFacultyChooseFromList_CheckedChanged(object sender, EventArgs e)
        {
            cmbSearchFacultyChooseFromList.Items.Clear();
            if (chkSearchFacultyChooseFromList.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, faculty f where p.PersonId = f.facultyid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbSearchFacultyChooseFromList.Items.Add(reader["personnum"].ToString());
                }
                //Search Checkbox
                txtSearchFacultyId.Enabled = false;
                cmbSearchFacultyChooseFromList.Enabled = true;
            }
            else
            {
                txtSearchFacultyId.Enabled = true;
                cmbSearchFacultyChooseFromList.Enabled = false;
            }
        }

        private void txtSearchFacultyId_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtFacultyId.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            txtPostalCode.Enabled = false;
            txtContactNo.Enabled = false;
            txtSalary.Enabled = false;

            cmbOffice.Items.Clear();
            cmbGender.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, f.salary as fSal, f.contactNo as fCon, f.office as foffice  FROM PERSON p, Faculty f where p.PersonId = f.facultyid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtSearchFacultyId.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblSearchFacultyId.ForeColor = System.Drawing.Color.Green;
                txtFacultyId.Text = reader["personnum"].ToString();
                txtFirstName.Text = reader["perfname"].ToString();
                txtLastName.Text = reader["perlname"].ToString();
                cmbOffice.Items.Add(reader["foffice"].ToString());
                cmbGender.Items.Add(reader["pergen"].ToString());
                cmbGender.SelectedIndex = 0;
                cmbOffice.SelectedIndex = 0;
                txtPostalCode.Text = reader["perpost"].ToString();
                txtAddress.Text = reader["peradd"].ToString();
                dtpDoB.Value = Convert.ToDateTime(reader["perdob"]);
                txtContactNo.Text = reader["fCon"].ToString();
                txtSalary.Text = reader["fSal"].ToString();

            }
            else
            {
                txtFacultyId.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                cmbGender.Items.Clear();
                txtAddress.Text = "";
                txtPostalCode.Text = "";
                txtSalary.Text = "";
                txtContactNo.Text = "";
                dtpDoB.Value = DateTime.Now;
                lblSearchFacultyId.ForeColor = System.Drawing.Color.Red;
            }
        }


        #endregion 



    }
}
