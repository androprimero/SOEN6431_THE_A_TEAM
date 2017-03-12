using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcademicManagementSystem.DataLayer.ComboBox;

namespace AcademicManagementSystem.Common
{
    public class ComboBoxBinding
    {
        ComboBoxData comboBoxData = new ComboBoxData();

        /// <summary>
        /// Bind gender ComboBox 
        /// </summary>
        /// <param name="cmb"></param>
        public void LoadGenderComboBox(ComboBox cmb)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = comboBoxData.SelectGenderData();
            cmb.DataSource = bindingSource.DataSource;
            cmb.DisplayMember = "Description";
            cmb.ValueMember = "Code";
        }

        /// <summary>
        /// Bind gender ComboBox 
        /// </summary>
        /// <param name="cmb"></param>
        public void LoadDepartmentComboBox(ComboBox cmb)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = comboBoxData.SelectDepartmentData();
            cmb.DataSource = bindingSource.DataSource;
            cmb.DisplayMember = "Description";
            cmb.ValueMember = "Code";
        }

        /// <summary>
        /// Bind gender ComboBox 
        /// </summary>
        /// <param name="cmb"></param>
        public void LoadFacultyComboBox(ComboBox cmb)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = comboBoxData.SelectFacultyData();
            cmb.DataSource = bindingSource.DataSource;
            cmb.DisplayMember = "Description";
            cmb.ValueMember = "Code";
        }

        /// <summary>
        /// Bind gender ComboBox 
        /// </summary>
        /// <param name="cmb"></param>
        public void LoadStudentComboBox(ComboBox cmb)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = comboBoxData.SelectStudentData();
            cmb.DataSource = bindingSource.DataSource;
            cmb.DisplayMember = "Description";
            cmb.ValueMember = "Code";
        }

    }
}
