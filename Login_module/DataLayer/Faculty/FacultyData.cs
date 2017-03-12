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

        //Get FacultyData
        public FacultyDto SelectFacultyByCode(string code)
        {
            FacultyDto facultyDto;
            try
            {
                facultyDto = new FacultyDto();
                query = SelectFacultyByCodeQuery(code);
                OleDbDataReader reader = dbConnect.SelectDataReader(query);

                if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                {
                    facultyDto.FacultyId = reader.GetInt32(0);
                    facultyDto.Office = reader.GetString(1);
                    facultyDto.Salary = reader.GetInt32(2);
                    facultyDto.ContactNo = reader.GetInt32(3);

                    //Person Info
                    PersonDto personDto = new PersonDto();
                    personDto.PersonCode = code;
                    personDto.PersonId = reader.GetInt32(4);
                    personDto.Firstname = reader.GetString(5);
                    personDto.Lastname = reader.GetString(6);
                    personDto.Gender = reader.GetString(7);
                    personDto.DateOfBirth = reader.GetDateTime(8);
                    personDto.PostalCode = reader.GetInt32(9);
                    personDto.Address = reader.GetString(10);
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



        #region 'Private Queries'

        private String SelectFacultyByCodeQuery(string code)
        {
            return @"SELECT
                       f.facultyId 
                       , f.office as foffice
                       , f.salary as fSal
                       , f.contactNo as fCon 
                       , p.PersonId 
                       , p.fname as perfname
                       , p.lname as perlname
                       , p.gender as pergen
                       , p.dob as perdob 
                       , p.postalcode as perpost
                       , p.address as peradd 
                            FROM PERSON p, Faculty f 
                    where p.PersonId = f.PersonId 
                    and p.personCode='" + code + "'";

        }

        #endregion

    }
}
