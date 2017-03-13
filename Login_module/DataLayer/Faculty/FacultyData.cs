using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using AcademicManagementSystem.Common;
using AcademicManagementSystem.DataLayer.Person;

namespace AcademicManagementSystem.DataLayer.Faculty
{
    public class FacultyData
    {

        #region 'Variables'
        private DatabaseConnection dbConnect = new DatabaseConnection();
        private String query = "";
        #endregion 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="facultyId"></param>
        /// <returns></returns>
        public FacultyDto SelectFacultyById(int facultyId)
        {
            FacultyDto facultyDto;
            try
            {
                facultyDto = new FacultyDto();
                query = SelectFacultyByCodeQuery(facultyId);
                OleDbDataReader reader = dbConnect.SelectDataReader(query);

                if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                {
                    facultyDto.FacultyId = reader.GetInt32(0);
                    facultyDto.Office = reader.GetString(1);
                    facultyDto.Salary = reader.GetInt32(2);
                    facultyDto.ContactNo = reader.GetInt32(3);
                    //Person Info
                    PersonData personData = new PersonData();
                    PersonDto personDto = personData.SelectPersonById(facultyId);
                    facultyDto.Person = personDto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dbConnect.CloseConnection();
            }
            return facultyDto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="facultyDto"></param>
        /// <returns></returns>
        public int InsertFaculty(FacultyDto facultyDto)
        {
            int returnedValue = 0;
            try
            {
                PersonData personData = new PersonData();
                returnedValue = personData.InsertPerson(facultyDto.Person);
                if (returnedValue > -1)
                {
                    query = InsertFacultyQuery(facultyDto);
                    returnedValue = dbConnect.ExecuteQueries(query, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                dbConnect.CloseConnection();
            }

            return returnedValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="facultyDto"></param>
        /// <returns></returns>
        public int UpdateFaculty(FacultyDto facultyDto)
        {
            int returnedValue = 0;
            try
            {
                PersonData personData = new PersonData();
                returnedValue = personData.UpdatePerson(facultyDto.Person);
                if (returnedValue > -1)
                {
                    query = UpdateFacultyQuery(facultyDto);
                    returnedValue = dbConnect.ExecuteQueries(query, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                dbConnect.CloseConnection();
            }

            return returnedValue;
        }

        #region 'Private Queries'

        /// <summary>
        /// 
        /// </summary>
        /// <param name="facultyId"></param>
        /// <returns></returns>
        private String SelectFacultyByCodeQuery(int facultyId)
        {
            return @" SELECT f.facultyId, f.office, f.salary , f.contactNo 
                            FROM   Faculty f 
                        WHERE f.facultyId = " + facultyId;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="facultyDto"></param>
        /// <returns></returns>
        private String InsertFacultyQuery(FacultyDto facultyDto)
        {
            return @"INSERT INTO faculty
                     (facultyid, office, salary, contactNo) VALUES 
                     (" + facultyDto.FacultyId + ",'" + facultyDto.Office + "'," + facultyDto.Salary + "," + facultyDto.ContactNo + ")";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="facultyDto"></param>
        /// <returns></returns>
        private String UpdateFacultyQuery(FacultyDto facultyDto)
        {
            return @"UPDATE faculty SET   salary = " + facultyDto.Salary + ", contactNo = " + facultyDto.ContactNo + "   WHERE facultyid = " + facultyDto.FacultyId;
        }

        #endregion

    }
}
