using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademicManagementSystem.Common;
using AcademicManagementSystem.DataLayer.Person;

namespace AcademicManagementSystem.BusinessLayer
{
    public class Person
    {

        public long GetNextCode(int personType)
        {
            long nextCode = 0;
            PersonData personData = new PersonData();
            PersonDto personDto = personData.SelectLatestPersonByType(personType);
            if (personDto != null && personDto.PersonId>0)
                nextCode = personDto.PersonId + 1;
            else
            {
                if (personType == (int)EnumCommonClass.PersonType.Faculty)
                    nextCode = (int.Parse(Properties.Settings.Default["FacultyCode"].ToString()) * 1000) + 1;
                else if (personType == (int)EnumCommonClass.PersonType.Student)
                    nextCode = (int.Parse(Properties.Settings.Default["StudentCode"].ToString()) * 1000) + 1;
            }
            return nextCode;

        }

        public PersonDto GetPersonById(int personId)
        {
            PersonData personData = new PersonData();
            return personData.SelectPersonById(personId);
        }


        public int CreatePerson(PersonDto person)
        {
            PersonData personData = new PersonData();
            int insertedId = personData.InsertPerson(person);

            return insertedId;
        }

    }
}
