using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademicManagementSystem.DataLayer.Person;

namespace AcademicManagementSystem.DataLayer.Faculty
{
    public class FacultyDto
    {
        #region Properties

        public Int64 FacultyId { get; set; }
        public string Office { get; set; }
        public double Salary { get; set; }
        public Int64 ContactNo { get; set; }
        public PersonDto Person { get; set; }

        public FacultyDto()
        {
             
        }

        public FacultyDto(long _facultyId, string _office, double _salary, long _contactNo, PersonDto _person)
        {
            FacultyId = _facultyId;
            Office = _office;
            Salary = _salary;
            ContactNo = _contactNo;
            Person = _person;
        }

        #endregion
    }
}
