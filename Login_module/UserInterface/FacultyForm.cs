using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademicManagementSystem.Common;
using AcademicManagementSystem.DataLayer.Faculty;
using AcademicManagementSystem.DataLayer.Person;

namespace AcademicManagementSystem.UserInterface
{
    public partial class FacultyForm : Form
    {
        ComboBoxBinding comboBoxBinding = new ComboBoxBinding();
        CommonFunctions commonFunctions = new CommonFunctions();
        FacultyDto facultyMainObject;
        public FacultyForm()
        {
            InitializeComponent();
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            commonFunctions.ClearInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess);
            loadComboBox();
            controlState();
            txtContactNo.Focus();
        }

        #region 'Common  Methods'

        private void controlState()
        {
            if (rdAddFaculty.Checked)
            {

                cmbOffice.Enabled = true;
                pnlSearch.Enabled = false;
                pnlForm.Enabled = true;
            }
            else if (rdUpdate.Checked)
            {
                pnlSearch.Enabled = true;
                cmbOffice.Enabled = false;
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
        }

        private void fillFacultyForm()
        {

            lblError.Text = "";
            if (facultyMainObject.Person != null)
            {
                txtFacultyId.Text = facultyMainObject.FacultyId.ToString();
                txtFirstName.Text = facultyMainObject.Person.Firstname;
                txtLastName.Text = facultyMainObject.Person.Lastname;
                cmbGender.SelectedValue = facultyMainObject.Person.Gender;
                cmbOffice.SelectedValue = facultyMainObject.Office;
                txtPostalCode.Text = facultyMainObject.Person.PostalCode.ToString();
                txtAddress.Text = facultyMainObject.Person.Address;
                dtpDoB.Value = facultyMainObject.Person.DateOfBirth;
                txtContactNo.Text = facultyMainObject.ContactNo.ToString();
                txtSalary.Text = facultyMainObject.Salary.ToString();
            }
            else
            {
                lblError.Text = @"Ooops!!! we couldn't find the faculty member?";
            }
        }

        private void fillFacultyDto()
        {

            if (rdAddFaculty.Checked && (String.IsNullOrEmpty(txtFacultyId.Text.Trim())))
            {
                facultyMainObject = new FacultyDto();
                PersonDto personDto = new PersonDto();
                personDto.Firstname = txtFirstName.Text.Trim();
                personDto.Lastname = txtLastName.Text.Trim();
                personDto.Gender = cmbGender.SelectedValue.ToString();
                personDto.PostalCode = commonFunctions.ValidateInteger(txtPostalCode.Text);
                personDto.Address = txtAddress.Text;
                personDto.DateOfBirth = dtpDoB.Value.Date;
                personDto.PersonType = (int)EnumCommonClass.PersonType.Faculty;
                facultyMainObject.Person = personDto;
            }
            else
            {
                facultyMainObject.Person.Firstname = txtFirstName.Text.Trim();
                facultyMainObject.Person.Lastname = txtLastName.Text.Trim();
                facultyMainObject.Person.Gender = cmbGender.SelectedValue.ToString();
                facultyMainObject.Person.PostalCode = commonFunctions.ValidateInteger(txtPostalCode.Text);
                facultyMainObject.Person.Address = txtAddress.Text;
                facultyMainObject.Person.DateOfBirth = dtpDoB.Value.Date;
            }

            facultyMainObject.Office = cmbOffice.SelectedValue.ToString();
            facultyMainObject.ContactNo = commonFunctions.ValidateLongInteger(txtContactNo.Text);
            facultyMainObject.Salary = commonFunctions.ValidateLongInteger(txtSalary.Text);

        }

        private bool validateRequiredFields()
        {
            lblError.Text = "";
            bool isValid = true;
            string errorMessage = "Whoops!!! It seems you missed filling :\n{0}";
            string errorWrongOperationMessage = "Ooops!!! You missed searching for the faculty you want to update ";

            if (rdUpdate.Checked && String.IsNullOrEmpty(txtFacultyId.Text.Trim()))
            {
                commonFunctions.LoadInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess, true, errorWrongOperationMessage);
                return false;
            }
            string missingFields = "";
            if (String.IsNullOrEmpty(txtFirstName.Text.Trim()))
                missingFields += "- First Name \n";
            if (String.IsNullOrEmpty(txtLastName.Text.Trim()))
                missingFields += "- Last Name \n";
            if (String.IsNullOrEmpty(txtContactNo.Text.Trim()))
                missingFields += "- Contact # \n";
            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
                missingFields += "- Address \n";
            if (String.IsNullOrEmpty(txtPostalCode.Text.Trim()))
                missingFields += "- Postal Code \n";

            if (!String.IsNullOrEmpty(missingFields))
            {
                isValid = false;
                string message= String.Format(errorMessage, missingFields);
                commonFunctions.LoadInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess, true, message);
            }

            return isValid;
        }

        #endregion

        #region "Operation Panel"

        private void rdOperation_CheckedChanged(object sender, EventArgs e)
        {
            resetFormControls();
            resetSearchControls();
            controlState();
            commonFunctions.ClearInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess);
        }

        #endregion

        #region "Search"

        private void chkSearchFacultyChooseFromList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchFacultyChooseFromList.Checked)
            {
                txtSearchFacultyId.Text = "";
                txtSearchFacultyId.Enabled = false;
                comboBoxBinding.LoadFacultyComboBox(cmbSearchFacultyChooseFromList);
                cmbSearchFacultyChooseFromList.Enabled = true;
            }
            else
            {
                txtSearchFacultyId.Text = "";
                cmbSearchFacultyChooseFromList.SelectedValue = "";
                txtSearchFacultyId.Enabled = true;
                cmbSearchFacultyChooseFromList.Enabled = false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            commonFunctions.ClearInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess);
            string code = "";
            lblError.Text = "";
            if (chkSearchFacultyChooseFromList.Checked)
                code = cmbSearchFacultyChooseFromList.SelectedValue.ToString();
            else
                code = txtSearchFacultyId.Text.Trim();
            if (!String.IsNullOrEmpty(code.Trim()))
            {
                DataLayer.Faculty.FacultyData facultyData = new DataLayer.Faculty.FacultyData();
                facultyMainObject = facultyData.SelectFacultyById(int.Parse(code));
                fillFacultyForm();
            }
            else
            {
                string message = "Sorry!!! we are currently out of fortune-tellers can you please tell us what you are searching for?";
                commonFunctions.LoadInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess, true, message);

            }
        }

        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            commonFunctions.ClearInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess);
            if (validateRequiredFields())
            {
                fillFacultyDto();
                BusinessLayer.Faculty facultyBusinessLayer = new BusinessLayer.Faculty();

                //Add New Record
                if (String.IsNullOrEmpty(txtFacultyId.Text.Trim()))
                {
                    long insertId = facultyBusinessLayer.CreateFaculty(facultyMainObject);
                    if (insertId > 0)
                    {
                        facultyMainObject.Person.PersonId = facultyMainObject.FacultyId = insertId;
                        fillFacultyForm();
                        string message = "Wow!!! Faculty members have been increased by one";
                        commonFunctions.LoadInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess, false, message);
                    }
                    else
                    {
                        string message = "Ooops!!! The System is currenty angry and doesn't want to save new records";
                        commonFunctions.LoadInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess, true, message);
                    }
                }
                ///Update Records
                else
                {
                    if (facultyBusinessLayer.EditFaculty(facultyMainObject) >= 0)
                    {
                        string message = "Good Job!!! Faculty is up to date";
                        fillFacultyForm();
                        commonFunctions.LoadInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess, false, message);
                    }
                    else
                    {
                        string message = "Whoops!!! The System is currenty angry and doesn't want to update faculty members";
                        commonFunctions.LoadInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess, true, message);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            commonFunctions.ClearInfoMessagePanel(imgWow, imgOops, lblError, lblSuccess);
            resetFormControls();
        }


    }
}
