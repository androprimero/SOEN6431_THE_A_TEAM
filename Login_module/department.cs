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
    public partial class department : Form
    {
        public department()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection();
        

        private void lblDepartmentname_Click(object sender, EventArgs e)
        {

        }

        private void txtDeptLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void department_Load(object sender, EventArgs e)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string dbDir = Directory.GetParent(Directory.GetParent(currentDir).FullName).FullName;
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbDir + @"\\university.accdb;Persist Security Info=False";
            con.Open();
            cmbDeptFacultyId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeptUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeptDeleteChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDeptFacultyFirstName.Enabled = false;
            txtDeptFacultyLastName.Enabled = false;
            btnAddDepartment.Enabled = false;
            //Update
            txtDepartmentUpdateId.Enabled = false;
            chkDeptUpdateChooseFromList.Enabled = false;
            cmbDeptUpdate.Enabled = false;
            btnDepartmentUpdate.Enabled = false;
            //Search
            txtDeptSearchId.Enabled = false;
            chkDeptmentSearchChoose.Enabled = false;
            cmbSearchDept.Enabled = false;
            //Delete
            txtDeptSearchDeptid.Enabled = false;
            cmbDeptDeleteChoose.Enabled = false;
            btnDepartmentDelete.Enabled = false;
            chkDeptDeleteChoose.Enabled = false;
        }

        private void chkUpdateDept_CheckedChanged(object sender, EventArgs e)
        {
            //Update
            if (chkUpdateDept.Checked == true)
            {
                txtDeptId.Enabled = true;
                txtDeptName.Enabled = true;
                txtDeptLocation.Enabled = true;
                //Add checkbox
                chkAddDepartmnt.Checked = false;
                chkDeptUpdateChooseFromList.Enabled = true;
                cmbDeptUpdate.Enabled = false;
                btnDepartmentUpdate.Enabled = true;
                //Search
                txtDeptSearchId.Enabled = false;
                chkDeptmentSearchChoose.Enabled = false;
                cmbSearchDept.Enabled = false;
                //Delete
                txtDeptSearchDeptid.Enabled = false;
                cmbDeptDeleteChoose.Enabled = false;
                btnDepartmentDelete.Enabled = false;
                chkDeptDeleteChoose.Enabled = false;
                txtDepartmentUpdateId.Enabled = true;
                //Check boxes
                chkSearchDept.Checked = false;
                chkDeleteDept.Checked = false;
            }
            else
            {
                chkDeptUpdateChooseFromList.Enabled = false;
                cmbDeptUpdate.Enabled = false;
                btnDepartmentUpdate.Enabled = false;
            }
        }

        private void chkSearchDept_CheckedChanged(object sender, EventArgs e)
        {
            //Search
            if (chkSearchDept.Checked == true)
            {

                //Add checkbox
                chkAddDepartmnt.Checked = false;
                txtDeptSearchId.Enabled = true;
                chkDeptmentSearchChoose.Enabled = true;
                cmbSearchDept.Enabled = false;
                //Update
                chkDeptUpdateChooseFromList.Enabled = false;
                cmbDeptUpdate.Enabled = false;
                btnDepartmentUpdate.Enabled = false;
                //Delete  
                txtDeptSearchDeptid.Enabled = false;
                cmbDeptDeleteChoose.Enabled = false;
                btnDepartmentDelete.Enabled = false;
                chkDeptDeleteChoose.Enabled = false;
                //Check boxes
                chkUpdateDept.Checked = false;
                chkDeleteDept.Checked = false;
                txtDepartmentUpdateId.Enabled = false;
            }
            else
            {
                txtDeptSearchId.Enabled = false;
                chkDeptmentSearchChoose.Enabled = false;
                cmbSearchDept.Enabled = false;
            }
        }

        private void chkDeleteDept_CheckedChanged(object sender, EventArgs e)
        {
            //Delete
            if (chkDeleteDept.Checked == true)
            {
                txtDeptId.Enabled = true;
                txtDeptName.Enabled = true;
                txtDeptLocation.Enabled = true;

                txtDepartmentUpdateId.Enabled = false;

                //Add checkbox
                chkAddDepartmnt.Checked = false;
                txtDeptSearchDeptid.Enabled = true;
                cmbDeptDeleteChoose.Enabled = false;
                btnDepartmentDelete.Enabled = true;
                chkDeptDeleteChoose.Enabled = true;
                //Update
                chkDeptUpdateChooseFromList.Enabled = false;
                cmbDeptUpdate.Enabled = false;
                btnDepartmentUpdate.Enabled = false;
                //Search
                txtDeptSearchId.Enabled = false;
                chkDeptmentSearchChoose.Enabled = false;
                cmbSearchDept.Enabled = false;
                //check boxes
                chkUpdateDept.Checked = false;
                chkSearchDept.Checked = false;
            }
            else
            {
                txtDeptSearchDeptid.Enabled = false;
                cmbDeptDeleteChoose.Enabled = false;
                btnDepartmentDelete.Enabled = false;
                chkDeptDeleteChoose.Enabled = false;
            }
        }

        private void chkDeptUpdateChooseFromList_CheckedChanged(object sender, EventArgs e)
        {
            cmbDeptUpdate.Items.Clear();
            if (chkDeptUpdateChooseFromList.Checked == true)
            {
                //Check box with database
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select deptid from department";
                OleDbDataReader dread = com.ExecuteReader();
                while (dread.Read())
                {
                    cmbDeptUpdate.Items.Add(dread["deptid"].ToString());
                }
                txtDepartmentUpdateId.Enabled = false;
                //Update Checkbox
                cmbDeptUpdate.Enabled = true;
            }
            else
            {
                txtDepartmentUpdateId.Enabled = true;
                cmbDeptUpdate.Enabled = false;
            }
        }

        private void chkDeptmentSearchChoose_CheckedChanged(object sender, EventArgs e)
        {
            cmbSearchDept.Items.Clear();
            if (chkDeptmentSearchChoose.Checked == true)
            {
                //Check box with database
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select deptid from department";
                OleDbDataReader dread = com.ExecuteReader();
                while (dread.Read())
                {
                    cmbSearchDept.Items.Add(dread["deptid"].ToString());
                }
                //Search Checkbox
                txtDeptSearchId.Enabled = false;
                cmbSearchDept.Enabled = true;
            }
            else
            {
                txtDeptSearchId.Enabled = true;
                cmbSearchDept.Enabled = false;
            }
        }

        private void chkDeptDeleteChoose_CheckedChanged(object sender, EventArgs e)
        {
            cmbDeptDeleteChoose.Items.Clear();
            if (chkDeptDeleteChoose.Checked == true)
            {
                //Check box with database
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select deptid from department";
                OleDbDataReader dread = com.ExecuteReader();
                while (dread.Read())
                {
                    cmbDeptDeleteChoose.Items.Add(dread["deptid"].ToString());
                }
                //Delete Checkbox
                txtDeptSearchDeptid.Enabled = false;
                cmbDeptDeleteChoose.Enabled = true;
            }
            else
            {
                txtDeptSearchDeptid.Enabled = true;
                cmbDeptDeleteChoose.Enabled = false;
            }
        }

        private void txtDeptId_Leave(object sender, EventArgs e)
        {
            string input = txtDeptId.Text;
            try
            {
                long id = long.Parse(input);
                lblDepartmentId.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtDeptId.Focus();
                lblDepartmentId.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtDeptName_Leave(object sender, EventArgs e)
        {
            string input = txtDeptName.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (count == input.Length)
            {
                lblDepartmentname.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtDeptName.Focus();
                lblDepartmentname.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtDeptLocation_Leave(object sender, EventArgs e)
        {
            string input = txtDeptLocation.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (count == input.Length)
            {
                lblLocation.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtDeptLocation.Focus();
                lblLocation.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtDepartmentUpdateId_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtDeptId.Enabled = false;
            cmbDeptFacultyId.Items.Clear();
            if (txtDepartmentUpdateId.Text != "")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
                com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
                OleDbDataReader Cread = com1.ExecuteReader();
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtDepartmentUpdateId.Text == fread["dept"].ToString())
                    {
                        cmbDeptFacultyId.Items.Add(fread["fid"].ToString());
                        txtDeptId.Text = fread["dept"].ToString();
                        txtDeptName.Text = fread["dename"].ToString();
                        txtDeptLocation.Text = fread["dloc"].ToString();
                        cmbDeptFacultyId.SelectedIndex = 0;
                        while (Cread.Read())
                        {
                            if (fread["dept"].ToString() == Cread["classDept"].ToString())
                            { 
                                txtDeptClass.Text = Cread["cName"].ToString();
                                break;
                            }
                        }
                        lblDepartmentIdDept.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtDeptId.Text = "";
                        txtDeptName.Text = "";
                        txtDeptLocation.Text = "";
                        cmbDeptFacultyId.Items.Clear();
                        txtDeptFacultyFirstName.Text = "";
                        txtDeptFacultyLastName.Text = "";
                        txtDeptClass.Text = "";
                        lblDepartmentIdDept.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void txtDeptSearchId_TextChanged(object sender, EventArgs e)
        {
            txtDeptId.Enabled = false;
            txtDeptName.Enabled = false;
            txtDeptLocation.Enabled = false;
            txtDeptClass.Enabled = false;
            cmbDeptFacultyId.Items.Clear();
            if (txtDeptSearchId.Text != "")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
            
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
                com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
                OleDbDataReader Cread = com1.ExecuteReader();
            
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtDeptSearchId.Text == fread["dept"].ToString())
                    {
                        cmbDeptFacultyId.Items.Add(fread["fid"].ToString());
                        txtDeptId.Text = fread["dept"].ToString();
                        txtDeptName.Text = fread["dename"].ToString();
                        txtDeptLocation.Text = fread["dloc"].ToString();
                        while (Cread.Read())
                        {
                            if (fread["dept"].ToString() == Cread["classDept"].ToString())
                            {
                                txtDeptClass.Text = Cread["cName"].ToString();
                                break;
                            }
                        }
                        cmbDeptFacultyId.SelectedIndex = 0;
                        lblDepartmentIdDept.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtDeptId.Text = "";
                        txtDeptName.Text = "";
                        txtDeptLocation.Text = "";
                        cmbDeptFacultyId.Items.Clear();
                        txtDeptFacultyFirstName.Text = "";
                        txtDeptFacultyLastName.Text = "";

                        txtDeptClass.Text = "";
                        lblDepartmentIdDept.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void txtDeptSearchDeptid_TextChanged(object sender, EventArgs e)
        {
            txtDeptId.Enabled = false;
            txtDeptName.Enabled = false;
            txtDeptLocation.Enabled = false;

            txtDeptClass.Enabled = false;
            cmbDeptFacultyId.Items.Clear();
            if (txtDeptSearchDeptid.Text != "")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
            
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
                com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
                OleDbDataReader Cread = com1.ExecuteReader();
            
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtDeptSearchDeptid.Text == fread["dept"].ToString())
                    {
                        cmbDeptFacultyId.Items.Add(fread["fid"].ToString());
                        txtDeptId.Text = fread["dept"].ToString();
                        txtDeptName.Text = fread["dename"].ToString();
                        txtDeptLocation.Text = fread["dloc"].ToString();
                        while (Cread.Read())
                        {
                            if (fread["dept"].ToString() == Cread["classDept"].ToString())
                            {
                                txtDeptClass.Text = Cread["cName"].ToString();
                                break;
                            }
                        }
                        cmbDeptFacultyId.SelectedIndex = 0;
                        lblDepartmentIdDept.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtDeptId.Text = "";
                        txtDeptName.Text = "";
                        txtDeptLocation.Text = "";
                        cmbDeptFacultyId.Items.Clear();
                        txtDeptFacultyFirstName.Text = "";
                        txtDeptFacultyLastName.Text = "";

                        txtDeptClass.Text = "";
                        lblDepartmentIdDept.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void chkAddDepartmnt_CheckedChanged(object sender, EventArgs e)
        {
            cmbDeptFacultyId.Items.Clear();
            if (chkAddDepartmnt.Checked == true)
            {
                txtDeptClass.Enabled = true;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select facultyid from faculty where facultyid NOT IN (select facultyid from department) ";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    cmbDeptFacultyId.Items.Add(fread["facultyid"].ToString());
                }
                txtDeptId.Text = "";
                txtDeptName.Text = "";
                txtDeptLocation.Text = "";
                txtDeptId.Enabled = true;
                txtDeptName.Enabled = true;
                txtDeptLocation.Enabled = true;
                
                chkUpdateDept.Checked = false;
                chkSearchDept.Checked = false;
                chkDeleteDept.Checked = false;
                btnAddDepartment.Enabled = true;
            }
            else
            {
                btnAddDepartment.Enabled = false;
            }

        }

        private void txtDeptId_TextChanged(object sender, EventArgs e)
        {
            bool flag = false;
            string input = txtDeptId.Text;
            try
            {
                int id = int.Parse(input);
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT deptid FROM Department";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    if (id.ToString() == reader["deptid"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    lblDepartmentId.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblDepartmentId.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                lblDepartmentId.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cmbDeptFacultyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = "Select  f.facultyid as fId, p.fname as pfname, p.lname as plname from faculty f, person p where f.facultyid = p.personid";
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (fread["fId"].ToString() == cmbDeptFacultyId.SelectedItem.ToString())
                {
                    txtDeptFacultyFirstName.Text = fread["pfname"].ToString();
                    txtDeptFacultyLastName.Text = fread["plname"].ToString();
                    break;
                }
            }
        }

        private void cmbDeptUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDeptFacultyId.Items.Clear();
            txtDeptId.Enabled = false;
            
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            
            com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
            com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
            OleDbDataReader Cread = com1.ExecuteReader();
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (cmbDeptUpdate.SelectedItem.ToString() == fread["dept"].ToString())
                {
                    cmbDeptFacultyId.Items.Add(fread["fid"].ToString());
                    txtDeptId.Text = fread["dept"].ToString();
                    txtDeptName.Text = fread["dename"].ToString();
                    while (Cread.Read())
                    {
                        if (fread["dept"].ToString() == Cread["classDept"].ToString())
                        {
                            txtDeptClass.Text = Cread["cName"].ToString();
                            break;
                        }
                    }
                    txtDeptLocation.Text = fread["dloc"].ToString();
                    break;
                }
            }
            cmbDeptFacultyId.SelectedIndex = 0;
        }

        private void cmbSearchDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDeptFacultyId.Items.Clear();
            txtDeptId.Enabled = false;
            txtDeptName.Enabled = false;
            txtDeptLocation.Enabled = false;
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            
            com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
            com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
            OleDbDataReader Cread = com1.ExecuteReader();
            
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (cmbSearchDept.SelectedItem.ToString() == fread["dept"].ToString())
                {
                    cmbDeptFacultyId.Items.Add(fread["fid"].ToString());
                    txtDeptId.Text = fread["dept"].ToString();
                    txtDeptName.Text = fread["dename"].ToString();
                    txtDeptLocation.Text = fread["dloc"].ToString();
                    while (Cread.Read())
                    {
                        if (fread["dept"].ToString() == Cread["classDept"].ToString())
                        {
                            txtDeptClass.Text = Cread["cName"].ToString();
                            break;
                        }
                    }
                    break;
                }
            }
            cmbDeptFacultyId.SelectedIndex = 0;
        }

        private void cmbDeptDeleteChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDeptFacultyId.Items.Clear();
            txtDeptId.Enabled = false;
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            
            com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
            com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
            OleDbDataReader Cread = com1.ExecuteReader();
            
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (cmbDeptDeleteChoose.SelectedItem.ToString() == fread["dept"].ToString())
                {
                    cmbDeptFacultyId.Items.Add(fread["fid"].ToString());
                    txtDeptId.Text = fread["dept"].ToString();
                    txtDeptName.Text = fread["dename"].ToString();
                    txtDeptLocation.Text = fread["dloc"].ToString();
                    while (Cread.Read())
                    {
                        if (fread["dept"].ToString() == Cread["classDept"].ToString())
                        {
                            txtDeptClass.Text = Cread["cName"].ToString();
                            break;
                        }
                    }
                    break;
                }
            }
            cmbDeptFacultyId.SelectedIndex = 0;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            string id = txtDeptId.Text;
            string dname = txtDeptName.Text;
            string dloc = txtDeptLocation.Text;
            string className = txtDeptClass.Text;
            object facultyId = cmbDeptFacultyId.SelectedItem;
            if (id != "" && dname != "" && dloc != "" && facultyId != null && className !="")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Insert into Department(deptid, dname, location, facultyid) values("+int.Parse(id)+",'"+dname+"','"+dloc+"',"+int.Parse(facultyId.ToString())+")";
                com1.CommandText = "Insert into class(className,deptid) values('"+className+"',"+int.Parse(id)+")";
                com.ExecuteNonQuery();
                com1.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Enter Values");
            }
        }

        private void btnDepartmentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDeptName.Text != "" && txtDeptLocation.Text != "" && txtDeptClass.Text != "")
                {
                    OleDbCommand com1 = new OleDbCommand();
                    com1.Connection = con;
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    com1.CommandText = "Update class set className = '"+txtDeptClass.Text+"' where deptid =" + int.Parse(txtDeptId.Text) + "";
                    com.CommandText = "Update department set dname = '" + txtDeptName.Text + "', location ='" + txtDeptLocation.Text + "' where deptid =" + int.Parse(txtDeptId.Text) + "";
                    com.ExecuteNonQuery();
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                }
            }
            catch
            {
                MessageBox.Show("Can not be updated");
            }
        }

        private void btnDepartmentDelete_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            OleDbCommand com2 = new OleDbCommand();
            com2.Connection = con;
            OleDbCommand com3 = new OleDbCommand();
            com3.Connection = con;
            OleDbCommand com4 = new OleDbCommand();
            com4.Connection = con;
            OleDbCommand com5 = new OleDbCommand();
            com5.Connection = con;
            OleDbCommand com6 = new OleDbCommand();
            com6.Connection = con;
            bool flag = false;
            if (txtDeptSearchDeptid.Enabled == true && cmbDeptDeleteChoose.Enabled == false)
            {
                try
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    com2.CommandText = "Delete from course where deptid = "+int.Parse(txtDeptId.Text)+"";
                    com1.CommandText = "Delete from Student where deptid =" +int.Parse(txtDeptId.Text)+"";
                    com5.CommandText = "Delete from class where deptid =" + int.Parse(txtDeptId.Text) + "";
                    com.CommandText = "Delete from department where deptid = " + int.Parse(txtDeptId.Text) + "";
                    com5.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    com1.ExecuteNonQuery();
                    com.ExecuteNonQuery();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
                if (flag)
                {
                    txtDeptId.Text = "";
                    txtDeptName.Text = "";
                    txtDeptLocation.Text = "";
                    txtDeptFacultyFirstName.Text = "";
                    txtDeptFacultyLastName.Text = "";
                    txtDeptClass.Text = "";
                    cmbDeptFacultyId.Items.Clear(); 
                    MessageBox.Show("Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Can not be Deleted");
                }
            }
            else
            {
                try
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    com4.CommandText = "Delete from course where deptid = " + int.Parse(cmbDeptDeleteChoose.SelectedItem.ToString()) + "";
                    com3.CommandText = "Delete from Student where deptid =" + int.Parse(cmbDeptDeleteChoose.SelectedItem.ToString()) + "";
                    com6.CommandText = "Delete from class where deptid =" + int.Parse(cmbDeptDeleteChoose.SelectedItem.ToString()) + "";
                    com.CommandText = "Delete from department where deptid = " + int.Parse(cmbDeptDeleteChoose.SelectedItem.ToString()) + "";
                    com6.ExecuteNonQuery();
                    com4.ExecuteNonQuery();
                    com3.ExecuteNonQuery();
                    com.ExecuteNonQuery();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
                if (flag)
                {
                    txtDeptId.Text = "";
                    txtDeptName.Text = "";
                    txtDeptLocation.Text = "";
                    txtDeptFacultyFirstName.Text = "";
                    txtDeptFacultyLastName.Text = "";
                    txtDeptClass.Text = "";
                    cmbDeptFacultyId.Items.Clear();
                    MessageBox.Show("Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Can not be Deleted");
                }
            }
        }

        private void txtDeptClass_MouseLeave(object sender, EventArgs e)
        {
            string input = txtDeptClass.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (count == input.Length)
            {
                lblDepartmentClass.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtDeptClass.Focus();
                lblDepartmentClass.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtDeptFacultyLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
