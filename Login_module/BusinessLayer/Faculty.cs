using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademicManagementSystem.Common;
using AcademicManagementSystem.DataLayer.Faculty;

namespace AcademicManagementSystem.BusinessLayer
{
    public class Faculty
    {


        public FacultyDto GetFacultyById(int facultyId)
        {

            FacultyData facultyData = new FacultyData();
            FacultyDto facultyDto = facultyData.SelectFacultyById(facultyId);

            return facultyDto;
        }

        public long CreateFaculty(FacultyDto facultyDto)
        {
            Person personBL = new Person();
            long newId = personBL.GetNextCode((int)EnumCommonClass.PersonType.Faculty);

            facultyDto.FacultyId = newId;
            facultyDto.Person.PersonId = newId;

            FacultyData facultyData = new FacultyData();
            if (facultyData.InsertFaculty(facultyDto) > -1)
            {
                return newId;
            }
            return -1;
        }


        public int EditFaculty(FacultyDto facultyDto)
        {
            FacultyData facultyData = new FacultyData();
            return facultyData.UpdateFaculty(facultyDto);

        }
    }
}
