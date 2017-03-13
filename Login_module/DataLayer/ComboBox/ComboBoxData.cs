using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using AcademicManagementSystem.Common;
using AcademicManagementSystem.DataLayer.Person;

namespace AcademicManagementSystem.DataLayer.ComboBox
{
    public class ComboBoxData
    {


        #region 'Variables'
        private DatabaseConnection dbConnect = new DatabaseConnection();
        private String query = "";
        #endregion 

        #region 'public Methods'
        /// <summary>
        /// Get Gender Data for Combobox Listing
        /// </summary>
        /// <returns></returns>
        public List<ComboBoxDto> SelectGenderData()
        {
            List<ComboBoxDto> comboBoxDtoList = new List<ComboBoxDto>();
            comboBoxDtoList.Add(new ComboBoxDto("", ""));
            foreach (var gender in Enum.GetValues(typeof(EnumCommonClass.Gender)))
            {
                comboBoxDtoList.Add(new ComboBoxDto(gender.ToString(), gender.ToString()));
            }
            return comboBoxDtoList;
        }

        /// <summary>
        /// Get Faculty Member Data For Listing
        /// </summary>
        /// <returns></returns>
        public List<ComboBoxDto> SelectFacultyData()
        {

            List<ComboBoxDto> comboBoxDtoList = new List<ComboBoxDto>();
            comboBoxDtoList.Add(new ComboBoxDto("", ""));
            query = SelectFacultyMemberQuery();
            object reader = dbConnect.SelectCollectionDataReader(query);
            if(reader !=null && ((DataTable)reader).Rows.Count>0)
            foreach (DataRow row in ((DataTable)reader).Rows)
            {
                comboBoxDtoList.Add(new ComboBoxDto(row["Code"].ToString(), row["Description"].ToString()));                
            }
            return comboBoxDtoList;

        }

        /// <summary>
        /// Get Student Member Data For Listing
        /// </summary>
        /// <returns></returns>
        public List<ComboBoxDto> SelectStudentData()
        {

            List<ComboBoxDto> comboBoxDtoList = new List<ComboBoxDto>();
            comboBoxDtoList.Add(new ComboBoxDto("", ""));
            query = SelectStudentsQuery();
            object reader = dbConnect.SelectCollectionDataReader(query);
            if (reader != null && ((DataTable)reader).Rows.Count > 0)
                foreach (DataRow row in ((DataTable)reader).Rows)
                {
                    comboBoxDtoList.Add(new ComboBoxDto(row["Code"].ToString(), row["Description"].ToString()));
                }
            return comboBoxDtoList;

        }

        /// <summary>
        /// Get Department Member Data For Listing
        /// </summary>
        /// <returns></returns>
        public List<ComboBoxDto> SelectDepartmentData()
        {
            List<ComboBoxDto> comboBoxDtoList = new List<ComboBoxDto>();
            comboBoxDtoList.Add(new ComboBoxDto("", ""));
            query = SelectDepartmentQuery();
            object reader = dbConnect.SelectCollectionDataReader(query);
            if (reader != null && ((DataTable)reader).Rows.Count > 0)
                foreach (DataRow row in ((DataTable)reader).Rows)
                {
                    comboBoxDtoList.Add(new ComboBoxDto(row["Code"].ToString(), row["Description"].ToString()));
                }
            return comboBoxDtoList;

        }

        #endregion

        #region 'private Methods'

        private String SelectFacultyMemberQuery()
        {
            return @"SELECT p.personId AS Code
                            ,IIF(ISNULL([p.fname]), '', [p.fname]) +' '+ IIF(ISNULL([p.lname]), '', [p.lname]) + ' (' + Str(p.personId) + ')'   AS Description
                     FROM PERSON p
                    where   p.personType=1";
        }


        private String SelectStudentsQuery()
        {
            return @"SELECT p.personId AS Code
                            ,IIF(ISNULL([p.fname]), '', [p.fname]) +' '+ IIF(ISNULL([p.lname]), '', [p.lname]) + ' (' + Str(p.personId) + ')'   AS Description
                     FROM PERSON p
                    where   p.personType=2";
        }

        private String SelectDepartmentQuery()
        {
            return @"SELECT
						  d.DeptId AS Code
                         ,IIF(ISNULL([d.dname]), '', [d.dname])     AS Description
                     FROM Department d  ";
        }

        #endregion 


    }
}
