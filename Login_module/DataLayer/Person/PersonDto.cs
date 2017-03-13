using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademicManagementSystem.DataLayer.Person
{
    public class PersonDto
    {
        #region Properties

        public Int64 PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PostalCode { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int PersonType { get; set; }


        public PersonDto()
        {

        }
        
        public PersonDto(long _personId,  string _firstname, string _lastname,
           DateTime _dateofBirth, int _postalCode, string _gender, string _address, int _personType)
        {
            PersonId = _personId;
            Firstname = _firstname;
            Lastname = _lastname;
            DateOfBirth = _dateofBirth;
            PostalCode = _postalCode;
            Gender = _gender;
            Address = _address;
            PersonType = _personType;
        }

        #endregion

    }
}
