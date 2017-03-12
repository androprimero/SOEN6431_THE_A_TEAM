using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademicManagementSystem.Common;
using AcademicManagementSystem.DataLayer;
using AcademicManagementSystem.DataLayer.Faculty;

namespace AcademicManagementSystem.UserInterface
{
    public partial class FacultyForm : Form
    {
        ComboBoxBinding comboBoxBinding = new ComboBoxBinding();

        public FacultyForm()
        {
            InitializeComponent();
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            loadComboBox();
            controlState();
        }

        #region 'Common  Methods'

        private void controlState()
        {
            if (rdAddFaculty.Checked)
            {
                pnlSearch.Enabled = false;
                pnlForm.Enabled = true;
            }
            else if (rdUpdate.Checked)
            {
                pnlSearch.Enabled = true;
                pnlForm.Enabled = true;
            }
            else
            {
                pnlSearch.Enabled = true;
                pnlForm.Enabled = false;
            }

        }

        private void resetFormControls()
        {
            txtFacultyId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbGender.SelectedValue = "";
            txtAddress.Text = "";
            txtPostalCode.Text = "";
            txtSalary.Text = "";
            txtContactNo.Text = "";
            dtpDoB.Value = DateTime.Now;
        }

        private void resetSearchControls()
        {
            txtSearchFacultyId.Text = "";
            cmbSearchFacultyChooseFromList.SelectedValue = "";
            txtSearchFacultyId.Enabled = true;
            chkSearchFacultyChooseFromList.Checked = false;
            cmbSearchFacultyChooseFromList.Enabled = false;
        }

        private void loadComboBox()
        {
            comboBoxBinding.LoadGenderComboBox(cmbGender);
            comboBoxBinding.LoadDepartmentComboBox(cmbOffice);
            comboBoxBinding.LoadFacultyComboBox(cmbSearchFacultyChooseFromList);
        }

        private void fillFaculty(FacultyDto faculty)
        {

            lblError.Text = "";
            if (faculty.Person != null)
            {
                txtFacultyId.Text = faculty.Person.PersonCode;
                txtFirstName.Text = faculty.Person.Firstname;
                txtLastName.Text = faculty.Person.Lastname;
                cmbGender.SelectedValue = faculty.Person.Gender;
                cmbOffice.SelectedText = faculty.Office;
                txtPostalCode.Text = faculty.Person.PostalCode.ToString();
                txtAddress.Text = faculty.Person.Address;
                dtpDoB.Value = faculty.Person.DateOfBirth;
                txtContactNo.Text = faculty.ContactNo.ToString();
                txtSalary.Text = faculty.Salary.ToString();
            }
            else
            {
                lblError.Text = @"Ooops!!! we couldn't find the faculty member?";
            }
        }

        #endregion

        #region "Operation Panel"

        private void rdOperation_CheckedChanged(object sender, EventArgs e)
        {
            resetFormControls();
            resetSearchControls();
            controlState();
        }

        #endregion

        #region "Search"

        private void chkSearchFacultyChooseFromList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchFacultyChooseFromList.Checked)
            {
                txtSearchFacultyId.Text = "";
                txtSearchFacultyId.Enabled = false;
                cmbSearchFacultyChooseFromList.Enabled = true;
            }
            else
            {
                txtSearchFacultyId.Text = "";
                txtSearchFacultyId.Enabled = true;
                cmbSearchFacultyChooseFromList.Enabled = false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string code = "";
            lblError.Text = "";
            if (chkSearchFacultyChooseFromList.Checked)
                code = cmbSearchFacultyChooseFromList.SelectedValue.ToString();
            else
                code = txtSearchFacultyId.Text.Trim();
            if (!String.IsNullOrEmpty(code.Trim()))
            {
                DataLayer.Faculty.FacultyData facultyData = new DataLayer.Faculty.FacultyData();
                DataLayer.Faculty.FacultyDto facultyDto = facultyData.SelectFacultyByCode(code);
                fillFaculty(facultyDto);
            }
            else
            {
                lblError.Text = @"Ooops!!! we are currently out of fortune-tellers can you please tell us what you are searching for?";
            }
        }

        #endregion

    }
}
