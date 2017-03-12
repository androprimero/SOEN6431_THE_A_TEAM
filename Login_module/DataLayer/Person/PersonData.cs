using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using AcademicManagementSystem.Common;

namespace AcademicManagementSystem.DataLayer.Person
{
    public class PersonData
    {
        #region 'Variables'
        private DatabaseConnection dbConnect = new DatabaseConnection();
        private String query = "";
        #endregion
        //Get FacultyData
        public PersonDto SelectLatestPersonByType(int personType)
        {
            PersonDto personDto;
            try
            {

                personDto = new PersonDto();
                query = SelectLatestPersonByTypeQuery(personType);
                OleDbDataReader reader = dbConnect.SelectDataReader(query);

                if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                {

                    //Person Info
                    personDto.PersonCode = reader.GetString(0);
                    personDto.Firstname = reader.GetString(1);
                    personDto.Lastname = reader.GetString(2);
                    personDto.DateOfBirth = reader.GetDateTime(3);
                    personDto.PostalCode = reader.GetInt32(4);
                    personDto.Gender = reader.GetString(5);
                    personDto.Address = reader.GetString(6);
                    personDto.PersonType = reader.GetInt32(7);
                    personDto.PersonId = reader.GetInt32(8);
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

            return personDto;
        }

        public int InsertPerson(PersonDto person)
        {
            int insertedId = 0;
            try
            {

                query = InsertPersonQuery(person);
                insertedId = dbConnect.ExecuteQueries(query, true);
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

            return insertedId;
        }


        #region 'Private Queries'

        private String SelectLatestPersonByTypeQuery(int personType)
        {
            return @"SELECT TOP 1 Person.PersonCode, Person.fname, Person.lname, Person.dob, Person.postalcode, Person.gender, Person.address, Person.PersonType, Person.PersonId
                        FROM Person 
                    WHERE Person.PersonType=" + personType +
                    "  ORDER BY Person.PersonCode DESC";

        }

        private String SelectLatestPersonByCodeQuery(string code)
        {
            return @"SELECT  Person.PersonCode, Person.fname, Person.lname, Person.dob, Person.postalcode, Person.gender, Person.address, Person.PersonType, Person.PersonId
                        FROM Person
                     WHERE Person.PersonCode = '" + code + "'";

        }

        private String InsertPersonQuery(PersonDto person)
        {
            return @"INSERT INTO person(personCode, fname, lname, dob, postalcode, gender, address, PersonType) 
                     Values
                    ('" + person.PersonCode + "','" + person.Firstname + "','" + person.Lastname + "',#" + person.DateOfBirth + "#," + person.PostalCode + ",'" + person.Gender + "','" + person.Address + "'," + person.PersonType + ")";
        }

        #endregion

    }
}
