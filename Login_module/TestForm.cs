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

        private void button1_Click(object sender, EventArgs e)
        {
            DataLayer.Person.PersonData personData = new DataLayer.Person.PersonData();
            DataLayer.Person.PersonDto person = new DataLayer.Person.PersonDto("321456", "FirstName1", "LastName1", DateTime.Parse("1990-10-01").Date, 123, "Male", "Address", 2);
            int id = personData.InsertPerson(person);
        }
    }
}
