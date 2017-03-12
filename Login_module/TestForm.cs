using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademicManagementSystem.Common;

namespace AcademicManagementSystem
{
    public partial class TestForm : Form
    {
        ComboBoxBinding comboBoxBinding = new ComboBoxBinding();

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
 
            comboBoxBinding.LoadGenderComboBox(cmbGender);
            comboBoxBinding.LoadDepartmentComboBox(cmbDepartment);
            comboBoxBinding.LoadFacultyComboBox(cmbFaculty);
            comboBoxBinding.LoadStudentComboBox(cmbStudent);
        }
    }
}
