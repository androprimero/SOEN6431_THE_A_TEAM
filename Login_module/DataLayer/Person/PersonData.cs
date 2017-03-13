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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="personType"></param>
        /// <returns></returns>
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

                    personDto.PersonId = reader.GetInt32(0);
                    personDto.Firstname = reader.GetString(1);
                    personDto.Lastname = reader.GetString(2);
                    personDto.DateOfBirth = reader.GetDateTime(3);
                    personDto.PostalCode = reader.GetInt32(4);
                    personDto.Gender = reader.GetString(5);
                    personDto.Address = reader.GetString(6);
                    personDto.PersonType = reader.GetInt32(7);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personDto"></param>
        /// <returns></returns>
        public int InsertPerson(PersonDto personDto)
        {
            int returnValue = 0;
            try
            {
                query = InsertPersonQuery(personDto);
                returnValue = dbConnect.ExecuteQueries(query, false);
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

            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personDto"></param>
        /// <returns></returns>
        public int UpdatePerson(PersonDto personDto)
        {
            int returnValue = 0;
            try
            {
                query = UpdatePersonQuery(personDto);
                returnValue = dbConnect.ExecuteQueries(query, false);
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

            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public PersonDto SelectPersonById(int personId)
        {
            PersonDto personDto;
            try
            {

                personDto = new PersonDto();
                query = SelectPersonByIdQuery(personId);
                OleDbDataReader reader = dbConnect.SelectDataReader(query);

                if (reader.Read() && reader.GetValue(0) != DBNull.Value)
                {
                    //Person Info
                    personDto.PersonId = reader.GetInt32(0);
                    personDto.Firstname = reader.GetString(1);
                    personDto.Lastname = reader.GetString(2);
                    personDto.DateOfBirth = reader.GetDateTime(3);
                    personDto.PostalCode = reader.GetInt32(4);
                    personDto.Gender = reader.GetString(5);
                    personDto.Address = reader.GetString(6);
                    personDto.PersonType = reader.GetInt32(7);
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

        #region 'Private Queries'

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personType"></param>
        /// <returns></returns>
        private String SelectLatestPersonByTypeQuery(int personType)
        {
            return @"SELECT TOP 1  Person.PersonId, Person.fname, Person.lname, Person.dob, Person.postalcode, Person.gender, Person.address, Person.PersonType
                        FROM Person 
                    WHERE Person.PersonType=" + personType +
                    "  ORDER BY Person.PersonId DESC";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        private String SelectPersonByIdQuery(int personId)
        {
            return @"SELECT Person.PersonId, Person.fname, Person.lname, Person.dob, Person.postalcode, Person.gender, Person.address, Person.PersonType
                        FROM Person
                     WHERE Person.PersonId =" + personId;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personDto"></param>
        /// <returns></returns>
        private String InsertPersonQuery(PersonDto personDto)
        {
            return @"INSERT INTO person(personId, fname, lname, dob, postalcode, gender, address, PersonType) 
                     Values
                    (" + personDto.PersonId + ",'" + personDto.Firstname + "','" + personDto.Lastname + "',#" + personDto.DateOfBirth + "#," + personDto.PostalCode + ",'" + personDto.Gender + "','" + personDto.Address + "'," + personDto.PersonType + ")";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personDto"></param>
        /// <returns></returns>
        private String UpdatePersonQuery(PersonDto personDto)
        {
            return @"UPDATE Person SET fname = '" + personDto.Firstname + "', lname = '" + personDto.Lastname + "', address = '" + personDto.Address + "', postalcode = " + personDto.PostalCode +
                                        ", dob =#" + personDto.DateOfBirth + "# , gender = '" + personDto.Gender + "'  WHERE personid = " + personDto.PersonId ;
        }

        #endregion

    }
}
